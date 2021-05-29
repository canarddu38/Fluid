using System;

namespace Fluid.Core
{
    public class Item 
    {
        //All Block IDs are here too
        public static int AIR = 0;
        public static int STONE = 1;
        public static int GRASS = 2;
        public static int DIRT = 3;
        public static int COBBLESTONE = 4;
        public static int PLANKS = 5;
        public static int SAPLING = 6;
        public static int BEDROCK = 7;
        public static int FLOWING_WATER = 8;
        public static int WATER = 9;
        public static int FLOATING_LAVA = 10;
        public static int LAVA = 11;
        public static int SAND = 12;
        public static int GRAVEL = 13;
        public static int GOLD_ORE = 14;
        public static int IRON_ORE = 15;
        public static int COAL_ORE = 16;
        public static int LOG = 17;
        public static int LEAVES = 18;
        public static int SPONGE = 19;
        public static int GLASS = 20;
        public static int LAPIS_ORE = 21;
        public static int LAPIS_BLOCK = 22;
        public static int DISPENSER = 23;
        public static int SANDSTONE = 24;
        public static int NOTEBLOCK = 25;
        public static int BED = 26;
        public static int POWERED_RAIL = 27;
        public static int DETECTOR_RAIL = 28;
        public static int STICKY_PISTON = 29;
        public static int COBWEB = 30;
        public static int TALL_GRASS = 31;
        public static int BUSH = 32;
        public static int DEAD_BUSH = 32;
        public static int PISTON = 33;
        public static int PISTON_HEAD = 34;
        public static int WOOL = 35;
        public static int DANDELION = 37;
        public static int POPPY = 38;
        public static int ROSE = 38;
        public static int FLOWER = 38;
        public static int RED_FLOWER = 38;
        public static int BROWN_MUSHROOM = 39;
        public static int RED_MUSHROOM = 40;
        public static int GOLD_BLOCK = 41;
        public static int IRON_BLOCK = 42;
        public static int DOUBLE_STONE_SLAB = 43;
        public static int STONE_SLAB = 44;
        public static int BRICKS_BLOCK = 45;
        public static int TNT = 46;
        public static int BOOKSHELF = 47;
        public static int MOSSY_COBBLESTONE = 48;
        public static int OBSIDIAN = 49;
        public static int TORCH = 50;
        public static int FIRE = 51;
        public static int MONSTER_SPAWNER = 52;
        public static int OAK_STAIRS = 53;
        public static int CHEST = 54;
        public static int REDSTONE_WIRE = 55;
        public static int DIAMOND_ORE = 56;
        public static int DIAMOND_BLOCK = 57;
        public static int CRAFTING_TABLE = 58;
        public static int WHEAT = 59;
        public static int FARMLAND = 60;
        public static int FURNACE = 61;
        public static int BURNING_FURNACE = 62;
        public static int STANDING_SIGN = 63;
        public static int OAK_DOOR_BLOCK = 64;
        public static int LADDER = 65;
        public static int RAIL = 66;
        public static int COBBLESTONE_STAIRS = 67;
        public static int WALL_SIGN = 68;
        public static int LEVER = 69;
        public static int STONE_PRESSURE_PLATE = 70;
        public static int IRON_DOOR_BLOCK = 71;
        public static int WOODEN_PRESSURE_PLATE = 72;
        public static int REDSTONE_ORE = 73;
        public static int LIT_REDSTONE_ORE = 74;
        public static int UNLIT_REDSTONE_TORCH = 75;
        public static int REDSTONE_TORCH = 76;
        public static int STONE_BUTTON = 77;
        public static int SNOW_LAYER = 78;
        public static int ICE = 79;
        public static int SNOW = 80;
        public static int CACTUS = 81;
        public static int CLAY = 82;
        public static int REEDS = 83;
        public static int JUKEBOX = 84;
        public static int FENCE = 85;
        public static int PUMPKIN = 86;
        public static int NETHERRACK = 87;
        public static int SOUL_SAND = 88;
        public static int GLOWSTONE = 89;
        public static int NETHER_PORTAL = 90;
        public static int LIT_PUMPKIN = 91;
        public static int CAKE = 92;
        public static int UNPOWERED_REPEATER = 93;
        public static int POWERED_REPEATER = 94;
        public static int STAINED_GLASS = 95;
        public static int TRAPDOOR = 96;
        public static int MONSTER_EGG = 97;
        public static int STONEBRICK = 98;
        public static int BROWN_MUSHROOM_BLOCK = 99;
        public static int RED_MUSHROOM_BLOCK = 100;
        public static int IRON_BARS = 101;
        public static int GLASS_PANE = 102;
        public static int MELON_BLOCK = 103;
        public static int PUMPKIN_STEM = 104;
        public static int MELON_STEM = 105;
        public static int VINE = 106;
        public static int FENCE_GATE = 107;
        public static int BRICK_STAIRS = 108;
        public static int STONE_BRICK_STAIRS = 109;
        public static int MYCELIUM = 110;
        public static int WATER_LILY = 111;
        public static int LILY_PAD = 111;
        public static int NETHER_BRICKS = 112;
        public static int NETHER_BRICK_BLOCK = 112;
        public static int NETHER_BRICK_FENCE = 113;
        public static int NETHER_BRICKS_STAIRS = 114;
        public static int NETHER_WART_BLOCK = 115;
        public static int ENCHANTING_TABLE = 116;
        public static int ENCHANT_TABLE = 116;
        public static int ENCHANTMENT_TABLE = 116;
        public static int BREWING_STAND_BLOCK = 117;
        public static int BREWING_BLOCK = 117;
        public static int CAULDRON_BLOCK = 118;
        public static int END_PORTAL = 119;
        public static int END_PORTAL_FRAME = 120;
        public static int END_STONE = 121;
        public static int DRAGON_EGG = 122;
        public static int REDSTONE_LAMP = 123;
        public static int LIT_REDSTONE_LAMP = 124;
        public static int DROPPER = 125;
        public static int ACTIVATOR_RAIL = 126;
        public static int COCOA = 127;
        public static int COCOA_BLOCK = 127;
        public static int SANDSTONE_STAIRS = 128;
        public static int EMERALD_ORE = 129;
        public static int ENDER_CHEST = 130;
        public static int TRIPWIRE_HOOK = 131;
        public static int TRIPWIRE = 132;
        public static int EMERALD_BLOCK = 133;
        public static int SPRUCE_WOOD_STAIRS = 134;
        public static int SPRUCE_WOODEN_STAIRS = 134;
        public static int BIRCH_WOOD_STAIRS = 135;
        public static int BIRCH_WOODEN_STAIRS = 135;
        public static int JUNGLE_WOOD_STAIRS = 136;
        public static int JUNGLE_WOODEN_STAIRS = 136;
        public static int COMMAND_BLOCK = 136;
        public static int BEACON = 138;
        public static int COBBLE_WALL = 139;
        public static int STONE_WALL = 139;
        public static int COBBLESTONE_WALL = 139;
        public static int FLOWER_POT_BLOCK = 140;
        public static int CARROT_BLOCK = 141;
        public static int POTATO_BLOCK = 142;
        public static int WOODEN_BUTTON = 143;
        public static int SKULL_BLOCK = 144;
        public static int ANVIL = 145;
        public static int TRAPPED_CHEST = 146;
        public static int LIGHT_WEIGHTED_PRESSURE_PLATE = 147;
        public static int HEAVY_WEIGHTED_PRESSURE_PLATE = 148;
        public static int UNPOWERED_COMPARATOR = 149;
        public static int POWERED_COMPARATOR = 150;
        public static int DAYLIGHT_DETECTOR = 151;
        public static int REDSTONE_BLOCK = 152;
        public static int QUARTZ_ORE = 153;
        public static int HOPPER_BLOCK = 154;
        public static int QUARTZ_BLOCK = 155;
        public static int QUARTZ_STAIRS = 156;
        public static int DOUBLE_WOOD_SLAB = 157;
        public static int DOUBLE_WOODEN_SLAB = 157;
        public static int DOUBLE_WOOD_SLABS = 157;
        public static int DOUBLE_WOODEN_SLABS = 157;
        public static int WOOD_SLAB = 158;
        public static int WOODEN_SLAB = 158;
        public static int WOOD_SLABS = 158;
        public static int WOODEN_SLABS = 158;
        public static int STAINED_TERRACOTTA = 159;
        public static int STAINED_HARDENED_CLAY = 159;
        public static int STAINED_GLASS_PANE = 160;
        public static int LEAVES2 = 161;
        public static int LEAVE2 = 161;
        public static int WOOD2 = 162;
        public static int TRUNK2 = 162;
        public static int LOG2 = 162;
        public static int ACACIA_WOOD_STAIRS = 163;
        public static int ACACIA_WOODEN_STAIRS = 163;
        public static int DARK_OAK_WOOD_STAIRS = 164;
        public static int DARK_OAK_WOODEN_STAIRS = 164;
        public static int SLIME_BLOCK = 165;
        public static int BARRIER = 166;
        public static int IRON_TRAPDOOR = 167;
        public static int PRISMARINE = 168;
        public static int SEA_LANTERN = 169;
        public static int HAY_BALE = 170;
        public static int CARPET = 171;
        public static int TERRACOTTA = 172;
        public static int COAL_BLOCK = 173;
        public static int PACKED_ICE = 174;
        public static int DOUBLE_PLANT = 175;
        public static int STANDING_BANNER = 176;
        public static int WALL_BANNER = 177;
        public static int DAYLIGHT_DETECTOR_INVERTED = 178;
        public static int RED_SANDSTONE = 179;
        public static int RED_SANDSTONE_STAIRS = 180;
        public static int DOUBLE_RED_SANDSTONE_SLAB = 181;
        public static int RED_SANDSTONE_SLAB = 182;
        public static int FENCE_GATE_SPRUCE = 183;
        public static int FENCE_GATE_BIRCH = 184;
        public static int FENCE_GATE_JUNGLE = 185;
        public static int FENCE_GATE_DARK_OAK = 186;
        public static int FENCE_GATE_ACACIA = 187;
        public static int SPRUCE_FENCE = 188;
        public static int BIRCH_FENCE = 189;
        public static int JUNGLE_FENCE = 190;
        public static int DARK_OAK_FENCE = 191;
        public static int ACACIA_FENCE = 192;
        public static int SPRUCE_DOOR_BLOCK = 193;
        public static int BIRCH_DOOR_BLOCK = 194;
        public static int JUNGLE_DOOR_BLOCK = 195;
        public static int ACACIA_DOOR_BLOCK = 196;
        public static int DARK_OAK_DOOR_BLOCK = 197;
        public static int GRASS_PATH = 198;
        public static int ITEM_FRAME_BLOCK = 199;
        public static int CHORUS_FLOWER = 200;
        public static int PURPUR_BLOCK = 201;
        public static int PURPUR_PILLAR = 202;
        public static int PURPUR_STAIRS = 203;
        public static int PURPUR_DOUBLE_SLAB = 204;
        public static int PURPUR_SLAB = 205;
        public static int END_BRICKS = 206;
        public static int BEETROOTS = 206;
        public static int END_ROD = 208;
        public static int END_GATEWAY = 209;
        public static int REPEATING_COMMAND_BLOCK = 210;
        public static int CHAIN_COMMAND_BLOCK = 211;
        public static int FROSTED_ICE = 212;
        public static int MAGMA = 213;
        public static int BLOCK_NETHER_WART_BLOCK = 214;
        public static int RED_NETHER_BRICK = 215;
        public static int BONE_BLOCK = 216;
        public static int STRUCTURE_VOID = 217;
        public static int OBSERVER = 218;
        public static int WHITE_SHULKER_BOX = 219;
        public static int ORANGE_SHULKER_BOX = 220;
        public static int MAGENTA_SHULKER_BOX = 221;
        public static int LIGHT_BLUE_SHULKER_BOX = 222;
        public static int YELLOW_SHULKER_BOX = 223;
        public static int LIME_SHULKER_BOX = 224;
        public static int PINK_SHULKER_BOX = 225;
        public static int GRAY_SHULKER_BOX = 226;
        public static int SILVER_SHULKER_BOX = 227;
        public static int CYAN_SHULKER_BOX = 228;
        public static int PURPLE_SHULKER_BOX = 229;
        public static int BLUE_SHULKER_BOX = 230;
        public static int BROWN_SHULKER_BOX = 231;
        public static int GREEN_SHULKER_BOX = 232;
        public static int RED_SHULKER_BOX = 233;
        public static int BLACK_SHULKER_BOX = 234;
        public static int WHITE_GLAZED_TERRACOTTA = 235;
        public static int ORANGE_GLAZED_TERRACOTTA = 236;
        public static int MAGENTA_GLAZED_TERRACOTTA = 237;
        public static int LIGHT_BLUE_GLAZED_TERRACOTTA = 238;
        public static int YELLOW_GLAZED_TERRACOTTA = 239;
        public static int LIME_GLAZED_TERRACOTTA = 240;
        public static int PINK_GLAZED_TERRACOTTA = 241;
        public static int GRAY_GLAZED_TERRACOTTA = 242;
        public static int LIGHT_GRAY_GLAZED_TERRACOTTA = 243;
        public static int CYAN_GLAZED_TERRACOTTA = 244;
        public static int PURPLE_GLAZED_TERRACOTTA = 245;
        public static int BLUE_GLAZED_TERRACOTTA = 246;
        public static int BROWN_GLAZED_TERRACOTTA = 247;
        public static int GREEN_GLAZED_TERRACOTTA = 248;
        public static int RED_GLAZED_TERRACOTTA = 249;
        public static int BLACK_GLAZED_TERRACOTTA = 250;
        public static int CONCRETE = 251;
        public static int CONCRETE_POWDER = 252;

