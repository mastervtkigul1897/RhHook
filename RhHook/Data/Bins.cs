// Decompiled with JetBrains decompiler
// Type: RhHook.Data.Bins
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

namespace RhHook.Data
{
  public class Bins
  {
    public static List<Bins._tagROHANATTENDANCE> Attendance = new List<Bins._tagROHANATTENDANCE>();
    public static List<Bins._tagROHANITEMTRADEMALLINFO_New> ItemTradeMall = new List<Bins._tagROHANITEMTRADEMALLINFO_New>();
    public static List<Bins._tagROHANITEMTRADEMALLINFO_New> ItemTradeMallEvent = new List<Bins._tagROHANITEMTRADEMALLINFO_New>();

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct _tagROHANITEMTRADEMALLINFO
    {
      public int m_MallID;
      public int m_ItemID;
      public byte m_Category;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
      public byte[] m_Group;
      public int m_AttributeType;
      public int m_Price;
      public byte m_RandomOption;

      public FieldInfo[] GetFields() => typeof (Bins._tagROHANITEMTRADEMALLINFO).GetFields(BindingFlags.Instance | BindingFlags.Public);
    }

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public class _tagRohanItemArmorInfo
    {
      public int m_Disable;
      public int m_ID;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_Name;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_KoreanName;
      public int m_ItemType;
      public int m_Description;
      public int m_Weight;
      public int m_Price;
      public int m_SellPrice;
      public int m_EquipLevel;
      public int m_BlockRate;
      public int m_Defence;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_ImageName;
      public int m_AttackAni;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_HUMAN_MAN_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_ELF_MAN_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_HALFELF_MAN_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_DAN_MAN_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_GIANT_MAN_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_DARKELF_MAN_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_TRINITY_MER_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_TRINITY_RUMIR_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_DEKAN_MAN_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_HUMAN_WOMAN_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_ELF_WOMAN_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_HALFELF_WOMAN_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_DAN_WOMAN_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_GIANT_WOMAN_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_DARKELF_WOMAN_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_TRINITY_NOIR_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_DEKAN_WOMAN_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_MATERIAL1;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_MATERIAL2;
      public int m_ItemEntity;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_szEquipSound;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_szDropSound;
      public int m_DecoLevel;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
      public int[] m_LevelEnchantPrice;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
      public int[] m_LevelEnchantRate;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
      public int[] m_nOptionType;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
      public int[] m_nOptionValue;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
      public int[] m_nAttributeType;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
      public int[] m_nAttributeValue;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
      public string m_szItemExplain;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_ItemLargeImage;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_szExplainFileName;
      public int m_GuildBankFee;
      public int m_ProductGrade;
      public int m_MaxSocketMask;
      public int m_SetItemID;
      public int m_Durability;
      public int m_Repair;
      public int m_RepairPrice;
      public int m_TranscendenceType;
      public int m_TrinityEnable;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public class _tagRohanItemAccessoryInfo
    {
      public int m_Disable;
      public int m_ID;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_Name;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_KoreanName;
      public int m_ItemType;
      public int m_Description;
      public int m_CostumeSocketCount;
      public int m_Weight;
      public int m_Price;
      public int m_SellPrice;
      public int m_EquipLevel;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_ImageName;
      public int m_ItemEntity;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
      public string m_szItemExplain;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_ItemLargeImage;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_szExplainFileName;
      public int m_GuildBankFee;
      public int m_ItemSpecies;
      public int m_IEF_EquipLevel;
      public int m_IEF_EquipSubLevel;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
      public int[] m_nAttributeType;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
      public int[] m_nAttributeValue;
      public int m_NoRandomOption;
      public int m_SetItemID;
      public int m_Durability;
      public int m_Repair;
      public int m_RepairPrice;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public class _tagRohanItemPotionInfo
    {
      public int m_Disable;
      public int m_ID;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_Name;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_KoreanName;
      public int m_ItemType;
      public int m_Description;
      public int m_Weight;
      public int m_Price;
      public int m_SellPrice;
      public int m_UseLevel;
      public int m_UseMaxLevel;
      public int m_Life;
      public int m_Mana;
      public int m_CoolTime;
      public int m_CureLevel;
      public int m_CureRate;
      public int m_MaxStack;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_ImageName;
      public int m_ItemEntity;
      public string m_szEquipSound;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_szDropSound;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 100)]
      public string m_szExplain;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_szItemLargeImage;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_szExplainFileName;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public class _tagRohanItemEtcInfo
    {
      public int m_Disable;
      public int m_ID;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_Name;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_KoreanName;
      public int m_ItemType;
      public int m_Description;
      public int m_Weight;
      public int m_Price;
      public int m_SellPrice;
      public int m_MaxStack;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
      public int[] m_AttributeType;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
      public int[] m_AttributeValue;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_ImageName;
      public int m_ItemEntity;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_szEquipSound;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_szDropSound;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
      public string m_szItemExplain;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_szItemLargeImage;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_szExplainFileName;
      public int m_ChangeType;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public class _tagRohanItemScrollInfo
    {
      public int m_Disable;
      public int m_ID;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_Name;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_KoreanName;
      public int m_ItemType;
      public int m_Description;
      public int m_Weight;
      public int m_Price;
      public int m_SellPrice;
      public int m_MaxStack;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
      public int[] m_AttributeType;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
      public int[] m_AttributeValue;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_ImageName;
      public int m_ItemEntity;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_Region;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
      public string m_szExplain;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_szItemLargeImage;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_szExplainFileName;
      public int m_job;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public class _tagROHANITEMQUESTINFO
    {
      public int m_Disable;
      public int m_ID;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_Name;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_KoreanName;
      public int m_ItemType;
      public int m_Description;
      public int m_Weight;
      public int m_Price;
      public int m_SellPrice;
      public int m_MaxStack;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
      public int[] m_AttributeType;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
      public int[] m_AttributeValue;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_ImageName;
      public int m_ItemEntity;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_szEquipSound;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_szDropSound;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
      public string m_szItemExplain;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_szItemLargeImage;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_szExplainFileName;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public class _tagROHANITEMSHIELDINFO
    {
      public int m_Disable;
      public int m_ID;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_Name;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_KoreanName;
      public int m_ItemType;
      public int m_Description;
      public int m_Weight;
      public int m_Price;
      public int m_SellPrice;
      public int m_EquipLevel;
      public int m_BlockRate;
      public int m_Defence;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_ImageName;
      public int m_AttackAni;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_HUMAN_MAN_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_ELF_MAN_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_HALFELF_MAN_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_DAN_MAN_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_GIANT_MAN_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_DARKELF_MAN_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_TRINITY_MER_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_TRINITY_RUMIR_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_DEKAN_MAN_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_HUMAN_WOMAN_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_ELF_WOMAN_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_HALFELF_WOMAN_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_DAN_WOMAN_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_GIANT_WOMAN_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_DARKELF_WOMAN_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_TRINITY_NOIR_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_DEKAN_WOMAN_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_MATERIAL1;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_MATERIAL2;
      public int m_ItemEntity;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_szEquipSound;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_szDropSound;
      public int m_DecoLevel;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
      public int[] m_LevelEnchantPrice;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
      public int[] m_LevelEnchantRate;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
      public int[] m_nOptionType;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
      public int[] m_nOptionValue;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
      public int[] m_nAttributeType;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
      public int[] m_nAttributeValue;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
      public string m_szItemExplain;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_ItemLargeImage;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_szExplainFileName;
      public int m_GuildBankFee;
      public int m_nProductGrade;
      public int m_MaxSocketMask;
      public int m_SetItemID;
      public int m_Durability;
      public bool m_Repair;
      public int m_RepairPrice;
      public int m_TranscendenceType;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public class _tagROHANITEMRESETINFO
    {
      public int m_Disable;
      public int m_ID;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_Name;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_KoreanName;
      public int m_ItemType;
      public int m_Description;
      public int m_Strength;
      public int m_Dexterity;
      public int m_Intelligence;
      public int m_Mentality;
      public int m_Health;
      public int m_Quickness;
      public int m_Weight;
      public int m_Price;
      public int m_SellPrice;
      public int m_MaxStack;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
      public int[] m_AttributeType;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
      public int[] m_AttributeValue;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_ImageName;
      public int m_ItemEntity;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_szEquipSound;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_szDropSound;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
      public string m_szItemExplain;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_szItemLargeImage;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_szExplainFileName;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public class _tagROHANITEMCOSTUMEINFO
    {
      public int m_Disable;
      public int m_ID;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_Name;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_KoreanName;
      public int m_Description;
      public int m_ItemType;
      public int m_SocketCount;
      public int m_Weight;
      public int m_Price;
      public int m_SellPrice;
      public int m_MaxStack;
      public int m_IEF_EquipLevel;
      public int m_IEF_EquipSubLevel;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
      public int[] m_AttributeType;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
      public int[] m_AttributeValue;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_ImageName;
      public int m_ItemEntity;
      public int m_ItemSpecies;
      public int m_DanceType;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_EffectType;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_szDropSound;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
      public string m_szItemExplain;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_szItemLargeImage;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_szExplainFileName;
      public bool m_bHairMaintain;
      public int m_SetItemID;
      public int m_Durability;
      public bool m_Repair;
      public int m_RepairPrice;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public class _tagRohanItemCharmInfo
    {
      public int m_Disable;
      public int m_ID;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_Name;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_KoreanName;
      public int m_ItemType;
      public int m_Description;
      public int m_Weight;
      public int m_Price;
      public int m_SellPrice;
      public int m_MaxStack;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
      public int[] m_AttributeType;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
      public int[] m_AttributeValue;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_ImageName;
      public int m_ItemEntity;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_szEquipSound;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_szDropSound;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
      public string m_szItemExplain;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_szItemLargeImage;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_szExplainFileName;
      public int m_nSubType;
      public int m_UseMinLevel;
      public int m_UseMaxLevel;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public class _tagRohanItemRecipeInfo
    {
      public int m_Disable;
      public int m_ID;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_Name;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_KoreanName;
      public int m_ItemType;
      public int m_Description;
      public int m_Weight;
      public int m_Price;
      public int m_SellPrice;
      public int m_MaxStack;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
      public int[] m_AttributeType;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
      public int[] m_AttributeValue;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_ImageName;
      public int m_ItemEntity;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_szEquipSound;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_szDropSound;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
      public string m_szItemExplain;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_szItemLargeImage;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_szExplainFileName;
      public int m_CraftSkill;
      public int m_LeanLevel;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public class _tagRohanItemSocketInfo
    {
      public int m_Disable;
      public int m_ID;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_Name;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_KoreanName;
      public int m_ItemType;
      public int m_CostumeOptionType;
      public int m_Description;
      public int m_Weight;
      public int m_Price;
      public int m_SellPrice;
      public int m_MaxStack;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
      public int[] m_nOptionType;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
      public int[] m_nOptionValue;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
      public int[] m_AttributeType;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
      public int[] m_AttributeValue;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_ImageName;
      public int m_ItemEntity;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_szEquipSound;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_szDropSound;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
      public string m_szItemExplain;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_szItemLargeImage;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_szExplainFileName;
      public int m_SocketGrade;
      public int m_SocketDuration;
      public int m_SocketSuccessRate;
      public int m_SocketBrokenRate;
      public int m_SocketType;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public class _tagROHAN_ITEM_OPTION
    {
      public int bDisable;
      public int nId;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string Name;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string KoreanName;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string ImageName;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string DropSound;
      public int nDescription;
      public int nItemType;
      public int nWeight;
      public int nPrice;
      public int m_SellPrice;
      public int nMaxStack;
      public int nItemEntity;
      public int nLevelMin;
      public int nLevelMax;
      public int nOption1Type;
      public int nOption1MinRate;
      public int nOption1MaxRate;
      public int nOption2Type;
      public int nOption2MinRate;
      public int nOption2MaxRate;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 100)]
      public string m_szExplain;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_szItemLargeImage;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_szExplainFileName;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct _tagItemWeaponInfo
    {
      public int m_Disable;
      public int m_ID;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
      public byte[] m_Name;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
      public byte[] m_KoreanName;
      public int m_ItemType;
      public int m_Description;
      public int m_Weight;
      public int m_Price;
      public int m_SellPrice;
      public int m_EquipLevel;
      public int m_Damage;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
      public int[] m_DamageEnchant;
      public int m_AttackSpeed;
      public int m_AttackRange;
      public int m_Miss;
      public int m_Critical;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
      public byte[] m_ImageName;
      public int m_AttackAni;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
      public byte[] m_HUMAN_MAN_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
      public byte[] m_HUMAN_MAN_EQUIP_MESH_CHANGE;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
      public byte[] m_ELF_MAN_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
      public byte[] m_HALFELF_MAN_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
      public byte[] m_DAN_MAN_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
      public byte[] m_GIANT_MAN_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
      public byte[] m_DARKELF_MAN_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
      public byte[] m_HALFLING_MAN_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
      public byte[] m_DEKAN_MAN_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
      public byte[] m_DEKAN_MAN_EQUIP_MESH_CHANGE;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
      public byte[] m_HUMAN_WOMAN_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
      public byte[] m_HUMAN_WOMAN_EQUIP_MESH_CHANGE;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
      public byte[] m_ELF_WOMAN_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
      public byte[] m_HALFELF_WOMAN_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
      public byte[] m_DAN_WOMAN_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
      public byte[] m_GIANT_WOMAN_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
      public byte[] m_DARKELF_WOMAN_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
      public byte[] m_HALFLING_WOMAN_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
      public byte[] m_DEKAN_WOMAN_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
      public byte[] m_DEKAN_WOMAN_EQUIP_MESH_CHANGE;
      public int m_ItemEntity;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
      public byte[] m_szEquipSound;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
      public byte[] m_szDropSound;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
      public int[] m_LevelEnchantPrice;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
      public int[] m_LevelEnchantRate;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
      public int[] m_nOptionType;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
      public int[] m_nOptionValue;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
      public int[] m_nAttributeType;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
      public int[] m_nAttributeValue;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
      public byte[] m_ItemExplain;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
      public byte[] m_szItemLargeImage;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
      public byte[] m_szExplainFileName;
      public int m_GuildBankFee;
      public int m_ProductGrade;
      public int m_MaxSocketMask;
      public int m_SetItemID;
      public int m_Durability;
      public byte m_Repair;
      public int m_RepairPrice;
      public int m_Sprit_Weapon_Level;
      public int m_Evolution;
      public long m_Growth_Exp;
      public int m_Growth_Weapon;
      public long m_Material_Exp;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
      public byte[] m_RUMIR_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
      public byte[] m_NOIR_EQUIP_MESH;
      public int m_TranscendenceType;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public class _tagItemRidingInfo
    {
      public int bDisable;
      public int nID;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string szName;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string szKoreanName;
      public int nItemType;
      public int nItemEntity;
      public int nDescription;
      public int nPlayerRace;
      public int nSpeed;
      public int nPrice;
      public int nSellPrice;
      public int nMaxStack;
      public int nWeight;
      public int nCastingTime;
      public int nEquipLevel;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string szEquipSound;
      public int nDecoLevel;
      public int bIgnoreCritical;
      public int bDungeon;
      public int bSafeZone;
      public int nTimerType;
      public int nTimerValue;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string szImageName;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
      public string szItemExplain;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string szItemLargeImage;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string szExplainFileName;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public class _tagItemPetInfo
    {
      public int bDisable;
      public int nID;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string szName;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string szKoreanName;
      public int nItemType;
      public int nItemEntity;
      public int nDescription;
      public int nKind;
      public int nLevel;
      public int nLevel1;
      public int nLevel2;
      public int nLevel3;
      public int nLv1Model;
      public int nLv2Model;
      public int nLv3Model;
      public int nFeedCount1;
      public int nFeedCount2;
      public int nPrice;
      public int nSellPrice;
      public int nMaxStack;
      public int nWeight;
      public int nHungryTime;
      public int nMaxHungryCount;
      public int nMaxWeightRate1;
      public int nMaxWeightRate2;
      public int nMaxWeightRate3;
      public int nLevel1_ExpValue1;
      public int nLevel1_ExpValue2;
      public int nLevel1_ExpValue3;
      public int nLevel1_ExpValue4;
      public int nLevel2_ExpValue1;
      public int nLevel2_ExpValue2;
      public int nLevel2_ExpValue3;
      public int nLevel2_ExpValue4;
      public int nLevel3_ExpValue1;
      public int nLevel3_ExpValue2;
      public int nLevel3_ExpValue3;
      public int nLevel3_ExpValue4;
      public int nTimerType;
      public int nTimerValue;
      public int nRestoration;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string szImageName;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string szItemLargeImage;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string szImageName2;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string szItemLargeImage2;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string szImageName3;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string szItemLargeImage3;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
      public string szItemExplain;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string szExplainFileName;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public class _tagItemFishInfo
    {
      public int bDisable;
      public int nID;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string szName;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string szKoreanName;
      public int m_Weight;
      public int m_Price;
      public int m_SellPrice;
      public int nItemType;
      public int nItemEntity;
      public int nDescription;
      public int nRewardGrade;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string szImageName;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
      public string szItemExplain;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public class _tagItemBuffScrollInfo
    {
      public int bDisable;
      public int nID;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string szKoreanName;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string szEnglishName;
      public int nItemType;
      public int nItemEntity;
      public int nDescription;
      public int nPrice;
      public int nSellPrice;
      public int nWeight;
      public int nEquipLevel;
      public int bAttitudeOn;
      public int nMaxStack;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string szImageName;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
      public string szItemExplain;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string szItemLargeImage;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string szExplainFileName;
      public int nDecoLevel;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
      public int[] nAttributeType;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
      public int[] nAttributeValue;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
      public ushort[] dwSkillKind;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
      public int[] nSkillLevel;
      public int nUseMinLevel;
      public int nUseMaxLevel;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct _tagROHANITEMETCDETAILSINFO
    {
      public int m_ID;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
      public byte[] m_EtcItemName;
      public int m_EtcItemID;
      public int m_GetExp;
      public int m_MoneyType;
      public int m_GetMoney;
      public int m_GetItemCountMax;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
      public int[] m_GetItem;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
      public int[] m_GetItemCount;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
      public int[] m_GetItemRate;
      public ushort m_UseSkillKind;
      public byte m_UseSkillLevel;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 200)]
      public byte[] m_UseSkillExplain;
      public ushort m_CheckSkillKind;
      public byte m_CheckSkillLevel;
      public int m_RunQuestID;
      public int m_ItemMaxUseCount;
      public int m_ItemReuseTime;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
      public int[] m_ItemEtcKeyItem;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct _tagROHANATTENDANCE : iStructure
    {
      public int m_ID;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)]
      public int[] m_Days_GetItem;

      public FieldInfo[] GetFields() => typeof (Bins._tagROHANATTENDANCE).GetFields(BindingFlags.Instance | BindingFlags.Public);
    }

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public class _tagRohanItemArmorInfo_New
    {
      public int m_Disable;
      public int m_ID;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_Name;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_KoreanName;
      public int m_ItemType;
      public int m_Description;
      public int m_Weight;
      public int m_Price;
      public int m_SellPrice;
      public int m_EquipLevel;
      public int m_BlockRate;
      public int m_Defence;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_ImageName;
      public int m_AttackAni;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_HUMAN_MAN_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_ELF_MAN_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_HALFELF_MAN_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_DAN_MAN_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_GIANT_MAN_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_DARKELF_MAN_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_TRINITY_MER_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_TRINITY_RUMIR_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_DEKAN_MAN_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_HUMAN_WOMAN_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_ELF_WOMAN_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_HALFELF_WOMAN_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_DAN_WOMAN_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_GIANT_WOMAN_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_DARKELF_WOMAN_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_TRINITY_NOIR_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_DEKAN_WOMAN_EQUIP_MESH;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_MATERIAL1;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_MATERIAL2;
      public int m_ItemEntity;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_szEquipSound;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_szDropSound;
      public int m_DecoLevel;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
      public int[] m_LevelEnchantPrice;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
      public int[] m_LevelEnchantRate;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
      public int[] m_nOptionType;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
      public int[] m_nOptionValue;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
      public int[] m_nAttributeType;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
      public int[] m_nAttributeValue;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
      public string m_szItemExplain;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_ItemLargeImage;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_szExplainFileName;
      public int m_GuildBankFee;
      public int m_ProductGrade;
      public int m_MaxSocketMask;
      public int m_SetItemID;
      public int m_Durability;
      public int m_Repair;
      public int m_RepairPrice;
      public int m_TranscendenceType;
      public int m_TrinityEnable;
      public int m_OptionGroup;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct _tagROHANITEMTRADEMALLINFO_New
    {
      public int m_MallID;
      public int m_ItemID;
      public byte m_Category;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
      public byte[] m_Group;
      public int m_AttributeType;
      public long m_Price;
      public int m_AttributeType2;
      public int padding;
      public long Price2;
      public byte m_RandomOption;
      public int padding2;

      public FieldInfo[] GetFields() => typeof (Bins._tagROHANITEMTRADEMALLINFO_New).GetFields(BindingFlags.Instance | BindingFlags.Public);
    }

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public class _tagRohanItemCharmInfo_new
    {
      public int m_Disable;
      public int m_ID;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_Name;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_KoreanName;
      public int m_ItemType;
      public int m_Description;
      public int m_Weight;
      public int m_Price;
      public int m_SellPrice;
      public int m_MaxStack;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
      public int[] m_AttributeType;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
      public int[] m_AttributeValue;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_ImageName;
      public int m_ItemEntity;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_szEquipSound;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_szDropSound;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
      public string m_szItemExplain;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_szItemLargeImage;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
      public string m_szExplainFileName;
      public int m_nSubType;
      public int m_UseMinLevel;
      public int m_UseMaxLevel;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct _tagROHANITEMETCDETAILSINFO_new
    {
      public int m_ID;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
      public byte[] m_EtcItemName;
      public int m_EtcItemID;
      public long m_GetExp;
      public int m_MoneyType;
      public int m_GetMoney;
      public int m_GetItemCountMax;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
      public int[] m_GetItem;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
      public int[] m_GetItemCount;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
      public int[] m_GetItemRate;
      public ushort m_UseSkillKind;
      public byte m_UseSkillLevel;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 200)]
      public byte[] m_UseSkillExplain;
      public ushort m_CheckSkillKind;
      public byte m_CheckSkillLevel;
      public int m_RunQuestID;
      public int m_ItemMaxUseCount;
      public int m_ItemReuseTime;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
      public int[] m_ItemEtcKeyItem;
    }
  }
}
