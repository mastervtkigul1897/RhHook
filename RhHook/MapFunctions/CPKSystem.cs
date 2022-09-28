// Decompiled with JetBrains decompiler
// Type: RhHook.MapFunctions.CPKSystem
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System;
using System.Runtime.InteropServices;

namespace RhHook.MapFunctions
{
  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public class CPKSystem : CPVPSystem
  {
    public IntPtr m_pPlayer;
    public CRemainedTimer m_disableKillRemaindTimer;
    public CPlayerHostility m_hostility;
    public CTimer m_timerSendState;
    public int m_bCombat;
  }
}
