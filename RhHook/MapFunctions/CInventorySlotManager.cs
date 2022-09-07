// Decompiled with JetBrains decompiler
// Type: RhHook.MapFunctions.CInventorySlotManager
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System;
using System.Runtime.InteropServices;

namespace RhHook.MapFunctions
{
  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public class CInventorySlotManager
  {
    public static readonly IntPtr SetItemA = (IntPtr) 6920160;
    public static readonly CInventorySlotManager.DSetItem SetItem = (CInventorySlotManager.DSetItem) Marshal.GetDelegateForFunctionPointer(CInventorySlotManager.SetItemA, typeof (CInventorySlotManager.DSetItem));
    public static readonly IntPtr GetItemA = (IntPtr) 6920368;
    public static readonly CInventorySlotManager.DGetItem GetItem = (CInventorySlotManager.DGetItem) Marshal.GetDelegateForFunctionPointer(CInventorySlotManager.GetItemA, typeof (CInventorySlotManager.DGetItem));
    public static readonly IntPtr GetFreeSlotA = (IntPtr) 6920560;
    public static readonly CInventorySlotManager.DGetFreeSlot GetFreeSlot = (CInventorySlotManager.DGetFreeSlot) Marshal.GetDelegateForFunctionPointer(CInventorySlotManager.GetFreeSlotA, typeof (CInventorySlotManager.DGetFreeSlot));
    public static readonly IntPtr GetCurCountA = (IntPtr) 6920864;
    public static readonly CInventorySlotManager.DGetCurCount GetCurCount = (CInventorySlotManager.DGetCurCount) Marshal.GetDelegateForFunctionPointer(CInventorySlotManager.GetCurCountA, typeof (CInventorySlotManager.DGetCurCount));
    public static readonly IntPtr GetAllowCountA = (IntPtr) 6920768;
    public static readonly CInventorySlotManager.DGetAllowCount GetAllowCount = (CInventorySlotManager.DGetAllowCount) Marshal.GetDelegateForFunctionPointer(CInventorySlotManager.GetAllowCountA, typeof (CInventorySlotManager.DGetAllowCount));
    public static readonly IntPtr ClearItemA = (IntPtr) 6920272;
    public static readonly CInventorySlotManager.DClearItem ClearItem = (CInventorySlotManager.DClearItem) Marshal.GetDelegateForFunctionPointer(CInventorySlotManager.ClearItemA, typeof (CInventorySlotManager.DClearItem));
    public static readonly IntPtr ResetInventoryA = (IntPtr) 6919952;
    public static readonly CInventorySlotManager.DResetInventory ResetInventory = (CInventorySlotManager.DResetInventory) Marshal.GetDelegateForFunctionPointer(CInventorySlotManager.ResetInventoryA, typeof (CInventorySlotManager.DResetInventory));
    public static readonly IntPtr InitStaticInventoryA = (IntPtr) 6919776;
    public static readonly CInventorySlotManager.DInitStaticInventory InitStaticInventory = (CInventorySlotManager.DInitStaticInventory) Marshal.GetDelegateForFunctionPointer(CInventorySlotManager.InitStaticInventoryA, typeof (CInventorySlotManager.DInitStaticInventory));
    public IntPtr vfptr;
    public IntPtr m_pInventorySlot;
    public int m_nInventoryCount;
    public CIOCriticalSection m_crit;

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DSetItem(IntPtr @this, int nInventory, int nSlot, IntPtr pItem);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate IntPtr DGetItem(IntPtr @this, int nInventory, int nSlot);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DGetFreeSlot(IntPtr @this, int nInventory, int nSlot);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DGetCurCount(IntPtr @this, int nInventory);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DGetAllowCount(IntPtr @this, int nInventory);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DClearItem(IntPtr @this, int nInventory, int nSlot);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DResetInventory(IntPtr @this, int nInventory);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DInitStaticInventory(IntPtr @this, int nInventory, int nSlotCount);
  }
}
