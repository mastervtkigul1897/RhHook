// Decompiled with JetBrains decompiler
// Type: RhHook.MapFunctions.CQualities
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

namespace RhHook.MapFunctions
{
  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public class CQualities
  {
    public static readonly IntPtr GetIntA = (IntPtr) 6742032;
    public static readonly CQualities.DGetInt GetInt = (CQualities.DGetInt) Marshal.GetDelegateForFunctionPointer(CQualities.GetIntA, typeof (CQualities.DGetInt));
    public static readonly IntPtr AddIntA = (IntPtr) 6742384;
    public static readonly CQualities.DAddInt AddInt = (CQualities.DAddInt) Marshal.GetDelegateForFunctionPointer(CQualities.AddIntA, typeof (CQualities.DAddInt));
    public static readonly IntPtr SetIntA = (IntPtr) 6742192;
    public static readonly CQualities.DSetInt SetInt = (CQualities.DSetInt) Marshal.GetDelegateForFunctionPointer(CQualities.SetIntA, typeof (CQualities.DSetInt));
    public static readonly IntPtr DelIntA = (IntPtr) 6742624;
    public static readonly CQualities.DDelInt DelInt = (CQualities.DDelInt) Marshal.GetDelegateForFunctionPointer(CQualities.DelIntA, typeof (CQualities.DDelInt));
    public static readonly IntPtr ClearA = (IntPtr) 6742752;
    public static readonly CQualities.DClear Clear = (CQualities.DClear) Marshal.GetDelegateForFunctionPointer(CQualities.ClearA, typeof (CQualities.DClear));
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
    public byte[] m_mapIntStore;
    public IntPtr m_pLock;

    [HandleProcessCorruptedStateExceptions]
    public static unsafe int GetIntValue(IntPtr @this, int key)
    {
      int intValue = 0;
      int num = CQualities.GetInt(@this, key, &intValue);
      return intValue;
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public unsafe delegate int DGetInt(IntPtr @this, int nAbility, int* nValue);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DAddInt(IntPtr @this, int nKey, int nValue);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DSetInt(IntPtr @this, int nKey, int nValue);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DDelInt(IntPtr @this, int nKey, int nValue);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DClear(IntPtr @this);
  }
}
