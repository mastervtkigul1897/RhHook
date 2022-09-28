// Decompiled with JetBrains decompiler
// Type: RhHook.MapFunctions.CEntityBaseStatus
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System;
using System.Runtime.InteropServices;

namespace RhHook.MapFunctions
{
  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public class CEntityBaseStatus
  {
    public static readonly IntPtr GetA = (IntPtr) 7078064;
    public static readonly CEntityBaseStatus.DGet Get = (CEntityBaseStatus.DGet) Marshal.GetDelegateForFunctionPointer(CEntityBaseStatus.GetA, typeof (CEntityBaseStatus.DGet));
    public static readonly IntPtr IncA = (IntPtr) 7078112;
    public static readonly CEntityBaseStatus.DInc Inc = (CEntityBaseStatus.DInc) Marshal.GetDelegateForFunctionPointer(CEntityBaseStatus.IncA, typeof (CEntityBaseStatus.DInc));
    public static readonly IntPtr SetAbilityA = (IntPtr) 7078176;
    public static readonly CEntityBaseStatus.DSetAbility SetAbility = (CEntityBaseStatus.DSetAbility) Marshal.GetDelegateForFunctionPointer(CEntityBaseStatus.SetAbilityA, typeof (CEntityBaseStatus.DSetAbility));
    public static readonly IntPtr CalMeleeAttackForceA = (IntPtr) 7078880;
    public static readonly CEntityBaseStatus.DCalMeleeAttackForce CalMeleeAttackForce = (CEntityBaseStatus.DCalMeleeAttackForce) Marshal.GetDelegateForFunctionPointer(CEntityBaseStatus.CalMeleeAttackForceA, typeof (CEntityBaseStatus.DCalMeleeAttackForce));
    public static readonly IntPtr CalMaxLifeA = (IntPtr) 7079632;
    public static readonly CEntityBaseStatus.DCalMaxLife CalMaxLife = (CEntityBaseStatus.DCalMaxLife) Marshal.GetDelegateForFunctionPointer(CEntityBaseStatus.CalMaxLifeA, typeof (CEntityBaseStatus.DCalMaxLife));
    public static readonly IntPtr CalMaxManaA = (IntPtr) 7079968;
    public static readonly CEntityBaseStatus.DCalMaxMana CalMaxMana = (CEntityBaseStatus.DCalMaxMana) Marshal.GetDelegateForFunctionPointer(CEntityBaseStatus.CalMaxManaA, typeof (CEntityBaseStatus.DCalMaxMana));
    public static readonly IntPtr CalPhysicsDefenceA = (IntPtr) 7078976;
    public static readonly CEntityBaseStatus.DCalPhysicsDefence CalPhysicsDefence = (CEntityBaseStatus.DCalPhysicsDefence) Marshal.GetDelegateForFunctionPointer(CEntityBaseStatus.CalPhysicsDefenceA, typeof (CEntityBaseStatus.DCalPhysicsDefence));
    public static readonly IntPtr CalMagicDefenceA = (IntPtr) 7079072;
    public static readonly CEntityBaseStatus.DCalMagicDefence CalMagicDefence = (CEntityBaseStatus.DCalMagicDefence) Marshal.GetDelegateForFunctionPointer(CEntityBaseStatus.CalMagicDefenceA, typeof (CEntityBaseStatus.DCalMagicDefence));
    public CQualities m_qual;
    public int m_nType;

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DGet(IntPtr @this, uint nAbility);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DInc(IntPtr @this, uint nAbility, uint nAddValue);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate void DSetAbility(IntPtr @this, uint nAbilityType, uint nValue);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DCalMeleeAttackForce(IntPtr @this, int nIntelligence, int nLevel);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DCalMaxLife(IntPtr @this, int nHealth, int nLevel);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DCalMaxMana(IntPtr @this, int nMentality, int nLevel);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DCalPhysicsDefence(IntPtr @this, int nHealth, int nStrength, int nLevel);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DCalMagicDefence(
      IntPtr @this,
      int nIntelligence,
      int nMentality,
      int nLevel);
  }
}
