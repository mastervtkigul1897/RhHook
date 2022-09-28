// Decompiled with JetBrains decompiler
// Type: RhHook.MapFunctions.CBiotic
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System;
using System.Runtime.InteropServices;

namespace RhHook.MapFunctions
{
  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public class CBiotic : CBioticBase
  {
    public static readonly IntPtr GetRandomA = (IntPtr) 5077520;
    public static readonly CBiotic.DGetRandom GetRandom = (CBiotic.DGetRandom) Marshal.GetDelegateForFunctionPointer(CBiotic.GetRandomA, typeof (CBiotic.DGetRandom));
    public static readonly IntPtr BroadcastTeleportA = (IntPtr) 5090112;
    public static readonly CBiotic.DBroadcastTeleport BroadcastTeleport = (CBiotic.DBroadcastTeleport) Marshal.GetDelegateForFunctionPointer(CBiotic.BroadcastTeleportA, typeof (CBiotic.DBroadcastTeleport));
    public static readonly IntPtr BroadCastAroundPlayersA = (IntPtr) 5071872;
    public static readonly CBiotic.DBroadCastAroundPlayers BroadCastAroundPlayers = (CBiotic.DBroadCastAroundPlayers) Marshal.GetDelegateForFunctionPointer(CBiotic.BroadCastAroundPlayersA, typeof (CBiotic.DBroadCastAroundPlayers));
    public static readonly IntPtr ChangeConditionBySkillA = (IntPtr) 5090560;
    public static readonly CBiotic.DChangeConditionBySkill ChangeConditionBySkill = (CBiotic.DChangeConditionBySkill) Marshal.GetDelegateForFunctionPointer(CBiotic.ChangeConditionBySkillA, typeof (CBiotic.DChangeConditionBySkill));
    public static readonly IntPtr GetAIWorldIdA = (IntPtr) 5091776;
    public static readonly CBiotic.DGetAIWorldId GetAIWorldId = (CBiotic.DGetAIWorldId) Marshal.GetDelegateForFunctionPointer(CBiotic.GetAIWorldIdA, typeof (CBiotic.DGetAIWorldId));
    public static readonly IntPtr BroadcastAddLifeA = (IntPtr) 5072128;
    public static readonly CBiotic.DBroadcastAddLife BroadcastAddLife = (CBiotic.DBroadcastAddLife) Marshal.GetDelegateForFunctionPointer(CBiotic.BroadcastAddLifeA, typeof (CBiotic.DBroadcastAddLife));
    public static readonly IntPtr BroadcastAddManaA = (IntPtr) 5072272;
    public static readonly CBiotic.DBroadcastAddMana BroadcastAddMana = (CBiotic.DBroadcastAddMana) Marshal.GetDelegateForFunctionPointer(CBiotic.BroadcastAddManaA, typeof (CBiotic.DBroadcastAddMana));
    public static readonly IntPtr RemoveBioticA = (IntPtr) 4984544;
    public static readonly CBiotic.DRemoveBiotic RemoveBiotic = (CBiotic.DRemoveBiotic) Marshal.GetDelegateForFunctionPointer(CBiotic.RemoveBioticA, typeof (CBiotic.DRemoveBiotic));
    public int m_nMapRef;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] m_szLogName;
    public uint m_dwAIConnId;
    public int m_nMapIndex;
    public int m_dwGenID;
    public int m_GenPatrolIndex;
    public int m_GroupLinkIndex;
    public byte m_nGrade;
    public CSkillManager m_SkillSlot;
    public CGOInterlocked m_ilBattleIndex;
    public uint m_dwAttackTargetID;
    public int m_nAttackType;
    public int m_bForceAttack;
    public uint m_nLifeManaIndex;
    public CGeoRandom m_random;
    public CTimer m_timerRecovery;
    public IntPtr m_pAIConnection;
    public CRemainedTimer m_remainedTimerSkillDelay;
    public int m_nDeadCount;
    public int m_bCriticalAttack;
    public int m_bCriticalAttacked;
    public int m_bInvincibleGuildMaster;
    public int m_bRemoveEntity;
    public int m_bInvincibleBySBindston;
    public uint m_LastUpdateTime;
    public uint m_NeedUpdateElaspedTime;

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DGetRandom(IntPtr @this, int nMax);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate void DBroadcastTeleport(IntPtr @this, IntPtr nMax);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DBroadCastAroundPlayers(
      IntPtr @this,
      int nProtocal,
      byte[] pData,
      uint dwSize,
      int bIncludeMe,
      byte nCellRange);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate void DChangeConditionBySkill(
      IntPtr @this,
      uint dwCondition,
      uint nMilliSecond,
      ushort wSkillKInd);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DGetAIWorldId(IntPtr @this);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate void DBroadcastAddLife(IntPtr @this, int nDiff, byte nReason);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate void DBroadcastAddMana(IntPtr @this, int nDiff, byte nReason);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate void DRemoveBiotic(IntPtr @this, uint dwDelayTime);
  }
}
