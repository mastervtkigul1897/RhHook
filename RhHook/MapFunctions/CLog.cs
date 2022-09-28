// Decompiled with JetBrains decompiler
// Type: RhHook.MapFunctions.CLog
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System;
using System.Runtime.InteropServices;

namespace RhHook.MapFunctions
{
  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public class CLog : CLogBase
  {
    public IntPtr m_pErrorLog;
    public IntPtr m_pLoginLog;
    public IntPtr m_pHackLog;
    public IntPtr m_pUnknownPacket;
    public IntPtr m_pItemDump;
    public IntPtr m_pPacketTime;
    public IntPtr m_pMoney;
    public IntPtr m_pBaccarat;
    public IntPtr m_pMoneyInfo;
    public IntPtr m_pNpcGuard;
    public IntPtr m_pCSAuth;
    public IntPtr m_pCSAuth30Log;
    public IntPtr m_pCSAuth30ClientLog;
    public IntPtr m_pBossMonster;
    public IntPtr m_pAutoConfirm;
    public IntPtr m_pMallItem;
    public IntPtr m_pLoginError;
    public IntPtr m_pSkillLog;
    public IntPtr m_pStatusLog;
    public IntPtr m_pNGuildWar;
    public IntPtr m_pItemControl;
    public IntPtr m_pBinLog;
    public IntPtr m_pPartyLog;
    public IntPtr m_pIndunLog;
    public IntPtr m_pBankTabLog;
    public IntPtr m_pSaveUIFileLog;
    public IntPtr m_pPVPLog;
    public IntPtr m_pRemoveInvalidItemsLog;
    public IntPtr m_pGCLog;
    public IntPtr m_pArenaLog;
    public IntPtr m_pPVPArenaLog;
  }
}
