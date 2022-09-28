// Decompiled with JetBrains decompiler
// Type: RhHook.MapFunctions.CCellMgr
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System;
using System.Runtime.InteropServices;

namespace RhHook.MapFunctions
{
  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public class CCellMgr : CIOBase
  {
    public IntPtr m_CellGraph;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
    public byte[] m_queue;
    public float m_fBaseX;
    public float m_fBaseY;
  }
}
