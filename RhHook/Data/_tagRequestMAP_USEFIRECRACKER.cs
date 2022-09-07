// Decompiled with JetBrains decompiler
// Type: RhHook.Data._tagRequestMAP_USEFIRECRACKER
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System.Runtime.InteropServices;

namespace RhHook.Data
{
  [StructLayout(LayoutKind.Sequential, Pack = 2)]
  public struct _tagRequestMAP_USEFIRECRACKER
  {
    public _tagEpochID2 itemID;
    public byte nInventory;
    public byte nSlot;
  }
}
