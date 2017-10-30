using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WvsAppLib.Helpers
{
    public enum Region
    {
        Korea = 1,
        Japan,
        Global = 8,
        SEA,
        Taiwan,
        China,
        Thailand
    }

    public enum Jobs
    {
        Beginner = 0,

        Warrior = 100,
        Fighter = 110,
        Crusader = 111,
        Hero = 112,
        Page = 120,
        WhiteKnight = 121,
        Paladin = 122,
        Spearman = 130,
        DragonKnight = 131,
        DarkKnight = 132,

        Magician = 200,
        FpWizard = 210,
        FpMage = 211,
        FpArchmage = 212,
        IlWizard = 220,
        IlMage = 221,
        IlArchmage = 222,
        Cleric = 230,
        Priest = 231,
        Bishop = 232,

        Bowman = 300,
        Hunter = 310,
        Ranger = 311,
        Bowmaster = 312,
        Crossbowman = 320,
        Sniper = 321,
        Marksman = 322,

        Thief = 400,
        Assassin = 410,
        Hermit = 411,
        Nightlord = 412,
        Bandit = 420,
        Chiefbandit = 421,
        Shadower = 422,
        BladeRecruit = 430,
        BladeAcolyte = 431,
        BladeSpecialist = 432,
        BladeLord = 433,
        BladeMaster = 434,

        Pirate = 500,
        PirateCannonShooter = 501,
        Jett1 = 508,
        Brawler = 510,
        Marauder = 511,
        Buccaneer = 512,
        Gunslinger = 520,
        Outlaw = 521,
        Corsair = 522,
        Cannoneer = 530,
        CannonBlaster = 531,
        CannonMaster = 532,
        Jett2 = 570,
        Jett3 = 571,
        Jett4 = 572,

        Manager = 800,
        GM = 900,
        SuperGM = 910,

        Noblesse = 1000,
        DawnWarrior1 = 1100,
        DawnWarrior2 = 1110,
        DawnWarrior3 = 1111,
        DawnWarrior4 = 1112,
        BlazeWizard1 = 1200,
        BlazeWizard2 = 1210,
        BlazeWizard3 = 1211,
        BlazeWizard4 = 1212,
        WindArcher1 = 1300,
        WindArcher2 = 1310,
        WindArcher3 = 1311,
        WindArcher4 = 1312,
        NightWalker1 = 1400,
        NightWalker2 = 1410,
        NightWalker3 = 1411,
        NightWalker4 = 1412,
        ThunderBreaker1 = 1500,
        ThunderBreaker2 = 1510,
        ThunderBreaker3 = 1511,
        ThunderBreaker4 = 1512,

        Legend = 2000,
        EvanNoob = 2001,
        Aran1 = 2100,
        Aran2 = 2110,
        Aran3 = 2111,
        Aran4 = 2112,
        Evan1 = 2200,
        Evan2 = 2210,
        Evan3 = 2211,
        Evan4 = 2212,
        Evan5 = 2213,
        Evan6 = 2214,
        Evan7 = 2215,
        Evan8 = 2216,
        Evan9 = 2217,
        Evan10 = 2218,
        Mercedes = 2002,
        Mercedes1 = 2300,
        Mercedes2 = 2310,
        Mercedes3 = 2311,
        Mercedes4 = 2312,
        Phantom = 2003,
        Phantom1 = 2400,
        Phantom2 = 2410,
        Phantom3 = 2411,
        Phantom4 = 2412,
        Luminous = 2004,
        Luminous1 = 2700,
        Luminous2 = 2710,
        Luminous3 = 2711,
        Luminous4 = 2712,

        Citizen = 3000,
        DemonSlayer = 3001,
        Xenon = 3002,
        DemonSlayer1 = 3100,
        DemonSlayer2 = 3110,
        DemonSlayer3 = 3111,
        DemonSlayer4 = 3112,
        DemonAvenger1 = 3101,
        DemonAvenger2 = 3120,
        DemonAvenger3 = 3121,
        DemonAvenger4 = 3122,
        BattleMage1 = 3200,
        BattleMage2 = 3210,
        BattleMage3 = 3211,
        BattleMage4 = 3212,
        WildHunter1 = 3300,
        WildHunter2 = 3310,
        WildHunter3 = 3311,
        WildHunter4 = 3312,
        Mechanic1 = 3500,
        Mechanic2 = 3510,
        Mechanic3 = 3511,
        Mechanic4 = 3512,
        Xenon1 = 3600,
        Xenon2 = 3610,
        Xenon3 = 3611,
        Xenon4 = 3612,

        Hayato = 4001,
        Kanna = 4002,
        Hayato1 = 4100,
        Hayato2 = 4110,
        Hayato3 = 4111,
        Hayato4 = 4112,
        Kanna1 = 4200,
        Kanna2 = 4210,
        Kanna3 = 4211,
        Kanna4 = 4212,

        NamelessWarden = 5000,
        Mihile1 = 5100,
        Mihile2 = 5110,
        Mihile3 = 5111,
        Mihile4 = 5112,

        Kaiser = 6000,
        AngelicBuster = 6001,
        Kaiser1 = 6100,
        Kaiser2 = 6110,
        Kaiser3 = 6111,
        Kaiser4 = 6112,
        AngelicBuster1 = 6500,
        AngelicBuster2 = 6510,
        AngelicBuster3 = 6511,
        AngelicBuster4 = 6512,

        AdditionalSkills = 9000,

        Zero = 10000,
        Zero1 = 10100,
        Zero2 = 10110,
        Zero3 = 10111,
        Zero4 = 10112


    }

    public enum InPacketHeader
    {
        HandshakeRequest = 0x00,
        LoginRequest = 0x20
    }

    public enum OutPacketHeader
    {
    }

    public enum Worlds
    {
        Scania = 0,
        Bera = 1,
        Broa = 2,
        Windia,
        Khaini = 4,
        Bellocan = 5,
        Mardia = 6,
        Kradia = 7,
        Yellonde = 8,
        Demethos = 9,
        Galicia = 10,
        ElNido = 11,
        Zenith = 12,
        Arcania = 13,
        Chaos = 14,
        Nova = 15,
        Renegades = 16,
        Enosis = 29,
        Luna = 30,
        Elysium = 31,
        Red = 43,
        Aurora = 44,
        Reboot = 45,
        Reboot2 = 46,
        Arcane = 50,
        Tespia = 100

    }

    public static class Definitions
    {

        static void Dump()
        {
            Type headers = typeof(InPacketHeader);

            foreach (var e in Enum.GetNames(headers))
            {
                foreach (var f in Enum.GetValues(headers))
                {
                    System.Console.WriteLine("{0} - {1}", e, f);
                }
            }
        }
    }
}
