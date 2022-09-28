// Decompiled with JetBrains decompiler
// Type: RhHook.DetouredFunctions.CEpochItemScriptManager
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using Detours;
using RhHook.Data;
using RhHook.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

namespace RhHook.DetouredFunctions
{
  internal class CEpochItemScriptManager
  {
    public static readonly CEpochItemScriptManager.DGeneric TradeItemMallFileCopy = new CEpochItemScriptManager.DGeneric(CEpochItemScriptManager.DetouredTradeItemMallFileCopy);
    public static readonly CEpochItemScriptManager.DGeneric ItemAccessoryFileCopy = new CEpochItemScriptManager.DGeneric(CEpochItemScriptManager.DetouredItemAccessoryFileCopy);
    public static readonly CEpochItemScriptManager.DGeneric ItemArmorFileCopy = new CEpochItemScriptManager.DGeneric(CEpochItemScriptManager.DetouredItemArmorFileCopy);
    public static readonly CEpochItemScriptManager.DGeneric ItemBuffScrollFileCopy = new CEpochItemScriptManager.DGeneric(CEpochItemScriptManager.DetouredItemBuffScrollFileCopy);
    public static readonly CEpochItemScriptManager.DGeneric ItemCharmFileCopy = new CEpochItemScriptManager.DGeneric(CEpochItemScriptManager.DetouredItemCharmFileCopy);
    public static readonly CEpochItemScriptManager.DGeneric ItemCostumeFileCopy = new CEpochItemScriptManager.DGeneric(CEpochItemScriptManager.DetouredItemCostumeFileCopy);
    public static readonly CEpochItemScriptManager.DGeneric ItemEtcFileCopy = new CEpochItemScriptManager.DGeneric(CEpochItemScriptManager.DetouredItemEtcFileCopy);
    public static readonly CEpochItemScriptManager.DGeneric ItemEtcDetailsFileCopy = new CEpochItemScriptManager.DGeneric(CEpochItemScriptManager.DetouredItemEtcDetailsFileCopy);
    public static readonly CEpochItemScriptManager.DGeneric ItemFishFileCopy = new CEpochItemScriptManager.DGeneric(CEpochItemScriptManager.DetouredItemFishFileCopy);
    public static readonly CEpochItemScriptManager.DGeneric ItemOptionFileCopy = new CEpochItemScriptManager.DGeneric(CEpochItemScriptManager.DetouredItemOptionFileCopy);
    public static readonly CEpochItemScriptManager.DGeneric ItemPetFileCopy = new CEpochItemScriptManager.DGeneric(CEpochItemScriptManager.DetouredItemPetFileCopy);
    public static readonly CEpochItemScriptManager.DGeneric ItemPotionFileCopy = new CEpochItemScriptManager.DGeneric(CEpochItemScriptManager.DetouredItemPotionFileCopy);
    public static readonly CEpochItemScriptManager.DGeneric ItemQuestFileCopy = new CEpochItemScriptManager.DGeneric(CEpochItemScriptManager.DetouredItemQuestFileCopy);
    public static readonly CEpochItemScriptManager.DGeneric ItemRecipeFileCopy = new CEpochItemScriptManager.DGeneric(CEpochItemScriptManager.DetouredItemRecipeFileCopy);
    public static readonly CEpochItemScriptManager.DGeneric ItemResetFileCopy = new CEpochItemScriptManager.DGeneric(CEpochItemScriptManager.DetouredItemResetFileCopy);
    public static readonly CEpochItemScriptManager.DGeneric ItemRidingFileCopy = new CEpochItemScriptManager.DGeneric(CEpochItemScriptManager.DetouredItemRidingFileCopy);
    public static readonly CEpochItemScriptManager.DGeneric ItemScrollFileCopy = new CEpochItemScriptManager.DGeneric(CEpochItemScriptManager.DetouredItemScrollFileCopy);
    public static readonly CEpochItemScriptManager.DGeneric ItemShieldFileCopy = new CEpochItemScriptManager.DGeneric(CEpochItemScriptManager.DetouredItemShieldFileCopy);
    public static readonly CEpochItemScriptManager.DGeneric ItemSocketFileCopy = new CEpochItemScriptManager.DGeneric(CEpochItemScriptManager.DetouredItemSocketFileCopy);
    public static readonly CEpochItemScriptManager.DGeneric ItemWeaponFileCopy = new CEpochItemScriptManager.DGeneric(CEpochItemScriptManager.DetouredItemWeaponFileCopy);
    public static readonly RhHook.Util.FunctionInfo[] FunctionInfo = new RhHook.Util.FunctionInfo[16]
    {
      new RhHook.Util.FunctionInfo((IntPtr) 7208560, "CEpochItemScriptManager::TradeItemMallFileCopy", (Delegate) CEpochItemScriptManager.TradeItemMallFileCopy, (Delegate) CEpochItemScriptManager.Generic, typeof (CEpochItemScriptManager.DGeneric)),
      new RhHook.Util.FunctionInfo((IntPtr) 6826352, "CEpochItemScriptManager::ItemAccessoryFileCopy", (Delegate) CEpochItemScriptManager.ItemAccessoryFileCopy, (Delegate) CEpochItemScriptManager.Generic, typeof (CEpochItemScriptManager.DGeneric)),
      new RhHook.Util.FunctionInfo((IntPtr) 6815056, "CEpochItemScriptManager::ItemArmorFileCopy", (Delegate) CEpochItemScriptManager.ItemArmorFileCopy, (Delegate) CEpochItemScriptManager.Generic, typeof (CEpochItemScriptManager.DGeneric)),
      new RhHook.Util.FunctionInfo((IntPtr) 6843312, "CEpochItemScriptManager::ItemBuffScrollFileCopy", (Delegate) CEpochItemScriptManager.ItemBuffScrollFileCopy, (Delegate) CEpochItemScriptManager.Generic, typeof (CEpochItemScriptManager.DGeneric)),
      new RhHook.Util.FunctionInfo((IntPtr) 6844304, "CEpochItemScriptManager::ItemCharmFileCopy", (Delegate) CEpochItemScriptManager.ItemCharmFileCopy, (Delegate) CEpochItemScriptManager.Generic, typeof (CEpochItemScriptManager.DGeneric)),
      new RhHook.Util.FunctionInfo((IntPtr) 6841760, "CEpochItemScriptManager::ItemCostumeFileCopy", (Delegate) CEpochItemScriptManager.ItemCostumeFileCopy, (Delegate) CEpochItemScriptManager.Generic, typeof (CEpochItemScriptManager.DGeneric)),
      new RhHook.Util.FunctionInfo((IntPtr) 6828768, "CEpochItemScriptManager::ItemEtcFileCopy", (Delegate) CEpochItemScriptManager.ItemEtcFileCopy, (Delegate) CEpochItemScriptManager.Generic, typeof (CEpochItemScriptManager.DGeneric)),
      new RhHook.Util.FunctionInfo((IntPtr) 6830000, "CEpochItemScriptManager::ItemEtcDetailsFileCopy", (Delegate) CEpochItemScriptManager.ItemEtcDetailsFileCopy, (Delegate) CEpochItemScriptManager.Generic, typeof (CEpochItemScriptManager.DGeneric)),
      new RhHook.Util.FunctionInfo((IntPtr) 6832992, "CEpochItemScriptManager::ItemOptionFileCopy", (Delegate) CEpochItemScriptManager.ItemOptionFileCopy, (Delegate) CEpochItemScriptManager.Generic, typeof (CEpochItemScriptManager.DGeneric)),
      new RhHook.Util.FunctionInfo((IntPtr) 6838800, "CEpochItemScriptManager::ItemPetFileCopy", (Delegate) CEpochItemScriptManager.ItemPetFileCopy, (Delegate) CEpochItemScriptManager.Generic, typeof (CEpochItemScriptManager.DGeneric)),
      new RhHook.Util.FunctionInfo((IntPtr) 6833984, "CEpochItemScriptManager::ItemQuestFileCopy", (Delegate) CEpochItemScriptManager.ItemQuestFileCopy, (Delegate) CEpochItemScriptManager.Generic, typeof (CEpochItemScriptManager.DGeneric)),
      new RhHook.Util.FunctionInfo((IntPtr) 6837264, "CEpochItemScriptManager::ItemResetFileCopy", (Delegate) CEpochItemScriptManager.ItemResetFileCopy, (Delegate) CEpochItemScriptManager.Generic, typeof (CEpochItemScriptManager.DGeneric)),
      new RhHook.Util.FunctionInfo((IntPtr) 6836240, "CEpochItemScriptManager::ItemRidingFileCopy", (Delegate) CEpochItemScriptManager.ItemRidingFileCopy, (Delegate) CEpochItemScriptManager.Generic, typeof (CEpochItemScriptManager.DGeneric)),
      new RhHook.Util.FunctionInfo((IntPtr) 6820560, "CEpochItemScriptManager::ItemShieldFileCopy", (Delegate) CEpochItemScriptManager.ItemShieldFileCopy, (Delegate) CEpochItemScriptManager.Generic, typeof (CEpochItemScriptManager.DGeneric)),
      new RhHook.Util.FunctionInfo((IntPtr) 6847392, "CEpochItemScriptManager::ItemSocketFileCopy", (Delegate) CEpochItemScriptManager.ItemSocketFileCopy, (Delegate) CEpochItemScriptManager.Generic, typeof (CEpochItemScriptManager.DGeneric)),
      new RhHook.Util.FunctionInfo((IntPtr) 6808544, "CEpochItemScriptManager::ItemWeaponFileCopy", (Delegate) CEpochItemScriptManager.ItemWeaponFileCopy, (Delegate) CEpochItemScriptManager.Generic, typeof (CEpochItemScriptManager.DGeneric))
    };

