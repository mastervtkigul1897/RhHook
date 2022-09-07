﻿// Decompiled with JetBrains decompiler
// Type: RhHook.Data.Itemattributetype
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

namespace RhHook.Data
{
  public enum Itemattributetype
  {
    IAT_ITEM_TYPE = 0,
    IAT_DESCRIPTION = 1,
    IAT_WEIGHT = 2,
    IAT_PRICE = 3,
    IAT_SELLPRICE = 4,
    IAT_EQUIP_LEVEL = 5,
    IAT_EQUIP_STRENGTH = 6,
    IAT_EQUIP_DEXTERITY = 7,
    IAT_EQUIP_INTELLIGENCE = 8,
    IAT_CUR_STACK = 9,
    IAT_MAX_STACK = 10, // 0x0000000A
    IAT_RANK = 11, // 0x0000000B
    IAT_INVENTORY = 12, // 0x0000000C
    IAT_SLOT = 13, // 0x0000000D
    IAT_DAMAGE = 14, // 0x0000000E
    IAT_ATTACK_SPEED = 15, // 0x0000000F
    IAT_ATTACK_RANGE = 16, // 0x00000010
    IAT_MISS = 17, // 0x00000011
    IAT_CRITICAL = 18, // 0x00000012
    IAT_BLOCK_RATE = 19, // 0x00000013
    IAT_DEFENCE = 20, // 0x00000014
    IAT_LIFE = 21, // 0x00000015
    IAT_MANA = 22, // 0x00000016
    IAT_COOL_TIME = 23, // 0x00000017
    IAT_CURE_LEVEL = 24, // 0x00000018
    IAT_CURE_RATE = 25, // 0x00000019
    IAT_CASTING_TIME = 26, // 0x0000001A
    IAT_USE_LEVEL = 27, // 0x0000001B
    IAT_SLOT_NUM = 28, // 0x0000001C
    IAT_DISCOUNT_RATE = 29, // 0x0000001D
    IAT_DISCOUNT_SUCCESS_RATE = 30, // 0x0000001E
    IAT_BUILD_TIME = 31, // 0x0000001F
    IAT_USE_SKILL_LEVEL = 32, // 0x00000020
    IAT_RIDING_SPEED = 33, // 0x00000021
    IAT_RIDING_CASTINGTIME = 34, // 0x00000022
    IAT_RIDING_PLAYERRACE = 35, // 0x00000023
    IAT_SUCCESS_PROBABILITY = 36, // 0x00000024
    IAT_PET_LEVEL1_RATE = 37, // 0x00000025
    IAT_PET_LEVEL2_RATE = 38, // 0x00000026
    IAT_PET_LEVEL3_RATE = 39, // 0x00000027
    IAT_PET_FEED1 = 40, // 0x00000028
    IAT_PET_FEED2 = 41, // 0x00000029
    IAT_PET_HUNGRY_TIME_MINUTE = 42, // 0x0000002A
    IAT_PET_MAX_HUNGRY_COUNT = 43, // 0x0000002B
    IAT_FEED_COUNT = 44, // 0x0000002C
    IAT_FEED_TIME_MINUTE = 45, // 0x0000002D
    IAT_USE_MAX_LEVEL = 46, // 0x0000002E
    IAT_MAX_WEIGHT_RATE = 47, // 0x0000002F
    IAT_PET_WEIGHT1_RATE = 48, // 0x00000030
    IAT_PET_WEIGHT2_RATE = 49, // 0x00000031
    IAT_PET_WEIGHT3_RATE = 50, // 0x00000032
    IAT_MAX_WEIGHT = 51, // 0x00000033
    IAT_PET_REBIRTHCOST_LEVEL1 = 52, // 0x00000034
    IAT_PET_REBIRTHCOST_LEVEL2 = 53, // 0x00000035
    IAT_PET_REBIRTHCOST_LEVEL3 = 54, // 0x00000036
    IAT_EXP_RECOVERY_RATE = 55, // 0x00000037
    IAT_NO_WEIGHT = 56, // 0x00000038
    IAT_NO_DROP = 57, // 0x00000039
    IAT_FISH_REWARD_GRADE = 58, // 0x0000003A
    IAT_ITEMTYPE_LEVEL = 59, // 0x0000003B
    IAT_GENDER = 60, // 0x0000003C
    IAT_FISHTOOL_PROBVALUE = 61, // 0x0000003D
    IAT_STRENGTH = 62, // 0x0000003E
    IAT_HEALTH = 63, // 0x0000003F
    IAT_INTELLIGENCE = 64, // 0x00000040
    IAT_MENTALITY = 65, // 0x00000041
    IAT_DEXTERITY = 66, // 0x00000042
    IAT_QUICKNESS = 67, // 0x00000043
    IAT_MELEE_ATTACK_FORCE = 68, // 0x00000044
    IAT_RANGE_ATTACK_FORCE = 69, // 0x00000045
    IAT_MAGIC_ATTACK_FORCE = 70, // 0x00000046
    IAT_HIT = 71, // 0x00000047
    IAT_EVADE = 72, // 0x00000048
    IAT_PHYSICAL_DEFENCE = 73, // 0x00000049
    IAT_MAGIC_DEFENCE = 74, // 0x0000004A
    IAT_USE_GM_ONLY = 75, // 0x0000004B
    IAT_ARMOR_DEFENCE_UNAVAILABLE = 76, // 0x0000004C
    IAT_INITSTATUS_POINT = 77, // 0x0000004D
    IAT_TIMER_TYPE = 78, // 0x0000004E
    IAT_USE_AREA = 79, // 0x0000004F
    IAT_USE_CRAFT_LEVEL = 79, // 0x0000004F
    IAT_DURATIONTIME = 80, // 0x00000050
    IAT_SKILLKIND = 81, // 0x00000051
    IAT_SKILLKIND_1ST = 81, // 0x00000051
    IAT_LIMIT_UPPER = 82, // 0x00000052
    IAT_LIMIT_LOWER = 83, // 0x00000053
    IAT_GUILD_POINT = 84, // 0x00000054
    IAT_ATTITUDEON = 85, // 0x00000055
    IAT_EXP_BONUS_RATE = 86, // 0x00000056
    IAT_COUNT_BONUS_VALUE = 87, // 0x00000057
    IAT_CONSERSTONE_PREMIUM = 88, // 0x00000058
    IAT_CRAFT_TYPE = 88, // 0x00000058
    IAT_SUBTYPE = 88, // 0x00000058
    IAT_LIFEMANA = 89, // 0x00000059
    IAT_PET_LEVEL1_EXPVALUE_1 = 90, // 0x0000005A
    IAT_PET_LEVEL2_EXPVALUE_1 = 91, // 0x0000005B
    IAT_PET_LEVEL3_EXPVALUE_1 = 92, // 0x0000005C
    IAT_PET_LEVEL1_EXPVALUE_2 = 93, // 0x0000005D
    IAT_PET_LEVEL2_EXPVALUE_2 = 94, // 0x0000005E
    IAT_PET_LEVEL3_EXPVALUE_2 = 95, // 0x0000005F
    IAT_SKILLKIND_2ND = 96, // 0x00000060
    IAT_SKILLKIND_3RD = 97, // 0x00000061
    IAT_SKILLKIND_4TH = 98, // 0x00000062
    IAT_ALL_STATUS = 99, // 0x00000063
    IAT_ALL_ATTACK_FORCE = 100, // 0x00000064
    IAT_ALL_DEFENCE = 101, // 0x00000065
    IAT_ADD_DROPRATE = 102, // 0x00000066
    IAT_COL_EXP_RATE = 103, // 0x00000067
    IAT_COL_SPEED = 104, // 0x00000068
    IAT_COL_ADD_RARE_RATE = 105, // 0x00000069
    IAT_COL_ADD_NUM_RATE = 106, // 0x0000006A
    IAT_COL_SHOW_RES = 107, // 0x0000006B
    IAT_ABILITY_CRAFT_START_NOUSE = 108, // 0x0000006C
    IAT_ABILITY_CRAFT_END_NOUSE = 109, // 0x0000006D
    IAT_ABILITY_EXT_END = 109, // 0x0000006D
    IAT_PET_LEVEL1_EXPVALUE_3 = 110, // 0x0000006E
    IAT_PET_LEVEL2_EXPVALUE_3 = 111, // 0x0000006F
    IAT_PET_LEVEL3_EXPVALUE_3 = 112, // 0x00000070
    IAT_PET_LEVEL1_EXPVALUE_4 = 113, // 0x00000071
    IAT_PET_LEVEL2_EXPVALUE_4 = 114, // 0x00000072
    IAT_PET_LEVEL3_EXPVALUE_4 = 115, // 0x00000073
    IAT_CRAFT_SKILLTYPE = 116, // 0x00000074
    IAT_CRAFT_EQUIPLIMIT = 117, // 0x00000075
    IAT_PET_RESTORATION = 118, // 0x00000076
    IAT_CONSERVATION_RATE = 119, // 0x00000077
    IAT_BOOSTER_TYPE = 120, // 0x00000078
    IAT_PRODUCT_GRADE = 121, // 0x00000079
    IAT_CRAFT_CP = 122, // 0x0000007A
    IAT_CRAFT_MAXCP_DOWN = 123, // 0x0000007B
    IAT_CRAFT_ACCIDENTRATE_DOWN = 124, // 0x0000007C
    IAT_CRAFT_FAILRATE_DOWN = 125, // 0x0000007D
    IAT_REINFORCE_VALUE = 126, // 0x0000007E
    IAT_REINFORCE_SUCCESS_RATE = 127, // 0x0000007F
    IAT_REINFORCE_FAIL_RATE = 128, // 0x00000080
    IAT_TOOL_USE_COUNT = 129, // 0x00000081
    IAT_MELEE_ATTACK_FORCE_2S = 130, // 0x00000082
    IAT_MAGIC_ATTACK_FORCE_2S = 131, // 0x00000083
    IAT_RANGE_ATTACK_FORCE_2S = 132, // 0x00000084
    IAT_ALL_ATTACK_FORCE_2S = 133, // 0x00000085
    IAT_PHYSICAL_DEFENCE_2S = 134, // 0x00000086
    IAT_MAGIC_DEFENCE_2S = 135, // 0x00000087
    IAT_ALL_DEFENCE_2S = 136, // 0x00000088
    IAT_PET_COMBINATION_ITEM_ID = 137, // 0x00000089
    IAT_BP_BONUS_RATE = 138, // 0x0000008A
    IAT_FAKED_BATTLE_RANK = 139, // 0x0000008B
    IAT_LIMIT_MAX_RANK = 140, // 0x0000008C
    IAT_PET_REBIRTH_USE_LEVEL = 141, // 0x0000008D
    IAT_ITEM_PIECE = 142, // 0x0000008E
    IAT_ENCHANT_STONE_SUCCESS_RATE = 143, // 0x0000008F
    IAT_PERIOD = 144, // 0x00000090
    IAT_PERIOD_TICKET = 145, // 0x00000091
    IAT_DURABILITY = 146, // 0x00000092
    IAT_REPAIR = 147, // 0x00000093
    IAT_REPAIRPRICE = 148, // 0x00000094
    IAT_PRICE_BY_IP = 149, // 0x00000095
    IAT_CHR_SPEED = 150, // 0x00000096
    IAT_ITEM_NOTTRADE = 151, // 0x00000097
    IAT_PRICE_BY_BADGES = 158, // 0x0000009E
  }
}