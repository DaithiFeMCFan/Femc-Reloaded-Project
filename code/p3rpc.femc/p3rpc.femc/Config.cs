﻿using p3rpc.commonmodutils;
using p3rpc.femc.Components;
using p3rpc.femc.Template.Configuration;
using System.ComponentModel;
using System.Diagnostics;
using p3rpc.femc;
using System.ComponentModel.DataAnnotations;

namespace p3rpc.femc.Configuration
{

    public class Config : Configurable<Config>
    {
        //Config Editing Standards: Any bool designed to be accessed by the config app must be in CamelCase
        
        // Debug

        [DisplayName("Debug Log Level")]
        [Category("Debug")]
        [Display(Order = 0)]
        [DefaultValue(LogLevel.Information)]
        public LogLevel DebugLogLevel { get; set; } = LogLevel.Information;

        // 2D Options

        [DisplayName("AOA Image")]
        [Description("The portrait used when finishing battles with an all-out attack initiated by FEMC.")]
        [Category("2D Options")]
        [Display(Order = 3)]
        [DefaultValue(AOAType.esaadrien)]
        public AOAType AOATrue { get; set; } = AOAType.esaadrien;

        public enum AOAType
        {
        [Display(Name = "Ely")]
        Ely,
        [Display(Name = "Chrysanthie")]
        Chrysanthie,
        [Display(Name = "Fernando")]
        Fernando,
        [Display(Name = "Monica")]
        Monica,
        [Display(Name = "Ronald Reagan")]
        RonaldReagan,
        [Display(Name = "Esa, Adrien")]
        esaadrien,
        [Display(Name = "Mekki")]
        mekki,
        [Display(Name = "shiosakana")]
        shiosakana,
        [Display(Name = "shiosakana (jacket closed)")]
        shiosakanaAlt,
        [Display(Name = "Namiweiko")]
        Nami,
        [Display(Name = "AngieDaGorl")]
        AngieDaGorl,
        [Display(Name = "StupidAle")]
        StupidAle,
        }

        [DisplayName("AOA Text Options")]
        [Description("The text used when finishing battles with an all-out attack initiated by FEMC.")]
        [Category("2D Options")]
        [Display(Order = 4)]
        [DefaultValue(AOATextType.SorryBoutThat)]
        public AOATextType AOAText { get; set; } = AOATextType.SorryBoutThat;

        public enum AOATextType
        {
        [Display(Name = "Don't look back.")]
        DontLookBack,
        [Display(Name = "Sorry 'bout that— bye-bye!")]
        SorryBoutThat,
        [Display(Name = "Perfectly accomplished!!")]
        PerfectlyAccomplished,
        }


        [DisplayName("Bustup")]
        [Description("The character portrait used in textboxes.")]
        [Category("2D Options")]
        [Display(Order = 5)]
        [DefaultValue(BustupType.Esa)]
        public BustupType BustupTrue { get; set; } = BustupType.Esa;

        public enum BustupType
        {
        [Display(Name = "Neptune")]
        Neptune,
        [Display(Name = "Ely")]
        Ely,
        [Display(Name = "Esa")]
        Esa,
        [Display(Name = "Betina")]
        Betina,
        [Display(Name = "P25th Anniversary Art")]
        Anniversary,
        [Display(Name = "Just Blue")]
        JustBlue,
        [Display(Name = "Sav")]
        Sav,
        [Display(Name = "Doodled")]
        Doodled,
        [Display(Name = "Ronald Reagan")]
        RonaldReagan,
        [Display(Name = "Ely (Alt)")]
        ElyAlt,
        [Display(Name = "Yuunagi")]
        Yuunagi,
        [Display(Name = "cielbell")]
        cielbell,
        [Display(Name = "axolotl")]
        axolotl,
        [Display(Name = "GhostedToast")]
        ghostedtoast,
        [Display(Name = "Strelko")]
        Strelko,
        [Display(Name = "gackt")]
        gackt,
        [Display(Name = "Jackie")]
        Jackie,
        [Display(Name = "Lisa9388")]
        Lisa,
        [Display(Name = "Mae (Beta FEMC)")]
        BetaFemcByMae,
        [Display(Name = "crezzstar")]
        crezzstar,
        [Display(Name = "crezzstar (Alt expression)")]
        crezzstarAlt,
        [Display(Name = "AngieDaGorl")]
        AngieDaGorl,
        [Display(Name = "namiweiko")]
        namiweiko,
        [Display(Name = "chitu")]
        chitu,
        [Display(Name = "shiosakana")]
        shiosakana,
        [Display(Name = "samythecoolkid")]
        samythecoolkid,
        [Display(Name = "Mixi_xiMi")]
        Mixi_xiMi,
        [Display(Name = "StupidAle")]
        StupidAle,
        [Display(Name = "Kiara")]
        Kiara,
        [Display(Name = "Autumn")]
        Autumn,
        [Display(Name = "P3 Portable by Yuha")]
        p3pYuha,
        [Display(Name = "Maru")]
        Maru,
        [Display(Name = "purpleoctogamer")]
        purpleoctogamer,
        [Display(Name = "purpleoctogamer Q2")]
        purpleoctogamerAlt
        }

        [DisplayName("Cutin")]
        [Description("The animation played occasionally when attacking weaknesses or hitting criticals.")]
        [Category("2D Options")]
        [Display(Order = 6)]
        [DefaultValue(CutinType.Mekki)]
        public CutinType CutinTrue { get; set; } = CutinType.Mekki;

        public enum CutinType
        {
        [Display(Name = "berrycha")]
        berrycha,
        [Display(Name = "Ely, PatManDX")]
        ElyandPatmandx,
        [Display(Name = "Mekki")]
        Mekki,
        [Display(Name = "shiosakana")]
        shiosakana
        }

        [DisplayName("Group Photo")]
        [Description("The group photo taken during a certain event.")]
        [Category("2D Options")]
        [Display(Order = 7)]
        [DefaultValue(GroupEventtype.ely)]
        public GroupEventtype GroupEventTrue { get; set; } = GroupEventtype.bichelle;

        public enum GroupEventtype
        {
        [Display(Name = "Bichelle")]
        bichelle,
        [Display(Name = "Ely")]
        ely
        }

        [DisplayName("Kyoto Photos")]
        [Description("The photos taken during the Kyoto trip.")]
        [Category("2D Options")]
        [Display(Order = 8)]
        [DefaultValue(KyotoEventtype.ely)]
        public KyotoEventtype KyotoEventTrue { get; set; } = KyotoEventtype.ely;

        public enum KyotoEventtype
        {
        [Display(Name = "Ely")]
        ely
        }

        [DisplayName("Level Up Art")]
        [Description("The character art used for the level up screen.")]
        [Category("2D Options")]
        [Display(Order = 9)]
        [DefaultValue(LevelUpType.Esa)]
        public LevelUpType LevelUpTrue { get; set; } = LevelUpType.Esa;

        public enum LevelUpType
        {
        [Display(Name = "Esa")]
        Esa,
        [Display(Name = "Ely")]
        Ely,
        [Display(Name = "shiosakana")]
        shiosakana,
        [Display(Name = "Ely (Alt)")]
        ElyAlt,
        [Display(Name = "AngieDaGorl")]
        AngieDaGorl

        }

        [DisplayName("Party Panel")]
        [Description("The character icon on the right when dungeon crawling or in combat.")]
        [Category("2D Options")]
        [Display(Order = 10)]
        [DefaultValue(PartyPanelType.Esa)]
        public PartyPanelType PartyPanelTrue { get; set; } = PartyPanelType.Esa;

        public enum PartyPanelType
        {
        [Display(Name = "Kris")]
        Kris,
        [Display(Name = "Esa")]
        Esa
        }

        [DisplayName("Status Menu Art")]
        [Description("The character art used in the status menu.")]
        [Category("2D Options")]
        [Display(Order = 11)]
        [DefaultValue(ShardType.Esa)]
        public ShardType ShardTrue { get; set; } = ShardType.Esa;

        public enum ShardType
        {
        [Display(Name = "Esa")]
        Esa,
        [Display(Name = "Ely")]
        Ely,
        [Display(Name = "Ely (Alt)")]
        ElyAlt,
        [Display(Name = "shiosakana")]
        Shiosakana,
        [Display(Name = "namiweiko")]
        namiweiko,
        [Display(Name = "AngieDaGorl")]
        AngieDaGorl,
        [Display(Name = "StupidAle")]
        StupidAle
        }

        // 3D Options

        [DisplayName("Animations")]
        [Description("Choose from a few animations.\n\nNote that some custom anims might not look correct if skeleton fix is enabled,\nsuch as the menu animations.")]
        [Category("3D Options")]
        [Display(Order = 12)]
        [DefaultValue(AnimType.OriginalAnims)]
        public AnimType AnimTrue { get; set; } = AnimType.OriginalAnims;

        public enum AnimType
        {
        [Display(Name = "Original Animations")]
        OriginalAnims,
        [Display(Name = "Custom Animations")]
        CustomAnims,
        [Display(Name = "Very Funny Animations")]
        VeryFunnyAnims
        }

        [DisplayName("Hair Options")]
        [Description("The hair model used on FEMC.")]
        [Category("3D Options")]
        [Display(Order = 13)]
        [DefaultValue(HairType.MudkipsHair)]
        public HairType HairTrue { get; set; } = HairType.MudkipsHair;

        public enum HairType
        {
        [Display(Name = "Default")]
        MudkipsHair,
        [Display(Name = "Kotone Bean")]
        KotoneBeanHair
        }

        [DisplayName("Naginata Weapons")]
        [Description("Changes FEMC's weapons from 1h swords to naginatas.")]
        [Category("3D Options")]
        [Display(Order = 14)]
        [DefaultValue(true)]
        public bool NagiWeap { get; set; } = true;

        // Voice

        [DisplayName("Voice Options")]
        [Description("The voice used ingame for FEMC.")]
        [Category("Voice")]
        [Display(Order = 20)]
        [DefaultValue(VoiceType.Mellodi)]
        public VoiceType VoiceTrue { get; set; } = VoiceType.Mellodi;

        public enum VoiceType
        {
        [Display(Name = "Mellodi")]
        Mellodi,
        [Display(Name = "Mellodi (Silly)")]
        MellodiSilly,
        [Display(Name = "Japanese")]
        Japanese
        }

        [DisplayName("Gendered Audio")]
        [Category("Voice")]
        [Description("Uses custom voice lines to refer to FEMC with she/her pronouns where applicable.\nOnly English audio is supported currently.")]
        [Display(Order = 21)]
        [DefaultValue(true)]
        public bool bluehairandpronounce { get; set; } = true;

        // Music
        //  Battle Music - Advantage

        [DisplayName("Pull the Trigger (P3P Arrange) by Karma")]
		[Category("Battle Music - Advantage")]
		[Description("Enable Pull The Trigger (P3P Arrange) as advantage battle music.\nMultiple songs can be chosen for randomization!")]
        [Display(Order = 30)]
		[DefaultValue(false)]
		public bool KarmaAdv { get; set; } = false;

		[DisplayName("Pull the Trigger -reload- by MOSQ")]
        [Category("Battle Music - Advantage")]
        [Description("Enable Pull The Trigger -reload- by MOSQ as advantage battle music.\nMultiple songs can be chosen for randomization!")]
        [Display(Order = 31)]
		[DefaultValue(true)]
		public bool MosqAdv { get; set; } = true;

		[DisplayName("Pull the Trigger -reload- by EidieK87")]
        [Category("Battle Music - Advantage")]
        [Description("Enable Pull The Trigger -reload- by EidieK87 as advantage battle music.\nMultiple songs can be chosen for randomization!")]
        [Display(Order = 32)]
		[DefaultValue(false)]
		public bool EidAdv { get; set; } = false;

        [DisplayName("It's Going Down Now")]
        [Category("Battle Music - Advantage")]
        [Description("Enable It's Going Down Now, which is used by default for advantage battle music.\nMultiple songs can be chosen for randomization!")]
        [Display(Order = 33)]
        [DefaultValue(false)]
        public bool ItGoingDown { get; set; } = false;

        //  Battle Music - Normal

        [DisplayName("Wiping All Out (Reload Arrange) by MOSQ")]
        [Category("Battle Music - Normal")]
        [Description("Enable Wiping All Out (Reload Arrange) by MOSQ as normal battle music.\nMultiple songs can be chosen for randomization!")]
        [Display(Order = 40)]
		[DefaultValue(true)]
		public bool MosqNom { get; set; } = true;

		[DisplayName("Wiping All Out -RELOADED- by Karma")]
        [Category("Battle Music - Normal")]
        [Description("Enable Wiping All Out -RELOADED- by Karma as normal battle music.\nMultiple songs can be chosen for randomization!")]
        [Display(Order = 41)]
		[DefaultValue(false)]
		public bool KarmaNom { get; set; } = false;

		[DisplayName("Wiping All Out cover by Satella")]
        [Category("Battle Music - Normal")]
        [Description("Enable Wiping All Out by Satella and GillStudio as normal battle music.\nMultiple songs can be chosen for randomization!")]
        [Display(Order = 42)]
		[DefaultValue(false)]
		public bool SgNom { get; set; } = false;