        // ID 253 - 254 are not existing

        public static int STRUCTURE_BLOCK = 255;

        //Normal Item IDs

        public static int IRON_SHOVEL = 256;
        public static int IRON_PICKAXE = 257;
        public static int IRON_AXE = 258;
        public static int FLINT_STEEL = 259;
        public static int FLINT_AND_STEEL = 259;
        public static int APPLE = 260;
        public static int BOW = 261;
        public static int ARROW = 262;
        public static int COAL = 263;
        public static int DIAMOND = 264;
        public static int IRON_INGOT = 265;
        public static int GOLD_INGOT = 266;
        public static int IRON_SWORD = 267;
        public static int WOODEN_SWORD = 268;
        public static int WOODEN_SHOVEL = 269;
        public static int WOODEN_PICKAXE = 270;
        public static int WOODEN_AXE = 271;
        public static int STONE_SWORD = 272;
        public static int STONE_SHOVEL = 273;
        public static int STONE_PICKAXE = 274;
        public static int STONE_AXE = 275;
        public static int DIAMOND_SWORD = 276;
        public static int DIAMOND_SHOVEL = 277;
        public static int DIAMOND_PICKAXE = 278;
        public static int DIAMOND_AXE = 279;
        public static int STICK = 280;
        public static int STICKS = 280;
        public static int BOWL = 281;
        public static int MUSHROOM_STEW = 282;
        public static int GOLD_SWORD = 283;
        public static int GOLDEN_SWORD = 283;
        public static int GOLD_SHOVEL = 284;
        public static int GOLDEN_SHOVEL = 284;
        public static int GOLD_PICKAXE = 285;
        public static int GOLDEN_PICKAXE = 285;
        public static int GOLD_AXE = 286;
        public static int GOLDEN_AXE = 286;
        public static int STRING = 287;
        public static int FEATHER = 288;
        public static int GUNPOWDER = 289;
        public static int WOODEN_HOE = 290;
        public static int STONE_HOE = 291;
        public static int IRON_HOE = 292;
        public static int DIAMOND_HOE = 293;
        public static int GOLD_HOE = 294;
        public static int GOLDEN_HOE = 294;
        public static int SEEDS = 295;
        public static int WHEAT_SEEDS = 295;
        public static int WHEAT = 296;
        public static int BREAD = 297;
        public static int LEATHER_CAP = 298;
        public static int LEATHER_TUNIC = 299;
        public static int LEATHER_PANTS = 300;
        public static int LEATHER_BOOTS = 301;
        public static int CHAIN_HELMET = 302;
        public static int CHAIN_CHESTPLATE = 303;
        public static int CHAIN_LEGGINGS = 304;
        public static int CHAIN_BOOTS = 305;
        public static int IRON_HELMET = 306;
        public static int IRON_CHESTPLATE = 307;
        public static int IRON_LEGGINGS = 308;
        public static int IRON_BOOTS = 309;
        public static int DIAMOND_HELMET = 310;
        public static int DIAMOND_CHESTPLATE = 311;
        public static int DIAMOND_LEGGINGS = 312;
        public static int DIAMOND_BOOTS = 313;
        public static int GOLD_HELMET = 314;
        public static int GOLD_CHESTPLATE = 315;
        public static int GOLD_LEGGINGS = 316;
        public static int GOLD_BOOTS = 317;
        public static int FLINT = 318;
        public static int RAW_PORKCHOP = 319;
        public static int COOKED_PORKCHOP = 320;
        public static int PAINTING = 321;
        public static int GOLDEN_APPLE = 322;
        public static int SIGN = 323;
        public static int WOODEN_DOOR = 324;
        public static int BUCKET = 325;

