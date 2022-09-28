// Decompiled with JetBrains decompiler
// Type: RhHook.MapFunctions.CBioticBase
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using RhHook.Data;
using System;
using System.Runtime.InteropServices;

namespace RhHook.MapFunctions
{
  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public class CBioticBase : CEntityBase
  {
    public static readonly IntPtr GetAbilityA = (IntPtr) 5172304;
    public static readonly CBioticBase.DGetAbility GetAbility = (CBioticBase.DGetAbility) Marshal.GetDelegateForFunctionPointer(CBioticBase.GetAbilityA, typeof (CBioticBase.DGetAbility));
    public static readonly IntPtr SetAbilityA = (IntPtr) 5172208;
    public static readonly CBioticBase.DSetAbility SetAbility = (CBioticBase.DSetAbility) Marshal.GetDelegateForFunctionPointer(CBioticBase.SetAbilityA, typeof (CBioticBase.DSetAbility));
    public static readonly IntPtr ClearSkillConditionA = (IntPtr) 5173536;
    public static readonly CBioticBase.DClearSkillCondition ClearSkillCondition = (CBioticBase.DClearSkillCondition) Marshal.GetDelegateForFunctionPointer(CBioticBase.ClearSkillConditionA, typeof (CBioticBase.DClearSkillCondition));
    public static readonly IntPtr GetCurLifeA = (IntPtr) 5172608;
    public static readonly CBioticBase.DGetCurLife GetCurLife = (CBioticBase.DGetCurLife) Marshal.GetDelegateForFunctionPointer(CBioticBase.GetCurLifeA, typeof (CBioticBase.DGetCurLife));
    public static readonly IntPtr SetCurLifeA = (IntPtr) 5172352;
    public static readonly CBioticBase.DSetCurLife SetCurLife = (CBioticBase.DSetCurLife) Marshal.GetDelegateForFunctionPointer(CBioticBase.SetCurLifeA, typeof (CBioticBase.DSetCurLife));
    public static readonly IntPtr AddAbilityA = (IntPtr) 5172256;
    public static readonly CBioticBase.DAddAbility AddAbility = (CBioticBase.DAddAbility) Marshal.GetDelegateForFunctionPointer(CBioticBase.AddAbilityA, typeof (CBioticBase.DAddAbility));
    public StateID2 m_State;
    public StateID2 m_MoveState;
    public StateID2 m_ActionState;
    public EpochVector3 m_Goal;
    public CQualities m_ability;
    public volatile int m_nCurLife;
    public volatile int m_nCurMana;
    public CRemainedTimer m_remainedDeleteTime;
    public CRemainedTimer m_remainedDelayAttackTime;
    public CTimer m_timerDelete;
    public uint m_dwCondition;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)]
    public byte[] m_mapConditionInfo;

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DGetAbility(IntPtr @this, uint nAbility);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DSetAbility(IntPtr @this, int nAbility, int nValue);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DClearSkillCondition(IntPtr @this, uint dwCondition, ushort WSkillKind);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DGetCurLife(IntPtr @this);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DSetCurLife(IntPtr @this, int nLife);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate void DAddAbility(IntPtr @this, int nAbility, int nValue);
  }
}
