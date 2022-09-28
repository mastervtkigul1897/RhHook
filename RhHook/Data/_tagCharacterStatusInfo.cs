// Decompiled with JetBrains decompiler
// Type: RhHook.Data._tagCharacterStatusInfo
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System.Runtime.InteropServices;

namespace RhHook.Data
{
  [StructLayout(LayoutKind.Sequential, Pack = 2)]
  public struct _tagCharacterStatusInfo
  {
    public ushort nStrength;
    public ushort nDexterity;
    public ushort nHealth;
    public ushort nIntelligence;
    public ushort nMentality;
    public ushort nQuickness;
    public ushort nMeleeAttackForce;
    public ushort nMissileAttackForce;
    public ushort nMagicAttackForce;
    public ushort nPhysicsDefence;
    public ushort nMagicDefence;
    public ushort nHitRate;
    public ushort nEscapeReate;
    public uint nMaxLife;
    public ushort nLifeRecovery;
    public uint nMaxMana;
    public ushort nManaRecovery;
    public ushort nResistance;
    public ushort nMoveSpeed;
    public ushort nAttackSpeed;
    public ushort nMaxWeight;
    public byte nResistanceBlazing;
    public byte nResistanceFrozen;
    public byte nResistanceDarkness;
    public byte nResistanceDivine;
  }
}
