// Decompiled with JetBrains decompiler
// Type: RhHook.MapFunctions.CSkill
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using RhHook.Data;
using System;
using System.Runtime.InteropServices;

namespace RhHook.MapFunctions
{
  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public class CSkill : CSkillScript
  {
    public static readonly IntPtr GetSkillLevelInfoA = (IntPtr) 4419696;
    public static readonly CSkill.DGetSkillLevelInfo GetSkillLevelInfo = (CSkill.DGetSkillLevelInfo) Marshal.GetDelegateForFunctionPointer(CSkill.GetSkillLevelInfoA, typeof (CSkill.DGetSkillLevelInfo));
    public static readonly IntPtr MakeAffectInfoA = (IntPtr) 7065680;
    public static readonly CSkill.DMakeAffectInfo MakeAffectInfo = (CSkill.DMakeAffectInfo) Marshal.GetDelegateForFunctionPointer(CSkill.MakeAffectInfoA, typeof (CSkill.DMakeAffectInfo));
    public float m_ClientSkillTimer;
    public float m_fClientStateTimeStamp;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
    public byte[] m_arrUseSkillItemInfo;
    public _tagSkill m_SkillState;
    public EpochID2 m_EpochId;
    public uint m_dwManaPerSecEvent;
    public uint m_dwTargetEntity;
    public int m_bForceAttack;
    public _tagEpochVector3 m_TargetPos;
    public uint m_dwCancelReason;
    public uint m_dwRequestCancelReason;
    public _tagITEM_INFO m_useItem;
    public int m_nScrollBind;
    public int m_nUseStack;
    public int m_nLearnGuildSkill;
    public int m_nCurrRemainCoolingTime;
    public byte m_nMaxAvailableLevel;
    public int m_bIgoreCooling;

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate IntPtr DGetSkillLevelInfo(IntPtr @this);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate IntPtr DMakeAffectInfo(IntPtr @this, IntPtr pAS);
  }
}
