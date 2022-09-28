// Decompiled with JetBrains decompiler
// Type: RhHook.MapFunctions.CLogBase
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System;
using System.Runtime.InteropServices;

namespace RhHook.MapFunctions
{
  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public class CLogBase
  {
    public IntPtr vfptr;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] m_strFolder;
    public long m_time;
    public IntPtr m_pTempLog;
    public IntPtr m_pThreadLog;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] m_formatter;
  }
}
