// Decompiled with JetBrains decompiler
// Type: RhHook.MapFunctions.CPet
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System;
using System.Runtime.InteropServices;

namespace RhHook.MapFunctions
{
  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  internal class CPet : CPetBase
  {
    public static readonly IntPtr SetDamagePetA = (IntPtr) 6226144;
    public static readonly CPet.DSetDamagePet SetDamagePet = (CPet.DSetDamagePet) Marshal.GetDelegateForFunctionPointer(CPet.SetDamagePetA, typeof (CPet.DSetDamagePet));

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate void DSetDamagePet(IntPtr @this, int bOnOff);
  }
}
