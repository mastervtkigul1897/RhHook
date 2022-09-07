// Decompiled with JetBrains decompiler
// Type: RhHook.DetouredFunctions.CPlayerItemSlotManager
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using Detours;
using RhHook.Data;
using RhHook.MapFunctions;
using RhHook.Util;
using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

namespace RhHook.DetouredFunctions
{
  internal class CPlayerItemSlotManager
  {
    public static readonly CPlayerItemSlotManager.DUseItem UseItem = new CPlayerItemSlotManager.DUseItem(CPlayerItemSlotManager.DetouredUseItem);
    public static readonly CPlayerItemSlotManager.DIsEquipItem IsEquipItem = new CPlayerItemSlotManager.DIsEquipItem(CPlayerItemSlotManager.DetouredIsEquipItem);
    public static readonly CPlayerItemSlotManager.DBreakSealedCharmItem BreakSealedCharmItem = new CPlayerItemSlotManager.DBreakSealedCharmItem(CPlayerItemSlotManager.DetouredBreakSealedCharmItem);
    public static readonly RhHook.Util.FunctionInfo[] FunctionInfo = new RhHook.Util.FunctionInfo[2]
    {
      new RhHook.Util.FunctionInfo((IntPtr) 5679584, "CPlayerItemSlotManager::UseItem", (Delegate) CPlayerItemSlotManager.UseItem, (Delegate) CPlayerItemSlotManager._UseItem, typeof (CPlayerItemSlotManager.DUseItem)),
      new RhHook.Util.FunctionInfo((IntPtr) 5720352, "CPlayerItemSlotManager::BreakSealedCharmItem", (Delegate) CPlayerItemSlotManager.BreakSealedCharmItem, (Delegate) CPlayerItemSlotManager._BreakSealedCharmItem, typeof (CPlayerItemSlotManager.DBreakSealedCharmItem))
    };

    [HandleProcessCorruptedStateExceptions]
    public static int DetouredUseItem(IntPtr @this, IntPtr pItem, IntPtr nCurStack)
    {
      int num1 = 0;
      int num2;
      try
      {
        if (GlobalData.Debug)
          Log.LogString("Hooked CPlayerItemSlotManager::UseItem");
        int ItemId = Marshal.ReadInt32(pItem, 32);
        if (GlobalData.Debug)
          Log.LogString("ItemId : " + ItemId.ToString());
        if (GlobalData.Stacks.Exists((Predicate<int>) (t => t == ItemId)))
        {
          Marshal.WriteInt32(nCurStack, EpochItemBase.GetAttribute(pItem, 9));
          num2 = 1;
        }
        else
          num2 = (int) ((Dictionary<string, Hook>) Hooks.Manager)["CPlayerItemSlotManager::UseItem"].CallOriginal(new object[3]
          {
            (object) @this,
            (object) pItem,
            (object) nCurStack
          });
      }
      catch (Exception ex)
      {
        Log.LogError(ex, "CPlayerItemSlotManager.UseItem");
        return num1;
      }
      return num2;
    }

    [HandleProcessCorruptedStateExceptions]
    private static byte DetouredIsEquipItem(IntPtr @this, int nEquipType, IntPtr pItem)
    {
      if (nEquipType == 29)
        return 1;
      return (byte) ((Dictionary<string, Hook>) Hooks.Manager)["CPlayerItemSlotManager::IsEquipItem"].CallOriginal(new object[3]
      {
        (object) @this,
        (object) nEquipType,
        (object) pItem
      });
    }

    [HandleProcessCorruptedStateExceptions]
    private static int DetouredBreakSealedCharmItem(
      IntPtr @this,
      _tagNewEntityItem SealedItem,
      IntPtr CharmItem,
      IntPtr nSealedItemCurStack)
    {
      try
      {
        int num = (int) ((Dictionary<string, Hook>) Hooks.Manager)["CPlayerItemSlotManager::BreakSealedCharmItem"].CallOriginal(new object[4]
        {
          (object) @this,
          (object) SealedItem,
          (object) CharmItem,
          (object) nSealedItemCurStack
        });
        if (num == 0)
        {
          IntPtr this1 = Marshal.ReadIntPtr(@this, 36);
          _rcmResponseMapDropItem str = new _rcmResponseMapDropItem()
          {
            nResult = 0,
            itemID = SealedItem.id,
            nCurStatck = 0,
            nInventory = SealedItem.nInventory,
            nSlot = SealedItem.nSlot
          };
          RhHook.MapFunctions.CPlayer.SendPacket(this1, (ushort) 5394, Misc.getBytes((object) str), 12U);
        }
        return num;
      }
      catch (Exception ex)
      {
        Log.LogError(ex, "CPlayerItemSlotManager.BreakSealedCharmItem");
        return 1;
      }
    }

    public static CPlayerItemSlotManager.DUseItem _UseItem { get; set; }

    public static CPlayerItemSlotManager.DIsEquipItem _IsEquipItem { get; set; }

    public static CPlayerItemSlotManager.DBreakSealedCharmItem _BreakSealedCharmItem { get; set; }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
    public delegate int DUseItem(IntPtr @this, IntPtr pItem, IntPtr nCurStack);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
    public delegate byte DIsEquipItem(IntPtr @this, int nEquipType, IntPtr pItem);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
    public delegate int DBreakSealedCharmItem(
      IntPtr @this,
      _tagNewEntityItem SealedItem,
      IntPtr CharmItem,
      IntPtr nSealedItemCurStack);
  }
}
