// Decompiled with JetBrains decompiler
// Type: RhHook.MapFunctions.CTradeItemMallList
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System;
using System.Runtime.InteropServices;

namespace RhHook.MapFunctions
{
  internal class CTradeItemMallList
  {
    public static readonly IntPtr CTradeItemMallListA = (IntPtr) 7207792;
    public static readonly CTradeItemMallList.DCTradeItemMallList CTradeItemMallListO = (CTradeItemMallList.DCTradeItemMallList) Marshal.GetDelegateForFunctionPointer(CTradeItemMallList.CTradeItemMallListA, typeof (CTradeItemMallList.DCTradeItemMallList));

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate IntPtr DCTradeItemMallList(
      IntPtr @this,
      IntPtr lpszPath,
      IntPtr pEpochItemScriptManager);
  }
}