    [HandleProcessCorruptedStateExceptions]
    private static void DetouredTradeItemMallFileCopy(IntPtr @this, IntPtr pInfo)
    {
      try
      {
        Bins._tagROHANITEMTRADEMALLINFO_New structure = (Bins._tagROHANITEMTRADEMALLINFO_New) Marshal.PtrToStructure(pInfo, typeof (Bins._tagROHANITEMTRADEMALLINFO_New));
        Bins.ItemTradeMall.Add(structure);
        Bins._tagROHANITEMTRADEMALLINFO rohanitemtrademallinfo = new Bins._tagROHANITEMTRADEMALLINFO()
        {
          m_MallID = structure.m_MallID,
          m_ItemID = structure.m_ItemID,
          m_Category = structure.m_Category,
          m_Group = structure.m_Group,
          m_AttributeType = structure.m_AttributeType,
          m_Price = (int) structure.m_Price,
          m_RandomOption = structure.m_RandomOption
        };
        Marshal.Copy(Misc.getBytes((object) rohanitemtrademallinfo), 0, pInfo, Marshal.SizeOf((object) rohanitemtrademallinfo));
        ((Dictionary<string, Hook>) Hooks.Manager)["CEpochItemScriptManager::TradeItemMallFileCopy"].CallOriginal(new object[2]
        {
          (object) @this,
          (object) pInfo
        });
      }
      catch (Exception ex)
      {
        Log.LogError(ex, "CEpochItemScriptManager.TradeItemMallFileCopy");
      }
    }

