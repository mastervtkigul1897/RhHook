// Decompiled with JetBrains decompiler
// Type: RhHook.DetouredFunctions.CPlayerItemSlotBaseManager
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using Detours;
using RhHook.MapFunctions;
using RhHook.Util;
using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

namespace RhHook.DetouredFunctions
{
  internal class CPlayerItemSlotBaseManager
  {
    public static readonly CPlayerItemSlotBaseManager.DIsEquipItem IsEquipItem = new CPlayerItemSlotBaseManager.DIsEquipItem(CPlayerItemSlotBaseManager.DetouredIsEquipItem);
    public static readonly CPlayerItemSlotBaseManager.DEquipDirect EquipDirect = new CPlayerItemSlotBaseManager.DEquipDirect(CPlayerItemSlotBaseManager.DetouredEquipDirect);
    public static readonly CPlayerItemSlotBaseManager.DUnEquip UnEquip = new CPlayerItemSlotBaseManager.DUnEquip(CPlayerItemSlotBaseManager.DetouredUnEquip);
    public static readonly RhHook.Util.FunctionInfo[] FunctionInfo = new RhHook.Util.FunctionInfo[2]
    {
      new RhHook.Util.FunctionInfo((IntPtr) 7132064, "CPlayerItemSlotBaseManager::EquipDirect", (Delegate) CPlayerItemSlotBaseManager.EquipDirect, (Delegate) CPlayerItemSlotBaseManager._EquipDirect, typeof (CPlayerItemSlotBaseManager.DEquipDirect)),
      new RhHook.Util.FunctionInfo((IntPtr) 7132736, "CPlayerItemSlotBaseManager::UnEquip", (Delegate) CPlayerItemSlotBaseManager.UnEquip, (Delegate) CPlayerItemSlotBaseManager._UnEquip, typeof (CPlayerItemSlotBaseManager.DUnEquip))
    };

    [HandleProcessCorruptedStateExceptions]
    private static byte DetouredIsEquipItem(IntPtr @this, int nEquipType, IntPtr pItem)
    {
      if (nEquipType == 29)
        return 1;
      return (byte) ((Dictionary<string, Hook>) Hooks.Manager)["CPlayerItemSlotBaseManager::IsEquipItem"].CallOriginal(new object[3]
      {
        (object) @this,
        (object) nEquipType,
        (object) pItem
      });
    }

    [HandleProcessCorruptedStateExceptions]
    private static int DetouredEquipDirect(IntPtr @this, int nEquipType, IntPtr pItem)
    {
      try
      {
        if (nEquipType == 29)
        {
          IntPtr ptr = @this + 4;
          if (pItem == IntPtr.Zero || RhHook.MapFunctions.CInventorySlotManager.GetItem(@this, 0, nEquipType) != IntPtr.Zero || CPlayerItemSlotBaseManager.IsEquipItem(@this, nEquipType, pItem) == (byte) 0 || RhHook.MapFunctions.CInventorySlotManager.SetItem(@this, 0, nEquipType, pItem) == 0)
            return 0;
          if (EpochItemBase.GetAttribute(pItem, 0) != 28)
            return 1;
          IntPtr this1 = Marshal.ReadIntPtr(ptr) + 10380;
          if (CInventorySlot.Init(this1, pItem) == 1)
            return 1;
          int num = RhHook.MapFunctions.CInventorySlotManager.ClearItem(@this, 0, nEquipType);
          return 0;
        }
        return (int) ((Dictionary<string, Hook>) Hooks.Manager)["CPlayerItemSlotBaseManager::EquipDirect"].CallOriginal(new object[3]
        {
          (object) @this,
          (object) nEquipType,
          (object) pItem
        });
      }
      catch (Exception ex)
      {
        Log.LogError(ex, "CPlayerItemSlotBaseManager.EquipDirect");
        return 0;
      }
    }

    [HandleProcessCorruptedStateExceptions]
    private static int DetouredUnEquip(IntPtr @this, int nEquipType, int nInventory, int nSlot)
    {
      if (nEquipType == 29)
      {
        IntPtr pItem = RhHook.MapFunctions.CInventorySlotManager.GetItem(@this, 0, nEquipType);
        if (pItem == IntPtr.Zero || RhHook.MapFunctions.CInventorySlotManager.GetItem(@this, nInventory, nSlot) != IntPtr.Zero || RhHook.MapFunctions.CInventorySlotManager.GetCurCount(@this, 5) > 0 || RhHook.MapFunctions.CInventorySlotManager.ResetInventory(@this, 5) == 0 || RhHook.MapFunctions.CInventorySlotManager.SetItem(@this, nInventory, nSlot, pItem) == 0)
          return 0;
        int num = RhHook.MapFunctions.CInventorySlotManager.ClearItem(@this, 0, nEquipType);
        return 1;
      }
      return (int) ((Dictionary<string, Hook>) Hooks.Manager)["CPlayerItemSlotBaseManager::UnEquip"].CallOriginal(new object[4]
      {
        (object) @this,
        (object) nEquipType,
        (object) nInventory,
        (object) nSlot
      });
    }

    public static CPlayerItemSlotBaseManager.DIsEquipItem _IsEquipItem { get; set; }

    public static CPlayerItemSlotBaseManager.DEquipDirect _EquipDirect { get; set; }

    public static CPlayerItemSlotBaseManager.DUnEquip _UnEquip { get; set; }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
    public delegate byte DIsEquipItem(IntPtr @this, int nEquipType, IntPtr pItem);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
    public delegate int DEquipDirect(IntPtr @this, int nEquipType, IntPtr pItem);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
    public delegate int DUnEquip(IntPtr @this, int nEquipType, int nInventory, int nSlot);
  }
}
