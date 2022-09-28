// Decompiled with JetBrains decompiler
// Type: RhHook.Data.SATTACKRESULT
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System.Runtime.InteropServices;

namespace RhHook.Data
{
  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  internal struct SATTACKRESULT
  {
    public int nBattleIndex;
    public _tagGR_ATTACKER attacker;
    public byte nAttackeeCount;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
    public _tagGR_ATTACKEE[] attackee;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
    public int[] nTotalDamage;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
    public int[] nReflectDamage;
    public char nUseItemCount;
    public int bIsSkillAttack;
  }
}