        [DisplayName("Wiping All Out (P3P)")]
        [Category("Battle Music - Normal")]
        [Description("Enable the original Wiping All Out from P3P as normal battle music.\nMultiple songs can be chosen for randomization!")]
        [Display(Order = 43)]
        [DefaultValue(false)]
        public bool P3PNom { get; set; } = false;

        [DisplayName("Mass Destruction -Reload-")]
        [Category("Battle Music - Normal")]
        [Description("Enable Mass Destruction -Reload-, which is used by default for normal battle music.\nMultiple songs can be chosen for randomization!")]
        [Display(Order = 44)]
        [DefaultValue(false)]
        public bool MassDes { get; set; } = false;

        //  Tartarus Boss Music

        [DisplayName("Danger Zone - Guitar Cover by GillStudio")]
		[Category("Tartarus Boss Music")]
        [Description("Enable Danger Zone by GillStudio as Tartarus boss battle music.\nMultiple songs can be chosen for randomization!")]
        [Display(Order = 50)]
		[DefaultValue(false)]
		public bool SgDis { get; set; } = false;

        [DisplayName("Danger Zone remix by EidieK87")]
        [Category("Tartarus Boss Music")]
        [Description("Enable Danger Zone by EidieK87 as Tartarus boss battle music.\nMultiple songs can be chosen for randomization!")]
        [Display(Order = 51)]
        [DefaultValue(false)]
        public bool EidDis { get; set; } = false;

        [DisplayName("Danger Zone -Reloaded- by Karma")]
        [Category("Tartarus Boss Music")]
        [Description("Enable Danger Zone -Reloaded- by Karma as Tartarus boss battle music.\nMultiple songs can be chosen for randomization!")]
        [Display(Order = 52)]
		[DefaultValue(false)]
		public bool KarmaDis { get; set; } = false;

		[DisplayName("Danger Zone (Reload Arrange) by MOSQ")]
        [Category("Tartarus Boss Music")]
        [Description("Enable Danger Zone (Reload Arrange) by MOSQ as Tartarus boss battle music.\nMultiple songs can be chosen for randomization!")]
        [Display(Order = 53)]
		[DefaultValue(true)]
		public bool MosqDis { get; set; } = true;

        [DisplayName("Danger Zone (P3P)")]
        [Category("Tartarus Boss Music")]
        [Description("Enable the original Danger Zone from P3P as Tartarus boss battle music.\nMultiple songs can be chosen for randomization!")]
        [Display(Order = 54)]
        [DefaultValue(false)]
        public bool P3PDis { get; set; } = false;

        [DisplayName("Master of Tartarus -Reload-")]
        [Category("Tartarus Boss Music")]
        [Description("Enable Master of Tartarus -Reload-, which is used by default for Tartarus boss battle music.\nMultiple songs can be chosen for randomization!")]
        [Display(Order = 55)]
        [DefaultValue(false)]
        public bool MasterTar { get; set; } = false;

        //  Full Moon Boss Music

        [DisplayName("Master of Shadow -Reload-")]
        [Category("Full Moon Boss Music")]
        [Description("Enable Master of Shadow -Reload-, the default full moon boss battle music.\nMultiple songs can be chosen for randomization!")]
        [Display(Order = 60)]
        [DefaultValue(false)]
        public bool BMS { get; set; } = true;

        [DisplayName("Master of Shadow -fate mix- by MOSQ")]
        [Category("Full Moon Boss Music")]
        [Description("Enable Master of Shadow -fate mix- by MOSQ as full moon boss battle music.\nMultiple songs can be chosen for randomization!")]
        [Display(Order = 61)]
        [DefaultValue(true)]
        public bool BMSF { get; set; } = true;

        //  Special Boss Music

        [DisplayName("Nyx Final Battle: Burn My Dread -Last Battle Reload-")]
        [Category("Special Boss Music")]
        [Description("Enable Burn My Dread -Last Battle Reload-, the default Nyx boss battle music.\nMultiple songs can be chosen for randomization!")]
        [Display(Order = 62)]
        [DefaultValue(true)]
        public bool BMD { get; set; } = true;

        [DisplayName("Nyx Final Battle: Soul Phrase -last battle- by Karma")]
        [Category("Special Boss Music")]
        [Description("Enable Soul Phrase -last battle- by Karma as the Nyx boss battle music.\nMultiple songs can be chosen for randomization!")]
        [Display(Order = 63)]
        [DefaultValue(false)]
        public bool SoulPK { get; set; } = false;

        //  Overworld Music

        [DisplayName("A Way of Life (Reload Arrange) by MOSQ")]
        [Category("Daytime Music")]
        [Description("Enable A Way Of Life -Reload- (Vocal Version) by MOSQ as the daytime music.\nMultiple songs can be chosen for randomization!")]
        [Display(Order = 71)]
        [DefaultValue(false)]
        public bool WayOfLife { get; set; } = false;

        [DisplayName("A Way of Life cover by Jen")]
        [Category("Daytime Music")]
        [Description("Enable A Way Of Life by Jen as the daytime music.\nMultiple songs can be chosen for randomization!")]
        [Display(Order = 72)]
        [DefaultValue(false)]
        public bool WayOfLifeJen { get; set; } = false;

        [DisplayName("A Way of Life -Reload- (Vocal Version) by Super M Plush, MOSQ, Karma, cora")]
        [Category("Daytime Music")]
        [Description("Enable A Way Of Life -Reload- (Vocal Version) by Super M Plush, MOSQ, Karma and cora\nas the daytime music.\nMultiple songs can be chosen for randomization!")]
        [Display(Order = 73)]
        [DefaultValue(true)]
        public bool WayLifeVocal { get; set; } = true;

        [DisplayName("A Way Of Life (P3P)")]
        [Category("Daytime Music")]
        [Description("Enable the original A Way Of Life from P3P as the daytime music.\nMultiple songs can be chosen for randomization!")]
        [Display(Order = 74)]
        [DefaultValue(false)]
        public bool WayOfLifeP3P { get; set; } = false;

        [DisplayName("A Way Of Life -Deep inside my mind Remix-")]
        [Category("Daytime Music")]
        [Description("Enable A Way Of Life -Deep inside my mind Remix- from P3P as the daytime music.\nMultiple songs can be chosen for randomization!")]
        [Display(Order = 75)]
        [DefaultValue(false)]
        public bool WayOfLifeRemix { get; set; } = false;

        [DisplayName("When the Moon's Reaching Out Stars -Reload-")]
        [Category("Daytime Music")]
        [Description("Enable When the Moon's Reaching Out Stars -Reload-, which is used by default for daytime music.\nMultiple songs can be chosen for randomization!")]
        [Display(Order = 76)]
        [DefaultValue(false)]
        public bool Moon { get; set; } = true;

        //  School Music - 1st semester

        [DisplayName("Time (Reload Arrange) by MOSQ")]
        [Category("School Music (1st semester)")]
        [Description("Enable Time (Reload Arrange) by MOSQ as the 1st semester school music.\nMultiple songs can be chosen for randomization!")]
        [Display(Order = 80)]
        [DefaultValue(false)]
        public bool TimeSchool { get; set; } = false;

        [DisplayName("Time -Reload- (Vocal Version) by GabiShy and MOSQ")]
        [Category("School Music (1st semester)")]
        [Description("Enable Time -Reload- (Vocal Version) by GabiShy and MOSQ as the 1st\nsemester school music.\nMultiple songs can be chosen for randomization!")]
        [Display(Order = 81)]
        [DefaultValue(true)]
        public bool GabiTimeSchool { get; set; } = true;

        [DisplayName("Time (P3P)")]
        [Category("School Music (1st semester)")]
        [Description("Enable the original Time from P3P as the 1st semester school music.\nMultiple songs can be chosen for randomization!")]
        [Display(Order = 82)]
        [DefaultValue(false)]
        public bool TimeSchoolP3P { get; set; } = false;

        [DisplayName("Want To Be Close -Reload-")]
        [Category("School Music (1st semester)")]
        [Description("Enable Want To Be Close -Reload-, which is used by default for  1st semester school music.\nMultiple songs can be chosen for randomization!")]
        [Display(Order = 83)]
        [DefaultValue(false)]
        public bool WantClose { get; set; } = false;

        //  School Music - 2nd semester

        [DisplayName("Sun (Reload Arrange) by MOSQ")]
        [Category("School Music (2nd semester)")]
        [Description("Enable Sun (Reload Arrange) by MOSQ as the 2nd semester school music.\nMultiple songs can be chosen for randomization!")]
        [Display(Order = 90)]
        [DefaultValue(true)]
        public bool Sun { get; set; } = true;

        [DisplayName("Sun -Reload- by MineFormer")]
        [Category("School Music (2nd semester)")]
        [Description("Enable Sun -Reload- by Mineformer as the 2nd semester school music.\nMultiple songs can be chosen for randomization!")]
        [Display(Order = 91)]
        [DefaultValue(false)]
        public bool SunMForm { get; set; } = false;

        [DisplayName("Sun (P3P)")]
        [Category("School Music (2nd semester)")]
        [Description("Enable the original Sun from P3P as the 1st semester school music.\nMultiple songs can be chosen for randomization!")]
        [Display(Order = 92)]
        [DefaultValue(false)]
        public bool SunP3P { get; set; } = false;

        [DisplayName("Changing Seasons -Reload-")]
        [Category("School Music (2nd semester)")]
        [Description("Enable Changing Seasons -Reload-, which is used by default for 1st semester school music.\nMultiple songs can be chosen for randomization!")]
        [Display(Order = 93)]
        [DefaultValue(false)]
        public bool Seasons { get; set; } = false;

        //  Night Music

		[DisplayName("Time (Night Version) by MOSQ")]
		[Category("Night Music")]
        [Description("Enable Time (Night Version) by Mineformer as the night music.\nMultiple songs can be chosen for randomization!")]
        [Display(Order = 100)]
        [DefaultValue(false)]
		public bool FemNight { get; set; } = false;

		[DisplayName("Time -Night- Vocal Version by GabiShy and MOSQ")]
        [Category("Night Music")]
        [Description("Enable Time -Night- Vocal Version by GabiShy and MOSQ as the night music.\nMultiple songs can be chosen for randomization!")]
        [Display(Order = 101)]
        [DefaultValue(false)]
		public bool GabiFemNight { get; set; } = false;

        [DisplayName("Midnight Reverie by Mineformer")]
        [Category("Night Music")]
        [Description("Enable Midnight Reverie by Mineformer as the night music.\nMultiple songs can be chosen for randomization!")]
        [Display(Order = 102)]
        [DefaultValue(false)]
        public bool MidNight { get; set; } = false;

        [DisplayName("Night Wanderer by MOSQ")]
        [Category("Night Music")]
        [Description("Enable Night Wanderer by MOSQ as the night music.\nMultiple songs can be chosen for randomization!")]
        [Display(Order = 103)]
        [DefaultValue(true)]
		public bool NightWand { get; set; } = true;

        [DisplayName("Moonlight by MOSQ")]
        [Category("Night Music")]
        [Description("Enable Moonlight by MOSQ as the night music.\nMultiple songs can be chosen for randomization!")]
        [Display(Order = 106)]
        [DefaultValue(false)]
        public bool EsaComm { get; set; } = false;

        [DisplayName("Color Your Night")]
        [Category("Night Music")]
        [Description("Enable Color Your Night, the default night music.\nMultiple songs can be chosen for randomization!")]
        [Display(Order = 104)]
        [DefaultValue(false)]
        public bool ColNight { get; set; } = false;

        //  Event Music

		[DisplayName("Social Link Events 1: After School (Reload Arrange) by MOSQ")]
        [Category("Event Music")]
        [Description("Enable After School by MOSQ to be played during social link events.\nMultiple songs can be chosen for randomization!")]
        [Display(Order = 110)]
        [DefaultValue(true)]
		public bool AfterSchool { get; set; } = true;

        [DisplayName("Social Link Events 1: After School")]
        [Category("Event Music")]
        [Description("Enable the original After School to be played during social link events.\nMultiple songs can be chosen for randomization!")]
        [Display(Order = 111)]
        [DefaultValue(false)]
        public bool AfterSchoolP3P { get; set; } = false;

        [DisplayName("Social Link Events 1: Joy")]
        [Category("Event Music")]
        [Description("Enable Joy, which is used by default for social link events.\nMultiple songs can be chosen for randomization!")]
        [Display(Order = 112)]
        [DefaultValue(false)]
        public bool Joy { get; set; } = false;

        // Commented out for now but whenever new social link music is added, uncomment this (and change the file/folder names accordingly too)
        //[DisplayName("Social Link Events: Tender Feelings")]
        //[Category("Music")]
        //[Description("Enable the original Tender Feelings to be played during social link events.\nMultiple songs can be chosen for randomization!")]
        //[DefaultValue(false)]
        //[Display(Order = 113)]
        //public bool TenderFeelings { get; set; } = false;

