using System;

namespace Fluid.Core
{
    /// <summary>
    /// all minecraft item-ids
    /// </summary>
    public enum Itemtype : uint
    {
        //all block ids are here too
        Air = 0,
        Stone = 1,
        Grass = 2,
        Dirt = 3,
        Cobblestone = 4,
        Planks = 5,
        Sapling = 6,
        Bedrock = 7,
        Flowing_water = 8,
        Water = 9,
        Floating_lava = 10,
        Lava = 11,
        Sand = 12,
        Gravel = 13,
        Gold_ore = 14,
        Iron_ore = 15,
        Coal_ore = 16,
        Log = 17,
        Leaves = 18,
        Sponge = 19,
        Glass = 20,
        Lapis_ore = 21,
        Lapis_block = 22,
        Dispenser = 23,
        Sandstone = 24,
        Noteblock = 25,
        Bed_block = 26,
        Powered_rail = 27,
        Detector_rail = 28,
        Sticky_piston = 29,
        Cobweb = 30,
        Tall_grass = 31,
        Deadbush = 32,
        Piston = 33,
        Piston_head = 34,
        Wool = 35,
        Dandelion = 37,
        Red_flower = 38,
        Brown_mushroom = 39,
        Red_mushroom = 40,
        Gold_block = 41,
        Iron_block = 42,
        Double_stone_slab = 43,
        Stone_slab = 44,
        Bricks_block = 45,
        Tnt = 46,
        Bookshelf = 47,
        Mossy_cobblestone = 48,
        Obsidian = 49,
        Torch = 50,
        Fire = 51,
        Monster_spawner = 52,
        Oak_stairs = 53,
        Chest = 54,
        Redstone_wire = 55,
        Diamond_ore = 56,
        Diamond_block = 57,
        Crafting_table = 58,
        Wheat_crops = 59,
        Farmland = 60,
        Furnace = 61,
        Burning_furnace = 62,
        Standing_sign = 63,
        Oak_door_block = 64,
        Ladder = 65,
        Rail = 66,
        Cobblestone_stairs = 67,
        Wall_sign = 68,
        Lever = 69,
        Stone_pressure_plate = 70,
        Iron_door_block = 71,
        Wooden_pressure_plate = 72,
        Redstone_ore = 73,
        Lit_redstone_ore = 74,
        Unlit_redstone_torch = 75,
        Redstone_torch = 76,
        Stone_button = 77,
        Snow_layer = 78,
        Ice = 79,
        Snow = 80,
        Cactus = 81,
        Clay_block = 82,
        Reeds_block = 83,
        Jukebox = 84,
        Fence = 85,
        Pumpkin = 86,
        Netherrack = 87,
        Soul_sand = 88,
        Glowstone = 89,
        Nether_portal = 90,
        Lit_pumpkin = 91,
        Cake_block = 92,
        Unpowered_repeater = 93,
        Powered_repeater = 94,
        Stained_glass = 95,
        Trapdoor = 96,
        Monster_egg = 97,
        Stonebrick = 98,
        Brown_mushroom_block = 99,
        Red_mushroom_block = 100,
        Iron_bars = 101,
        Glass_pane = 102,
        Melon_block = 103,
        Pumpkin_stem = 104,
        Melon_stem = 105,
        Vine = 106,
        Fence_gate = 107,
        Brick_stairs = 108,
        Stone_brick_stairs = 109,
        Mycelium = 110,
        Waterlily = 111,
        Nether_brick_block = 112,
        Nether_brick_fence = 113,
        Nether_bricks_stairs = 114,
        Nether_wart_block = 115,
        Enchanting_table = 116,
        Brewing_stand_block = 117,
        Cauldron_block = 118,
        End_portal = 119,
        End_portal_frame = 120,
        End_stone = 121,
        Dragon_egg = 122,
        Redstone_lamp = 123,
        Lit_redstone_lamp = 124,
        Double_wooden_slab = 125,
        Wooden_slab = 126,
        Cocoa = 127,
        Sandstone_stairs = 128,
        Emerald_ore = 129,
        Ender_chest = 130,
        Tripwire_hook = 131,
        Tripwire = 132,
        Emerald_block = 133,
        Spruce_stairs = 134,
        Birch_stairs = 135,
        Jungle_stairs = 136,
        Command_block = 137,
        Beacon = 138,
        Cobblestone_wall = 139,
        Flower_pot_block = 140,
        Carrots = 141,
        Potatoes = 142,
        Wooden_button = 143,
        Skull_block = 144,
        Anvil = 145,
        Trapped_chest = 146,
        Light_weighted_pressure_plate = 147,
        Heavy_weighted_pressure_plate = 148,
        Unpowered_comparator = 149,
        Powered_comparator = 150,
        Daylight_detector = 151,
        Redstone_block = 152,
        Quartz_ore = 153,
        Hopper_block = 154,
        Quartz_block = 155,
        Quartz_stairs = 156,
        Activator_rail = 157,
        Dropper = 158,
        Stained_hardened_terracotta = 159,
        Stained_glass_pane = 160,
        Leaves2 = 161,
        Log2 = 162,
        Acacia_stairs = 163,
        Dark_oak_stairs = 164,
        Slime_block = 165,
        Barrier = 166,
        Iron_trapdoor = 167,
        Prismarine = 168,
        Sea_lantern = 169,
        Hay_bale = 170,
        Carpet = 171,
        Terracotta = 172,
        Coal_block = 173,
        Packed_ice = 174,
        Double_plant = 175,
        Standing_banner = 176,
        Wall_banner = 177,
        Daylight_detector_inverted = 178,
        Red_sandstone = 179,
        Red_sandstone_stairs = 180,
        Double_red_sandstone_slab = 181,
        Red_sandstone_slab = 182,
        Fence_gate_spruce = 183,
        Fence_gate_birch = 184,
        Fence_gate_jungle = 185,
        Fence_gate_dark_oak = 186,
        Fence_gate_acacia = 187,
        Spruce_fence = 188,
        Birch_fence = 189,
        Jungle_fence = 190,
        Dark_oak_fence = 191,
        Acacia_fence = 192,
        Spruce_door_block = 193,
        Birch_door_block = 194,
        Jungle_door_block = 195,
        Acacia_door_block = 196,
        Dark_oak_door_block = 197,
        Grass_path = 198,
        Item_frame_block = 199,
        Chorus_flower = 200,
        Purpur_block = 201,
        Purpur_pillar = 202,
        Purpur_stairs = 203,
        Purpur_double_slab = 204,
        Purpur_slab = 205,
        End_bricks = 206,
        Beetroots = 206,
        End_rod = 208,
        End_gateway = 209,
        Repeating_command_block = 210,
        Chain_command_block = 211,
        Frosted_ice = 212,
        Magma = 213,
        Block_nether_wart_block = 214,
        Red_nether_brick = 215,
        Bone_block = 216,
        Structure_void = 217,
        Observer = 218,
        White_shulker_box = 219,
        Orange_shulker_box = 220,
        Magenta_shulker_box = 221,
        Light_blue_shulker_box = 222,
        Yellow_shulker_box = 223,
        Lime_shulker_box = 224,
        Pink_shulker_box = 225,
        Gray_shulker_box = 226,
        Silver_shulker_box = 227,
        Cyan_shulker_box = 228,
        Purple_shulker_box = 229,
        Blue_shulker_box = 230,
        Brown_shulker_box = 231,
        Green_shulker_box = 232,
        Red_shulker_box = 233,
        Black_shulker_box = 234,
        White_glazed_terracotta = 235,
        Orange_glazed_terracotta = 236,
        Magenta_glazed_terracotta = 237,
        Light_blue_glazed_terracotta = 238,
        Yellow_glazed_terracotta = 239,
        Lime_glazed_terracotta = 240,
        Pink_glazed_terracotta = 241,
        Gray_glazed_terracotta = 242,
        Light_gray_glazed_terracotta = 243,
        Cyan_glazed_terracotta = 244,
        Purple_glazed_terracotta = 245,
        Blue_glazed_terracotta = 246,
        Brown_glazed_terracotta = 247,
        Green_glazed_terracotta = 248,
        Red_glazed_terracotta = 249,
        Black_glazed_terracotta = 250,
        Concrete = 251,
        Concrete_powder = 252,

