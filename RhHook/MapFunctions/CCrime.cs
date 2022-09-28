// Decompiled with JetBrains decompiler
// Type: RhHook.MapFunctions.CCrime
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System;
using System.Runtime.InteropServices;

namespace RhHook.MapFunctions
{
  internal class CCrime
  {
    public static readonly IntPtr IsPrisonA = (IntPtr) 5170064;
    public static readonly CCrime.DIsPrison IsPrison = (CCrime.DIsPrison) Marshal.GetDelegateForFunctionPointer(CCrime.IsPrisonA, typeof (CCrime.DIsPrison));

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate byte DIsPrison(IntPtr @this);
  }
}
