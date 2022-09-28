// Decompiled with JetBrains decompiler
// Type: RhHook.MapFunctions.CTradeItemList
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System;
using System.Runtime.InteropServices;

namespace RhHook.MapFunctions
{
  internal class CTradeItemList
  {
    public static readonly IntPtr GetListA = (IntPtr) 7208480;
    public static readonly CTradeItemList.DGetList GetList = (CTradeItemList.DGetList) Marshal.GetDelegateForFunctionPointer(CTradeItemList.GetListA, typeof (CTradeItemList.DGetList));

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate IntPtr DGetList(IntPtr @this, uint nNpcID);
  }
}
