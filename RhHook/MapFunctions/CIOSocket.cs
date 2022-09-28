// Decompiled with JetBrains decompiler
// Type: RhHook.MapFunctions.CIOSocket
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using RhHook.Data;
using System;
using System.Runtime.InteropServices;

namespace RhHook.MapFunctions
{
  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public class CIOSocket : CIOObject
  {
    public uint m_hSocket;
    public CIOCriticalSection m_lock;
    public _OVERLAPPED m_overlappedRead;
    public _OVERLAPPED m_overlappedWrite;
    public IntPtr m_pReadBuf;
    public IntPtr m_pFirstBuf;
    public IntPtr m_pLastBuf;
    public int m_nPendingWrite;
  }
}
