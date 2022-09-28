// Decompiled with JetBrains decompiler
// Type: RhHook.Data.SBattleContext
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System;
using System.Runtime.InteropServices;

namespace RhHook.Data
{
  [StructLayout(LayoutKind.Sequential, Pack = 1)]
  internal struct SBattleContext
  {
    public int bWeaponHit;
    public int bCriticalHit;
    public int bIgnoreDefence;
    public int bUseRevisionDamage;
    public int bIgnoreDamageRate;
    public int nRectTypeDamageCount;
    public int nAllinshotUsecount;
    public int nAllinshotArrowDamage;
    public int nElementDamage;
    public int nAttackeeIndex;
    public int nUseGhostArrow;
    public IntPtr pAttackee;
  }
}
