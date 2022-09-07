// Decompiled with JetBrains decompiler
// Type: RhHook.MapFunctions.MercenaryManager
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System;
using System.Runtime.InteropServices;

namespace RhHook.MapFunctions
{
  [StructLayout(LayoutKind.Sequential, Pack = 8)]
  public class MercenaryManager
  {
    public CIOCriticalSection m_crit;
    public bool m_decision;
    public IntPtr m_pPlayer;
    public long m_reward;
    public int m_successCount;
    public Mercenary_Task_Manager m_listTask;
    public Mercenary_Employ_Manager m_listEmploy;
  }
}