        // Fun Stuff

        [DisplayName("Kotone Room")]
        [Category("Fun Stuff")]
        [Description("Decorate your dorm room with FEMC artwork made by the community!")]
        [Display(Order = 120)]
        [DefaultValue(false)]
        public bool KotoneRoom { get; set; } = false;

        [DisplayName("Gregory House Apron")]
        [Category("Fun Stuff")]
        [Display(Order = 121)]
        [DefaultValue(false)]
        public bool GregoryHouseRatPoisonDeliverySystem { get; set; } = false;

        [DisplayName("Otome Arcade Game")]
        [Description("Changes the arcade game that raises charm to be gender swapped.")]
        [Category("Fun Stuff")]
        [Display(Order = 122)]
        [DefaultValue(false)]
        public bool OtomeArcade { get; set; } = false;

        // Theo

        [DisplayName("Enable Theodore")]
        [Category("Theo")]
        [Description("Enable Theodore to replace Elizabeth as FEMC's Velvet Room attendant.")]
        [Display(Order = 123)]
        [DefaultValue(false)]
        public bool TheodorefromAlvinandTheChipmunks { get; set; } = false; // soon this should be a whole thing, movies, bustups, etc 

        // Dorm Swap

        [DisplayName("Test Dorm Room Swap")]
        [Category("Testing")]
        [Description("THIS LETS YOU TEST THE NEW DORM ROOM SWAP, IT MIGHT BE VERY BROKEN.")]
        [DefaultValue(false)]
        public bool TesticlesDorm { get; set; } = false; // yeah

        // UI Components

        [DisplayName("Enable Mail Icon")]
        [Category("UI Components")]
        [Display(Order = 150)]
        [DefaultValue(true)]
        public bool EnableMailIcon { get; set; } = true;

        [DisplayName("Enable Date Time Panel")]
        [Category("UI Components")]
        [Display(Order = 151)]
        [DefaultValue(true)]
        public bool EnableDateTimePanel { get; set; } = true;

        [DisplayName("Enable Camp Menu")]
        [Category("UI Components")]
        [Display(Order = 152)]
        [DefaultValue(true)]
        public bool EnableCampMenu { get; set; } = true;

        [DisplayName("Enable Standard Message Box")]
        [Category("UI Components")]
        [Display(Order = 153)]
        [DefaultValue(true)]
        public bool EnableTextbox { get; set; } = true;

        [DisplayName("Enable Mind Message Box")]
        [Category("UI Components")]
        [Display(Order = 154)]
        [DefaultValue(true)]
        public bool EnableMindMessageBox { get; set; } = true;

        [DisplayName("Enable Interact Prompt")]
        [Category("UI Components")]
        [Display(Order = 155)]
        [DefaultValue(true)]
        public bool EnableInteractPrompt { get; set; } = true;

        [DisplayName("Enable Minimap")]
        [Category("UI Components")]
        [Display(Order = 156)]
        [DefaultValue(true)]
        public bool EnableMinimap { get; set; } = true;

        [DisplayName("Enable Bustup")]
        [Category("UI Components")]
        [Display(Order = 157)]
        [DefaultValue(true)]
        public bool EnableBustup { get; set; } = true;

        [DisplayName("Enable MessageScript")]
        [Category("UI Components")]
        [Display(Order = 158)]
        [DefaultValue(true)]
        public bool EnableMessageScript { get; set; } = true;

        [DisplayName("Enable Town Map")]
        [Category("UI Components")]
        [Display(Order = 159)]
        [DefaultValue(true)]
        public bool EnableTownMap { get; set; } = true;

        [DisplayName("Enable Party Panel")]
        [Category("UI Components")]
        [Display(Order = 160)]
        [DefaultValue(true)]
        public bool EnablePartyPanel { get; set; } = true;

        [DisplayName("Enable Time Skip")]
        [Category("UI Components")]
        [Display(Order = 161)]
        [DefaultValue(true)]
        public bool EnableTimeSkip { get; set; } = true;

        [DisplayName("Enable Get Item")]
        [Category("UI Components")]
        [Display(Order = 162)]
        [DefaultValue(true)]
        public bool EnableGetItem { get; set; } = true;

        [DisplayName("Enable Network Features")]
        [Category("UI Components")]
        [Display(Order = 163)]
        [DefaultValue(true)]
        public bool EnableNetworkFeatures { get; set; } = true;

        [DisplayName("Enable Shop")]
        [Category("UI Components")]
        [Display(Order = 164)]
        [DefaultValue(true)]
        public bool EnableShop { get; set; } = true;

        [DisplayName("Enable Persona Status")]
        [Category("UI Components")]
        [Display(Order = 165)]
        [DefaultValue(true)]
        public bool EnablePersonaStatus { get; set; } = true;

        [DisplayName("Enable Backlog")]
        [Category("UI Components")]
        [Display(Order = 166)]
        [DefaultValue(true)]
        public bool EnableBacklog { get; set; } = true;

        [DisplayName("Enable Button Prompts")]
        [Category("UI Components")]
        [Display(Order = 167)]
        [DefaultValue(true)]
        public bool EnableButtonPrompts { get; set; } = true;

        [DisplayName("Enable Title Menu")]
        [Category("UI Components")]
        [Display(Order = 168)]
        [DefaultValue(true)]
        public bool EnableTitleMenu { get; set; } = true;

        [DisplayName("Enable Staff Roll")]
        [Category("UI Components")]
        [Display(Order = 169)]
        [DefaultValue(true)]
        public bool EnableStaffRoll { get; set; } = true;

        [DisplayName("Enable Cutin")]
        [Category("UI Components")]
        [Display(Order = 170)]
        [DefaultValue(true)]
        public bool EnableCutin { get; set; } = true;

        [DisplayName("Enable Wipe")]
        [Category("UI Components")]
        [Display(Order = 171)]
        [DefaultValue(true)]
        public bool EnableWipe { get; set; } = true;

        [DisplayName("Enable Battle")]
        [Category("UI Components")]
        [Display(Order = 172)]
        [DefaultValue(true)]
        public bool EnableBattle { get; set; } = true;

        [DisplayName("Enable Item List")]
        [Category("UI Components")]
        [Display(Order = 173)]
        [DefaultValue(true)]
        public bool EnableItemList { get; set; } = true;

        [DisplayName("Mail Icon: Outer Color")]
        [Category("UI Colors")]
        [Display(Order = 200)]
        public ConfigColor MailIconOuterCircleColorEx { get; set; } = ConfigColor.MellodiColorMid1;

        [DisplayName("Mail Icon: Inner Color")]
        [Category("UI Colors")]
        [Display(Order = 201)]
        public ConfigColor MailIconInnerCircleColorEx { get; set; } = ConfigColor.MailIconInnerColor;

        [DisplayName("Camp: High Color")]
        [Category("UI Colors")]
        [Display(Order = 202)]
        public ConfigColor CampHighColor { get; set; } = ConfigColor.CampBgColor;

        [DisplayName("Camp: High Color Gradation")]
        [Category("UI Colors")]
        [Display(Order = 203)]
        public ConfigColor CampHighColorGradation { get; set; } = ConfigColor.CampBgColor;

        [DisplayName("Camp: Middle Color")]
        [Category("UI Colors")]
        [Display(Order = 204)]
        public ConfigColor CampMiddleColor { get; set; } = ConfigColor.CampBgColor;

        [DisplayName("Camp: Low Color")]
        [Category("UI Colors")]
        [Display(Order = 205)]
        public ConfigColor CampLowColor { get; set; } = ConfigColor.CampBgColor;

        [DisplayName("Date Time Panel: Top Text Color")]
        [Category("UI Colors")]
        [Display(Order = 206)]
        public ConfigColor DateTimePanelTopTextColor { get; set; } = ConfigColor.DarkColor;

        [DisplayName("Date Time Panel: Bottom Text Color")]
        [Category("UI Colors")]
        [Display(Order = 207)]
        public ConfigColor DateTimePanelBottomTextColor { get; set; } = ConfigColor.MidColor;

        [DisplayName("Date Time Panel: Water Color")]
        [Category("UI Colors")]
        [Display(Order = 208)]
        public ConfigColor DateTimePanelWaterColor { get; set; } = ConfigColor.DateTimeWaterColor;

        [DisplayName("Text Box: Back Fill Color")]
        [Category("UI Colors")]
        [Display(Order = 209)]
        public ConfigColor TextBoxBackFillColor { get; set; } = ConfigColor.TextBoxBackFillColor;

        [DisplayName("Text Box: Front Fill Color")]
        [Category("UI Colors")]
        [Display(Order = 210)]
        public ConfigColor TextBoxFrontFillColor { get; set; } = ConfigColor.TextBoxFrontFillColor;

        [DisplayName("Text Box: Front Fill Border Color")]
        [Category("UI Colors")]
        [Display(Order = 211)]
        public ConfigColor TextBoxFrontBorderColor { get; set; } = ConfigColor.DarkColor;

        [DisplayName("Text Box: Speaker Name Triangle Color")]
        [Category("UI Colors")]
        [Display(Order = 212)]
        public ConfigColor TextBoxSpeakerNameTriangle { get; set; } = ConfigColor.TextBoxSpeakerNameTriangle;

        [DisplayName("Text Box: Speaker Name")]
        [Category("UI Colors")]
        [Display(Order = 213)]
        public ConfigColor TextBoxSpeakerName { get; set; } = ConfigColor.LightColor;

        [DisplayName("Text Box: Left Haze Color")]
        [Category("UI Colors")]
        [Display(Order = 214)]
        public ConfigColor TextBoxLeftHaze { get; set; } = ConfigColor.TextBoxLeftHaze;

        [DisplayName("Mind Window: Outer Border")]
        [Category("UI Colors")]
        [Display(Order = 215)]
        public ConfigColor MindWindowOuterBorderNew { get; set; } = UICommon.MindWindowOuterBorder;

        [DisplayName("Mind Window: Inner Color")]
        [Category("UI Colors")]
        [Display(Order = 216)]
        public ConfigColor MindWindowInnerColorNew { get; set; } = UICommon.MindWindowInnerColor;

        /*[DisplayName("Mind Window: Outer Haze")] i'm hardcoding this it's broken for too many people lol
         * [Category("UI Colors")]
         * [Display(Order = 217)]
        public ConfigColor MindWindowOuterHazeEx { get; set; } = new ConfigColor(ConfigColor.MellodiColorLight3.R, ConfigColor.MellodiColorLight3.G, ConfigColor.MellodiColorLight3.B, 128);
        */

        [DisplayName("Mind Window: Background Dots")]
        [Category("UI Colors")]
        [Display(Order = 218)]
        public ConfigColor MindWindowBgDotsNew { get; set; } = UICommon.MindWindowOuterBorder;

        [DisplayName("Minimap: Place Name Background Color")]
        [Category("UI Colors")]
        [Display(Order = 219)]
        public ConfigColor MinimapPlaceNameBgColor { get; set; } = ConfigColor.DarkColor;

        [DisplayName("Interact Prompt: Back Box Color")]
        [Category("UI Colors")]
        [Display(Order = 220)]
        public ConfigColor CheckPromptBackBoxColorNew { get; set; } = UICommon.CheckPromptBgBox;

        [DisplayName("Interact Prompt: Front Box Base Color")]
        [Category("UI Colors")]
        [Display(Order = 221)]
        public ConfigColor CheckPromptFrontBoxColorNew { get; set; } = ConfigColor.MellodiColorDark3;

        [DisplayName("Interact Prompt: Front Box Highlight Color")]
        [Category("UI Colors")]
        [Display(Order = 222)]
        public ConfigColor CheckPromptFrontBoxColorHighNew { get; set; } = UICommon.CheckPromptFgBox;

        [DisplayName("Bustup: Shadow Color")]
        [Category("UI Colors")]
        [Display(Order = 223)]
        public ConfigColor BustupShadowColor { get; set; } = ConfigColor.DarkColor;

        [DisplayName("Camp: Menu Item Color 1 (Requires Restart)")]
        [Category("UI Colors")]
        [Display(Order = 224)]
        public ConfigColor CampMenuItemColor1 { get; set; } = ConfigColor.CampMenuItemColor1;

        [DisplayName("Camp: Menu Item Color 2 (Requires Restart)")]
        [Category("UI Colors")]
        [Display(Order = 225)]
        public ConfigColor CampMenuItemColor2 { get; set; } = ConfigColor.CampMenuItemColor2;

        [DisplayName("Camp: Menu Item Color 3 (Requires Restart)")]
        [Category("UI Colors")]
        [Display(Order = 226)]
        public ConfigColor CampMenuItemColor3 { get; set; } = ConfigColor.CampMenuItemColor3;

        [DisplayName("Camp: Menu Item Color No Select (Requires Restart)")]
        [Category("UI Colors")]
        [Display(Order = 227)]
        public ConfigColor CampMenuItemColorNoSel { get; set; } = ConfigColor.CampMenuItemColorNoSel;