        public static int MINECART = 328;
        public static int SADDLE = 329;
        public static int IRON_DOOR = 330;
        public static int REDSTONE = 331;
        public static int REDSTONE_DUST = 331;
        public static int SNOWBALL = 332;
        public static int BOAT = 333;
        public static int LEATHER = 334;

        public static int BRICK = 336;
        public static int CLAY = 337;
        public static int SUGARCANE = 338;
        public static int SUGAR_CANE = 338;
        public static int SUGAR_CANES = 338;
        public static int PAPER = 339;
        public static int BOOK = 340;
        public static int SLIMEBALL = 341;
        public static int MINECART_WITH_CHEST = 342;

        public static int EGG = 344;
        public static int COMPASS = 345;
        public static int FISHING_ROD = 346;
        public static int CLOCK = 347;
        public static int GLOWSTONE_DUST = 348;
        public static int RAW_FISH = 349;
        public static int COOKED_FISH = 350;
        public static int DYE = 351;
        public static int BONE = 352;
        public static int SUGAR = 353;
        public static int CAKE = 354;
        public static int BED = 355;
        public static int REPEATER = 356;
        public static int COOKIE = 357;
        public static int MAP = 358;
        public static int SHEARS = 359;
        public static int MELON = 360;
        public static int MELON_SLICE = 360;
        public static int PUMPKIN_SEEDS = 361;
        public static int MELON_SEEDS = 362;
        public static int RAW_BEEF = 363;
        public static int STEAK = 364;
        public static int COOKED_BEEF = 364;
        public static int RAW_CHICKEN = 365;
        public static int COOKED_CHICKEN = 366;
        public static int ROTTEN_FLESH = 367;
        public static int ENDER_PEARL = 368;
        public static int BLAZE_ROD = 369;
        public static int GHAST_TEAR = 370;
        public static int GOLD_NUGGET = 371;
        public static int GOLDEN_NUGGET = 371;
        public static int NETHER_WART = 372;
        public static int POTION = 373;
        public static int GLASS_BOTTLE = 374;
        public static int BOTTLE = 374;
        public static int SPIDER_EYE = 375;
        public static int FERMENTED_SPIDER_EYE = 376;
        public static int BLAZE_POWDER = 377;
        public static int MAGMA_CREAM = 378;
        public static int BREWING_STAND = 379;
        public static int BREWING = 379;
        public static int CAULDRON = 380;
        public static int ENDER_EYE = 381;
        public static int GLISTERING_MELON = 382;
        public static int SPAWN_EGG = 383;
        public static int EXPERIENCE_BOTTLE = 384;
        public static int FIRE_CHARGE = 385;
        public static int BOOK_AND_QUILL = 386;
        public static int WRITTEN_BOOK = 387;
        public static int EMERALD = 388;
        public static int ITEM_FRAME = 389;
        public static int FLOWER_POT = 390;
        public static int CARROT = 391;
        public static int CARROTS = 391;
        public static int POTATO = 392;
        public static int POTATOES = 392;
        public static int BAKED_POTATO = 393;
        public static int BAKED_POTATOES = 393;
        public static int POISONOUS_POTATO = 394;
        public static int EMPTY_MAP = 395;
        public static int GOLDEN_CARROT = 396;
        public static int SKULL = 397;
        public static int CARROT_ON_A_STICK = 398;
        public static int NETHER_STAR = 399;
        public static int PUMPKIN_PIE = 400;

