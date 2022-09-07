// Decompiled with JetBrains decompiler
// Type: RhHook.Util.Invoke
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

namespace RhHook.Util
{
  internal class Invoke
  {
    [HandleProcessCorruptedStateExceptions]
    [DllImport("kernel32.dll")]
    public static extern bool VirtualProtectEx(
      IntPtr hProcess,
      IntPtr lpAddress,
      uint dwSize,
      uint flNewProtect,
      out uint lpflOldProtect);

    [HandleProcessCorruptedStateExceptions]
    [DllImport("kernel32.dll", SetLastError = true)]
    public static extern bool WriteProcessMemory(
      IntPtr hProcess,
      IntPtr lpBaseAddress,
      byte[] lpBuffer,
      int dwSize);

    [HandleProcessCorruptedStateExceptions]
    [DllImport("Kernel32.dll", EntryPoint = "RtlMoveMemory")]
    public static extern void memmove(IntPtr dest, IntPtr src, int size);

    [HandleProcessCorruptedStateExceptions]
    [DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr memcpy(byte[] dest, IntPtr src, int count);

    [HandleProcessCorruptedStateExceptions]
    [DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr memset(IntPtr dest, int value, int count);

    [HandleProcessCorruptedStateExceptions]
    [DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr memcpy(IntPtr dest, byte[] src, int count);

    [HandleProcessCorruptedStateExceptions]
    [DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr memcpy(IntPtr dest, IntPtr src, int count);

    [DllImport("winmm.dll", EntryPoint = "timeGetTime")]
    public static extern uint MM_GetTime();

    [DllImport("winmm.dll")]
    public static extern uint timeGetTime();

    [DllImport("kernel32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool AllocConsole();

    [DllImport("user32.dll")]
    public static extern bool EnableMenuItem(IntPtr hMenu, uint uIDEnableItem, uint uEnable);

    [DllImport("user32.dll")]
    public static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
  }
}
