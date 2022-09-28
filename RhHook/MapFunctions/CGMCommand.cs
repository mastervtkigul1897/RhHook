// Decompiled with JetBrains decompiler
// Type: RhHook.MapFunctions.CGMCommand
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System;
using System.Runtime.InteropServices;

namespace RhHook.MapFunctions
{
  [StructLayout(LayoutKind.Sequential)]
  public class CGMCommand
  {
    public static readonly IntPtr WhoA = (IntPtr) 4933056;
    public static readonly CGMCommand.DWho Who = (CGMCommand.DWho) Marshal.GetDelegateForFunctionPointer(CGMCommand.WhoA, typeof (CGMCommand.DWho));
    public static readonly IntPtr WhoNpcA = (IntPtr) 4933824;
    public static readonly CGMCommand.DWhoNpc WhoNpc = (CGMCommand.DWhoNpc) Marshal.GetDelegateForFunctionPointer(CGMCommand.WhoNpcA, typeof (CGMCommand.DWhoNpc));
    public static readonly IntPtr WhoPlayerA = (IntPtr) 4934336;
    public static readonly CGMCommand.DWhoPlayer WhoPlayer = (CGMCommand.DWhoPlayer) Marshal.GetDelegateForFunctionPointer(CGMCommand.WhoPlayerA, typeof (CGMCommand.DWhoPlayer));
    public static readonly IntPtr WhoAllA = (IntPtr) 4935776;
    public static readonly CGMCommand.DWhoAll WhoAll = (CGMCommand.DWhoAll) Marshal.GetDelegateForFunctionPointer(CGMCommand.WhoAllA, typeof (CGMCommand.DWhoAll));
    public static readonly IntPtr CreateA = (IntPtr) 4937184;
    public static readonly CGMCommand.DCreate Create = (CGMCommand.DCreate) Marshal.GetDelegateForFunctionPointer(CGMCommand.CreateA, typeof (CGMCommand.DCreate));
    public static readonly IntPtr SummonA = (IntPtr) 4936560;
    public static readonly CGMCommand.DSummon Summon = (CGMCommand.DSummon) Marshal.GetDelegateForFunctionPointer(CGMCommand.SummonA, typeof (CGMCommand.DSummon));
    public static readonly IntPtr SetFBZEnterLevelLimitA = (IntPtr) 4952032;
    public static readonly CGMCommand.DSetFBZEnterLevelLimit SetFBZEnterLevelLimit = (CGMCommand.DSetFBZEnterLevelLimit) Marshal.GetDelegateForFunctionPointer(CGMCommand.SetFBZEnterLevelLimitA, typeof (CGMCommand.DSetFBZEnterLevelLimit));
    public static readonly IntPtr KickAllA = (IntPtr) 4937664;
    public static readonly CGMCommand.DKickAll KickAll = (CGMCommand.DKickAll) Marshal.GetDelegateForFunctionPointer(CGMCommand.KickAllA, typeof (CGMCommand.DKickAll));
    public static readonly IntPtr KickA = (IntPtr) 4932608;
    public static readonly CGMCommand.DKick Kick = (CGMCommand.DKick) Marshal.GetDelegateForFunctionPointer(CGMCommand.KickA, typeof (CGMCommand.DKick));
    public static readonly IntPtr CallA = (IntPtr) 4932144;
    public static readonly CGMCommand.DCall Call = (CGMCommand.DCall) Marshal.GetDelegateForFunctionPointer(CGMCommand.CallA, typeof (CGMCommand.DCall));
    public static readonly IntPtr LevelUpA = (IntPtr) 4938816;
    public static readonly CGMCommand.DLevelUp LevelUp = (CGMCommand.DLevelUp) Marshal.GetDelegateForFunctionPointer(CGMCommand.LevelUpA, typeof (CGMCommand.DLevelUp));
    public static readonly IntPtr AddAbilityPointA = (IntPtr) 4938208;
    public static readonly CGMCommand.DAddAbilityPoint AddAbilityPoint = (CGMCommand.DAddAbilityPoint) Marshal.GetDelegateForFunctionPointer(CGMCommand.AddAbilityPointA, typeof (CGMCommand.DAddAbilityPoint));
    public static readonly IntPtr AddSkillPointA = (IntPtr) 4938512;
    public static readonly CGMCommand.DAddSkillPoint AddSkillPoint = (CGMCommand.DAddSkillPoint) Marshal.GetDelegateForFunctionPointer(CGMCommand.AddSkillPointA, typeof (CGMCommand.DAddSkillPoint));
    public static readonly IntPtr GoodA = (IntPtr) 4939472;
    public static readonly CGMCommand.DGood Good = (CGMCommand.DGood) Marshal.GetDelegateForFunctionPointer(CGMCommand.GoodA, typeof (CGMCommand.DGood));
    public static readonly IntPtr TeleportNameA = (IntPtr) 4930960;
    public static readonly CGMCommand.DTeleportName TeleportName = (CGMCommand.DTeleportName) Marshal.GetDelegateForFunctionPointer(CGMCommand.TeleportNameA, typeof (CGMCommand.DTeleportName));
    public static readonly IntPtr TeleportPosA = (IntPtr) 4930960;
    public static readonly CGMCommand.DTeleportPos TeleportPos = (CGMCommand.DTeleportPos) Marshal.GetDelegateForFunctionPointer(CGMCommand.TeleportPosA, typeof (CGMCommand.DTeleportPos));
    public static readonly IntPtr SetPartyRemoveA = (IntPtr) 4952288;
    public static readonly CGMCommand.DSetPartyRemove SetPartyRemove = (CGMCommand.DSetPartyRemove) Marshal.GetDelegateForFunctionPointer(CGMCommand.SetPartyRemoveA, typeof (CGMCommand.DSetPartyRemove));
    public static readonly IntPtr GiveMoneyA = (IntPtr) 4937984;
    public static readonly CGMCommand.DGiveMoney GiveMoney = (CGMCommand.DGiveMoney) Marshal.GetDelegateForFunctionPointer(CGMCommand.GiveMoneyA, typeof (CGMCommand.DGiveMoney));
    public static readonly IntPtr CallPartyA = (IntPtr) 4940080;
    public static readonly CGMCommand.DCallParty CallParty = (CGMCommand.DCallParty) Marshal.GetDelegateForFunctionPointer(CGMCommand.CallPartyA, typeof (CGMCommand.DCallParty));
    public static readonly IntPtr ArrangeMarriageA = (IntPtr) 4949744;
    public static readonly CGMCommand.DArrangeMarriage ArrangeMarriage = (CGMCommand.DArrangeMarriage) Marshal.GetDelegateForFunctionPointer(CGMCommand.ArrangeMarriageA, typeof (CGMCommand.DArrangeMarriage));
    public static readonly IntPtr CreateMarriageRingA = (IntPtr) 4951136;
    public static readonly CGMCommand.DCreateMarriageRing CreateMarriageRing = (CGMCommand.DCreateMarriageRing) Marshal.GetDelegateForFunctionPointer(CGMCommand.CreateMarriageRingA, typeof (CGMCommand.DCreateMarriageRing));
    public static readonly IntPtr SetGuildWarTermA = (IntPtr) 4949248;
    public static readonly CGMCommand.DSetGuildWarTerm SetGuildWarTerm = (CGMCommand.DSetGuildWarTerm) Marshal.GetDelegateForFunctionPointer(CGMCommand.SetGuildWarTermA, typeof (CGMCommand.DSetGuildWarTerm));
    public static readonly IntPtr SetTimeA = (IntPtr) 4941776;
    public static readonly CGMCommand.DSetTime SetTime = (CGMCommand.DSetTime) Marshal.GetDelegateForFunctionPointer(CGMCommand.SetTimeA, typeof (CGMCommand.DSetTime));
    public static readonly IntPtr atoiA = (IntPtr) 7293893;
    public static readonly CGMCommand.Datoi atoi = (CGMCommand.Datoi) Marshal.GetDelegateForFunctionPointer(CGMCommand.atoiA, typeof (CGMCommand.Datoi));