    [HandleProcessCorruptedStateExceptions]
    private static void DetouredItemAccessoryFileCopy(IntPtr @this, IntPtr pInfo)
    {
      try
      {
        Bins._tagRohanItemAccessoryInfo structure = (Bins._tagRohanItemAccessoryInfo) Marshal.PtrToStructure(pInfo, typeof (Bins._tagRohanItemAccessoryInfo));
        if (structure.m_ItemType >= 183)
          structure.m_ItemType -= 6;
        Marshal.Copy(Misc.getBytes((object) structure), 0, pInfo, Marshal.SizeOf((object) structure));
        ((Dictionary<string, Hook>) Hooks.Manager)["CEpochItemScriptManager::ItemAccessoryFileCopy"].CallOriginal(new object[2]
        {
          (object) @this,
          (object) pInfo
        });
      }
      catch (Exception ex)
      {
        Log.LogError(ex, "CEpochItemScriptManager.ItemAccessoryFileCopy");
      }
    }

    [HandleProcessCorruptedStateExceptions]
    private static void DetouredItemArmorFileCopy(IntPtr @this, IntPtr pInfo)
    {
      try
      {
        Bins._tagRohanItemArmorInfo structure = (Bins._tagRohanItemArmorInfo) Marshal.PtrToStructure(pInfo, typeof (Bins._tagRohanItemArmorInfo));
        if (structure.m_ItemType >= 183)
          structure.m_ItemType -= 6;
        Marshal.Copy(Misc.getBytes((object) structure), 0, pInfo, Marshal.SizeOf((object) structure));
        ((Dictionary<string, Hook>) Hooks.Manager)["CEpochItemScriptManager::ItemArmorFileCopy"].CallOriginal(new object[2]
        {
          (object) @this,
          (object) pInfo
        });
      }
      catch (Exception ex)
      {
        Log.LogError(ex, "CEpochItemScriptManager.ItemArmorFileCopy");
      }
    }

