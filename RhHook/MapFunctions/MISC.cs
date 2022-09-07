// Decompiled with JetBrains decompiler
// Type: RhHook.MapFunctions.MISC
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System;
using System.Runtime.InteropServices;

namespace RhHook.MapFunctions
{
  public class MISC
  {
    public static readonly IntPtr __RTDynamicCastA = (IntPtr) 7289835;
    public static readonly MISC.D__RTDynamicCast __RTDynamicCast = (MISC.D__RTDynamicCast) Marshal.GetDelegateForFunctionPointer(MISC.__RTDynamicCastA, typeof (MISC.D__RTDynamicCast));
    public static readonly MISC.D__RTDynamicCast2 __RTDynamicCast2 = (MISC.D__RTDynamicCast2) Marshal.GetDelegateForFunctionPointer(MISC.__RTDynamicCastA, typeof (MISC.D__RTDynamicCast2));
    public static readonly IntPtr _time64A = (IntPtr) 7291565;
    public static readonly MISC.D_time64 _time64 = (MISC.D_time64) Marshal.GetDelegateForFunctionPointer(MISC._time64A, typeof (MISC.D_time64));

    [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = true)]
    public delegate IntPtr D__RTDynamicCast(
      IntPtr inptr,
      int VfDelta,
      IntPtr SrcType,
      IntPtr TargetType,
      int isReference);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = true)]
    public delegate IntPtr D__RTDynamicCast2(
      CEpochItemScript inptr,
      int VfDelta,
      IntPtr SrcType,
      IntPtr TargetType,
      int isReference);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = true)]
    public delegate long D_time64(int timeptr);
  }
}
