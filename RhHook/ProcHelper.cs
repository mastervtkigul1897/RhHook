// Decompiled with JetBrains decompiler
// Type: RhHook.ProcHelper
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace RhHook
{
  internal class ProcHelper
  {
    [DllImport("kernel32.dll")]
    private static extern IntPtr OpenThread(
      ProcHelper.ThreadAccess dwDesiredAccess,
      bool bInheritHandle,
      uint dwThreadId);

    [DllImport("kernel32.dll")]
    private static extern uint SuspendThread(IntPtr hThread);

    [DllImport("kernel32.dll")]
    private static extern int ResumeThread(IntPtr hThread);

    [DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
    private static extern bool CloseHandle(IntPtr handle);

    public static void SuspendProcess(int pid, int currentthread)
    {
      Process processById = Process.GetProcessById(pid);
      if (processById.ProcessName == string.Empty)
        return;
      foreach (ProcessThread thread in (ReadOnlyCollectionBase) processById.Threads)
      {
        IntPtr num1 = ProcHelper.OpenThread(ProcHelper.ThreadAccess.SUSPEND_RESUME, false, (uint) thread.Id);
        if (!(num1 == IntPtr.Zero))
        {
          if (thread.Id != currentthread)
          {
            int num2 = (int) ProcHelper.SuspendThread(num1);
          }
          ProcHelper.CloseHandle(num1);
        }
      }
    }

    public static void ResumeProcess(int pid)
    {
      Process processById = Process.GetProcessById(pid);
      if (processById.ProcessName == string.Empty)
        return;
      foreach (ProcessThread thread in (ReadOnlyCollectionBase) processById.Threads)
      {
        IntPtr num = ProcHelper.OpenThread(ProcHelper.ThreadAccess.SUSPEND_RESUME, false, (uint) thread.Id);
        if (!(num == IntPtr.Zero))
        {
          do
            ;
          while (ProcHelper.ResumeThread(num) > 0);
          ProcHelper.CloseHandle(num);
        }
      }
    }

    [Flags]
    public enum ThreadAccess
    {
      TERMINATE = 1,
      SUSPEND_RESUME = 2,
      GET_CONTEXT = 8,
      SET_CONTEXT = 16, // 0x00000010
      SET_INFORMATION = 32, // 0x00000020
      QUERY_INFORMATION = 64, // 0x00000040
      SET_THREAD_TOKEN = 128, // 0x00000080
      IMPERSONATE = 256, // 0x00000100
      DIRECT_IMPERSONATION = 512, // 0x00000200
    }
  }
}