        public static int ENCHANTED_BOOK = 403;
        public static int ENCHANT_BOOK = 403;
        public static int COMPARATOR = 404;
        public static int NETHER_BRICK = 405;
        public static int QUARTZ = 406;
        public static int NETHER_QUARTZ = 406;
        public static int MINECART_WITH_TNT = 407;
        public static int MINECART_WITH_HOPPER = 408;
        public static int PRISMARINE_SHARD = 409;
        public static int HOPPER = 410;
        public static int RAW_RABBIT = 411;
        public static int COOKED_RABBIT = 412;
        public static int RABBIT_STEW = 413;
        public static int RABBIT_FOOT = 414;
        public static int RABBIT_HIDE = 415;
        public static int LEATHER_HORSE_ARMOR = 416;
        public static int IRON_HORSE_ARMOR = 417;
        public static int GOLD_HORSE_ARMOR = 418;
        public static int DIAMOND_HORSE_ARMOR = 419;
        public static int LEAD = 420;
        public static int NAME_TAG = 421;
        public static int PRISMARINE_CRYSTALS = 422;
        public static int RAW_MUTTON = 423;
        public static int COOKED_MUTTON = 424;

        public static int END_CRYSTAL = 426;
        public static int SPRUCE_DOOR = 427;
        public static int BIRCH_DOOR = 428;
        public static int JUNGLE_DOOR = 429;
        public static int ACACIA_DOOR = 430;
        public static int DARK_OAK_DOOR = 431;
        public static int CHORUS_FRUIT = 432;
        public static int POPPED_CHORUS_FRUIT = 433;

        public static int DRAGON_BREATH = 437;
        public static int SPLASH_POTION = 438;

        public static int LINGERING_POTION = 441;

        public static int ELYTRA = 444;

        public static int SHULKER_SHELL = 445;

        public static int BEETROOT = 457;
        public static int BEETROOT_SEEDS = 458;
        public static int BEETROOT_SEED = 458;
        public static int BEETROOT_SOUP = 459;
        public static int RAW_SALMON = 460;
        public static int CLOWNFISH = 461;
        public static int PUFFERFISH = 462;
        public static int COOKED_SALMON = 463;

        public static int GOLDEN_APPLE_ENCHANTED = 466;

        public static int RECORD_13 = 500;
        public static int RECORD_CAT = 501;
        public static int RECORD_BLOCKS = 502;
        public static int RECORD_CHIRP = 503;
        public static int RECORD_FAR = 504;
        public static int RECORD_MALL = 505;
        public static int RECORD_MELLOHI = 506;
        public static int RECORD_STAL = 507;
        public static int RECORD_STRAD = 508;
        public static int RECORD_WARD = 509;
        public static int RECORD_11 = 510;
        public static int RECORD_WAIT = 511;
    }
}