    [HandleProcessCorruptedStateExceptions]
    private static void DetouredItemBuffScrollFileCopy(IntPtr @this, IntPtr pInfo)
    {
      try
      {
        Bins._tagItemBuffScrollInfo structure = (Bins._tagItemBuffScrollInfo) Marshal.PtrToStructure(pInfo, typeof (Bins._tagItemBuffScrollInfo));
        if (structure.nItemType >= 183)
          structure.nItemType -= 6;
        Marshal.Copy(Misc.getBytes((object) structure), 0, pInfo, Marshal.SizeOf((object) structure));
        ((Dictionary<string, Hook>) Hooks.Manager)["CEpochItemScriptManager::ItemBuffScrollFileCopy"].CallOriginal(new object[2]
        {
          (object) @this,
          (object) pInfo
        });
      }
      catch (Exception ex)
      {
        Log.LogError(ex, "CEpochItemScriptManager.ItemBuffScrollFileCopy");
      }
    }

    [HandleProcessCorruptedStateExceptions]
    private static void DetouredItemCharmFileCopy(IntPtr @this, IntPtr pInfo)
    {
      try
      {
        Bins._tagRohanItemCharmInfo_new structure = (Bins._tagRohanItemCharmInfo_new) Marshal.PtrToStructure(pInfo, typeof (Bins._tagRohanItemCharmInfo_new));
        Bins._tagRohanItemCharmInfo rohanItemCharmInfo = new Bins._tagRohanItemCharmInfo()
        {
          m_Disable = structure.m_Disable,
          m_ID = structure.m_ID,
          m_Name = structure.m_Name,
          m_KoreanName = structure.m_KoreanName,
          m_ItemType = structure.m_ItemType,
          m_Description = structure.m_Description,
          m_Weight = structure.m_Weight,
          m_Price = structure.m_Price,
          m_SellPrice = structure.m_SellPrice,
          m_MaxStack = structure.m_MaxStack,
          m_AttributeType = ((IEnumerable<int>) structure.m_AttributeType).Take<int>(4).ToArray<int>(),
          m_AttributeValue = ((IEnumerable<int>) structure.m_AttributeValue).Take<int>(4).ToArray<int>(),
          m_ImageName = structure.m_ImageName,
          m_ItemEntity = structure.m_ItemEntity,
          m_szEquipSound = structure.m_szEquipSound,
          m_szDropSound = structure.m_szDropSound,
          m_szItemExplain = structure.m_szItemExplain,
          m_szItemLargeImage = structure.m_szItemLargeImage,
          m_szExplainFileName = structure.m_szExplainFileName,
          m_nSubType = structure.m_nSubType,
          m_UseMaxLevel = structure.m_UseMinLevel,
          m_UseMinLevel = structure.m_UseMinLevel
        };
        if (rohanItemCharmInfo.m_ItemType >= 183)
          rohanItemCharmInfo.m_ItemType -= 6;
        Marshal.Copy(Misc.getBytes((object) rohanItemCharmInfo), 0, pInfo, Marshal.SizeOf((object) rohanItemCharmInfo));
        ((Dictionary<string, Hook>) Hooks.Manager)["CEpochItemScriptManager::ItemCharmFileCopy"].CallOriginal(new object[2]
        {
          (object) @this,
          (object) pInfo
        });
      }
      catch (Exception ex)
      {
        Log.LogError(ex, "CEpochItemScriptManager.ItemCharmFileCopy");
      }
    }

