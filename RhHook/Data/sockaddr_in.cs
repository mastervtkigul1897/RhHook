﻿// Decompiled with JetBrains decompiler
// Type: RhHook.Data.sockaddr_in
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System.Runtime.InteropServices;

namespace RhHook.Data
{
  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public struct sockaddr_in
  {
    public short sin_family;
    public ushort sin_port;
    public in_addr sin_addr;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
    public byte[] sin_zero;
  }
}
