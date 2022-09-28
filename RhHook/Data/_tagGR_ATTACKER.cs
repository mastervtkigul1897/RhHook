// Decompiled with JetBrains decompiler
// Type: RhHook.Data._tagGR_ATTACKER
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System.Runtime.InteropServices;

namespace RhHook.Data
{
  [StructLayout(LayoutKind.Sequential, Pack = 1)]
  internal struct _tagGR_ATTACKER
  {
    public _tagEpochID2 ID;
    public byte nAttackType;
    public ushort nSkillKind;
    public byte nSkillLevel;
    public uint dwUseItemID;
    public byte nItemCount;
  }
}