        [DisplayName("Camp: Skill Text Color")]
        [Category("UI Colors")]
        [Display(Order = 228)]
        public ConfigColor CampSkillTextColor { get; set; } = ConfigColor.MellodiColorLight1;

        [DisplayName("Camp: Skill Text Color No Select")]
        [Category("UI Colors")]
        [Display(Order = 229)]
        public ConfigColor CampSkillTextColorNoSel { get; set; } = ConfigColor.MellodiColorLight3;

        [DisplayName("Camp: Skill Text Color Current Select")]
        [Category("UI Colors")]
        [Display(Order = 230)]
        public ConfigColor CampSkillTextColorCurrSel { get; set; } = ConfigColor.MellodiColorDark2;

        [DisplayName("Social Stats: Academics Circle Color")]
        [Category("UI Colors")]
        [Display(Order = 231)]
        public ConfigColor SocialStatsCircleAcademicsColor { get; set; } = ConfigColor.SocialStatsAcademics;

        [DisplayName("Social Stats: Charm Circle Color")]
        [Category("UI Colors")]
        [Display(Order = 232)]
        public ConfigColor SocialStatsCircleCharmColor { get; set; } = ConfigColor.SocialStatsCharm;

        [DisplayName("Social Stats: Courage Circle Color")]
        [Category("UI Colors")]
        [Display(Order = 233)]
        public ConfigColor SocialStatsCircleCourageColor { get; set; } = ConfigColor.SocialStatsCourage;

        [DisplayName("Camp: Item Menu Character Top Color (Requires Restart)")]
        [Category("UI Colors")]
        [Display(Order = 234)]
        public ConfigColor CampItemMenuCharacterTopColor { get; set; } = ConfigColor.DarkColor;

        [DisplayName("Camp: Item Menu Character Bottom Color (Requires Restart)")]
        [Category("UI Colors")]
        [Display(Order = 235)]
        public ConfigColor CampItemMenuCharacterBottomColor { get; set; } = ConfigColor.DarkColor;

        [DisplayName("Assist Message Box: Background Color")]
        [Category("UI Colors")]
        [Display(Order = 236)]
        public ConfigColor MsgAssistBgColor { get; set; } = ConfigColor.MellodiColorMid2;

        [DisplayName("Town Map: Border Color")]
        [Category("UI Colors")]
        [Display(Order = 237)]
        public ConfigColor TownMapBorderColor { get; set; } = ConfigColor.MellodiColorDark3;

        [DisplayName("Town Map: Text Color")]
        [Category("UI Colors")]
        [Display(Order = 238)]
        public ConfigColor TownMapTextColor { get; set; } = ConfigColor.MellodiColorMid1;

        [DisplayName("Camp Social Link: Light Color")]
        [Category("UI Colors")]
        [Display(Order = 239)]
        public ConfigColor CampSocialLinkLight { get; set; } = ConfigColor.MellodiColorLight2;

        [DisplayName("Camp Social Link: Dark Color")]
        [Category("UI Colors")]
        [Display(Order = 240)]
        public ConfigColor CampSocialLinkDark { get; set; } = ConfigColor.MellodiColorDark3;

        [DisplayName("Camp Social Link: Desc BG")]
        [Category("UI Colors")]
        [Display(Order = 241)]
        public ConfigColor CampSocialLinkDetailDescBg { get; set; } = ConfigColor.MellodiColorDark3;

        [DisplayName("Camp Social Link: Desc Triangle")]
        [Category("UI Colors")]
        [Display(Order = 242)]
        public ConfigColor CampSocialLinkDetailDescTriangle { get; set; } = ConfigColor.MellodiColorMid1;

        [DisplayName("Camp Social Link: Desc Name")]
        [Category("UI Colors")]
        [Display(Order = 243)]
        public ConfigColor CampSocialLinkDetailDescName { get; set; } = ConfigColor.MellodiColorLight1;

        [DisplayName("Arcana Card Fall Color 1")]
        [Category("UI Colors")]
        [Display(Order = 244)]
        public ConfigColor ArcanaCardFallColor1 { get; set; } = ConfigColor.MellodiColorMid1;

        [DisplayName("Arcana Card Fall Color 2")]
        [Category("UI Colors")]
        [Display(Order = 245)]
        public ConfigColor ArcanaCardFallColor2 { get; set; } = ConfigColor.MellodiColorMid2;

        [DisplayName("Arcana Card Fall Color 3")]
        [Category("UI Colors")]
        [Display(Order = 246)]
        public ConfigColor ArcanaCardFallColor3 { get; set; } = ConfigColor.MellodiColorMid3;

        [DisplayName("Camp Calendar: Sunday Color (Requires Restart)")]
        [Category("UI Colors")]
        [Display(Order = 247)]
        public ConfigColor CampCalendarSundayColor { get; set; } = ConfigColor.MellodiColorLight3;

        [DisplayName("Camp Calendar: Sunday Color 2 (Requires Restart)")]
        [Category("UI Colors")]
        [Display(Order = 248)]
        public ConfigColor CampCalendarSundayColor2 { get; set; } = ConfigColor.MellodiColorLight1;

        [DisplayName("Camp Calendar: Text Color (Requires Restart)")]
        [Category("UI Colors")]
        [Display(Order = 249)]
        public ConfigColor CampCalendarTextColor { get; set; } = ConfigColor.MellodiColorDark3;

        [DisplayName("Camp Calendar: Highlight Color (Requires Restart)")]
        [Category("UI Colors")]
        [Display(Order = 250)]
        public ConfigColor CampCalendarHighlightColor { get; set; } = ConfigColor.MellodiColorLight1;

        [DisplayName("Camp Calendar: Part Time Job Background")]
        [Category("UI Colors")]
        [Display(Order = 251)]
        public ConfigColor CampCalendarPartTimeJobBackground { get; set; } = ConfigColor.MellodiColorDark1;

        [DisplayName("Party Panel Background Color")]
        [Category("UI Colors")]
        [Display(Order = 252)]
        public ConfigColor PartyPanelBgColor { get; set; } = ConfigColor.MellodiColorMid2;

        [DisplayName("Button Prompt Fill Color (Requires Restart)")]
        [Category("UI Colors")]
        [Display(Order = 253)]
        public ConfigColor ButtonPromptHighlightColor { get; set; } = ConfigColor.MellodiColorLight3;

        [DisplayName("Button Prompt Triangle Color")]
        [Category("UI Colors")]
        [Display(Order = 254)]
        public ConfigColor ButtonPromptTriangleColor { get; set; } = ConfigColor.MellodiColorMid2;

        [DisplayName("Back Log Blackboard Color")]
        [Category("UI Colors")]
        [Display(Order = 255)]
        public ConfigColor BackLogBlackboardColor { get; set; } = ConfigColor.BackLogBlackBoard;

        [DisplayName("Back Log Haze Color")]
        [Category("UI Colors")]
        [Display(Order = 256)]
        public ConfigColor BackLogGladationColor { get; set; } = ConfigColor.MellodiColorMid2;

        [DisplayName("Back Log Blueboard Color")]
        [Category("UI Colors")]
        [Display(Order = 257)]
        public ConfigColor BackLogBlueboardColorEx { get; set; } = ConfigColor.MellodiColorMid2;

        [DisplayName("Back Log Title Color (Requires Restart)")]
        [Category("UI Colors")]
        [Display(Order = 258)]
        public ConfigColor BackLogTitleColor { get; set; } = ConfigColor.MellodiColorMid2;

        [DisplayName("Back Log Text/Icon Color Selected")]
        [Category("UI Colors")]
        [Display(Order = 259)]
        public ConfigColor BackLogTexColorSelected { get; set; } = ConfigColor.MellodiColorLight3;

        [DisplayName("Back Log Text/Icon Color Unselected")]
        [Category("UI Colors")]
        [Display(Order = 260)]
        public ConfigColor BackLogTexColorUnselectedEx { get; set; } = ConfigColor.MellodiColorDark1;

        [DisplayName("Location Select Background Color")]
        [Category("UI Colors")]
        [Display(Order = 261)]
        public ConfigColor LocationSelectBgColor { get; set; } = ConfigColor.MellodiColorMid1;

        [DisplayName("Location Select Marker Color")]
        [Category("UI Colors")]
        [Display(Order = 262)]
        public ConfigColor LocationSelectMarkerColor { get; set; } = ConfigColor.MellodiColorMid2;

        [DisplayName("Location Select Selected Item Color (Requires Restart)")]
        [Category("UI Colors")]
        [Display(Order = 263)]
        public ConfigColor LocationSelectSelColor { get; set; } = ConfigColor.MellodiColorMid1;

        [DisplayName("Time Skip Color")]
        [Category("UI Colors")]
        [Display(Order = 264)]
        public ConfigColor TimeSkipColor { get; set; } = ConfigColor.MellodiColorMid1;

        [DisplayName("Next Day Band Color")]
        [Category("UI Colors")]
        [Display(Order = 265)]
        public ConfigColor NextDayBandColor { get; set; } = ConfigColor.MellodiColorDark1;

        [DisplayName("Next Day Text Color")]
        [Category("UI Colors")]
        [Display(Order = 266)]
        public ConfigColor NextDayTextColor { get; set; } = ConfigColor.MellodiColorMid3;

        [DisplayName("Next Day Moon Shadow Color")]
        [Category("UI Colors")]
        [Display(Order = 267)]
        public ConfigColor NextDayMoonShadowColor { get; set; } = ConfigColor.DayChangeMoonShadow;

        [DisplayName("Next Day Ripple")]
        [Category("UI Colors")]
        [Display(Order = 268)]
        public ConfigColor NextDayRipple { get; set; } = ConfigColor.MellodiColorMid1;

        [DisplayName("Shop Payment Color")]
        [Category("UI Colors")]
        [Display(Order = 269)]
        public ConfigColor ShopPayColor { get; set; } = ConfigColor.MellodiColorLight3;

        [DisplayName("Shop Fill Color")]
        [Category("UI Colors")]
        [Display(Order = 270)]
        public ConfigColor ShopFillColor { get; set; } = ConfigColor.MellodiColorMid1;

        [DisplayName("Shop Shadow Color")]
        [Category("UI Colors")]
        [Display(Order = 271)]
        public ConfigColor ShopShadowColor { get; set; } = ConfigColor.MellodiColorMid2;

        [DisplayName("Shop Payment Unselect Color")]
        [Category("UI Colors")]
        [Display(Order = 272)]
        public ConfigColor ShopPayUnselColor { get; set; } = ConfigColor.MellodiColorMid4;

        [DisplayName("Get Item Background Mask Color")]
        [Category("UI Colors")]
        [Display(Order = 273)]
        public ConfigColor GetItemBgMaskColor { get; set; } = ConfigColor.GetItemFillMask;

        [DisplayName("Get Item Background Color")]
        [Category("UI Colors")]
        [Display(Order = 274)]
        public ConfigColor GetItemBgColor { get; set; } = ConfigColor.MellodiColorMid2;

        [DisplayName("Get Item Got Text Color")]
        [Category("UI Colors")]
        [Display(Order = 275)]
        public ConfigColor GetItemGotTextColor { get; set; } = ConfigColor.GetItemGotTextColor;

        [DisplayName("Get Item Got Item Count Background")]
        [Category("UI Colors")]
        [Display(Order = 276)]
        public ConfigColor GetItemCountBgColor { get; set; } = ConfigColor.MellodiColorMid1;

        [DisplayName("Mind Select: Selected Text Color")]
        [Category("UI Colors")]
        [Display(Order = 277)]
        public ConfigColor MindSelActiveTextColor { get; set; } = ConfigColor.MellodiColorMid1;

        [DisplayName("Mind Select Window Fill (Requires Restart)")]
        [Category("UI Colors")]
        [Display(Order = 278)]
        public ConfigColor MindSelWindowFill { get; set; } = ConfigColor.MellodiColorMid1;

        [DisplayName("Mind Select Window Border (Requires Restart)")]
        [Category("UI Colors")]
        [Display(Order = 279)]
        public ConfigColor MindSelWindowBorder { get; set; } = ConfigColor.MellodiColorMid2;

        [DisplayName("Mind Select Dot Color (Requires Restart)")]
        [Category("UI Colors")]
        [Display(Order = 280)]
        public ConfigColor MindSelectDotColor { get; set; } = ConfigColor.MindSelectDotColor;

        [DisplayName("Generic Select Character Backplate Color ")]
        [Category("UI Colors")]
        [Display(Order = 281)]
        public ConfigColor GenericSelectCharacterBackplate { get; set; } = ConfigColor.MellodiColorMid1;

        [DisplayName("Generic Select List Color Morning")]
        [Category("UI Colors")]
        [Display(Order = 282)]
        public ConfigColor GenericSelectListColorMorning { get; set; } = ConfigColor.MellodiColorMid2;

        [DisplayName("Generic Select List Color After School")]
        [Category("UI Colors")]
        [Display(Order = 283)]
        public ConfigColor GenericSelectListColorAfterSchool { get; set; } = ConfigColor.MellodiColorMid1;