    [HandleProcessCorruptedStateExceptions]
    private static void DetouredItemCostumeFileCopy(IntPtr @this, IntPtr pInfo)
    {
      try
      {
        Bins._tagROHANITEMCOSTUMEINFO structure = (Bins._tagROHANITEMCOSTUMEINFO) Marshal.PtrToStructure(pInfo, typeof (Bins._tagROHANITEMCOSTUMEINFO));
        if (structure.m_ItemType >= 183)
          structure.m_ItemType -= 6;
        Marshal.Copy(Misc.getBytes((object) structure), 0, pInfo, Marshal.SizeOf((object) structure));
        ((Dictionary<string, Hook>) Hooks.Manager)["CEpochItemScriptManager::ItemCostumeFileCopy"].CallOriginal(new object[2]
        {
          (object) @this,
          (object) pInfo
        });
      }
      catch (Exception ex)
      {
        Log.LogError(ex, "CEpochItemScriptManager.ItemCostumeFileCopy");
      }
    }

    [HandleProcessCorruptedStateExceptions]
    private static void DetouredItemEtcDetailsFileCopy(IntPtr @this, IntPtr pInfo)
    {
      try
      {
        Bins._tagROHANITEMETCDETAILSINFO_new structure = (Bins._tagROHANITEMETCDETAILSINFO_new) Marshal.PtrToStructure(pInfo, typeof (Bins._tagROHANITEMETCDETAILSINFO_new));
        Bins._tagROHANITEMETCDETAILSINFO rohanitemetcdetailsinfo = new Bins._tagROHANITEMETCDETAILSINFO()
        {
          m_ID = structure.m_ID,
          m_EtcItemName = structure.m_EtcItemName,
          m_EtcItemID = structure.m_EtcItemID,
          m_GetExp = structure.m_GetExp.LongToInt(),
          m_GetMoney = structure.m_GetMoney,
          m_MoneyType = structure.m_MoneyType,
          m_GetItemCountMax = structure.m_GetItemCountMax,
          m_GetItem = structure.m_GetItem,
          m_GetItemCount = structure.m_GetItemCount,
          m_GetItemRate = structure.m_GetItemRate,
          m_UseSkillKind = structure.m_UseSkillKind,
          m_UseSkillLevel = structure.m_UseSkillLevel,
          m_UseSkillExplain = structure.m_UseSkillExplain,
          m_CheckSkillKind = structure.m_CheckSkillKind,
          m_CheckSkillLevel = structure.m_UseSkillLevel,
          m_RunQuestID = structure.m_RunQuestID,
          m_ItemMaxUseCount = structure.m_ItemMaxUseCount,
          m_ItemReuseTime = structure.m_ItemReuseTime,
          m_ItemEtcKeyItem = structure.m_ItemEtcKeyItem
        };
        Marshal.Copy(Misc.getBytes((object) rohanitemetcdetailsinfo), 0, pInfo, Marshal.SizeOf((object) rohanitemetcdetailsinfo));
        ((Dictionary<string, Hook>) Hooks.Manager)["CEpochItemScriptManager::ItemEtcDetailsFileCopy"].CallOriginal(new object[2]
        {
          (object) @this,
          (object) pInfo
        });
      }
      catch (Exception ex)
      {
        Log.LogError(ex, "CEpochItemScriptManager.ItemEtcDetailsFileCopy");
      }
    }

