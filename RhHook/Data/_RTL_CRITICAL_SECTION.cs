// Decompiled with JetBrains decompiler
// Type: RhHook.Data._RTL_CRITICAL_SECTION
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System;
using System.Runtime.InteropServices;

namespace RhHook.Data
{
  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public struct _RTL_CRITICAL_SECTION
  {
    public IntPtr DebugInfo;
    public int LockCount;
    public int RecursionCount;
    public IntPtr OwningThread;
    public IntPtr LockSemaphore;
    public uint SpinCount;
  }
}