        [DisplayName("Generic Select List Color Night")]
        [Category("UI Colors")]
        [Display(Order = 284)]
        public ConfigColor GenericSelectListColorNight { get; set; } = ConfigColor.MellodiColorMid3;

        [DisplayName("Generic Select Title Color")]
        [Category("UI Colors")]
        [Display(Order = 285)]
        public ConfigColor GenericSelectTitle { get; set; } = ConfigColor.MellodiColorMid1;

        [DisplayName("Generic Select Character Shadow (Requires Restart)")]
        [Category("UI Colors")]
        [Display(Order = 286)]
        public ConfigColor GenericSelectCharacterShadow { get; set; } = ConfigColor.MellodiColorMid4;

        [DisplayName("Message Box Select Text Color")]
        [Category("UI Colors")]
        [Display(Order = 287)]
        public ConfigColor MsgSimpleSelectTextColor { get; set; } = ConfigColor.MellodiColorMid1;

        [DisplayName("Message Box Select Box Shadow Color")]
        [Category("UI Colors")]
        [Display(Order = 288)]
        public ConfigColor MsgSimpleSelectBoxShadow { get; set; } = ConfigColor.MellodiColorDark1;

        [DisplayName("Message Box Shadow Color")]
        [Category("UI Colors")]
        [Display(Order = 289)]
        public ConfigColor MsgSimpleSelectShadowEx { get; set; } = ConfigColor.TextBoxFrontFillColor;

        [DisplayName("Message Box Border Color")]
        [Category("UI Colors")]
        [Display(Order = 290)]
        public ConfigColor MsgSimpleSelectBorderColorEx { get; set; } = ConfigColor.MellodiColorDark3;

        [DisplayName("System Message Light Color (Requires Restart)")]
        [Category("UI Colors")]
        [Display(Order = 291)]
        public ConfigColor MsgSimpleSystemLightColor { get; set; } = ConfigColor.MellodiColorMid1;

        [DisplayName("System Message Dark Color")]
        [Category("UI Colors")]
        [Display(Order = 292)]
        public ConfigColor MsgSimpleSystemDarkColor { get; set; } = ConfigColor.MsgWindowSystemDark;

        [DisplayName("System Message Dark Haze Color")]
        [Category("UI Colors")]
        [Display(Order = 293)]
        public ConfigColor MsgSimpleSystemGradationColor { get; set; } = ConfigColor.MellodiColorDark3;

        [DisplayName("Persona Status Skill List Background Top Left")]
        [Category("UI Colors")]
        [Display(Order = 294)]
        public ConfigColor PersonaStatusSkillListBg { get; set; } = ConfigColor.PersonaStatusSkillListBg;

        [DisplayName("Persona Status Skill List Background Lower Line")]
        [Category("UI Colors")]
        [Display(Order = 295)]
        public ConfigColor PersonaStatusSkillListBg2 { get; set; } = ConfigColor.MellodiColorMid1;

        [DisplayName("Persona Status Skill List Checkerboard")]
        [Category("UI Colors")]
        [Display(Order = 296)]
        public ConfigColor PersonaStatusSkillListCheckboardAlt { get; set; } = ConfigColor.PersonaStatusSkillListCheckboardAlt;

        [DisplayName("Persona Status Skill List Next Skill Color")]
        [Category("UI Colors")]
        [Display(Order = 297)]
        public ConfigColor PersonaSkillListNextSkillColor { get; set; } = ConfigColor.MellodiColorMid1;

        [DisplayName("Persona Status Skill List Level Color")]
        [Category("UI Colors")]
        [Display(Order = 298)]
        public ConfigColor PersonaSkillListNextLevelColor { get; set; } = ConfigColor.MellodiColorLight3;

        [DisplayName("Persona Status Skill List Next Skill Name Color")]
        [Category("UI Colors")]
        [Display(Order = 299)]
        public ConfigColor PersonaSkillListNextSkillInfoName { get; set; } = ConfigColor.MellodiColorLight1;

        [DisplayName("Persona Status Info Color")]
        [Category("UI Colors")]
        [Display(Order = 300)]
        public ConfigColor PersonaStatusPlayerInfoColor { get; set; } = ConfigColor.MellodiColorMid2;

        [DisplayName("Persona Status Info Selected Persona Color 1")]
        [Category("UI Colors")]
        [Display(Order = 301)]
        public ConfigColor PersonaStatusInfoSelPersonaColor1 { get; set; } = ConfigColor.MellodiColorLight3;

        [DisplayName("Persona Status Info Selected Persona Color 2")]
        [Category("UI Colors")]
        [Display(Order = 302)]
        public ConfigColor PersonaStatusInfoSelPersonaColor2 { get; set; } = ConfigColor.MellodiColorMid2;

        [DisplayName("Persona Status Param Background Color")]
        [Category("UI Colors")]
        [Display(Order = 303)]
        public ConfigColor PersonaStatusParamColor { get; set; } = ConfigColor.MellodiColorDark3;

        [DisplayName("Persona Status Lore Title Color")]
        [Category("UI Colors")]
        [Display(Order = 304)]
        public ConfigColor PersonaStatusCommentaryTitleColor { get; set; } = ConfigColor.MellodiColorLight1;

        [DisplayName("Persona Status Base Stat Color")]
        [Category("UI Colors")]
        [Display(Order = 305)]
        public ConfigColor PersonaStatusBaseStat { get; set; } = ConfigColor.MellodiColorLight3;

        [DisplayName("Persona Status Skill Affinity Outline Color (Requires Restart)")]
        [Category("UI Colors")]
        [Display(Order = 306)]
        public ConfigColor PersonaStatusAttributeOutline { get; set; } = ConfigColor.MellodiColorMid1;

        [DisplayName("Network: Daily Action Sticky Note Background Color 1")]
        [Category("UI Colors")]
        [Display(Order = 307)]
        public ConfigColor NetworkDailyActionStickyNoteBgColor1 { get; set; } = UICommon.NetStickyNoteBgColor1;

        [DisplayName("Network: Daily Action Sticky Note Background Color 2")]
        [Category("UI Colors")]
        [Display(Order = 308)]
        public ConfigColor NetworkDailyActionStickyNoteBgColor2 { get; set; } = ConfigColor.MellodiColorMid1;

        [DisplayName("Network: Daily Action Sticky Note Dotpoint Color 1")]
        [Category("UI Colors")]
        [Display(Order = 309)]
        public ConfigColor NetworkDailyActionStickyNoteDotColor1 { get; set; } = ConfigColor.MellodiColorLight2;

        [DisplayName("Network: Daily Action Sticky Note Dotpoint Color 2")]
        [Category("UI Colors")]
        [Display(Order = 310)]
        public ConfigColor NetworkDailyActionStickyNoteDotColor2 { get; set; } = ConfigColor.MellodiColorLight3;

        [DisplayName("Network: Daily Action Sticky Note Text Color 1")]
        [Category("UI Colors")]
        [Display(Order = 311)]
        public ConfigColor NetworkDailyActionStickyNoteTextColor1 { get; set; } = UICommon.NetStickyNoteTextColor1;

        [DisplayName("Network: Daily Action Sticky Note Text Color 2")]
        [Category("UI Colors")]
        [Display(Order = 312)]
        public ConfigColor NetworkDailyActionStickyNoteTextColor2 { get; set; } = ConfigColor.MellodiColorLight1;

        [DisplayName("Network: Daily Action Blue Background Color")]
        [Category("UI Colors")]
        [Display(Order = 313)]
        public ConfigColor NetworkDailyActionBlueBgColor { get; set; } = ConfigColor.MellodiColorMid4;

        [DisplayName("Network: Daily Action Network Icon Color")]
        [Category("UI Colors")]
        [Display(Order = 314)]
        public ConfigColor NetworkDailyActionNetworkIcon { get; set; } = ConfigColor.MellodiColorMid1;

        [DisplayName("Simple Shop: Info Color")]
        [Category("UI Colors")]
        [Display(Order = 315)]
        public ConfigColor SimpleShopInfoColor { get; set; } = ConfigColor.MellodiColorMid1;

        [DisplayName("Cutin: Outer Highlight Color")]
        [Category("UI Colors")]
        [Display(Order = 316)]
        public ConfigColor CutinOuterHighlight { get; set; } = ConfigColor.MellodiColorMid2;

        [DisplayName("Cutin: Emotion Gradient Color")]
        [Category("UI Colors")]
        [Display(Order = 317)]
        public ConfigColor CutinEmotionGradient { get; set; } = ConfigColor.MellodiColorLight3;

        [DisplayName("Cutin: Emotion Tint Color")]
        [Category("UI Colors")]
        [Display(Order = 318)]
        public ConfigColor CutinEmotionTint { get; set; } = ConfigColor.MellodiColorMid2;

        [DisplayName("Title Menu: Select Rectangle Color")]
        [Category("UI Colors")]
        [Display(Order = 319)]
        public ConfigColor TitleMenuSelRectColor { get; set; } = ConfigColor.MellodiColorMid1;

        [DisplayName("Localization Staff Roll: Header Color (Requires Restart)")]
        [Category("UI Colors")]
        [Display(Order = 320)]
        public ConfigColor LocalStaffRollHeader { get; set; } = ConfigColor.MellodiColorLight3;

        [DisplayName("Difficulty Selection Background")]
        [Category("UI Colors")]
        [Display(Order = 321)]
        public ConfigColor DifficultySelectBgColor { get; set; } = ConfigColor.MellodiColorDark3;

        [DisplayName("Wipe Background")]
        [Category("UI Colors")]
        [Display(Order = 322)]
        public ConfigColor WipeBgColor { get; set; } = ConfigColor.MellodiColorDark3;

        [DisplayName("Camp Equip: Item Stat Value Padding Color")]
        [Category("UI Colors")]
        [Display(Order = 323)]
        public ConfigColor CampItemStatValuePadColor { get; set; } = ConfigColor.MellodiColorDark1;

        [DisplayName("Camp Equip: Item Stat Value Padding Color")]
        [Category("UI Colors")]
        [Display(Order = 324)]
        public ConfigColor CampItemStatValueValColor { get; set; } = ConfigColor.MellodiColorMid2;

        [DisplayName("Camp Equip: Overview List Type Color")]
        [Category("UI Colors")]
        [Display(Order = 325)]
        public ConfigColor CampEquipOverviewListType { get; set; } = ConfigColor.MellodiColorMid3;

        [DisplayName("Camp Persona: Arcana Phrase Color (Requires Restart)")]
        [Category("UI Colors")]
        [Display(Order = 326)]
        public ConfigColor CampPersonaArcanaPhraseColor { get; set; } = ConfigColor.MellodiColorLight3;

        [DisplayName("Camp Persona: Name Color")]
        [Category("UI Colors")]
        [Display(Order = 327)]
        public ConfigColor CampPersonaNameColor { get; set; } = ConfigColor.MellodiColorLight3;

        [DisplayName("Camp Persona: Arcana Background Color")]
        [Category("UI Colors")]
        [Display(Order = 328)]
        public ConfigColor CampPersonaArcanaBgColor { get; set; } = ConfigColor.MellodiColorDark3;

        [DisplayName("Camp Status: Kotone Line Color")]
        [Category("UI Colors")]
        [Display(Order = 329)]
        public ConfigColor CampStatusKotoneLineColor { get; set; } = ConfigColor.MellodiColorLight3;

        [DisplayName("Camp Status: Inactive Party Member Background (Tartarus)")]
        [Category("UI Colors")]
        [Display(Order = 330)]
        public ConfigColor CampStatusInactiveMemberBgTartarus { get; set; } = UICommon.InactivePartyMemberTartarusBG;

        [DisplayName("Camp Status: Inactive Member Details Pale Pink (Tartarus)")]
        [Category("UI Colors")]
        [Display(Order = 331)]
        public ConfigColor CampStatusInactiveMemberDetailsPalePinkTartarus { get; set; } = UICommon.InactivePartyMemberPalePink;

        [DisplayName("Camp Status: Inactive Member Details Dark Pink (Tartarus)")]
        [Category("UI Colors")]
        [Display(Order = 332)]
        public ConfigColor CampStatusInactiveMemberDetailsDarkPinkTartarus { get; set; } = UICommon.InactivePartyMemberDarkPink;

        [DisplayName("Camp Status: Inactive Member HP Bar (Tartarus)")]
        [Category("UI Colors")]
        [Display(Order = 333)]
        public ConfigColor CampStatusInactiveMemberHPBarTartarus { get; set; } = UICommon.InactivePartyMemberHPColor;

        [DisplayName("Town Map: Location Details Background Tint")]
        [Category("UI Colors")]
        [Display(Order = 334)]
        public ConfigColor TownMapLocationDetailsBgTint { get; set; } = ConfigColor.MellodiColorMid1;

        [DisplayName("Town Map: Location Details Top Left Bg")]
        [Category("UI Colors")]
        [Display(Order = 335)]
        public ConfigColor TownMapLocationDetailsTopLeftBg { get; set; } = ConfigColor.MellodiColorMid2;