        // id 253 - 254 are not existing

        Structure_block = 255,

        //normal item ids

        Iron_shovel = 256,
        Iron_pickaxe = 257,
        Iron_axe = 258,
        Flint_and_steel = 259,
        Apple = 260,
        Bow = 261,
        Arrow = 262,
        Coal = 263,
        Diamond = 264,
        Iron_ingot = 265,
        Gold_ingot = 266,
        Iron_sword = 267,
        Wooden_sword = 268,
        Wooden_shovel = 269,
        Wooden_pickaxe = 270,
        Wooden_axe = 271,
        Stone_sword = 272,
        Stone_shovel = 273,
        Stone_pickaxe = 274,
        Stone_axe = 275,
        Diamond_sword = 276,
        Diamond_shovel = 277,
        Diamond_pickaxe = 278,
        Diamond_axe = 279,
        Stick = 280,
        Bowl = 281,
        Mushroom_stew = 282,
        Golden_sword = 283,
        Golden_shovel = 284,
        Golden_pickaxe = 285,
        Golden_axe = 286,
        String = 287,
        Feather = 288,
        Gunpowder = 289,
        Wooden_hoe = 290,
        Stone_hoe = 291,
        Iron_hoe = 292,
        Diamond_hoe = 293,
        Golden_hoe = 294,
        Wheat_seeds = 295,
        Wheat = 296,
        Bread = 297,
        Leather_cap = 298,
        Leather_tunic = 299,
        Leather_pants = 300,
        Leather_boots = 301,
        Chain_helmet = 302,
        Chain_chestplate = 303,
        Chain_leggings = 304,
        Chain_boots = 305,
        Iron_helmet = 306,
        Iron_chestplate = 307,
        Iron_leggings = 308,
        Iron_boots = 309,
        Diamond_helmet = 310,
        Diamond_chestplate = 311,
        Diamond_leggings = 312,
        Diamond_boots = 313,
        Gold_helmet = 314,
        Gold_chestplate = 315,
        Gold_leggings = 316,
        Gold_boots = 317,
        Flint = 318,
        Raw_porkchop = 319,
        Cooked_porkchop = 320,
        Painting = 321,
        Golden_apple = 322,
        Sign = 323,
        Wooden_door = 324,
        Bucket = 325,
        Water_bucket = 326,
        Lava_bucket = 327,
        Minecart = 328,
        Saddle = 329,
        Iron_door = 330,
        Redstone = 331,
        Snowball = 332,
        Boat = 333,
        Leather = 334,
        Milk_bukkit = 335,
        Brick = 336,
        Clay = 337,
        Reeds = 338,
        Paper = 339,
        Book = 340,
        Slimeball = 341,
        Chest_minecart = 342,
        Furnace_minecart = 343,
        Egg = 344,
        Compass = 345,
        Fishing_rod = 346,
        Clock = 347,
        Glowstone_dust = 348,
        Raw_fish = 349,
        Cooked_fish = 350,
        Dye = 351,
        Bone = 352,
        Sugar = 353,
        Cake = 354,
        Bed = 355,
        Repeater = 356,
        Cookie = 357,
        Map = 358,
        Shears = 359,
        Melon = 360,
        Pumpkin_seeds = 361,
        Melon_seeds = 362,
        Raw_beef = 363,
        Cooked_beef = 364,
        Raw_chicken = 365,
        Cooked_chicken = 366,
        Rotten_flesh = 367,
        Ender_pearl = 368,
        Blaze_rod = 369,
        Ghast_tear = 370,
        Gold_nugget = 371,
        Nether_wart = 372,
        Potion = 373,
        Glass_bottle = 374,
        Spider_eye = 375,
        Fermented_spider_eye = 376,
        Blaze_powder = 377,
        Magma_cream = 378,
        Brewing_stand = 379,
        Cauldron = 380,
        Ender_eye = 381,
        Glistering_melon = 382,
        Spawn_egg = 383,
        Experience_bottle = 384,
        Fire_charge = 385,
        Book_and_quill = 386,
        Written_book = 387,
        Emerald = 388,
        Item_frame = 389,
        Flower_pot = 390,
        Carrot = 391,
        Potato = 392,
        Baked_potato = 393,
        Baked_potatoes = 393,
        Poisonous_potato = 394,
        Empty_map = 395,
        Golden_carrot = 396,
        Skull = 397,
        Carrot_on_a_stick = 398,
        Nether_star = 399,
        Pumpkin_pie = 400,
        Fireworks = 401,
        Firework_charge = 402,
        Enchanted_book = 403,
        Comparator = 404,
        Nether_brick = 405,
        Quartz = 406,
        Minecart_with_tnt = 407,
        Minecart_with_hopper = 408,
        Prismarine_shard = 409,
        Hopper = 410,
        Raw_rabbit = 411,
        Cooked_rabbit = 412,
        Rabbit_stew = 413,
        Rabbit_foot = 414,
        Rabbit_hide = 415,
        Leather_horse_armor = 416,
        Iron_horse_armor = 417,
        Gold_horse_armor = 418,
        Diamond_horse_armor = 419,
        Lead = 420,
        Name_tag = 421,
        Prismarine_crystals = 422,
        Raw_mutton = 423,
        Cooked_mutton = 424,
        Banner = 425,
        End_crystal = 426,
        Spruce_door = 427,
        Birch_door = 428,
        Jungle_door = 429,
        Acacia_door = 430,
        Dark_oak_door = 431,
        Chorus_fruit = 432,
        Popped_chorus_fruit = 433,
        Beetroot = 434,
        Beetroot_seeds = 435,
        Beetroot_soup = 436,
        Dragon_breath = 437,
        Splash_potion = 438,
        Spectral_arrow = 439,
        Tipped_arrow = 440,
        Lingering_potion = 441,
        Shield = 442,
        Elytra = 443,
        Spruce_boat = 444,
        Birch_boat = 445,
        Jungle_boat = 446,
        Acacia_boat = 447,
        Dark_oak_boat = 448,
        Totem_of_undying = 449,
        Shulker_shell = 450,
        Iron_nugget = 452,
        Knowledge_book = 453,
        Record_13 = 2256,
        Record_cat = 2257,
        Record_blocks = 2258,
        Record_chirp = 2259,
        Record_far = 2260,
        Record_mall = 2261,
        Record_mellohi = 2262,
        Record_stal = 2263,
        Record_strad = 2264,
        Record_ward = 2265,
        Record_11 = 2266,
        Record_wait = 2267,
    }
}