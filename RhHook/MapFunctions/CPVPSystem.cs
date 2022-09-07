// Decompiled with JetBrains decompiler
// Type: RhHook.MapFunctions.CPVPSystem
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System;
using System.Runtime.InteropServices;

namespace RhHook.MapFunctions
{
  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public class CPVPSystem
  {
    public IntPtr vfptr;
    public int m_nPKPoint;
    public int m_nKillCount;
    public int m_nKilledCount;
    public CDeathNote m_deathNote;
    public CBattleInfo m_battleInfo;
    public CPKState m_pkState;
    public int m_bInit;
    public CIOCriticalSection m_crit;
    public PVPNote m_notePK;
  }
}