        [DisplayName("Town Map: Location Details Top Left Text")]
        [Category("UI Colors")]
        [Display(Order = 336)]
        public ConfigColor TownMapLocationDetailsTopLeftText { get; set; } = ConfigColor.MellodiColorMid1;

        [DisplayName("Town Map: Selected Marker Outline")]
        [Category("UI Colors")]
        [Display(Order = 337)]
        public ConfigColor TownMapSelectedMarkerOutline { get; set; } = ConfigColor.MellodiColorMid2;

        [DisplayName("Social Stats: Stats Up Text")]
        [Category("UI Colors")]
        [Display(Order = 338)]
        public ConfigColor SocialStatsUpText { get; set; } = ConfigColor.MellodiColorLight3;

        [DisplayName("Social Stats: Stat Up Pulse Circle Color")]
        [Category("UI Colors")]
        [Display(Order = 339)]
        public ConfigColor SocialStatsPulseCircleColorMain { get; set; } = ConfigColor.MellodiColorLight3;

        [DisplayName("Social Stats: Stat Up Pulse Circle Fade")]
        [Category("UI Colors")]
        [Display(Order = 340)]
        public ConfigColor SocialStatsPulseCircleColorFade { get; set; } = ConfigColor.MellodiColorMid1;

        [DisplayName("Assist Message Box: Text Background")]
        [Category("UI Colors")]
        [Display(Order = 341)]
        public ConfigColor MsgAssistTextBgColor { get; set; } = ConfigColor.MellodiColorDark3;

        [DisplayName("Location Select: Map Background Color")]
        [Category("UI Colors")]
        [Display(Order = 342)]
        public ConfigColor LocationSelMapBg { get; set; } = ConfigColor.MellodiColorDark3;

        [DisplayName("Location Select: Map Label Color")]
        [Category("UI Colors")]
        [Display(Order = 343)]
        public ConfigColor LocationSelMapLabel { get; set; } = UICommon.LocationSelectMapLabel;

        [DisplayName("System Message Picture Border Color (Requires Restart)")]
        [Category("UI Colors")]
        [Display(Order = 344)]
        public ConfigColor MsgSystemPicBorderColor { get; set; } = ConfigColor.MellodiColorDark1;

        [DisplayName("Tutorial List Entry Color (Requires Restart)")]
        [Category("UI Colors")]
        [Display(Order = 345)]
        public ConfigColor TutorialListEntryColor { get; set; } = ConfigColor.MellodiColorLight3;

        [DisplayName("Tutorial List Background Color")]
        [Category("UI Colors")]
        [Display(Order = 346)]
        public ConfigColor TutorialBgColor { get; set; } = ConfigColor.MellodiColorDark3;

        [DisplayName("Missing Person: Selected Person \"Last Sighted\" Color")]
        [Category("UI Colors")]
        [Display(Order = 347)]
        public ConfigColor MissingLastSighted { get; set; } = ConfigColor.MellodiColorLight3;

        [DisplayName("Missing Person: Page Background")]
        [Category("UI Colors")]
        [Display(Order = 348)]
        public ConfigColor MissingPageBg { get; set; } = ConfigColor.MellodiColorDark3;

        [DisplayName("Missing Person: Light Text Color")]
        [Category("UI Colors")]
        [Display(Order = 349)]
        public ConfigColor MissingTextLight { get; set; } = ConfigColor.MellodiColorLight3;

        [DisplayName("Missing Person: Dark Text Color")]
        [Category("UI Colors")]
        [Display(Order = 350)]
        public ConfigColor MissingTextDark { get; set; } = ConfigColor.MellodiColorDark3;

        [DisplayName("Request/Missing Person: Sort by Triangle")]
        [Category("Ui Colors")]
        [Display(Order = 351)]
        public ConfigColor MissingSortTriangle { get; set; } = ConfigColor.MellodiColorMid2;


        //silly edits

        [DisplayName("Camp: Waves Top A Color")]
        [Category("UI Colors")]
        [Display(Order = 352)]
        public ConfigColor NamiTopAColor { get; set; } = ConfigColor.MellodiColorLight3;
        
        [DisplayName("Camp: Waves Top B Color")]
        [Category("UI Colors")]
        [Display(Order = 353)]
        public ConfigColor NamiTopBColor { get; set; } = ConfigColor.MellodiColorLight3;

        [DisplayName("Camp: Waves Skill A Color")]
        [Category("UI Colors")]
        [Display(Order = 354)]
        public ConfigColor NamiSkillAColor { get; set; } = ConfigColor.MellodiColorLight3;

        [DisplayName("Camp: Waves Skill B Color")]
        [Category("UI Colors")]
        [Display(Order = 355)]
        public ConfigColor NamiSkillBColor { get; set; } = ConfigColor.MellodiColorLight3;

        [DisplayName("Camp: Waves Item A Color")]
        [Category("UI Colors")]
        [Display(Order = 356)]
        public ConfigColor NamiItemAColor { get; set; } = ConfigColor.MellodiColorLight3;

        [DisplayName("Camp: Waves Item B Color")]
        [Category("UI Colors")]
        [Display(Order = 357)]
        public ConfigColor NamiItemBColor { get; set; } = ConfigColor.MellodiColorLight3;

        [DisplayName("Camp: Waves Equip A Color")]
        [Category("UI Colors")]
        [Display(Order = 358)]
        public ConfigColor NamiEquipAColor { get; set; } = ConfigColor.MellodiColorLight3;

        [DisplayName("Camp: Waves Equip B Color")]
        [Category("UI Colors")]
        [Display(Order = 359)]
        public ConfigColor NamiEquipBColor { get; set; } = ConfigColor.MellodiColorLight3;

        [DisplayName("Camp: Waves Persona A Color")]
        [Category("UI Colors")]
        [Display(Order = 360)]
        public ConfigColor NamiPersonaAColor { get; set; } = ConfigColor.MellodiColorLight3;

        [DisplayName("Camp: Waves Persona B Color")]
        [Category("UI Colors")]
        [Display(Order = 361)]
        public ConfigColor NamiPersonaBColor { get; set; } = ConfigColor.MellodiColorLight3;

        [DisplayName("Camp: Waves Status A Color")]
        [Category("UI Colors")]
        [Display(Order = 362)]
        public ConfigColor NamiStatusAColor { get; set; } = ConfigColor.MellodiColorLight3;

        [DisplayName("Camp: Waves Status B Color")]
        [Category("UI Colors")]
        [Display(Order = 363)]
        public ConfigColor NamiStatusBColor { get; set; } = ConfigColor.MellodiColorLight3;

        [DisplayName("Camp: Waves Quest A Color")]
        [Category("UI Colors")]
        [Display(Order = 364)]
        public ConfigColor NamiQuestAColor { get; set; } = ConfigColor.MellodiColorLight3;

        [DisplayName("Camp: Waves Quest B Color")]
        [Category("UI Colors")]
        [Display(Order = 365)]
        public ConfigColor NamiQuestBColor { get; set; } = ConfigColor.MellodiColorLight3;

        [DisplayName("Camp: Waves Commu A Color")]
        [Category("UI Colors")]
        [Display(Order = 366)]
        public ConfigColor NamiCommuAColor { get; set; } = ConfigColor.MellodiColorLight3;

        [DisplayName("Camp: Waves Commu B Color")]
        [Category("UI Colors")]
        [Display(Order = 367)]
        public ConfigColor NamiCommuBColor { get; set; } = ConfigColor.MellodiColorLight3;

        [DisplayName("Camp: Waves Calendar A Color")]
        [Category("UI Colors")]
        [Display(Order = 368)]
        public ConfigColor NamiCalendarAColor { get; set; } = ConfigColor.MellodiColorLight3;

        [DisplayName("Camp: Waves Calendar B Color")]
        [Category("UI Colors")]
        [Display(Order = 369)]
        public ConfigColor NamiCalendarBColor { get; set; } = ConfigColor.MellodiColorLight3;

        [DisplayName("Camp: Waves System A Color")]
        [Category("UI Colors")]
        [Display(Order = 370)]
        public ConfigColor NamiSystemAColor { get; set; } = ConfigColor.MellodiColorLight3;

        [DisplayName("Camp: Waves System B Color")]
        [Category("UI Colors")]
        [Display(Order = 371)]
        public ConfigColor NamiSystemBColor { get; set; } = ConfigColor.MellodiColorLight3;

        [DisplayName("Camp: Waves Tutorial A Color")]
        [Category("UI Colors")]
        [Display(Order = 372)]
        public ConfigColor NamiTutorialAColor { get; set; } = ConfigColor.MellodiColorLight3;

        [DisplayName("Camp: Waves Tutorial B Color")]
        [Category("UI Colors")]
        [Display(Order = 373)]
        public ConfigColor NamiTutorialBColor { get; set; } = ConfigColor.MellodiColorLight3;

        [DisplayName("Camp: Waves Config A Color")]
        [Category("UI Colors")]
        [Display(Order = 374)]
        public ConfigColor NamiConfigAColor { get; set; } = ConfigColor.MellodiColorLight3;

        [DisplayName("Camp: Waves Config B Color")]
        [Category("UI Colors")]
        [Display(Order = 375)]
        public ConfigColor NamiConfigBColor { get; set; } = ConfigColor.MellodiColorLight3;

        // silly edits end

        [DisplayName("Camp: GradAUpColorHigh")]
        [Category("UI Colors")]
        [Display(Order = 376)]
        public ConfigColor GradAUpColorHigh { get; set; } = ConfigColor.White;

        [DisplayName("Camp: GradBUpColorHigh")]
        [Category("UI Colors")]
        [Display(Order = 377)]
        public ConfigColor GradBUpColorHigh { get; set; } = ConfigColor.CampBgColor;

        [DisplayName("Camp: GradBDownColorHigh")]
        [Category("UI Colors")]
        [Display(Order = 378)]
        public ConfigColor GradBDownColorHigh { get; set; } = ConfigColor.CampBgColor;

        [DisplayName("Camp: GradAUpColorMid")]
        [Category("UI Colors")]
        [Display(Order = 379)]
        public ConfigColor GradAUpColorMid { get; set; } = ConfigColor.White;

        [DisplayName("Camp: GradBUpColorMid")]
        [Category("UI Colors")]
        [Display(Order = 380)]
        public ConfigColor GradBUpColorMid { get; set; } = ConfigColor.CampBgColor;

        [DisplayName("Camp: GradBDownColorMid")]
        [Category("UI Colors")]
        [Display(Order = 381)]
        public ConfigColor GradBDownColorMid { get; set; } = ConfigColor.CampBgColor;

        [DisplayName("Camp: GradAUpColorLow")]
        [Category("UI Colors")]
        [Display(Order = 382)]
        public ConfigColor GradAUpColorLow { get; set; } = ConfigColor.White;

        [DisplayName("Camp: GradBUpColorLow")]
        [Category("UI Colors")]
        [Display(Order = 383)]
        public ConfigColor GradBUpColorLow { get; set; } = ConfigColor.CampBgColor;

        [DisplayName("Camp: GradBDownColorLow")]
        [Category("UI Colors")]
        [Display(Order = 384)]
        public ConfigColor GradBDownColorLow { get; set; } = ConfigColor.CampBgColor;

        [DisplayName("Camp: HeroCaptureBgColor")]
        [Category("UI Colors")]
        [Display(Order = 385)]
        public ConfigColor HeroCaptureBgColor { get; set; } = ConfigColor.CampBgColor;

        // sillies


        // do you want this still really :skull:
        //[DisplayName("Example Hex Edit Color")]
        //[Category("UI Colors")]
        //[Display(Order = 352)]
        /*public ConfigColor ExampleHexEditColor { get; set; } = new ConfigColor(0xFF, 0x00, 0x00, 0xFF);*/

        [DisplayName("Missing Person: Shadows Femc and Chairs in Detail Color")]
        public ConfigColor MissingDetailFemcChairsShadow { get; set; } = new ConfigColor(0x36, 0x0c, 0x18, 0xFF);

        [DisplayName("Request: Back Card Color")]
        public ConfigColor RequestBackCard { get; set; } = new ConfigColor(0x60, 0x00, 0x21, 0xFF);

        [DisplayName("Request: Back Squares Color")]
        public ConfigColor RequestBackSquares { get; set; } = new ConfigColor(0x38, 0x00, 0x10, 0xFF);

        [DisplayName("Request: Back Card Detail Color")]
        public ConfigColor RequestBackCardDetail { get; set; } = new ConfigColor(0x2e, 0x09, 0x17, 0xFF);

        [DisplayName("Request: Back Card Detail Right Down Solid Color")]
        public ConfigColor RequestBackCardRightDownDetail { get; set; } = new ConfigColor(0x5d, 0x00, 0x20, 0xFF);

        [DisplayName("Request: Shadows Femc and Chairs in Detail Color")] 
        public ConfigColor RequestDetailFemcChairsShadow { get; set; } = new ConfigColor(0x48, 0x11, 0x23, 0xFF);

        [DisplayName("Request: 'Task' Font Color")]
        public ConfigColor RequestTaskFont { get; set; } = new ConfigColor(0xFF, 0x91, 0xb0, 0xFF);