    [HandleProcessCorruptedStateExceptions]
    private static void DetouredItemEtcFileCopy(IntPtr @this, IntPtr pInfo)
    {
      try
      {
        Bins._tagRohanItemEtcInfo structure = (Bins._tagRohanItemEtcInfo) Marshal.PtrToStructure(pInfo, typeof (Bins._tagRohanItemEtcInfo));
        if (structure.m_ItemType >= 183)
          structure.m_ItemType -= 6;
        Marshal.Copy(Misc.getBytes((object) structure), 0, pInfo, Marshal.SizeOf((object) structure));
        ((Dictionary<string, Hook>) Hooks.Manager)["CEpochItemScriptManager::ItemEtcFileCopy"].CallOriginal(new object[2]
        {
          (object) @this,
          (object) pInfo
        });
      }
      catch (Exception ex)
      {
        Log.LogError(ex, "CEpochItemScriptManager.ItemEtcFileCopy");
      }
    }

    [HandleProcessCorruptedStateExceptions]
    private static void DetouredItemFishFileCopy(IntPtr @this, IntPtr pInfo)
    {
      try
      {
        Bins._tagItemFishInfo structure = (Bins._tagItemFishInfo) Marshal.PtrToStructure(pInfo, typeof (Bins._tagItemFishInfo));
        if (structure.nItemType >= 183)
          structure.nItemType -= 6;
        Marshal.Copy(Misc.getBytes((object) structure), 0, pInfo, Marshal.SizeOf((object) structure));
        ((Dictionary<string, Hook>) Hooks.Manager)["CEpochItemScriptManager::ItemFishFileCopy"].CallOriginal(new object[2]
        {
          (object) @this,
          (object) pInfo
        });
      }
      catch (Exception ex)
      {
        Log.LogError(ex, "CEpochItemScriptManager.ItemFishFileCopy");
      }
    }

    [HandleProcessCorruptedStateExceptions]
    private static void DetouredItemOptionFileCopy(IntPtr @this, IntPtr pInfo)
    {
      try
      {
        Bins._tagROHAN_ITEM_OPTION structure = (Bins._tagROHAN_ITEM_OPTION) Marshal.PtrToStructure(pInfo, typeof (Bins._tagROHAN_ITEM_OPTION));
        if (structure.nItemType >= 183)
          structure.nItemType -= 6;
        Marshal.Copy(Misc.getBytes((object) structure), 0, pInfo, Marshal.SizeOf((object) structure));
        ((Dictionary<string, Hook>) Hooks.Manager)["CEpochItemScriptManager::ItemOptionFileCopy"].CallOriginal(new object[2]
        {
          (object) @this,
          (object) pInfo
        });
      }
      catch (Exception ex)
      {
        Log.LogError(ex, "CEpochItemScriptManager.ItemOptionFileCopy");
      }
    }

    [HandleProcessCorruptedStateExceptions]
    private static void DetouredItemPetFileCopy(IntPtr @this, IntPtr pInfo)
    {
      try
      {
        Bins._tagItemPetInfo structure = (Bins._tagItemPetInfo) Marshal.PtrToStructure(pInfo, typeof (Bins._tagItemPetInfo));
        if (structure.nItemType >= 183)
          structure.nItemType -= 6;
        Marshal.Copy(Misc.getBytes((object) structure), 0, pInfo, Marshal.SizeOf((object) structure));
        ((Dictionary<string, Hook>) Hooks.Manager)["CEpochItemScriptManager::ItemPetFileCopy"].CallOriginal(new object[2]
        {
          (object) @this,
          (object) pInfo
        });
      }
      catch (Exception ex)
      {
        Log.LogError(ex, "CEpochItemScriptManager.ItemPetFileCopy");
      }
    }

    [HandleProcessCorruptedStateExceptions]
    private static void DetouredItemPotionFileCopy(IntPtr @this, IntPtr pInfo)
    {
      try
      {
        Bins._tagRohanItemPotionInfo structure = (Bins._tagRohanItemPotionInfo) Marshal.PtrToStructure(pInfo, typeof (Bins._tagRohanItemPotionInfo));
        if (structure.m_ItemType >= 183)
          structure.m_ItemType -= 6;
        Marshal.Copy(Misc.getBytes((object) structure), 0, pInfo, Marshal.SizeOf((object) structure));
        ((Dictionary<string, Hook>) Hooks.Manager)["CEpochItemScriptManager::ItemPotionFileCopy"].CallOriginal(new object[2]
        {
          (object) @this,
          (object) pInfo
        });
      }
      catch (Exception ex)
      {
        Log.LogError(ex, "CEpochItemScriptManager.ItemPotionFileCopy");
      }
    }

