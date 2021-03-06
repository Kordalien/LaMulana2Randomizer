﻿using System.Collections.Generic;
using LaMulana2RandomizerShared;

namespace LM2RandomiserMod
{
    public abstract class ItemDB
    {
        public static ItemInfo GetItemInfo(ItemID id)
        {
            itemData.TryGetValue(id, out ItemInfo result);
            return result;
        }
        
        private static readonly Dictionary<ItemID, ItemInfo> itemData = new Dictionary<ItemID, ItemInfo>
        {
            {ItemID.HandScanner,                new ItemInfo("H Scanner",        "H Scanner",         "item",        0,       10,    1)},
            {ItemID.DjedPillar,                 new ItemInfo("Djed Pillar",      "Djed Pillar",       "item",        1,       100,    1)},
            {ItemID.Mjolnir,                    new ItemInfo("Mjolnir",          "Mjolnir",           "item",        2,       100,    1)},
            {ItemID.Beherit,                    new ItemInfo("Beherit",          "Beherit",           "item",        3,       80,    1)},
            {ItemID.AncientBattery,             new ItemInfo("Battery",          "Battery",           "item",        4,       100,    1)},
            {ItemID.LampofTime,                 new ItemInfo("Lamp",             "Lamp",              "item",        5,       100,    1)},
            {ItemID.PochetteKey,                new ItemInfo("P Key",            "P Key",             "item",        6,       100,    1)},
            {ItemID.PyramidCrystal,             new ItemInfo("Crystal P",        "Crystal P",         "item",        7,       100,    1)},
            {ItemID.CrystalSkull,               new ItemInfo("Crystal S",        "Crystal S",         "item",        8,       50,    1)},
            {ItemID.Vessel,                     new ItemInfo("Vessel",           "Vessel",            "item",        9,       100,    1)},
            {ItemID.Pepper,                     new ItemInfo("Pepper",           "Pepper",            "item",        10,      50,    1)},
            {ItemID.EggofCreation,              new ItemInfo("Egg",              "Egg",               "item",        11,      100,    1)},
            {ItemID.GiantsFlute,                new ItemInfo("G Pipe",           "G Pipe",            "item",        12,      100,    1)},
            {ItemID.CogofAntiquity,             new ItemInfo("Gear",             "Gear",              "item",        13,      100,    1)},
            {ItemID.MulanaTalisman,             new ItemInfo("M Talisman",       "M Talisman",        "item",        14,      80,    1)},
                                                                                                                         
            {ItemID.MobileSuperx3P,             new ItemInfo("MSX3p",            "MSX",               "item",        15,      150,   2)},
            {ItemID.ShellHorn,                  new ItemInfo("Shell Horn",       "Shell Horn",        "item",        16,      80,    1)},
            {ItemID.HolyGrail,                  new ItemInfo("Holy Grail",       "Holy Grail",        "item",        17,      10,    1)},
            {ItemID.FairyPass,                  new ItemInfo("F Pass",           "F Pass",            "item",        18,      100,    1)},
            {ItemID.Gloves,                     new ItemInfo("Glove",            "Glove",             "item",        19,      80,    1)},
            {ItemID.DinosaurFigure,             new ItemInfo("D Figure",         "D Figure",          "item",        20,      80,    1)},
            {ItemID.GaleFibula,                 new ItemInfo("G Band",           "G Band",            "item",        21,      80,    1)},
            {ItemID.FlameTorc,                  new ItemInfo("F Torque",         "F Torque",          "item",        22,      100,    1)},
            {ItemID.Vajra,                      new ItemInfo("Vajra",            "Vajra",             "item",        23,      80,   1)},
            {ItemID.PowerBand,                  new ItemInfo("Power Band",       "Power Band",        "item",        24,      100,    1)},
            {ItemID.BronzeMirror,               new ItemInfo("B Mirror",         "B Mirror",          "item",        25,      80,    1)},
            {ItemID.Perfume,                    new ItemInfo("Perfume",          "Perfume",           "item",        26,      100,   1)},
            {ItemID.IceCloak,                   new ItemInfo("Ice Cape",         "Ice Cape",          "item",        27,      80,    1)},
            {ItemID.NemeanFur,                  new ItemInfo("Fur",              "Fur",               "item",        28,      120,   1)},
            {ItemID.Gauntlet,                   new ItemInfo("Gauntlet",         "Gauntlet",          "item",        29,      80,    1)},
            {ItemID.Anchor,                     new ItemInfo("Anchor",           "Anchor",            "item",        30,      80,    1)},
            {ItemID.FreyasPendant,              new ItemInfo("F Pendant",        "F Pendant",         "item",        31,      50,    1)},
            {ItemID.TotemPole,                  new ItemInfo("T Pole",           "T Pole",            "item",        32,      100,   1)},
            {ItemID.GrappleClaw,                new ItemInfo("G Claw",           "G Claw",            "item",        33,      80,    1)},
            {ItemID.Spaulder,                   new ItemInfo("Spaulder",         "Spaulder",          "item",        34,      100,    1)},
            {ItemID.Scalesphere,                new ItemInfo("Scalesphere",      "Scalesphere",       "item",        35,      80,    1)},
            {ItemID.Crucifix,                   new ItemInfo("Crucifix",         "Crucifix",          "item",        36,      100,   1)},
            {ItemID.GaneshaTalisman,            new ItemInfo("Gold Bangle",      "Gold Bangle",       "item",        37,      100,    1)},
            {ItemID.MaatsFeather,               new ItemInfo("M Feather",        "M Feather",         "item",        38,      80,    1)},
            {ItemID.Ring,                       new ItemInfo("Ring",             "Ring",              "item",        39,      100,   1)},
            {ItemID.Bracelet,                   new ItemInfo("Bracelet",         "Bracelet",          "item",        40,      100,   1)},
            {ItemID.Feather,                    new ItemInfo("Feather",          "Feather",           "item",        41,      80,    1)},
            {ItemID.Scriptures,                 new ItemInfo("Scriptures",       "Scriptures",        "item",        42,      100,   1)},
            {ItemID.FreysShip,                  new ItemInfo("F Ship",           "F Ship",            "item",        43,      100,    1)},
            {ItemID.Codices,                    new ItemInfo("Pandora Box",      "Pandora Box",       "item",        44,      50,    1)},
            {ItemID.SnowShoes,                  new ItemInfo("Snow Shoes",       "Snow Shoes",        "item",        45,      50,    1)},
            {ItemID.Harp,                       new ItemInfo("Harp",             "Harp",              "item",        46,      10,    1)},
            {ItemID.BookoftheDead,              new ItemInfo("Book",             "Book",              "item",        47,      100,   1)},
            {ItemID.LightScythe,                new ItemInfo("L Scythe",         "L Scythe",          "item",        48,      80,    1)},
            {ItemID.DestinyTablet,              new ItemInfo("Destiny Tablet",   "Destiny Tablet",    "item",        49,      100,   1)},
            {ItemID.SecretTreasureofLife,       new ItemInfo("Secret Treasure",  "Secret Treasure",   "item",        50,      150,   1)},
                                                                                                                         
            {ItemID.OriginSigil,                new ItemInfo("Origin Seal",      "Origin Seal",       "item",        51,      50,    1)},
            {ItemID.BirthSigil,                 new ItemInfo("Birth Seal",       "Birth Seal",        "item",        52,      75,    1)},
            {ItemID.LifeSigil,                  new ItemInfo("Life Seal",        "Life Seal",         "item",        53,      100,    1)},
            {ItemID.DeathSigil,                 new ItemInfo("Death Seal",       "Death Seal",        "item",        54,      125,   1)},
                                                                                                                        
            {ItemID.ClaydollSuit,               new ItemInfo("Clay Doll",        "Clay Doll",         "fashion",     56,      100,   1)},
            {ItemID.KimonoCowgirl,              new ItemInfo("Kimono Cowgirl",   "Kimono Cowgirl",    "fashion",     57,      0,     1)},
            {ItemID.Valkyria,                   new ItemInfo("Valkyria",         "Valkyria",          "fashion",     58,      0,     1)},
            {ItemID.LittleDevil,                new ItemInfo("Little Devil",     "Little Devil",      "fashion",     59,      0,     1)},
            {ItemID.EasternEurope,              new ItemInfo("Eastern Europe",   "Eastern Europe",    "fashion",     60,      0,     1)},
                                                                                                                         
            {ItemID.Whip,                       new ItemInfo("Whip",             "Whip",              "weapon",      62,      50,    1)},
            {ItemID.ChainWhip,                  new ItemInfo("Whip2",            "Whip2",             "weapon",      62,      100,    1)},
            {ItemID.FlailWhip,                  new ItemInfo("Whip3",            "Whip3",             "weapon",      62,      200,   1)},
                                                                                                                         
            {ItemID.Knife,                      new ItemInfo("Knife",            "Knife",             "weapon",      63,      40,    1)},
            {ItemID.Rapier,                     new ItemInfo("Rapier",           "Rapier",            "weapon",      64,      80,    1)},
            {ItemID.Axe,                        new ItemInfo("Axe",              "Axe",               "weapon",      65,      100,   1)},
            {ItemID.Katana,                     new ItemInfo("Katana",           "Katana",            "weapon",      66,      100,   1)},
            {ItemID.Shuriken,                   new ItemInfo("Shuriken",         "Shuriken",          "weapon",      67,      30,    1)},
            {ItemID.RollingShuriken,            new ItemInfo("R-Shuriken",       "R-Shuriken",        "weapon",      68,      30,    1)},
            {ItemID.EarthSpear,                 new ItemInfo("E-Spear",          "E-Spear",           "weapon",      69,      40,    1)},
            {ItemID.Flare,                      new ItemInfo("Flare Gun",        "Flare Gun",         "weapon",      70,      40,    1)},
            {ItemID.Bomb,                       new ItemInfo("Bomb",             "Bomb",              "weapon",      71,      50,    1)},
            {ItemID.Chakram,                    new ItemInfo("Chakram",          "Chakram",           "weapon",      72,      50,    1)},
            {ItemID.Caltrops,                   new ItemInfo("Caltrops",         "Caltrops",          "weapon",      73,      30,    1)},
            {ItemID.Pistol,                     new ItemInfo("Pistol",           "Pistol",            "weapon",      74,      200,   1)},
                                                                                                                         
            {ItemID.Buckler,                    new ItemInfo("Shield",           "Shield",            "weapon",      75,      10,    1)},
            {ItemID.SilverShield,               new ItemInfo("Shield2",          "Shield2",           "weapon",      75,      100,    1)},
            {ItemID.AngelShield,                new ItemInfo("Shield3",          "Shield3",           "weapon",      75,      200,   1)},
                                                                                                                         
            {ItemID.AnkhJewel,                  new ItemInfo("Ankh Jewel",       "Ankh Jewel",        "weapon",      76,      50,    1)},
                                                                                                                         
            {ItemID.Xelputter,                  new ItemInfo("Xelputter",        "Xelputter",         "soft",        77,      150,   1)},
            {ItemID.YagooMapReader,             new ItemInfo("G Map",            "G Map",             "soft",        78,      150,   1)},
            {ItemID.YagooMapStreet,             new ItemInfo("G Street",         "G Street",          "soft",        79,      150,   1)},
            {ItemID.TextTrax,                   new ItemInfo("TextTrax",         "TextTrax",          "soft",        80,      150,   1)},
            {ItemID.RuinsEncylopedia,           new ItemInfo("R Book",           "R Book",            "soft",        81,      150,   1)},
            {ItemID.Mantra,                     new ItemInfo("Mantra",           "Mantra",            "soft",        82,      75,    1)},
            {ItemID.Guild,                      new ItemInfo("Guild",            "Guild",             "soft",        83,      150,   1)},
            {ItemID.Research,                   new ItemInfo("Research",         "Research",          "soft",        84,      150,   1)},
            {ItemID.EngaMusica,                 new ItemInfo("Enga Musica",      "Enga Musica",       "soft",        85,      100,    1)},
            {ItemID.BeoEglana,                  new ItemInfo("Beo Eg-Lana",      "Beo Eg-Lana",       "soft",        86,      150,   1)},
            {ItemID.Alert,                      new ItemInfo("Alarm",            "Alarm",             "soft",        87,      150,   1)},
            {ItemID.Snapshot,                   new ItemInfo("Snapshots",        "Snapshots",         "soft",        88,      75,    1)},
            {ItemID.SkullReader,                new ItemInfo("Skull",            "Skull",             "soft",        89,      150,   1)},
            {ItemID.RaceScanner,                new ItemInfo("Race Reader",      "Race Reader",       "soft",        90,      150,   1)},
            {ItemID.DeathVillage,               new ItemInfo("Death Village",    "Death Village",     "soft",        91,      150,   1)},
            {ItemID.RoseandCamelia,             new ItemInfo("R and C",          "R and C",           "soft",        92,      150,   1)},
            {ItemID.SpaceCapstarII,             new ItemInfo("Capstar II",       "Capstar II",        "soft",        93,      150,   1)},
            {ItemID.LonelyHouseMoving,          new ItemInfo("L House Moving",   "L House Moving",    "soft",        94,      150,    1)},
            {ItemID.MekuriMaster,               new ItemInfo("Mekuri Master",    "Mekuri Master",     "soft",        95,      150,   1)},
            {ItemID.BounceShot,                 new ItemInfo("Bounce Shot",      "Bounce Shot",       "soft",        96,      150,   1)},
            {ItemID.MiracleWitch,               new ItemInfo("Miracle Witch",    "Miracle Witch",     "soft",        97,      150,   1)},
            {ItemID.FutureDevelopmentCompany,   new ItemInfo("Future DC",        "Future DC",         "soft",        98,      40,    1)},
            {ItemID.LaMulana,                   new ItemInfo("La-Mulana",        "La-Mulana",         "soft",        99,      150,   1)},
            {ItemID.LaMulana2,                  new ItemInfo("La-Mulana2",       "La-Mulana2",        "soft",        100,     150,   1)},
                                                                                                                         
            {ItemID.SacredOrb0,                 new ItemInfo("Sacred Orb",       "Sacred Orb0",       "item",        101,     75,    1)},
            {ItemID.SacredOrb1,                 new ItemInfo("Sacred Orb",       "Sacred Orb1",       "item",        102,     75,    1)},
            {ItemID.SacredOrb2,                 new ItemInfo("Sacred Orb",       "Sacred Orb2",       "item",        103,     75,    1)},
            {ItemID.SacredOrb3,                 new ItemInfo("Sacred Orb",       "Sacred Orb3",       "item",        104,     100,    1)},
            {ItemID.SacredOrb4,                 new ItemInfo("Sacred Orb",       "Sacred Orb4",       "item",        105,     100,    1)},
            {ItemID.SacredOrb5,                 new ItemInfo("Sacred Orb",       "Sacred Orb5",       "item",        106,     100,    1)},
            {ItemID.SacredOrb6,                 new ItemInfo("Sacred Orb",       "Sacred Orb6",       "item",        107,     100,    1)},
            {ItemID.SacredOrb7,                 new ItemInfo("Sacred Orb",       "Sacred Orb7",       "item",        108,     125,    1)},
            {ItemID.SacredOrb8,                 new ItemInfo("Sacred Orb",       "Sacred Orb8",       "item",        109,     125,    1)},
            {ItemID.SacredOrb9,                 new ItemInfo("Sacred Orb",       "Sacred Orb9",       "item",        110,     125,    1)},
                                                                                                                         
            {ItemID.Map1,                       new ItemInfo("Map",              "Map1",              "item",        111,     40,    1)},
            {ItemID.Map2,                       new ItemInfo("Map",              "Map2",              "item",        112,     40,    1)},
            {ItemID.Map3,                       new ItemInfo("Map",              "Map3",              "item",        113,     40,    1)},
            {ItemID.Map4,                       new ItemInfo("Map",              "Map4",              "item",        114,     40,    1)},
            {ItemID.Map5,                       new ItemInfo("Map",              "Map5",              "item",        115,     50,    1)},
            {ItemID.Map6,                       new ItemInfo("Map",              "Map6",              "item",        116,     50,    1)},
            {ItemID.Map7,                       new ItemInfo("Map",              "Map7",              "item",        117,     50,    1)},
            {ItemID.Map8,                       new ItemInfo("Map",              "Map8",              "item",        118,     50,    1)},
            {ItemID.Map9,                       new ItemInfo("Map",              "Map9",              "item",        119,     60,    1)},
            {ItemID.Map10,                      new ItemInfo("Map",              "Map10",             "item",        120,     60,    1)},
            {ItemID.Map11,                      new ItemInfo("Map",              "Map11",             "item",        121,     60,    1)},
            {ItemID.Map12,                      new ItemInfo("Map",              "Map12",             "item",        122,     60,    1)},
            {ItemID.Map13,                      new ItemInfo("Map",              "Map13",             "item",        123,     70,    1)},
            {ItemID.Map14,                      new ItemInfo("Map",              "Map14",             "item",        124,     70,    1)},
            {ItemID.Map15,                      new ItemInfo("Map",              "Map15",             "item",        125,     70,    1)},
            {ItemID.Map16,                      new ItemInfo("Map",              "Map16",             "item",        126,     70,    1)},
            {ItemID.Map17,                      new ItemInfo("Map",              "Map17",             "item",        127,     80,    1)},
            {ItemID.Map18,                      new ItemInfo("Map",              "Map18",             "item",        128,     80,    1)},
            {ItemID.Map19,                      new ItemInfo("Map",              "Map19",             "item",        129,     80,    1)},
            {ItemID.Map20,                      new ItemInfo("Map",              "Map20",             "item",        130,     80,    1)},
                                                                                                                         
            {ItemID.AnkhJewel1,                 new ItemInfo("Ankh Jewel",       "Ankh Jewel1",       "weapon",      131,     50,    1)},
            {ItemID.AnkhJewel2,                 new ItemInfo("Ankh Jewel",       "Ankh Jewel2",       "weapon",      132,     50,    1)},
            {ItemID.AnkhJewel3,                 new ItemInfo("Ankh Jewel",       "Ankh Jewel3",       "weapon",      133,     50,    1)},
            {ItemID.AnkhJewel4,                 new ItemInfo("Ankh Jewel",       "Ankh Jewel4",       "weapon",      134,     75,    1)},
            {ItemID.AnkhJewel5,                 new ItemInfo("Ankh Jewel",       "Ankh Jewel5",       "weapon",      135,     75,    1)},
            {ItemID.AnkhJewel6,                 new ItemInfo("Ankh Jewel",       "Ankh Jewel6",       "weapon",      136,     75,    1)},
            {ItemID.AnkhJewel7,                 new ItemInfo("Ankh Jewel",       "Ankh Jewel7",       "weapon",      137,     100,    1)},
            {ItemID.AnkhJewel8,                 new ItemInfo("Ankh Jewel",       "Ankh Jewel8",       "weapon",      138,     100,    1)},
            {ItemID.AnkhJewel9,                 new ItemInfo("Ankh Jewel",       "Ankh Jewel9",       "weapon",      139,     100,    1)},
                                                                                                                         
            {ItemID.CrystalSkull1,              new ItemInfo("Crystal S",        "Crystal S1",        "item",        140,     100,   1)},
            {ItemID.CrystalSkull2,              new ItemInfo("Crystal S",        "Crystal S2",        "item",        141,     100,   1)},
            {ItemID.CrystalSkull3,              new ItemInfo("Crystal S",        "Crystal S3",        "item",        142,     100,   1)},
            {ItemID.CrystalSkull4,              new ItemInfo("Crystal S",        "Crystal S4",        "item",        143,     100,   1)},
            {ItemID.CrystalSkull5,              new ItemInfo("Crystal S",        "Crystal S5",        "item",        144,     100,   1)},
            {ItemID.CrystalSkull6,              new ItemInfo("Crystal S",        "Crystal S6",        "item",        145,     100,   1)},
            {ItemID.CrystalSkull7,              new ItemInfo("Crystal S",        "Crystal S7",        "item",        146,     100,   1)},
            {ItemID.CrystalSkull8,              new ItemInfo("Crystal S",        "Crystal S8",        "item",        147,     100,   1)},
            {ItemID.CrystalSkull9,              new ItemInfo("Crystal S",        "Crystal S9",        "item",        148,     100,   1)},
            {ItemID.CrystalSkull10,             new ItemInfo("Crystal S",        "Crystal S10",       "item",        149,     100,   1)},
            {ItemID.CrystalSkull11,             new ItemInfo("Crystal S",        "Crystal S11",       "item",        150,     100,   1)},
            {ItemID.CrystalSkull12,             new ItemInfo("Crystal S",        "Crystal S12",       "item",        151,     100,   1)},

            {ItemID.Heaven,                     new ItemInfo("Mantra1",          "Mantra1",           "menu",        152,     75,    1)},
            {ItemID.Earth,                      new ItemInfo("Mantra2",          "Mantra2",           "menu",        153,     75,    1)},
            {ItemID.Sun,                        new ItemInfo("Mantra3",          "Mantra3",           "menu",        154,     75,    1)},
            {ItemID.Moon,                       new ItemInfo("Mantra4",          "Mantra4",           "menu",        155,     75,    1)},
            {ItemID.Sea,                        new ItemInfo("Mantra5",          "Mantra5",           "menu",        156,     75,    1)},
            {ItemID.Fire,                       new ItemInfo("Mantra6",          "Mantra6",           "menu",        157,     75,    1)},
            {ItemID.Wind,                       new ItemInfo("Mantra7",          "Mantra7",           "menu",        158,     75,    1)},
            {ItemID.Mother,                     new ItemInfo("Mantra8",          "Mantra8",           "menu",        159,     75,    1)},
            {ItemID.Child,                      new ItemInfo("Mantra9",          "Mantra9",           "menu",        160,     75,    1)},
            {ItemID.Night,                      new ItemInfo("Mantra10",         "Mantra10",          "menu",        161,     75,    1)},
        
            {ItemID.ShurikenAmmo,               new ItemInfo("Shuriken-b",       "Shuriken-b",        "weapon",      -1,      10,    10)},
            {ItemID.RollingShurikenAmmo,        new ItemInfo("R-Shuriken-b",     "R-Shuriken-b",      "weapon",      -1,      10,    10)},
            {ItemID.EarthSpearAmmo,             new ItemInfo("E-Spear-b",        "E-Spear-b",         "weapon",      -1,      15,    10)},
            {ItemID.FlareAmmo,                  new ItemInfo("Flare Gun-b",      "Flare Gun-b",       "weapon",      -1,      15,    10)},
            {ItemID.BombAmmo,                   new ItemInfo("Bomb-b",           "Bomb-b",            "weapon",      -1,      30,    5)},
            {ItemID.ChakramAmmo,                new ItemInfo("Chakram-b",        "Chakram-b",         "weapon",      -1,      20,    1)},
            {ItemID.CaltropsAmmo,               new ItemInfo("Caltrops-b",       "Caltrops-b",        "weapon",      -1,      10,    10)},
            {ItemID.PistolAmmo,                 new ItemInfo("Pistol-b",         "Pistol-b",          "weapon",      -1,      400,   1)},
            {ItemID.Weights,                    new ItemInfo("Weight",           "Weight",            "item",        -1,      10,    5)}
        };                                                                                                               

    }

    public class ItemInfo
    {
        public string boxName;
        public string shopName;
        public string shopType;
        public int itemFlag;
        public int shopPrice;
        public int shopAmount;
        
        public ItemInfo(string boxName, string shopName, string type, int itemFlag, int price, int amount)
        {
            this.boxName = boxName;
            this.shopName = shopName;
            this.shopType = type;
            this.itemFlag = itemFlag;
            this.shopPrice = price;
            this.shopAmount = amount;
        }
    }
}