        [DisplayName("Request: Detail 'Request Details' Font Color")]
        public ConfigColor RequestDetailsFont { get; set; } = new ConfigColor(0xFD, 0x9B, 0xb7, 0xFF);

        [DisplayName("Request: Detail 'Complete' Tag Color")]
        public ConfigColor RequestDetailCompleted { get; set; } = new ConfigColor(0x43, 0x0d, 0x1b, 0xFF);

        [DisplayName("Request: Detail Background 'Complete' Tag Color")]
        public ConfigColor RequestDetailBackgroundCompleted { get; set; } = new ConfigColor(0x8c, 0x09, 0x30, 0xFF);

        [DisplayName("Request: Detail 'Earned' Tag Color")]
        public ConfigColor RequestDetailEarned { get; set; } = new ConfigColor(0xFF, 0x91, 0xb0, 0xFF);

        [DisplayName("Request: Detail Difficulty Rank Upper Part Color")]
        public ConfigColor RequestDifficultyRankUp { get; set; } = new ConfigColor(0x17, 0x03, 0x0c, 0xFF);

        [DisplayName("Request: Detail Difficulty Rank Lower Part Color")]
        public ConfigColor RequestDifficultyRankDown { get; set; } = new ConfigColor(0x41, 0x03, 0x20, 0xFF);

        [DisplayName("Request: Detail Difficulty Butterfly Indicator Color")]
        public ConfigColor RequestDifficultyIndicator { get; set; } = new ConfigColor(0x73, 0x0e, 0x38, 0xFF);

        [DisplayName("Request: Detail Difficulty Font Color")]
        public ConfigColor RequestDifficultyFont { get; set; } = new ConfigColor(0x71, 0x0d, 0x2b, 0xFF);

        [DisplayName("Request: Status Light Font and Tag Background Color")]
        public ConfigColor RequestStatusFontTagBack { get; set; } = new ConfigColor(0xfc, 0x9a, 0xb6, 0xFF);

        [DisplayName("Request: Status Tag Font Color")]
        public ConfigColor RequestStatusTagFont { get; set; } = new ConfigColor(0x68, 0x01, 0x08, 0xFF);

        [DisplayName("Request: Status Tag Underlay Color")]
        public ConfigColor RequestStatusTagUnderlay { get; set; } = new ConfigColor(0x6a, 0x00, 0x19, 0xFF);

        [DisplayName("Social Stats: Musical Notes Color")]
        public ConfigColor MusicNotesColor { get; set; } = new ConfigColor(0xFF, 0x8F, 0xEC, 0xFF);

        [DisplayName("Camp: Party Panel Missing Health/SP Color")]
        public ConfigColor PartyPanelMissingHealthSp { get; set; } = new ConfigColor(0x68, 0x01, 0x08, 0xFF);

        [DisplayName("Camp: Transition between menus color")]
        public ConfigColor CampColorTransition { get; set; } = ConfigColor.MellodiColorLight3;

        [DisplayName("Camp: Skill Card Sub Menu Background Color")]
        public ConfigColor CampSkillCardBackground { get; set; } = new ConfigColor(0x78, 0x68, 0x6f, 0xFF);

        [DisplayName("Camp: Skill Card Sub Menu Frame Color")]
        public ConfigColor CampSkillCardFrame { get; set; } = new ConfigColor(0x65, 0x35, 0x48, 0xFF);

        [DisplayName("Camp: Skill Card Femc Sub Menu Color")]
        public ConfigColor CampSkillCardFemc { get; set; } = new ConfigColor(0x21, 0x08, 0x12, 0xFF);

        [DisplayName("Camp: Femc Shadow Color")]
        public ConfigColor CampFemcShadow { get; set; } = UICommon.FemcShadowColor;

        [DisplayName("Camp: Highlighted selection color high")]
        public ConfigColor CampHighlightedColor { get; set; } = ConfigColor.Blue;

        [DisplayName("Camp: Highlighted selection color lower high")]
        public ConfigColor CampHighlightedLowerColor { get; set; } = new ConfigColor(0x00, 0x00, 0xEE, 0xFF);

        [DisplayName("Camp: Highlighted selection color middle (involves highlighted party member with lower high)")]
        public ConfigColor CampHighlightedMidColor { get; set; } = new ConfigColor(0x00, 0x00, 0x6A, 0xFF);

        [DisplayName("Camp: Social Link Arcana selection color")]
        public ConfigColor CampSocialLinkArcanaHighlightedColor { get; set; } = new ConfigColor(0x6d, 0x03, 0x0d, 0x7F);

        [DisplayName("Camp: System falling words starting color")]
        public ConfigColor CampSystemStartFallingWordsColor { get; set; } = new ConfigColor(0x2B, 0x00, 0x00, 0xFF);

        [DisplayName("Camp: System falling words end color")]
        public ConfigColor CampSystemEndFallingWordsColor { get; set; } = new ConfigColor(0xA3, 0x20, 0x26, 0xFF);

        [DisplayName("Camp Equip: Square Background")]
        public ConfigColor EquipSquareBack { get; set; } = ConfigColor.MellodiColorDark2;

        [DisplayName("Camp Equip: Menu title inside square color")]
        public ConfigColor EquipTitleBackground { get; set; } = ConfigColor.MellodiColorDark3;

        [DisplayName("Camp Equip: 'Effect' font color in equipment description")]
        public ConfigColor EquipEffectColor { get; set; } = ConfigColor.MellodiColorDark3;

        [DisplayName("Camp: In-game screenshot color filter curve keyframe 1")]
        public ConfigColor CampScreenshotFilterKeyframe1 { get; set; } = new ConfigColor(0x0C, 0x01, 0x05, 0xFF);

        [DisplayName("Camp: In-game screenshot color filter curve keyframe 2")]
        public ConfigColor CampScreenshotFilterKeyframe2 { get; set; } = new ConfigColor(0xCC, 0x19, 0x52, 0xFF);

        [DisplayName("Camp: In-game screenshot color filter curve keyframe 3")]
        public ConfigColor CampScreenshotFilterKeyframe3 { get; set; } = new ConfigColor(0xF2, 0x26, 0x67, 0xFF);

        [DisplayName("Camp: In-game screenshot color filter curve keyframe 4")]
        public ConfigColor CampScreenshotFilterKeyframe4 { get; set; } = new ConfigColor(0xFF, 0xFF, 0xFF, 0xFF);

        [DisplayName("Camp: Shards color curve keyframe 1")]
        public ConfigColor CampShardsKeyframe1 { get; set; } = new ConfigColor(0xFF, 0x4D, 0x70, 0x66);

        [DisplayName("Camp: Shards color curve keyframe 2")]
        public ConfigColor CampShardsKeyframe2 { get; set; } = new ConfigColor(0x64, 0x96, 0xFB, 0xD6);

        [DisplayName("Camp: Shards color curve keyframe 3")]
        public ConfigColor CampShardsKeyframe3 { get; set; } = new ConfigColor(0x7E, 0x80, 0xFB, 0xF5);

        [DisplayName("Camp: Shards color curve keyframe 4")]
        public ConfigColor CampShardsKeyframe4 { get; set; } = new ConfigColor(0xFF, 0x83, 0x8A, 0xFF);

        [DisplayName("Camp: Shards color curve keyframe 5")]
        public ConfigColor CampShardsKeyframe5 { get; set; } = new ConfigColor(0xFF, 0xC5, 0x85, 0xDF);

        [DisplayName("Camp: Shards color curve keyframe 6")]
        public ConfigColor CampShardsKeyframe6 { get; set; } = new ConfigColor(0xB8, 0x1C, 0x3B, 0xCB);

        [DisplayName("Camp: Shards color curve keyframe 7")]
        public ConfigColor CampShardsKeyframe7 { get; set; } = new ConfigColor(0xED, 0x5F, 0x9D, 0xA9);

        [DisplayName("Quest: Shadows Femc and Chairs Color")]
        public ConfigColor QuestFemcChairsShadow { get; set; } = new ConfigColor(0x58, 0x0F, 0x21, 0xFF);

        [DisplayName("Quest: Request/Missing Person Toggler Background Color")]
        public ConfigColor QuestToggler { get; set; } = new ConfigColor(0x2e, 0x09, 0x17, 0xFF);

        [DisplayName("Persona Status: Highlighted selection color")]
        public ConfigColor PersonaStatusHighlightedColor { get; set; } = new ConfigColor(0x29, 0x00, 0xEA, 0x99);

        [DisplayName("Persona Status: Skill Card Skill Background color")]
        public ConfigColor SkillCardSkillBg { get; set; } = new ConfigColor(0x66, 0x2b, 0x47, 0xFF);

        [DisplayName("Persona Status: Skill Card Selected Skill animation color")]
        public ConfigColor SkillCardSelectedSkillAnimation { get; set; } = new ConfigColor(0xD1, 0x62, 0x87, 0xFF);

        [DisplayName("Persona Status: Skill Description Main Background color")]
        public ConfigColor SkillDescriptionMainBg { get; set; } = new ConfigColor(0x57, 0x21, 0x3D, 0xFF);

        [DisplayName("Persona Status: Skill Description Corner and Title Background color")]
        public ConfigColor SkillDescriptionCornerBg { get; set; } = new ConfigColor(0x7D, 0x4D, 0x66, 0xFF);

        [DisplayName("Persona Status: --NONE-- skill color")]
        public ConfigColor NoneSkillColor { get; set; } = new ConfigColor(0x9F, 0x83, 0x8C, 0xFF);

        [DisplayName("Persona Status: Selected skill font color")]
        public ConfigColor SelectedSkillFontColor { get; set; } = ConfigColor.PersonaStatusSkillListBg;

        [DisplayName("Persona Status: Skill swap selected skill shadow font color")]
        public ConfigColor SwapSkillShadowSelectedFontColor { get; set; } = new ConfigColor(0xFE, 0x9B, 0xB8, 0xFF);

        [DisplayName("Persona Status: Skill swap unselected skill background color")]
        public ConfigColor SwapSkillUnselectedFontColor { get; set; } = new ConfigColor(0x9E, 0x3C, 0x5E, 0xFF);

        [DisplayName("Persona Status: Skill swap unselected skill background color")]
        public ConfigColor SwapSkillUnselectedBgColor { get; set; } = new ConfigColor(0xFD, 0x75, 0x9B, 0xFF);

        [DisplayName("Persona Status: Inheritable skill tick color")]
        public ConfigColor InheritableSkillTick { get; set; } = new ConfigColor(0xCC, 0x7C, 0x93, 0xFF);

        [DisplayName("Persona Status: Inheritable skill tick tag background color")]
        public ConfigColor InheritableSkillTickBg { get; set; } = new ConfigColor(0x71, 0x36, 0x4D, 0xFF);

        [DisplayName("Persona Status: Next skill left zero color")]
        public ConfigColor NextSkillZero { get; set; } = new ConfigColor(0x99, 0x53, 0x64, 0xFF);

        [DisplayName("Persona Status: Next skill outter outline question mark color")]
        public ConfigColor NextSkillOutterOutlineColor { get; set; } = new ConfigColor(0x59, 0x02, 0x23, 0xFF);

        [DisplayName("Persona Status: Next skill inner outline question mark color")]
        public ConfigColor NextSkillInnerOutlineColor { get; set; } = new ConfigColor(0xFD, 0x9B, 0xB7, 0xFF);

        [DisplayName("Persona Status: Persona shadow when selecting inheritance skills/high level persona")]
        public ConfigColor PersonaFusionShadow { get; set; } = new ConfigColor(0x30, 0x10, 0x27, 0xFF);

        [DisplayName("Persona Status: Social Link Bonus color when choosing inheritance skills")]
        public ConfigColor PersonaSocialLinkInheritance { get; set; } = new ConfigColor(0x6E, 0x03, 0x0A, 0xFF);

        [DisplayName("Persona Status: Mutation animation strip colors")]
        public ConfigColor MutationStripColor { get; set; } = new ConfigColor(0xC6, 0x00, 0x35, 0xFF);

        [DisplayName("Persona Status: Fusion level up new learned skill info animation background color")]
        public ConfigColor PersonaLvlUpSkillListNextSkillColor { get; set; } = new ConfigColor(0xFF, 0x7D, 0xA9, 0xFF);

        [DisplayName("Persona Status: Fusion top left corner numbers/result color")]
        public ConfigColor FusionTopRightIndicatorColors { get; set; } = ConfigColor.MellodiColorLight1;

        [DisplayName("Battle: Squares colors from battle result animation")]
        public ConfigColor BtlResultSquaresColor { get; set; } = new ConfigColor(0xD1, 0x00, 0x3F, 0xFF);

        [DisplayName("Party Panel Femc Background Color")]
        public ConfigColor PartyPanelFemcBgColor { get; set; } = new ConfigColor(0xFF, 0x89, 0xA6, 0xFF);

        [DisplayName("Request/Missing Person: Column titles color")]
        public ConfigColor DataColumnColor { get; set; } = new ConfigColor(0x92, 0x72, 0x7B, 0xFF);

