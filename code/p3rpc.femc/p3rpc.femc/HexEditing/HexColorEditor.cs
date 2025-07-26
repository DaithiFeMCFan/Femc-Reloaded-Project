﻿using p3rpc.commonmodutils;
using p3rpc.femc.Configuration;
using Reloaded.Memory.Extensions;
using Reloaded.Mod.Interfaces;
using System;
using System.Drawing;
using System.IO;
using System.Threading;
using static p3rpc.femc.HexEditing.HexColorEditor;

namespace p3rpc.femc.HexEditing
{
    public static class HexColorEditor
    {
        public enum ComponentType
        {
            BYTE,
            FLOAT,
            hFLOAT
        }
        public enum ColorOrder
        {
            RGBA,
            ARGB,
            BGRA,
            RGB,
            BGR
        }
        /// <param name="filePath">Absolute path to the file to edit.</param>
        /// <param name="offset">Offset in bytes where the color should be written.</param>
        /// <param name="color">The color value to inject.</param>
        /// <param name="order">Byte order used for the color value.</param>
        /// <param name="type">Component type in the hex file.</param>
        public static void WriteColor(string filePath, long offset, ConfigColor color, ColorOrder order = ColorOrder.RGBA, ComponentType type = ComponentType.BYTE)
        {
            byte[] bytes;

            bytes = order switch
            { 
                ColorOrder.RGB => CreateColorComponents(new[] { color.R, color.G, color.B }, type),
                ColorOrder.BGR => CreateColorComponents(new[] { color.B, color.G, color.R }, type),
                ColorOrder.RGBA => CreateColorComponents(new[] { color.R, color.G, color.B, color.A }, type),
                ColorOrder.ARGB => CreateColorComponents(new[] { color.A, color.R, color.G, color.B }, type),
                ColorOrder.BGRA => CreateColorComponents(new[] { color.B, color.G, color.R, color.A }, type),
                _ => throw new ArgumentOutOfRangeException(nameof(order), order, null)
            };

            using FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Write, FileShare.Read);
            stream.Seek(offset, SeekOrigin.Begin);
            stream.Write(bytes, 0, bytes.Length);
        }

        private static byte[] CreateColorComponents(byte[] components, ComponentType type)
        {
            List<byte> bytes = new List<byte>();

            switch (type)
            {
                case ComponentType.BYTE:
                    return components;

                case ComponentType.FLOAT:
                    foreach (byte component in components)
                    {
                        float floatComponent = component / 255.0f;
                        byte[] floatComponentBytes = BitConverter.GetBytes(floatComponent);

                        bytes.AddRange(floatComponentBytes);
                    }
                    break;

                case ComponentType.hFLOAT:
                    foreach (byte component in components)
                    {
                        Half hFloatComponent = (Half) ((float) component / 255.0f);
                        ushort bits = BitConverter.ToUInt16(BitConverter.GetBytes(hFloatComponent), 0);

                        byte lo = (byte) (bits & 0xFF);
                        byte hi = (byte) ((bits >> 8) & 0xFF);

                        byte[] hFloatComponentBytes = new[] {lo, hi};

                        bytes.AddRange(hFloatComponentBytes);
                    }
                    break;
            }

            return bytes.ToArray();
        }

        /// <param name="filePath">Absolute path to the file to edit</param>
        /// <param name="offset">Offset in bytes where the color curve should be written</param>
        /// <param name="colorKeyframes">A dictionary (0s-1s time, color) that will be used to interpolate all colors of the curve</param>
        public static void WriteColorCurve(string filePath, long offset, Dictionary<float, ConfigColor> colorKeyframes)
        {
            if (colorKeyframes.Count < 2)
                throw new ArgumentException("At least two keyframes are needed to create a color curve", nameof(colorKeyframes));

            // Order keyframes just in case
            var sortedKeyFrames = colorKeyframes.Keys.OrderBy(k => k).ToList();

            using FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Write, FileShare.Read);
            stream.Seek(offset, SeekOrigin.Begin);

            // These color curves have 64 colors
            for (int i = 0; i < 64; i++)
            {
                float actTime = i / 63.0f;

                for (int j = 0; j < sortedKeyFrames.Count - 1; j++)
                {
                    float t1 = sortedKeyFrames[j];
                    float t2 = sortedKeyFrames[j + 1];

                    if (actTime >= t1 && actTime <= t2)
                    {
                        ConfigColor c1 = colorKeyframes[t1];
                        ConfigColor c2 = colorKeyframes[t2];

                        float t = (actTime - t1) / (t2 - t1);

                        // Interpolate current color relative to current time frame
                        float r = (c1.R + t * (c2.R - c1.R)) / 255.0f;
                        float g = (c1.G + t * (c2.G - c1.G)) / 255.0f;
                        float b = (c1.B + t * (c2.B - c1.B)) / 255.0f;
                        float a = (c1.A + t * (c2.A - c1.A)) / 255.0f;

                        WriteHalf(stream, (Half) r);
                        WriteHalf(stream, (Half) g);
                        WriteHalf(stream, (Half) b);
                        WriteHalf(stream, (Half) a);

                        break;
                    }
                }
            }
        }

        public static void WriteHalf(Stream stream, Half value)
        {
            ushort bits = BitConverter.ToUInt16(BitConverter.GetBytes(value), 0);

            // We need lower byte and higher byte of our converted half
            byte lo = (byte) (bits & 0xFF);
            byte hi = (byte) ((bits >> 8) & 0xFF);

            stream.WriteByte(lo);
            stream.WriteByte(hi);
        }

        public static void WriteByte(string filePath, long offset, byte value)
        {
            using FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Write, FileShare.Read);
            stream.Seek(offset, SeekOrigin.Begin);
            stream.WriteByte(value);
        }

        public static void WriteFloat(string filePath, long offset, float value)
        {
            byte[] floatComponentBytes = BitConverter.GetBytes(value);

            using FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Write, FileShare.Read);
            stream.Seek(offset, SeekOrigin.Begin);
            stream.Write(floatComponentBytes, 0, floatComponentBytes.Length);
        }

        /// <param name="filePath">Absolute path to the file to edit</param>
        /// <param name="offset">Offset in bytes where the BLUE component starts</param>
        /// <param name="color">New color value to be written</param>
        public static void WriteBlueprintSplitColor(string filePath, long offset, ConfigColor color, ColorOrder order = ColorOrder.BGRA)
        {
            // Their order is always BGR / BGRA
            if (!order.Equals(ColorOrder.BGR) && !order.Equals(ColorOrder.BGRA))
                throw new ArgumentException("Blueprint hardcoded colors must be either BGR or BGRA", nameof(order));

            byte[] bytes = new[] { color.B, color.G, color.R, color.A };

            using FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Write, FileShare.Read);

            stream.Seek(offset, SeekOrigin.Begin);
            stream.WriteByte(color.B);

            stream.Seek(offset+0x35, SeekOrigin.Begin);
            stream.WriteByte(color.G);

            stream.Seek(offset + 0x6A, SeekOrigin.Begin);
            stream.WriteByte(color.R);

            if (order == ColorOrder.BGRA)
            {
                stream.Seek(offset + 0x9F, SeekOrigin.Begin);
                stream.WriteByte(color.A);
            }
        }
    }
}