    [HandleProcessCorruptedStateExceptions]
    private static void DetouredItemQuestFileCopy(IntPtr @this, IntPtr pInfo)
    {
      try
      {
        Bins._tagROHANITEMQUESTINFO structure = (Bins._tagROHANITEMQUESTINFO) Marshal.PtrToStructure(pInfo, typeof (Bins._tagROHANITEMQUESTINFO));
        if (structure.m_ItemType >= 183)
          structure.m_ItemType -= 6;
        Marshal.Copy(Misc.getBytes((object) structure), 0, pInfo, Marshal.SizeOf((object) structure));
        ((Dictionary<string, Hook>) Hooks.Manager)["CEpochItemScriptManager::ItemQuestFileCopy"].CallOriginal(new object[2]
        {
          (object) @this,
          (object) pInfo
        });
      }
      catch (Exception ex)
      {
        Log.LogError(ex, "CEpochItemScriptManager.ItemQuestFileCopy");
      }
    }

    [HandleProcessCorruptedStateExceptions]
    private static void DetouredItemRecipeFileCopy(IntPtr @this, IntPtr pInfo)
    {
      try
      {
        Bins._tagRohanItemRecipeInfo structure = (Bins._tagRohanItemRecipeInfo) Marshal.PtrToStructure(pInfo, typeof (Bins._tagRohanItemRecipeInfo));
        if (structure.m_ItemType >= 183)
          structure.m_ItemType -= 6;
        Marshal.Copy(Misc.getBytes((object) structure), 0, pInfo, Marshal.SizeOf((object) structure));
        ((Dictionary<string, Hook>) Hooks.Manager)["CEpochItemScriptManager::ItemQuestFileCopy"].CallOriginal(new object[2]
        {
          (object) @this,
          (object) pInfo
        });
      }
      catch (Exception ex)
      {
        Log.LogError(ex, "CEpochItemScriptManager.ItemQuestFileCopy");
      }
    }

    [HandleProcessCorruptedStateExceptions]
    private static void DetouredItemResetFileCopy(IntPtr @this, IntPtr pInfo)
    {
      try
      {
        Bins._tagROHANITEMRESETINFO structure = (Bins._tagROHANITEMRESETINFO) Marshal.PtrToStructure(pInfo, typeof (Bins._tagROHANITEMRESETINFO));
        if (structure.m_ItemType >= 183)
          structure.m_ItemType -= 6;
        Marshal.Copy(Misc.getBytes((object) structure), 0, pInfo, Marshal.SizeOf((object) structure));
        ((Dictionary<string, Hook>) Hooks.Manager)["CEpochItemScriptManager::ItemResetFileCopy"].CallOriginal(new object[2]
        {
          (object) @this,
          (object) pInfo
        });
      }
      catch (Exception ex)
      {
        Log.LogError(ex, "CEpochItemScriptManager.ItemResetFileCopy");
      }
    }

    [HandleProcessCorruptedStateExceptions]
    private static void DetouredItemRidingFileCopy(IntPtr @this, IntPtr pInfo)
    {
      try
      {
        Bins._tagItemRidingInfo structure = (Bins._tagItemRidingInfo) Marshal.PtrToStructure(pInfo, typeof (Bins._tagItemRidingInfo));
        if (structure.nItemType >= 183)
          structure.nItemType -= 6;
        Marshal.Copy(Misc.getBytes((object) structure), 0, pInfo, Marshal.SizeOf((object) structure));
        ((Dictionary<string, Hook>) Hooks.Manager)["CEpochItemScriptManager::ItemRidingFileCopy"].CallOriginal(new object[2]
        {
          (object) @this,
          (object) pInfo
        });
      }
      catch (Exception ex)
      {
        Log.LogError(ex, "CEpochItemScriptManager.ItemRidingFileCopy");
      }
    }

