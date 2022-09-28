// Decompiled with JetBrains decompiler
// Type: RhHook.MapFunctions.CPlayer
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using RhHook.Data;
using System;
using System.Runtime.InteropServices;

namespace RhHook.MapFunctions
{
  [StructLayout(LayoutKind.Sequential, Pack = 8)]
  public class CPlayer : CBiotic
  {
    public static readonly IntPtr SendConquerorLevelA = (IntPtr) 5334544;
    public static readonly CPlayer.DSendConquerorLevel SendConquerorLevel = (CPlayer.DSendConquerorLevel) Marshal.GetDelegateForFunctionPointer(CPlayer.SendConquerorLevelA, typeof (CPlayer.DSendConquerorLevel));
    public static readonly IntPtr SubMoneyA = (IntPtr) 5125975;
    public static readonly CPlayer.DSubMoney SubMoney = (CPlayer.DSubMoney) Marshal.GetDelegateForFunctionPointer(CPlayer.SubMoneyA, typeof (CPlayer.DSubMoney));
    public static readonly IntPtr CheckTradeItemWorkA = (IntPtr) 5181680;
    public static readonly CPlayer.DCheckTradeItemWork CheckTradeItemWork = (CPlayer.DCheckTradeItemWork) Marshal.GetDelegateForFunctionPointer(CPlayer.CheckTradeItemWorkA, typeof (CPlayer.DCheckTradeItemWork));
    public static readonly IntPtr SetPosA = (IntPtr) 5155040;
    public static readonly CPlayer.DSetPos SetPos = (CPlayer.DSetPos) Marshal.GetDelegateForFunctionPointer(CPlayer.SetPosA, typeof (CPlayer.DSetPos));
    public static readonly IntPtr AddIndunPointA = (IntPtr) 5155040;
    public static readonly CPlayer.NDAddIndunPoint AddIndunPoint = (CPlayer.NDAddIndunPoint) Marshal.GetDelegateForFunctionPointer(CPlayer.AddIndunPointA, typeof (CPlayer.NDAddIndunPoint));
    public static readonly IntPtr IncAbilityA = (IntPtr) 5188752;
    public static readonly CPlayer.DIncAbility IncAbility = (CPlayer.DIncAbility) Marshal.GetDelegateForFunctionPointer(CPlayer.IncAbilityA, typeof (CPlayer.DIncAbility));
    public static readonly IntPtr BroadcastIncAbilityA = (IntPtr) 5114752;
    public static readonly CPlayer.DBroadcastIncAbility BroadcastIncAbility = (CPlayer.DBroadcastIncAbility) Marshal.GetDelegateForFunctionPointer(CPlayer.BroadcastIncAbilityA, typeof (CPlayer.DBroadcastIncAbility));
    public static readonly IntPtr SendStatusA = (IntPtr) 5093136;
    public static readonly CPlayer.DSendStatus SendStatus = (CPlayer.DSendStatus) Marshal.GetDelegateForFunctionPointer(CPlayer.SendStatusA, typeof (CPlayer.DSendStatus));
    public static readonly IntPtr GetStatusInfoA = (IntPtr) 5187248;
    public static readonly CPlayer.DGetStatusInfo GetStatusInfoO = (CPlayer.DGetStatusInfo) Marshal.GetDelegateForFunctionPointer(CPlayer.GetStatusInfoA, typeof (CPlayer.DGetStatusInfo));
    public static readonly IntPtr CheckSelfItemWorkA = (IntPtr) 5282832;
    public static readonly CPlayer.DCheckSelfItemWork CheckSelfItemWork = (CPlayer.DCheckSelfItemWork) Marshal.GetDelegateForFunctionPointer(CPlayer.CheckSelfItemWorkA, typeof (CPlayer.DCheckSelfItemWork));
    public static readonly IntPtr CheckWorkItemA = (IntPtr) 5285312;
    public static readonly CPlayer.DCheckWorkItem CheckWorkItem = (CPlayer.DCheckWorkItem) Marshal.GetDelegateForFunctionPointer(CPlayer.CheckWorkItemA, typeof (CPlayer.DCheckWorkItem));
    public static readonly IntPtr CalAllAbilityA = (IntPtr) 5094064;
    public static readonly CPlayer.DCalAllAbility CalAllAbility = (CPlayer.DCalAllAbility) Marshal.GetDelegateForFunctionPointer(CPlayer.CalAllAbilityA, typeof (CPlayer.DCalAllAbility));
    public static readonly IntPtr CalAbilityA = (IntPtr) 5096560;
    public static readonly CPlayer.DCalAbility CalAbility = (CPlayer.DCalAbility) Marshal.GetDelegateForFunctionPointer(CPlayer.CalAbilityA, typeof (CPlayer.DCalAbility));
    public static readonly IntPtr SendPacketA = (IntPtr) 4285072;
    public static readonly CPlayer.DSendPacket SendPacket = (CPlayer.DSendPacket) Marshal.GetDelegateForFunctionPointer(CPlayer.SendPacketA, typeof (CPlayer.DSendPacket));
    public static readonly IntPtr SearchAndRemoveItemA = (IntPtr) 5268608;
    public static readonly CPlayer.DSearchAndRemoveItem SearchAndRemoveItem = (CPlayer.DSearchAndRemoveItem) Marshal.GetDelegateForFunctionPointer(CPlayer.SearchAndRemoveItemA, typeof (CPlayer.DSearchAndRemoveItem));
    public static readonly IntPtr BroadcastPetLevelUpA = (IntPtr) 5295776;
    public static readonly CPlayer.DBroadcastPetLevelUp BroadcastPetLevelUp = (CPlayer.DBroadcastPetLevelUp) Marshal.GetDelegateForFunctionPointer(CPlayer.BroadcastPetLevelUpA, typeof (CPlayer.DBroadcastPetLevelUp));
    public static readonly IntPtr GetNameA = (IntPtr) 5083392;
    public static readonly CPlayer.DGetName GetName = (CPlayer.DGetName) Marshal.GetDelegateForFunctionPointer(CPlayer.GetNameA, typeof (CPlayer.DGetName));
    public static readonly IntPtr SetMarriageRingCoolTimeA = (IntPtr) 5311616;
    public static readonly CPlayer.DSetMarriageRingCoolTime SetMarriageRingCoolTime = (CPlayer.DSetMarriageRingCoolTime) Marshal.GetDelegateForFunctionPointer(CPlayer.SetMarriageRingCoolTimeA, typeof (CPlayer.DSetMarriageRingCoolTime));
    public static readonly IntPtr ItemBuffSkillAffectSkillA = (IntPtr) 5314096;
    public static readonly CPlayer.DItemBuffSkillAffectSkill ItemBuffSkillAffectSkill = (CPlayer.DItemBuffSkillAffectSkill) Marshal.GetDelegateForFunctionPointer(CPlayer.ItemBuffSkillAffectSkillA, typeof (CPlayer.DItemBuffSkillAffectSkill));
    public CPlayerItemSlotManager m_slotManager;
    public CPKSystem m_pkSystem;
    public CLiveTimer m_liveTimer;
    public CFriendManager m_friendManager;
    public int m_bAnonymousMode;
    public int m_bGCAnonymity;
    public IntPtr m_pConnection;
    public CTimer m_timerSaveDB;
    public CTimer m_timerLogout;
    public CTimer m_timerSendGameTime;
    public CTimer m_timerCheckItem;
    public CRemainedTimer m_remainedTimerPotionLife;
    public CRemainedTimer m_remainedTimerPotionMana;
    public CRemainedTimer m_remainedTimerPotionLifeMana;
    public CRemainedTimer m_remainedTimerPotionCure;
    public CRemainedTimer m_remainedTimerScroll;
    public CRemainedTimer m_remainedTimerTemp;
    public CRemainedTimer m_timerPetRelease;
    public CRemainedTimer m_remainedTimerAutoConfirm;
    public CRemainedTimer m_remaindTimerSafePK;
    public CRemainedTimer m_remaindTimerMarriageRing;
    public CRemainedTimer m_remainedTimerInstantPotionLife;
    public CRemainedTimer m_remainedTimerInstantPotionMana;
    public CRemainedTimer m_remainedTimerInstantPotionLifeMana;
    public CRemainedTimer m_remaindedTimerGuildPoint;
    public int m_IsActiveMoveSpeedCheck;
    public CTimer m_timerMoveSpeedCheck;
    public CTimer m_timerAccumulatedMoveTime;
    public EpochVector3 m_initial_server_pos;
    public float m_acc_move_dist;
    public float m_acc_movable_dist;
    public uint m_old_movespeed_checktime;
    public uint m_dwPartyLeaderID;
    public EpochID2 m_p2pTradeID;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 21)]
    public byte[] m_strCharName;
    public int m_nBindIndex;
    public int m_nScrollBindIndex;
    public int m_bGameIn;
    public byte m_nHair;
    public byte m_nFace;
    public CEntityBaseStatus m_baseStatus;
    public byte m_nStyleType;
    public byte m_nStyleIndex;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
    public byte[] m_strRaceName;
    public uint m_dwOption;
    public IntPtr m_pQuestManager;
    public IntPtr m_pPrivateShop;
    public CPlayerMapMemo m_MapMemo;
    public int m_nMaxWeight;
    public CInventoryState m_InventoryState;
    public CTimer m_timerPrivateShopSearch;
    public CTimer m_timerEnchantItem;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
    public byte[] m_szSearchItemName;
    public _tagResponseMAP_PRIVATE_SHOP_SEARCH m_ShopSearch;
    public CTimer m_timerRankMsg;
    public int m_nRank;
    public byte m_nGuildGrade;
    public int m_tGuildLeaveTime;
    public int m_bDBGuildCreateOK;
    public long m_nExperience;
    public long m_nMoney;
    public long m_nAddMoney;
    public long m_nLastDropExp;
    public long m_nIndunPoint;
    public long m_nAddIndunPoint;
    public int m_nMode;
    public int m_nKillMonster;
    public int m_bKillBonus;
    public double m_dKillBonusRate;
    public int m_bBegin;
    public IntPtr m_pConsign;
    public IntPtr m_pEventItemManager;
    public IntPtr m_pMallItemManager;
    public IntPtr m_pExchangeItemManager;
    public uint m_dwLastAffectSkillSaveTime;
    public CTimer m_timerAlive;
    public float m_nTotalTime;
    public int m_nOverSpeedCount;
    public int m_nOverPositionCount;
    public IntPtr m_pRidingItem;
    public CTimer m_timerRidingItemCasting;
    public IntPtr m_pPet;
    public int m_nPetType;
    public uint m_nPetItemType;
    public int m_nPetLevel;
    public byte m_nPetStyleIndex;
    public byte m_nPetStyleType;
    public CAliveCall m_aliveCall;
    public uint m_dwAliveCallCount;
    public CRemainedTimer m_remainedTimerSilent;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
    public byte[] m_P2pChat;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
    public byte[] m_P2pChatRequest;
    public int m_ChatState;
    public uint m_nUserId;
    public int m_bPCBang;
    public int m_bCostume;
    public IntPtr m_pCrime;
    public IntPtr m_pAutoHunt;
    public int m_bAutoConfirm;
    public int m_bRecallRequest;
    public CTimerItemManager m_TimerItemManager;
    public CTimerEndItemManager m_TimerEndItemManager;
    public CNGuildPlayerQueue m_GuildQueue;
    public int m_nBonusExpRate;
    public int m_nCharmItemBonusKillCount;
    public int m_nItemBuffScrollBonusKillCount;
    public int m_nPartyBonusExpRate;
    public int m_nPartyBonusKillCount;
    public int m_bPartyBonusKillCountCharm;
    public int m_bPartyBonusKillCountScroll;
    public int m_nAddDropRate;
    public int m_nBonusExpRateByCharm;
    public int m_nBonusExpRateByExtendCharm;
    public int m_nBonusExpRateByScroll;
    public int m_nBonusPartyExpRateByCharm;
    public int m_nBonusPartyExpRateByScroll;
    public int m_nPetDamage;
    public int m_nPetAttkProb;
    public int m_nPetReduceCastTime;
    public CTimer m_timerPartyMatchingList;
    public _tagResponseMapPartyMatchingList m_PartyMatchingList;
    public int m_bIgnoreCriticalVehicle;
    public int m_bDungeonVehicle;
    public CTimer m_timerCheckAncientReinforceTime;
    public byte m_nPenaltyPointReason;
    public CGambleInfo m_GambleInfo;
    public int m_nSpouseID;
    public IntPtr m_pMarriageRing;
    public uint m_dwActionKey;
    public char m_nColType;
    public int m_nColExp;
    public char m_nCraftType;
    public int m_nCraftExp;
    public byte m_nCraftLevel;
    public EpochID2 m_nCollectedEntityID;
    public CRecipeManager m_RecipeManager;
    public CPlayerSocketManager m_PlayerSocketManager;
    public uint m_dwClockSync;
    public IntPtr m_pCraftWork;
    public CIOCriticalSection m_critCraft;
    public uint m_NormalAttackDelayStartTick;
    public CPostItemBox m_PostItemBox;
    public uint m_dwReceivedPostPacketTime;
    public bool m_bIjjiUser;
    public _tagBASKET m_Basket;
    public IntPtr m_mgrTitleQuest;
    public int m_idCharTitle;
    public bool m_isHonorInvenFull;
    public _tagGR_HONOR_PVP_POINT m_HonorPVPPoint;
    public int m_nAddCronPoint;
    public uint m_dwIncConnectPointTick;
    public long m_nHonorCrone;
    public int m_nAddHonorCrone;
    public MercenaryManager m_mgrMercenary;
    public short m_IncrementStat;
    public uint dwReflectKiller;
    public int m_nCurTP;

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate void DSendConquerorLevel(IntPtr @this, IntPtr pPlayer);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate void DSubMoney(IntPtr @this, long nDiff, byte nReason, int bClient);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate IntPtr DCheckTradeItemWork(IntPtr @this, int bPrisoner);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate IntPtr DSetPos(IntPtr @this, IntPtr EpochVector3);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate IntPtr NDAddIndunPoint(
      IntPtr @this,
      long nDiff,
      byte nReason,
      int bClient);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DIncAbility(IntPtr @this, uint nAbilityType);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate void DBroadcastIncAbility(IntPtr @this);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate void DSendStatus(IntPtr @this);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public unsafe delegate void DGetStatusInfo(
      IntPtr @this,
      _tagCharacterStatusInfo* grCharStatusInfo);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DCheckSelfItemWork(IntPtr @this, int bAction);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DCheckWorkItem(IntPtr @this, uint dwItemID);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate void DCalAllAbility(IntPtr @this);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate void DCalAbility(IntPtr @this, int nAbilityType);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate void DSendPacket(IntPtr @this, ushort protocol_id, byte[] pData, uint nSize);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DSearchAndRemoveItem(IntPtr @this, int nType, int nRemovedCount);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate void DBroadcastPetLevelUp(IntPtr @this, int nLevel);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate IntPtr DGetName(IntPtr @this);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate void DSetMarriageRingCoolTime(IntPtr @this, int second);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DItemBuffSkillAffectSkill(
      IntPtr @this,
      int nSkillKInd,
      int nSkillLevel,
      uint dwTargetID,
      uint dwStartTime);
  }
}
