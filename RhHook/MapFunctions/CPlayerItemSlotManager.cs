// Decompiled with JetBrains decompiler
// Type: RhHook.MapFunctions.CPlayerItemSlotManager
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using RhHook.Data;
using System;
using System.Runtime.InteropServices;

namespace RhHook.MapFunctions
{
  [StructLayout(LayoutKind.Sequential, Pack = 8)]
  public class CPlayerItemSlotManager : CPlayerItemSlotBaseManager
  {
    public static readonly IntPtr RemoveItemA = (IntPtr) 5682992;
    public static readonly CPlayerItemSlotManager.DRemoveItem RemoveItem = (CPlayerItemSlotManager.DRemoveItem) Marshal.GetDelegateForFunctionPointer(CPlayerItemSlotManager.RemoveItemA, typeof (CPlayerItemSlotManager.DRemoveItem));
    public static readonly IntPtr GetFreeInventorySlotA = (IntPtr) 5709792;
    public static readonly CPlayerItemSlotManager.DGetFreeInventorySlot GetFreeInventorySlot = (CPlayerItemSlotManager.DGetFreeInventorySlot) Marshal.GetDelegateForFunctionPointer(CPlayerItemSlotManager.GetFreeInventorySlotA, typeof (CPlayerItemSlotManager.DGetFreeInventorySlot));
    public static readonly IntPtr GetItemCountInInventoryA = (IntPtr) 5670240;
    public static readonly CPlayerItemSlotManager.DGetItemCountInInventory GetItemCountInInventory = (CPlayerItemSlotManager.DGetItemCountInInventory) Marshal.GetDelegateForFunctionPointer(CPlayerItemSlotManager.GetItemCountInInventoryA, typeof (CPlayerItemSlotManager.DGetItemCountInInventory));
    public static readonly IntPtr FindItemA = (IntPtr) 5673984;
    public static readonly CPlayerItemSlotManager.DFindItem FindItem = (CPlayerItemSlotManager.DFindItem) Marshal.GetDelegateForFunctionPointer(CPlayerItemSlotManager.FindItemA, typeof (CPlayerItemSlotManager.DFindItem));
    public static readonly IntPtr RemoveItemsInInventoryA = (IntPtr) 5722048;
    public static readonly CPlayerItemSlotManager.DRemoveItemsInInventory RemoveItemsInInventory = (CPlayerItemSlotManager.DRemoveItemsInInventory) Marshal.GetDelegateForFunctionPointer(CPlayerItemSlotManager.RemoveItemsInInventoryA, typeof (CPlayerItemSlotManager.DRemoveItemsInInventory));
    public static readonly IntPtr AddItemA = (IntPtr) 5730016;
    public static readonly CPlayerItemSlotManager.DAddItem AddItem = (CPlayerItemSlotManager.DAddItem) Marshal.GetDelegateForFunctionPointer(CPlayerItemSlotManager.AddItemA, typeof (CPlayerItemSlotManager.DAddItem));
    public static readonly IntPtr CreateA = (IntPtr) 5666944;
    public static readonly CPlayerItemSlotManager.DCreate Create = (CPlayerItemSlotManager.DCreate) Marshal.GetDelegateForFunctionPointer(CPlayerItemSlotManager.CreateA, typeof (CPlayerItemSlotManager.DCreate));
    public static readonly CPlayerItemSlotManager.DCreateptr Createptr = (CPlayerItemSlotManager.DCreateptr) Marshal.GetDelegateForFunctionPointer(CPlayerItemSlotManager.CreateA, typeof (CPlayerItemSlotManager.DCreateptr));
    public static readonly IntPtr GetEquipItemTypeA = (IntPtr) 5672816;
    public static readonly CPlayerItemSlotManager.DGetEquipItemType GetEquipItemType = (CPlayerItemSlotManager.DGetEquipItemType) Marshal.GetDelegateForFunctionPointer(CPlayerItemSlotManager.GetEquipItemTypeA, typeof (CPlayerItemSlotManager.DGetEquipItemType));
    public static readonly IntPtr IsEquipShieldA = (IntPtr) 5672912;
    public static readonly CPlayerItemSlotManager.DIsEquipShield IsEquipShield = (CPlayerItemSlotManager.DIsEquipShield) Marshal.GetDelegateForFunctionPointer(CPlayerItemSlotManager.IsEquipShieldA, typeof (CPlayerItemSlotManager.DIsEquipShield));
    public static readonly IntPtr CreateMallItemA = (IntPtr) 5710976;
    public static readonly CPlayerItemSlotManager.DCreateMallItem CreateMallItem = (CPlayerItemSlotManager.DCreateMallItem) Marshal.GetDelegateForFunctionPointer(CPlayerItemSlotManager.CreateMallItemA, typeof (CPlayerItemSlotManager.DCreateMallItem));
    public IntPtr m_pPlayer;
    public CQualitiesOption m_optionAttr;
    public CQualitiesOption m_optionMagic;
    public new CIOCriticalSection m_crit;
    public int m_nTotalWeight;
    public byte m_nWeightState;
    public int m_bTimerItemCheck;
    public SetItem_SetItemManager m_mgrSetItem;
    public long m_nCharmItemMask;
    public long m_nCharmItemApplyMask;
    public RepairMgr m_mgrRepair;

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DRemoveItem(IntPtr @this, IntPtr pItem);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public unsafe delegate int DGetFreeInventorySlot(IntPtr @this, int* nInventory, int* nSlot);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DGetItemCountInInventory(IntPtr @this, uint dwItemType);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate IntPtr DFindItem(IntPtr @this, uint dwItemType);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DRemoveItemsInInventory(IntPtr @this, IntPtr pItem, int nNumber);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DAddItem(
      IntPtr @this,
      IntPtr pItem,
      int nInventory,
      int nSlot,
      int _sendDB);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DCreate(IntPtr @this, int nType, byte[] item, int nStack);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DCreateptr(IntPtr @this, int nType, ref RhHook.Data.__tagItem item, int nStack);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public unsafe delegate int DGetEquipItemType(IntPtr @this, int* equip_itemtype);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DIsEquipShield(IntPtr @this);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DCreateMallItem(
      IntPtr @this,
      int nItemType,
      int nCount,
      IntPtr itemPingMall,
      IntPtr bAddCurStack);
  }
}
