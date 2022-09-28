// Decompiled with JetBrains decompiler
// Type: RhHook.MapFunctions.CQualitiesOption
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

namespace RhHook.MapFunctions
{
  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public class CQualitiesOption : CQualities
  {
    public static readonly IntPtr CalOptionA = (IntPtr) 5062128;
    public static readonly CQualitiesOption.DCalOption CalOption = (CQualitiesOption.DCalOption) Marshal.GetDelegateForFunctionPointer(CQualitiesOption.CalOptionA, typeof (CQualitiesOption.DCalOption));
    public static readonly IntPtr SetOptionA = (IntPtr) 5156048;
    public static readonly CQualitiesOption.DSetOption SetOption = (CQualitiesOption.DSetOption) Marshal.GetDelegateForFunctionPointer(CQualitiesOption.SetOptionA, typeof (CQualitiesOption.DSetOption));
    public static readonly IntPtr GetOptionA = (IntPtr) 6742032;
    public static readonly CQualitiesOption.DGetOption GetOption = (CQualitiesOption.DGetOption) Marshal.GetDelegateForFunctionPointer(CQualitiesOption.GetOptionA, typeof (CQualitiesOption.DGetOption));
    public static readonly IntPtr ConstructorA = (IntPtr) 5155984;
    public static readonly CQualitiesOption.DConstructor Constructor = (CQualitiesOption.DConstructor) Marshal.GetDelegateForFunctionPointer(CQualitiesOption.ConstructorA, typeof (CQualitiesOption.DConstructor));

    [HandleProcessCorruptedStateExceptions]
    public static unsafe int GetOptionValue(IntPtr @this, int key)
    {
      int optionValue = 0;
      int num = CQualitiesOption.GetOption(@this, key, &optionValue);
      return optionValue;
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate void DCalOption(IntPtr @this, int nOptionType, int nCalValue, int bAdd);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate void DSetOption(IntPtr @this, int nOptionType, int nCalValue);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public unsafe delegate int DGetOption(IntPtr @this, int key, int* nValue);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DConstructor(IntPtr @this);
  }
}
