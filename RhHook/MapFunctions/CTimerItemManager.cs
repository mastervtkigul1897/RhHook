// Decompiled with JetBrains decompiler
// Type: RhHook.MapFunctions.CTimerItemManager
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System;
using System.Runtime.InteropServices;

namespace RhHook.MapFunctions
{
  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public class CTimerItemManager
  {
    public static readonly IntPtr AddItemA = (IntPtr) 5750960;
    public static readonly CTimerItemManager.DAddItem AddItem = (CTimerItemManager.DAddItem) Marshal.GetDelegateForFunctionPointer(CTimerItemManager.AddItemA, typeof (CTimerItemManager.DAddItem));
    public int m_nCount;
    public IntPtr m_pPlayer;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
    public byte[] m_mapTimerItem;
    public CIOCriticalSection m_Crit;

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DAddItem(IntPtr @this, IntPtr pItem, long terminationTime);
  }
}
