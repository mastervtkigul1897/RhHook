﻿// Decompiled with JetBrains decompiler
// Type: RhHook.Data._tagRequestMAP_TELEPORT
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System.Runtime.InteropServices;

namespace RhHook.Data
{
  [StructLayout(LayoutKind.Sequential, Pack = 1)]
  internal struct _tagRequestMAP_TELEPORT
  {
    public _tagEpochVector3 pos;
    public byte nType;
    public int nBind;
    public int nPortal;
  }
}
