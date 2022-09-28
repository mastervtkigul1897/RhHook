// Decompiled with JetBrains decompiler
// Type: RhHook.MapFunctions.CSkillManager
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System;
using System.Runtime.InteropServices;

namespace RhHook.MapFunctions
{
  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public class CSkillManager : CSkillSlot
  {
    public static readonly IntPtr GetTotalDynamicLevelA = (IntPtr) 4906432;
    public static readonly CSkillManager.DGetTotalDynamicLevel GetTotalDynamicLevel = (CSkillManager.DGetTotalDynamicLevel) Marshal.GetDelegateForFunctionPointer(CSkillManager.GetTotalDynamicLevelA, typeof (CSkillManager.DGetTotalDynamicLevel));
    public static readonly IntPtr ChangeLifeA = (IntPtr) 4881584;
    public static readonly CSkillManager.DChangeLife ChangeLife = (CSkillManager.DChangeLife) Marshal.GetDelegateForFunctionPointer(CSkillManager.ChangeLifeA, typeof (CSkillManager.DChangeLife));
    public static readonly IntPtr ChangeManaA = (IntPtr) 4881504;
    public static readonly CSkillManager.DChangeMana ChangeMana = (CSkillManager.DChangeMana) Marshal.GetDelegateForFunctionPointer(CSkillManager.ChangeManaA, typeof (CSkillManager.DChangeMana));
    public static readonly IntPtr SetOptionA = (IntPtr) 4953808;
    public static readonly CSkillManager.DSetOption SetOption = (CSkillManager.DSetOption) Marshal.GetDelegateForFunctionPointer(CSkillManager.SetOptionA, typeof (CSkillManager.DSetOption));
    public static readonly IntPtr CureSleep_OnAttackedA = (IntPtr) 4869328;
    public static readonly CSkillManager.DCureSleep_OnAttacked CureSleep_OnAttacked = (CSkillManager.DCureSleep_OnAttacked) Marshal.GetDelegateForFunctionPointer(CSkillManager.CureSleep_OnAttackedA, typeof (CSkillManager.DCureSleep_OnAttacked));
    public static readonly IntPtr OffHidingA = (IntPtr) 4882416;
    public static readonly CSkillManager.DOffHiding OffHiding = (CSkillManager.DOffHiding) Marshal.GetDelegateForFunctionPointer(CSkillManager.OffHidingA, typeof (CSkillManager.DOffHiding));
    public static readonly IntPtr ProcessDamageByManaReturnA = (IntPtr) 4903424;
    public static readonly CSkillManager.DProcessDamageByManaReturn ProcessDamageByManaReturn = (CSkillManager.DProcessDamageByManaReturn) Marshal.GetDelegateForFunctionPointer(CSkillManager.ProcessDamageByManaReturnA, typeof (CSkillManager.DProcessDamageByManaReturn));
    public static readonly IntPtr ProcessDamageByMagicBarrierDefenceA = (IntPtr) 4903504;
    public static readonly CSkillManager.DProcessDamageByMagicBarrierDefence ProcessDamageByMagicBarrierDefence = (CSkillManager.DProcessDamageByMagicBarrierDefence) Marshal.GetDelegateForFunctionPointer(CSkillManager.ProcessDamageByMagicBarrierDefenceA, typeof (CSkillManager.DProcessDamageByMagicBarrierDefence));
    public static readonly IntPtr ProcessDamageByGuildMagicBarrierDefenceA = (IntPtr) 4903616;
    public static readonly CSkillManager.DProcessDamageByGuildMagicBarrierDefence ProcessDamageByGuildMagicBarrierDefence = (CSkillManager.DProcessDamageByGuildMagicBarrierDefence) Marshal.GetDelegateForFunctionPointer(CSkillManager.ProcessDamageByGuildMagicBarrierDefenceA, typeof (CSkillManager.DProcessDamageByGuildMagicBarrierDefence));
    public static readonly IntPtr ProcessDamageByScrollMagicBarrierDefenceA = (IntPtr) 4903728;
    public static readonly CSkillManager.DProcessDamageByScrollMagicBarrierDefence ProcessDamageByScrollMagicBarrierDefence = (CSkillManager.DProcessDamageByScrollMagicBarrierDefence) Marshal.GetDelegateForFunctionPointer(CSkillManager.ProcessDamageByScrollMagicBarrierDefenceA, typeof (CSkillManager.DProcessDamageByScrollMagicBarrierDefence));
    public static readonly IntPtr ProcessDamageByManaGuardA = (IntPtr) 4904400;
    public static readonly CSkillManager.DProcessDamageByManaGuard ProcessDamageByManaGuard = (CSkillManager.DProcessDamageByManaGuard) Marshal.GetDelegateForFunctionPointer(CSkillManager.ProcessDamageByManaGuardA, typeof (CSkillManager.DProcessDamageByManaGuard));
    public static readonly IntPtr ProcessDamageByManaShieldA = (IntPtr) 4904560;
    public static readonly CSkillManager.DProcessDamageByManaShield ProcessDamageByManaShield = (CSkillManager.DProcessDamageByManaShield) Marshal.GetDelegateForFunctionPointer(CSkillManager.ProcessDamageByManaShieldA, typeof (CSkillManager.DProcessDamageByManaShield));
    public static readonly IntPtr ProcessDamageByDragonsSkinA = (IntPtr) 4904304;
    public static readonly CSkillManager.DProcessDamageByDragonsSkin ProcessDamageByDragonsSkin = (CSkillManager.DProcessDamageByDragonsSkin) Marshal.GetDelegateForFunctionPointer(CSkillManager.ProcessDamageByDragonsSkinA, typeof (CSkillManager.DProcessDamageByDragonsSkin));
    public static readonly IntPtr ProcessDamageByCriticalImmunityA = (IntPtr) 4904352;
    public static readonly CSkillManager.DProcessDamageByCriticalImmunity ProcessDamageByCriticalImmunity = (CSkillManager.DProcessDamageByCriticalImmunity) Marshal.GetDelegateForFunctionPointer(CSkillManager.ProcessDamageByCriticalImmunityA, typeof (CSkillManager.DProcessDamageByCriticalImmunity));
    public static readonly IntPtr ProcessDamageByBlueDefenseA = (IntPtr) 4904512;
    public static readonly CSkillManager.DProcessDamageByBlueDefense ProcessDamageByBlueDefense = (CSkillManager.DProcessDamageByBlueDefense) Marshal.GetDelegateForFunctionPointer(CSkillManager.ProcessDamageByBlueDefenseA, typeof (CSkillManager.DProcessDamageByBlueDefense));
    public static readonly IntPtr ProcessDamageByObligationA = (IntPtr) 4904912;
    public static readonly CSkillManager.DProcessDamageByObligation ProcessDamageByObligation = (CSkillManager.DProcessDamageByObligation) Marshal.GetDelegateForFunctionPointer(CSkillManager.ProcessDamageByObligationA, typeof (CSkillManager.DProcessDamageByObligation));
    public static readonly IntPtr EndAffectSkillA = (IntPtr) 4793264;
    public static readonly CSkillManager.DEndAffectSkill EndAffectSkill = (CSkillManager.DEndAffectSkill) Marshal.GetDelegateForFunctionPointer(CSkillManager.EndAffectSkillA, typeof (CSkillManager.DEndAffectSkill));
    public static readonly IntPtr ReflectSkillA = (IntPtr) 4894768;
    public static readonly CSkillManager.DReflectSkill ReflectSkill = (CSkillManager.DReflectSkill) Marshal.GetDelegateForFunctionPointer(CSkillManager.ReflectSkillA, typeof (CSkillManager.DReflectSkill));
    public static readonly IntPtr EraseBuffSkillA = (IntPtr) 4901040;
    public static readonly CSkillManager.DEraseBuffSkill EraseBuffSkill = (CSkillManager.DEraseBuffSkill) Marshal.GetDelegateForFunctionPointer(CSkillManager.EraseBuffSkillA, typeof (CSkillManager.DEraseBuffSkill));
    public static readonly IntPtr AddAffectSkillA = (IntPtr) 4819344;
    public static readonly CSkillManager.DAddAffectSkill AddAffectSkill = (CSkillManager.DAddAffectSkill) Marshal.GetDelegateForFunctionPointer(CSkillManager.AddAffectSkillA, typeof (CSkillManager.DAddAffectSkill));
    public static readonly IntPtr OnAffectSkillEventA = (IntPtr) 4866272;
    public static readonly CSkillManager.DOnAffectSkillEvent OnAffectSkillEvent = (CSkillManager.DOnAffectSkillEvent) Marshal.GetDelegateForFunctionPointer(CSkillManager.OnAffectSkillEventA, typeof (CSkillManager.DOnAffectSkillEvent));
    public static readonly IntPtr GetCurTPA = (IntPtr) 4909024;
    public static readonly CSkillManager.DGetCurTP GetCurTP = (CSkillManager.DGetCurTP) Marshal.GetDelegateForFunctionPointer(CSkillManager.GetCurTPA, typeof (CSkillManager.DGetCurTP));
    public static readonly IntPtr EraseBuffA = (IntPtr) 4896992;
    public static readonly CSkillManager.DEraseBuff EraseBuff = (CSkillManager.DEraseBuff) Marshal.GetDelegateForFunctionPointer(CSkillManager.EraseBuffA, typeof (CSkillManager.DEraseBuff));
    public IntPtr m_pBiotic;
    public uint m_dwLastBeginTime;
    public CQualitiesOption m_option;
    public int m_bChangeMana;
    public int m_bChangeLife;
    public CQualities m_dotDamage;
    public int m_nDotDamageDelayTime;
    public CQualities m_dotHeal;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
    public byte[] m_RemoveSkillList;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
    public byte[] m_EventSkillList;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
    public byte[] m_listEndAffectSkill;
    public int m_iMagicBarrierDefence;
    public int m_iManaGuardDefence;
    public int m_bSoulMeditation;
    public int m_bCastOver;
    public int m_bGroupEuphoria;
    public int m_bKillTime;
    public ushort m_wKillTimeSkillKind;
    public int m_nKillTime_Count;
    public int m_nSKillTime_Count;
    public int m_nKillingTime_Count;
    public int m_GhostArrowCount;
    public int m_IgnoreAggroPercent;
    public int m_OrderSwingCount;
    public int m_StormAssaultCount;
    public int m_FurytempestCount;
    public int m_bManaShield;
    public int m_bManaShieldDE;
    public int m_ManaShield_UnitDamage;
    public int m_ManaShield_UnitManaConsume;
    public int m_ManaShield_ManaSaving;
    public int m_bObligation;
    public int m_Obligation_UnitDamage;
    public int m_Obligation_UnitManaConsume;
    public int m_bSecretHideOn;
    public int m_bBlackMantleOn;
    public int m_bManaReturn;
    public int m_ManaReturnPercent;
    public int m_percentDragonsSkin;
    public int m_bMistOn;
    public int m_bInitDekanTransform;
    public int m_nCriticalReflectCount;
    public int m_bGuildMantleOn;
    public int m_bKingShadowOn;
    public int m_iGuildMagicBarrierDefence;
    public int m_iScrollMagicBarrierDefence;
    public int m_bSCriticalImmuneOn;
    public int m_bSHidingOn;
    public CQualities m_mapItemSkillCoolingTime;
    public CQualities m_mapSkillTeleport;
    public CQualities m_mapSkillRespawn;
    public int m_nIntelligentShield;
    public int m_nMentalityShield;
    public int m_bGroupMortalImmuneOn;
    public int m_nMagicMirrorCount;
    public int m_nTripleFatal;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
    public byte[] m_mapTrapEntities;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
    public byte[] m_mapGuildTrapEntities;
    public int m_bIsLoadingSkill;
    public int m_nIsAffectSkillByLevel;

    public static void SetCurTP(IntPtr @this, int TP)
    {
      IntPtr inptr = @this + 88;
      IntPtr ptr = MISC.__RTDynamicCast(inptr, 0, (IntPtr) 8295944, (IntPtr) 8295992, 0);
      if (!(ptr != IntPtr.Zero))
        return;
      Marshal.WriteInt32(ptr, 8272);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate byte DGetTotalDynamicLevel(IntPtr @this, ushort wSkillKind);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate void DChangeLife(IntPtr @this, int nDiff, int bMinLife);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate void DChangeMana(IntPtr @this, int nDiff);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate void DSetOption(IntPtr @this, int nAbilityOptionType, int nValue);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate void DCureSleep_OnAttacked(IntPtr @this);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DOffHiding(IntPtr @this, int bUseItem);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate void DProcessDamageByManaReturn(IntPtr @this, int bUseItem);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DProcessDamageByMagicBarrierDefence(IntPtr @this, int nDamage);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DProcessDamageByGuildMagicBarrierDefence(IntPtr @this, int nDamage);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DProcessDamageByScrollMagicBarrierDefence(IntPtr @this, int nDamage);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DProcessDamageByManaGuard(IntPtr @this, int nDamage);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DProcessDamageByManaShield(IntPtr @this, int nDamage);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DProcessDamageByDragonsSkin(IntPtr @this, int nDamage);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DProcessDamageByCriticalImmunity(IntPtr @this, int nDamage);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DProcessDamageByBlueDefense(IntPtr @this, int nDamage);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DProcessDamageByObligation(IntPtr @this, int nDamage);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate void DEndAffectSkill(
      IntPtr @this,
      ushort wKind,
      byte nReason,
      uint dwParam,
      uint dwSkiller);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DReflectSkill(IntPtr @this, IntPtr pASkill);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DEraseBuffSkill(IntPtr @this, int nRemoveCount);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DAddAffectSkill(IntPtr @this, IntPtr pAffectedSkill);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate void DOnAffectSkillEvent(
      IntPtr @this,
      uint dwEventType,
      IntPtr pASkill,
      byte nReason,
      uint dwParam);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DGetCurTP(IntPtr @this);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DEraseBuff(IntPtr @this, ushort skillkind);
  }
}
