// Decompiled with JetBrains decompiler
// Type: RhHook.MapFunctions.CPetBase
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System;
using System.Runtime.InteropServices;

namespace RhHook.MapFunctions
{
  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  internal class CPetBase
  {
    public IntPtr vfptr;
    public IntPtr m_pOwner;
    public IntPtr m_pPetItem;
    public int m_nLevel;
    public int m_nFeedCount;
    public int m_nLifeTimeMinute;
    public int m_nHungryCount;
    public int m_nMaxHungryCount;
    public int m_nHungryTime;
    public int m_nFeedTime;
    public int m_bIsHealingPet;
    public int m_bIsTelePet;
    public int m_bPositionMemorize;
    public int m_bSummon;
    public int m_bDeadWarning;
    public int m_bActive;
    public int m_bTimerAlarm;
    public int m_bTimerEffect;
    public CRemainedTimer m_timerPetLife;
    public CRemainedTimer m_timerPetTimerSync;
    public CRemainedTimer m_timerHungry;
    public CRemainedTimer m_timerEffect;
    public CRemainedTimer m_timerAlarm;
    public CRemainedTimer m_timerAction1;
    public CRemainedTimer m_timerTeleportCoolTime;
    public CIOCriticalSection m_Crit;
  }
}
