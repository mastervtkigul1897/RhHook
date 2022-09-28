// Decompiled with JetBrains decompiler
// Type: RhHook.MapFunctions.__tagItem
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System;
using System.Runtime.InteropServices;

namespace RhHook.MapFunctions
{
  internal class __tagItem
  {
    public static readonly IntPtr InitA = (IntPtr) 4284640;
    public static readonly __tagItem.DInit Init = (__tagItem.DInit) Marshal.GetDelegateForFunctionPointer(__tagItem.InitA, typeof (__tagItem.DInit));

    [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = true)]
    public delegate int DInit(IntPtr _pItem);
  }
}
