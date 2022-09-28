// Decompiled with JetBrains decompiler
// Type: RhHook.MapFunctions.CRemainedTimer
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System;
using System.Runtime.InteropServices;

namespace RhHook.MapFunctions
{
  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public class CRemainedTimer
  {
    public static readonly IntPtr SetSecondA = (IntPtr) 6577808;
    public static readonly CRemainedTimer.DSetSecond SetSecond = (CRemainedTimer.DSetSecond) Marshal.GetDelegateForFunctionPointer(CRemainedTimer.SetSecondA, typeof (CRemainedTimer.DSetSecond));
    public static readonly IntPtr GetSecondA = (IntPtr) 6578064;
    public static readonly CRemainedTimer.DGetSecond GetSecond = (CRemainedTimer.DGetSecond) Marshal.GetDelegateForFunctionPointer(CRemainedTimer.GetSecondA, typeof (CRemainedTimer.DGetSecond));
    public uint m_dwTick;

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate void DSetSecond(IntPtr @this, int nRemainedSecond);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate uint DGetSecond(IntPtr @this);
  }
}