        [DisplayName("Request: Selected Sort By Column Title")]
        public ConfigColor SelectedSortColumnTitle { get; set; } = new ConfigColor(0xFF, 0xD3, 0xFF, 0xFF);

        [DisplayName("Simple Shop: Highlighted Selection Color")]
        public ConfigColor SimpleShopHighlightedColor { get; set; } = new ConfigColor(0xED, 0x6D, 0x91, 0xFF);

        [DisplayName("Simple Shop: Blur filter color when choosing amount to buy")]
        public ConfigColor SimpleShopBlurFilterColor { get; set; } = new ConfigColor(0x68, 0x01, 0x08, 0xFF);

        [DisplayName("Simple Shop: Zero font color when selecting amount to buy")]
        public ConfigColor SimpleShopZeroFontColor { get; set; } = ConfigColor.Red;

        [DisplayName("Simple Shop: Shadow color in buy menu")]
        public ConfigColor SimpleShopBuyShadowColor { get; set; } = new ConfigColor(0xEB, 0x44, 0x7D, 0xFF);

        [DisplayName("Simple Shop: Buy menu selected option font color")]
        public ConfigColor SimpleShopBuyFontColor { get; set; } = new ConfigColor(0x5C, 0x00, 0x06, 0xFF);

        [DisplayName("Date Time Panel: Weekday triangle color")]
        public ConfigColor DateTimePanelWeekdayTriangleColor { get; set; } = new ConfigColor(0x24, 0x07, 0x09, 0xFF);

        [DisplayName("Item List: Highlighted selection color")]
        public ConfigColor ItemListHighlightedColor { get; set; } = new ConfigColor(0xFF, 0x75, 0x9C, 0xFF);

        [DisplayName("Minimap: Field minimap inner circle background color")]
        public ConfigColor MinimapFieldInnerCircle { get; set; } = new ConfigColor(0xEB, 0x00, 0x4E, 0xFF);

        [DisplayName("Minimap: Field minimap outter circle background color")]
        public ConfigColor MinimapFieldOutterCircle { get; set; } = new ConfigColor(0x2B, 0x10, 0x13, 0xFF);

        [DisplayName("Minimap: Minimap locations view higher strip background color")]
        public ConfigColor MinimapLocationsHighStrip { get; set; } = new ConfigColor(0x2B, 0x10, 0x13, 0xFF);

        [DisplayName("Minimap: Minimap locations view lower strip background color")]
        public ConfigColor MinimapLocationsLowerStrip { get; set; } = new ConfigColor(0xEB, 0x00, 0x4E, 0xFF);

        [DisplayName("Town Map: Selected Rounded Outline Color")]
        public ConfigColor PreviewRoundedOutline { get; set; } = new ConfigColor(0xFD, 0x9B, 0xB7, 0xFF);

        [DisplayName("Town Map: Preview Taint Color")]
        public ConfigColor PreviewTaintColor { get; set; } = new ConfigColor(0xBB, 0x96, 0xA0, 0xFF);

        [DisplayName("Town Map: Location Subtle Shadow")]
        public ConfigColor LocationSubtleShadowColor { get; set; } = new ConfigColor(0x53, 0x00, 0x04, 0xFF);

        [DisplayName("Town Map: Mini Location Centered Circle when changing selection")]
        public ConfigColor MiniLocationCircleColor { get; set; } = new ConfigColor(0xEB, 0x44, 0x7D, 0xFF);

        [DisplayName("SaveLoad: In-game screenshot color filter curve keyframe 1")]
        public ConfigColor SaveLoadScreenshotFilterKeyframe1 { get; set; } = new ConfigColor(0x99, 0x25, 0x6B, 0xFF);

        [DisplayName("SaveLoad: In-game screenshot color filter curve keyframe 2")]
        public ConfigColor SaveLoadScreenshotFilterKeyframe2 { get; set; } = new ConfigColor(0xCC, 0x19, 0x8D, 0xFF);

        [DisplayName("SaveLoad: In-game screenshot color filter curve keyframe 3")]
        public ConfigColor SaveLoadScreenshotFilterKeyframe3 { get; set; } = new ConfigColor(0xF2, 0x26, 0xA7, 0xFF);

        [DisplayName("Mail: Open animation color")]
        public ConfigColor MailStartAnimationColor { get; set; } = new ConfigColor(0xC2, 0x00, 0x44, 0xFF);

        [DisplayName("Battle Result: Left square color")]
        public ConfigColor BattleResultLeftSquare { get; set; } = new ConfigColor(0x6E, 0x03, 0x0E, 0xFF);

        [DisplayName("Battle Result: Left 0 font color in item count")]
        public ConfigColor BattleResultLeftZeroFontColor { get; set; } = new ConfigColor(0xEB, 0x44, 0x7D, 0xFF);

        [DisplayName("Battle Result: Font color in item count")]
        public ConfigColor BattleResultFontColor { get; set; } = new ConfigColor(0xFD, 0x9B, 0xB7, 0xFF);

        [DisplayName("Camp Configuration: Light reflective material 1")]
        public ConfigColor CampConfigurationLightReflectiveColor1 { get; set; } = new ConfigColor(0xFF, 0x2E, 0x70, 0xFF);

        [DisplayName("Camp Configuration: Light reflective material 2")]
        public ConfigColor CampConfigurationLightReflectiveColor2 { get; set; } = new ConfigColor(0xFF, 0x60, 0x92, 0xFF);

        [DisplayName("SaveLoad: Gradient bottom top color")]
        public ConfigColor SaveLoadGradientBottomTopColor { get; set; } = new ConfigColor(0xB2, 0x22, 0x50, 0x00);

        [DisplayName("SaveLoad: Gradient bottom color")]
        public ConfigColor SaveLoadGradientBottomColor { get; set; } = new ConfigColor(0xB2, 0x22, 0x50, 0x28);

        [DisplayName("SaveLoad: Gradient top color")]
        public ConfigColor SaveLoadGradientTopColor { get; set; } = new ConfigColor(0xFF, 0x00, 0x62, 0x32);

        [DisplayName("SaveLoad: Gradient top bottom color")]
        public ConfigColor SaveLoadGradientTopBottomColor { get; set; } = new ConfigColor(0xFF, 0x00, 0x6A, 0x00);

        [DisplayName("Persona Status: Velvet Room in-game screenshot deep color filter")]
        public ConfigColor PersonaStatusDeepColorFilter { get; set; } = new ConfigColor(0x88, 0x00, 0x17, 0xA9);

        [DisplayName("Persona Status: Velvet Room in-game screenshot medium strong color filter")]
        public ConfigColor PersonaStatusMediumStrongColorFilter { get; set; } = new ConfigColor(0xDE, 0x00, 0x46, 0x00);

        [DisplayName("Persona Status: Velvet Room in-game screenshot soft strong color filter")]
        public ConfigColor PersonaStatusSoftColorFilter { get; set; } = new ConfigColor(0x8B, 0x01, 0x51, 0x00);

        [DisplayName("Persona Status: Inheritance skill selection square color")]
        public ConfigColor PersonaStatusInheritanceSquareColor { get; set; } = new ConfigColor(0x6E, 0x03, 0x0A, 0x00);

        [DisplayName("Persona Status: Strip main color")]
        public ConfigColor PersonaStatusStripColor { get; set; } = new ConfigColor(0xCC, 0x00, 0x4E, 0xFF);

        [DisplayName("Persona Status: Waves over the strip")]
        public ConfigColor PersonaStatusWavesStripColor { get; set; } = new ConfigColor(0xE9, 0x00, 0x59, 0xFF);

        [DisplayName("Persona Status: Master Material unknown color 1")]
        public ConfigColor PersonaStatusMMUnk1 { get; set; } = new ConfigColor(0xAD, 0x00, 0x4F, 0xB2);

        [DisplayName("Persona Status: Master Material unknown color 2")]
        public ConfigColor PersonaStatusMMUnk2 { get; set; } = new ConfigColor(0xFD, 0x00, 0xA6, 0x00);

        [DisplayName("Persona Status: Master Material unknown color 3")]
        public ConfigColor PersonaStatusMMUnk3 { get; set; } = new ConfigColor(0xAC, 0x00, 0x51, 0xFF);

        [DisplayName("Persona Status: Master Material unknown color 4")]
        public ConfigColor PersonaStatusMMUnk4 { get; set; } = new ConfigColor(0xFF, 0x00, 0x55, 0xFF);

        [DisplayName("Quest: Elizabeth Quest Menu top gradient")]
        public ConfigColor QuestElizabethTopGradient1 { get; set; } = new ConfigColor(0xAD, 0x00, 0x5B, 0xCC);

        [DisplayName("Quest: Elizabeth Quest Menu bottom gradient")]
        public ConfigColor QuestElizabethBottomGradient { get; set; } = new ConfigColor(0xAD, 0x00, 0x5E, 0x00);

        [DisplayName("Quest: Elizabeth Quest Menu additional top gradient")]
        public ConfigColor QuestElizabethTopGradient2 { get; set; } = new ConfigColor(0xC3, 0x04, 0x5D, 0x00);

        [DisplayName("Persona Status: In-game screenshot color filter curve keyframe 1")]
        public ConfigColor PersonaStatusScreenshotFilterKeyframe1 { get; set; } = new ConfigColor(0xB3, 0x00, 0x4B, 0xFF);

        [DisplayName("Persona Status: In-game screenshot color filter curve keyframe 2")]
        public ConfigColor PersonaStatusScreenshotFilterKeyframe2 { get; set; } = new ConfigColor(0xCC, 0x19, 0x73, 0xFF);

        [DisplayName("Persona Status: In-game screenshot color filter curve keyframe 3")]
        public ConfigColor PersonaStatusScreenshotFilterKeyframe3 { get; set; } = new ConfigColor(0xD9, 0x99, 0xB0, 0xFF);

        [DisplayName("Persona Status: In-game screenshot color filter curve keyframe 4")]
        public ConfigColor PersonaStatusScreenshotFilterKeyframe4 { get; set; } = new ConfigColor(0xE5, 0xCC, 0xD6, 0xFF);

        [DisplayName("Camp: Dormitory Calendar in-game screenshot color filter curve keyframe 1")]
        public ConfigColor CampCalendarScreenshotFilterKeyframe1 { get; set; } = new ConfigColor(0xCC, 0x40, 0x6A, 0xFF);

        [DisplayName("Camp: Dormitory Calendar in-game screenshot color filter curve keyframe 2")]
        public ConfigColor CampCalendarScreenshotFilterKeyframe2 { get; set; } = new ConfigColor(0xE6, 0x66, 0x8A, 0xFF);

        [DisplayName("Camp: Dormitory Calendar in-game screenshot color filter curve keyframe 3")]
        public ConfigColor CampCalendarScreenshotFilterKeyframe3 { get; set; } = new ConfigColor(0xEF, 0x0E, 0x64, 0xFF);

        [DisplayName("Camp: Dormitory Calendar in-game screenshot color filter curve keyframe 4")]
        public ConfigColor CampCalendarScreenshotFilterKeyframe4 { get; set; } = new ConfigColor(0xED, 0x57, 0xAC, 0xFF);

        [DisplayName("Camp: Configuration main menu in-game screenshot color filter curve keyframe 1")]
        public ConfigColor CampMainMenuConfigScreenshotFilterKeyframe1 { get; set; } = new ConfigColor(0x4D, 0x00, 0x26, 0xFF);

        [DisplayName("Camp: Configuration main menu in-game screenshot color filter curve keyframe 2")]
        public ConfigColor CampMainMenuConfigScreenshotFilterKeyframe2 { get; set; } = new ConfigColor(0x66, 0x00, 0x36, 0xFF);

        [DisplayName("Camp: Configuration main menu in-game screenshot color filter curve keyframe 3")]
        public ConfigColor CampMainMenuConfigScreenshotFilterKeyframe3 { get; set; } = new ConfigColor(0x99, 0x00, 0x47, 0xFF);

        [DisplayName("Camp: Configuration main menu in-game screenshot color filter curve keyframe 4")]
        public ConfigColor CampMainMenuConfigScreenshotFilterKeyframe4 { get; set; } = new ConfigColor(0xCA, 0x73, 0xA0, 0xFF);

        /*[DisplayName("Draw Original Select Box")]
        [Category("Debug")]
        [Display(Order = 1)]
        [DefaultValue(true)]
        public bool DebugDrawOgSelBox { get; set; } = true;
        */
        /*
        [DisplayName("Draw Original Missing Person")]
        [Category("Debug")]
        [Display(Order = 2)]
        [DefaultValue(true)]
        public bool DebugDrawMissingPerson { get; set; } = true;
        */
    }


    /// <summary>
    /// Allows you to override certain aspects of the configuration creation process (e.g. create multiple configurations).
    /// Override elements in <see cref="ConfiguratorMixinBase"/> for finer control.
    /// </summary>
    public class ConfiguratorMixin : ConfiguratorMixinBase
    {

        
    }
}
