// Decompiled with JetBrains decompiler
// Type: RhHook.Data._tagGR_ATTACKEE
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System.Runtime.InteropServices;

namespace RhHook.Data
{
  [StructLayout(LayoutKind.Sequential, Pack = 1)]
  internal struct _tagGR_ATTACKEE
  {
    private uint nLifeManaIndex;
    private _tagEpochID2 ID;
    private int nResult;
    private int nDamage;
    private int nElementDamage;
    private int nCurLife;
    private int nCurMana;
    private short nLevel;
    private char bSkillAffect;
  }
}
