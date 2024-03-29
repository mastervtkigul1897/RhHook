﻿// Decompiled with JetBrains decompiler
// Type: RhHook.Data.ECHARACTERABILITY
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

namespace RhHook.Data
{
  public enum ECHARACTERABILITY
  {
    CA_ABILITY_START = 0,
    CA_BASE_START = 0,
    CA_STRENGTH = 0,
    CA_HEALTH = 1,
    CA_INTELLIGENCE = 2,
    CA_DEXTERITY = 3,
    CA_MENTALITY = 4,
    CA_BASE_END = 5,
    CA_QUICKNESS = 5,
    CA_MELEE_ATTACK_FORCE = 6,
    CA_MISSILE_ATTACK_FORCE = 7,
    CA_MAGIC_ATTACK_FORCE = 8,
    CA_PHYSICS_DEFENCE = 9,
    CA_MAGIC_DEFENCE = 10, // 0x0000000A
    CA_HIT_RATE = 11, // 0x0000000B
    CA_ESCAPE_RATE = 12, // 0x0000000C
    CA_MAX_LIFE = 13, // 0x0000000D
    CA_LIFE_RECOVERY = 14, // 0x0000000E
    CA_MAX_MANA = 15, // 0x0000000F
    CA_MANA_RECOVERY = 16, // 0x00000010
    CA_RESISTANCE = 17, // 0x00000011
    CA_MOVE_SPEED = 18, // 0x00000012
    CA_ATTACK_SPEED = 19, // 0x00000013
    CA_ABILITY_END = 20, // 0x00000014
    CA_MAX_WEIGHT = 20, // 0x00000014
    CA_LEVEL = 21, // 0x00000015
    CA_REMAINED_SKILL_POINT = 22, // 0x00000016
    CA_REMAINED_POINT = 23, // 0x00000017
    CA_FACE = 24, // 0x00000018
    CA_HAIR = 25, // 0x00000019
    CA_LOGIN_COUNT = 26, // 0x0000001A
    CA_ATTACK_RANGE = 27, // 0x0000001B
    CA_MISS_RATE = 28, // 0x0000001C
    CA_CRITICAL_RATE = 29, // 0x0000001D
    CA_CRITICAL_FACTOR = 30, // 0x0000001E
    CA_BLOCK_PROBABILITY = 31, // 0x0000001F
    CA_CAL_MELEE_ATTACK_FORCE = 32, // 0x00000020
    CA_CAL_MISSILE_ATTACK_FORCE = 33, // 0x00000021
    CA_CAL_MAGIC_ATTACK_FORCE = 34, // 0x00000022
    CA_CAL_PHYSICS_DEFENCE = 35, // 0x00000023
    CA_CAL_MAGIC_DEFENCE = 36, // 0x00000024
    CA_LIFE_DRAIN_RATE = 37, // 0x00000025
    CA_MANA_DRAIN_RATE = 38, // 0x00000026
    CA_POTION_RECOVERY_RATE = 39, // 0x00000027
    CA_ATTACK_NULL_PROBABILITY = 40, // 0x00000028
    CA_PHYSICS_ATTACK_NULL = 41, // 0x00000029
    CA_PARRY_PROBABILITY = 42, // 0x0000002A
    CA_DAMAGE_RATE = 43, // 0x0000002B
    CA_NOT_USE_ARROW_PROBABILITY = 44, // 0x0000002C
    CA_HEAL_RECOVERY_RATE = 45, // 0x0000002D
    CA_SKILL_SAVING_MANA = 46, // 0x0000002E
    CA_RESISTANCE_BLAZING = 47, // 0x0000002F
    CA_RESISTANCE_FROZEN = 48, // 0x00000030
    CA_RESISTANCE_DARKNESS = 49, // 0x00000031
    CA_RESISTANCE_DIVINE = 50, // 0x00000032
    CA_DART_ATTACK_FORCE = 51, // 0x00000033
    CA_AXE_ATTACK_FORCE = 52, // 0x00000034
    CA_SKILL_MANA_DEC_RATE = 53, // 0x00000035
    CA_MAGICS_ATTACK_NULL = 54, // 0x00000036
    CA_LIFE_DRAIN_BONUS = 55, // 0x00000037
    CA_LIFE_DRAIN_RATE_OTHER = 56, // 0x00000038
    CA_LIFE_DRAIN_BONUS_OTHER = 57, // 0x00000039
    CA_DAMAGE_REFLECTION_RATE = 58, // 0x0000003A
    CA_LEVEL_DAMAGE_REDUCTION_RATE = 59, // 0x0000003B
    CA_RECORVERY_HP_BY_DAMAGE = 60, // 0x0000003C
    CA_RECORVERY_MP_BY_DAMAGE = 61, // 0x0000003D
    CA_RECORVERY_HP_BY_DAMAGE_SUCCESS_RATE = 62, // 0x0000003E
    CA_RECORVERY_MP_BY_DAMAGE_SUCCESS_RATE = 63, // 0x0000003F
    CA_RESIST_STUN_RATE = 64, // 0x00000040
    CA_RESIST_POISON_RATE = 65, // 0x00000041
    CA_CRITICAL_DAMAGE_REDUCTION = 66, // 0x00000042
    CA_DAMAGE_REFLECTION_VALUE = 67, // 0x00000043
    CA_FIXED_EXP_MONSTER = 68, // 0x00000044
    CA_DROPLOOP_COUNT = 69, // 0x00000045
    CA_RESIST_SLEEP_RATE = 70, // 0x00000046
    CA_RESIST_ABSORPTION_RATE = 71, // 0x00000047
    CA_RESIST_CONFUSION_RATE = 72, // 0x00000048
    CA_RESIST_DISPEL_RATE = 73, // 0x00000049
    CA_RESIST_DOT_RATE = 74, // 0x0000004A
    CA_RESIST_ETC_RATE = 75, // 0x0000004B
    CA_RESIST_KNOCKBACK_RATE = 76, // 0x0000004C
    CA_RESIST_PARALYZE_RATE = 77, // 0x0000004D
    CA_RESIST_ROOT_RATE = 78, // 0x0000004E
    CA_RESIST_SLOW_RATE = 79, // 0x0000004F
    CA_RESIST_SNARE_RATE = 80, // 0x00000050
    CA_RESIST_STATUS_RATE = 81, // 0x00000051
    CA_RESIST_TAUNT_RATE = 82, // 0x00000052
    CA_RESIST_PHYSICAL_DAMAGE_RATE = 83, // 0x00000053
    CA_RESIST_MAGICAL_DAMAGE_RATE = 84, // 0x00000054
    CA_ABILITY_COL_START = 85, // 0x00000055
    CA_ABILITY_EXT_START = 85, // 0x00000055
    CA_COL_EXP_RATE = 85, // 0x00000055
    CA_COL_SPEED = 86, // 0x00000056
    CA_COL_SHOW_RES = 87, // 0x00000057
    CA_COL_ADD_RARE_RATE = 88, // 0x00000058
    CA_ABILITY_COL_END = 89, // 0x00000059
    CA_COL_ADD_NUM_RATE = 89, // 0x00000059
    CA_ABILITY_CRAFT_START = 90, // 0x0000005A
    CA_CRAFT_CP = 90, // 0x0000005A
    CA_CRAFT_MAXCP_DOWN = 91, // 0x0000005B
    CA_CRAFT_ACCIDENTRATE_DOWN = 92, // 0x0000005C
    CA_ABILITY_CRAFT_END = 93, // 0x0000005D
    CA_ABILITY_EXT_END = 93, // 0x0000005D
    CA_CRAFT_FAILRATE_DOWN = 93, // 0x0000005D
    CA_DETECT_RANGE = 94, // 0x0000005E
    CA_DAMAGE_RECOVERY_RATE = 95, // 0x0000005F
    CA_DECREASE_PHYSICS_DEFENCE = 96, // 0x00000060
    CA_DECREASE_MAGIC_DEFENCE = 97, // 0x00000061
    CA_DECREASE_SKILL_DAMAGE_RATE = 98, // 0x00000062
    CA_DONT_MOVE_CONDITION_REDUCE_RATE = 99, // 0x00000063
    CA_MAX_DAMAGE = 100, // 0x00000064
    CA_CONQUERORLEVEL = 101, // 0x00000065
    CA_PRODUCT_L_PLUS_RATE = 102, // 0x00000066
    CA_PRODUCT_M_PLUS_RATE = 103, // 0x00000067
    CA_PRODUCT_H_PLUS_RATE = 104, // 0x00000068
    CA_PRODUCT_VH_PLUS_RATE = 105, // 0x00000069
    CA_PENETRATE_DEC_DMG_RATE = 106, // 0x0000006A
    CA_INC_CRITICAL_DMG_RATE = 107, // 0x0000006B
    CA_PENETRATE_DEF_RATE = 108, // 0x0000006C
    CA_PVP_ATTACK_RATE = 109, // 0x0000006D
    CA_PVP_DEFENCE_RATE = 110, // 0x0000006E
  }
}