    [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = true)]
    public delegate int DWho(IntPtr pGM, byte[] prcreq);

    [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = true)]
    public delegate int DWhoNpc(IntPtr pGM, byte[] prcreq);

    [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = true)]
    public delegate int DWhoPlayer(IntPtr pGM, byte[] prcreq);

    [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = true)]
    public delegate int DWhoAll(IntPtr pGM);

    [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = true)]
    public delegate int DCreate(IntPtr pGM, byte[] prcreq);

    [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = true)]
    public delegate int DSummon(IntPtr pGM, byte[] prcreq);

    [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = true)]
    public delegate int DSetFBZEnterLevelLimit(IntPtr pGM, byte[] prcreq);

    [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = true)]
    public delegate int DKickAll(IntPtr pGM);

    [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = true)]
    public delegate int DKick(IntPtr pGM, byte[] prcreq);

    [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = true)]
    public delegate int DCall(IntPtr pGM, byte[] prcreq);

    [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = true)]
    public delegate int DLevelUp(IntPtr pGM, byte[] prcreq);

    [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = true)]
    public delegate int DAddAbilityPoint(IntPtr pGM, byte[] prcreq);

    [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = true)]
    public delegate int DAddSkillPoint(IntPtr pGM, byte[] prcreq);

    [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = true)]
    public delegate int DGood(IntPtr pGM, byte[] prcreq);

    [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = true)]
    public delegate int DTeleportName(IntPtr pGM, byte[] prcreq);

    [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = true)]
    public delegate int DTeleportPos(IntPtr pGM, byte[] prcreq);

    [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = true)]
    public delegate int DSetPartyRemove(IntPtr pGM, byte[] prcreq);

    [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = true)]
    public delegate int DGiveMoney(IntPtr pGM, byte[] prcreq);

    [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = true)]
    public delegate int DCallParty(IntPtr pGM, byte[] prcreq);

    [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = true)]
    public delegate int DArrangeMarriage(IntPtr pGM, byte[] prcreq);

    [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = true)]
    public delegate int DCreateMarriageRing(IntPtr pGM, IntPtr pMan, IntPtr pWoman);

    [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = true)]
    public delegate int DSetGuildWarTerm(IntPtr pGM, byte[] prcreq);

    [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = true)]
    public delegate int DSetTime(IntPtr pGM, byte[] prcreq);

    [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = true)]
    public delegate int Datoi(byte[] prcreq);
  }
}
