// Decompiled with JetBrains decompiler
// Type: RhHook.MapFunctions.CIOCriticalSection
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using RhHook.Data;
using System.Runtime.InteropServices;

namespace RhHook.MapFunctions
{
  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public class CIOCriticalSection
  {
    public _RTL_CRITICAL_SECTION m_critical_section;
  }
}
