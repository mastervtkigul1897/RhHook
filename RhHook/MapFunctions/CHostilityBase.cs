﻿// Decompiled with JetBrains decompiler
// Type: RhHook.MapFunctions.CHostilityBase
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System;
using System.Runtime.InteropServices;

namespace RhHook.MapFunctions
{
  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public class CHostilityBase
  {
    public IntPtr vfptr;
    public CHostility m_hostility;
    public CHostility m_partyHostility;
    public IntPtr m_pParent;
    public CIOCriticalSection m_crit;
  }
}
