﻿// Decompiled with JetBrains decompiler
// Type: RhHook.Data._tagSkillLevelInfo
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System.Runtime.InteropServices;

namespace RhHook.Data
{
  [StructLayout(LayoutKind.Sequential, Pack = 1)]
  public struct _tagSkillLevelInfo
  {
    public byte nLearnLevel;
    public ushort nCastingMana;
    public ushort nCastingTime;
    public ushort nSkillAniTime;
    public ushort nManaPerSec;
    public uint nDurationTime;
    public uint nCoolingTime;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
    public uint[] nParam;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
    public byte[] szAffectDescription;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
    public byte[] szDescription;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
    public byte[] szExplainFileName;
  }
}