    [HandleProcessCorruptedStateExceptions]
    private static void DetouredItemScrollFileCopy(IntPtr @this, IntPtr pInfo)
    {
      try
      {
        Bins._tagRohanItemScrollInfo structure = (Bins._tagRohanItemScrollInfo) Marshal.PtrToStructure(pInfo, typeof (Bins._tagRohanItemScrollInfo));
        if (structure.m_ItemType >= 183)
          structure.m_ItemType -= 6;
        Marshal.Copy(Misc.getBytes((object) structure), 0, pInfo, Marshal.SizeOf((object) structure));
        ((Dictionary<string, Hook>) Hooks.Manager)["CEpochItemScriptManager::ItemScrollFileCopy"].CallOriginal(new object[2]
        {
          (object) @this,
          (object) pInfo
        });
      }
      catch (Exception ex)
      {
        Log.LogError(ex, "CEpochItemScriptManager.ItemScrollFileCopy");
      }
    }

    [HandleProcessCorruptedStateExceptions]
    private static void DetouredItemShieldFileCopy(IntPtr @this, IntPtr pInfo)
    {
      try
      {
        Bins._tagROHANITEMSHIELDINFO structure = (Bins._tagROHANITEMSHIELDINFO) Marshal.PtrToStructure(pInfo, typeof (Bins._tagROHANITEMSHIELDINFO));
        if (structure.m_ItemType >= 183)
          structure.m_ItemType -= 6;
        Marshal.Copy(Misc.getBytes((object) structure), 0, pInfo, Marshal.SizeOf((object) structure));
        ((Dictionary<string, Hook>) Hooks.Manager)["CEpochItemScriptManager::ItemShieldFileCopy"].CallOriginal(new object[2]
        {
          (object) @this,
          (object) pInfo
        });
      }
      catch (Exception ex)
      {
        Log.LogError(ex, "CEpochItemScriptManager.ItemShieldFileCopy");
      }
    }

    [HandleProcessCorruptedStateExceptions]
    private static void DetouredItemSocketFileCopy(IntPtr @this, IntPtr pInfo)
    {
      try
      {
        Bins._tagRohanItemSocketInfo structure = (Bins._tagRohanItemSocketInfo) Marshal.PtrToStructure(pInfo, typeof (Bins._tagRohanItemSocketInfo));
        if (structure.m_ItemType >= 183)
          structure.m_ItemType -= 6;
        Marshal.Copy(Misc.getBytes((object) structure), 0, pInfo, Marshal.SizeOf((object) structure));
        ((Dictionary<string, Hook>) Hooks.Manager)["CEpochItemScriptManager::ItemSocketFileCopy"].CallOriginal(new object[2]
        {
          (object) @this,
          (object) pInfo
        });
      }
      catch (Exception ex)
      {
        Log.LogError(ex, "CEpochItemScriptManager.ItemSocketFileCopy");
      }
    }

    [HandleProcessCorruptedStateExceptions]
    private static void DetouredItemWeaponFileCopy(IntPtr @this, IntPtr pInfo)
    {
      try
      {
        Bins._tagItemWeaponInfo structure = (Bins._tagItemWeaponInfo) Marshal.PtrToStructure(pInfo, typeof (Bins._tagItemWeaponInfo));
        if (structure.m_ItemType >= 183)
          structure.m_ItemType -= 6;
        Marshal.Copy(Misc.getBytes((object) structure), 0, pInfo, Marshal.SizeOf((object) structure));
        ((Dictionary<string, Hook>) Hooks.Manager)["CEpochItemScriptManager::ItemWeaponFileCopy"].CallOriginal(new object[2]
        {
          (object) @this,
          (object) pInfo
        });
      }
      catch (Exception ex)
      {
        Log.LogError(ex, "CEpochItemScriptManager.ItemWeaponFileCopy");
      }
    }

    public static CEpochItemScriptManager.DGeneric Generic { get; set; }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
    public delegate void DGeneric(IntPtr @this, IntPtr pInfo);
  }
}
