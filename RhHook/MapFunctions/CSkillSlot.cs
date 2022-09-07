// Decompiled with JetBrains decompiler
// Type: RhHook.MapFunctions.CSkillSlot
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System;
using System.Runtime.InteropServices;

namespace RhHook.MapFunctions
{
  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public class CSkillSlot : CSkillEvent
  {
    public static readonly IntPtr IsAffectSkillA = (IntPtr) 6899712;
    public static readonly CSkillSlot.DIsAffectSkill IsAffectSkill = (CSkillSlot.DIsAffectSkill) Marshal.GetDelegateForFunctionPointer(CSkillSlot.IsAffectSkillA, typeof (CSkillSlot.DIsAffectSkill));
    public static readonly IntPtr IsAffectSkillasA = (IntPtr) 6899568;
    public static readonly CSkillSlot.DIsAffectSkillas IsAffectSkillas = (CSkillSlot.DIsAffectSkillas) Marshal.GetDelegateForFunctionPointer(CSkillSlot.IsAffectSkillasA, typeof (CSkillSlot.DIsAffectSkillas));
    public static readonly IntPtr GetSkillA = (IntPtr) 6893408;
    public static readonly CSkillSlot.DGetSkill GetSkill = (CSkillSlot.DGetSkill) Marshal.GetDelegateForFunctionPointer(CSkillSlot.GetSkillA, typeof (CSkillSlot.DGetSkill));
    public static readonly IntPtr CanLearnSkillA = (IntPtr) 6899136;
    public static readonly CSkillSlot.DCanLearnSkill CanLearnSkill = (CSkillSlot.DCanLearnSkill) Marshal.GetDelegateForFunctionPointer(CSkillSlot.CanLearnSkillA, typeof (CSkillSlot.DCanLearnSkill));
    public static readonly IntPtr IncreaseSkillPointA = (IntPtr) 6896912;
    public static readonly CSkillSlot.DIncreaseSkillPoint IncreaseSkillPoint = (CSkillSlot.DIncreaseSkillPoint) Marshal.GetDelegateForFunctionPointer(CSkillSlot.IncreaseSkillPointA, typeof (CSkillSlot.DIncreaseSkillPoint));
    public static readonly IntPtr AddSkillA = (IntPtr) 6891088;
    public static readonly CSkillSlot.DAddSkill AddSkill = (CSkillSlot.DAddSkill) Marshal.GetDelegateForFunctionPointer(CSkillSlot.AddSkillA, typeof (CSkillSlot.DAddSkill));
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
    public byte[] m_mapSkill;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
    public byte[] m_listActiveSkill;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
    public byte[] m_mapAffectedSkill;
    public IntPtr m_pActiveNativeSkill;
    public IntPtr m_pActiveOwnSkill;
    public int m_bManaRecover;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
    public byte[] m_mapTargetPos;
    public CIOCriticalSection m_lock;

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DIsAffectSkill(IntPtr @this, uint dwKind);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DIsAffectSkillas(IntPtr @this, uint dwKind, IntPtr @as);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate IntPtr DGetSkill(IntPtr @this, uint dwKind);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DCanLearnSkill(
      IntPtr @this,
      int nClassType,
      int nKind,
      int nReqSkillLevel,
      int nPlayerLevel);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DIncreaseSkillPoint(IntPtr @this, uint nKind);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DAddSkill(IntPtr @this, IntPtr skill);
  }
}
