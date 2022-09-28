// Decompiled with JetBrains decompiler
// Type: RhHook.Data._tagRequestMapIndunBuyItem
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System.Runtime.InteropServices;

namespace RhHook.Data
{
  [StructLayout(LayoutKind.Sequential, Pack = 2)]
  public struct _tagRequestMapIndunBuyItem
  {
    public _tagEpochID2 NpcId;
    public _tagEpochID2 ItemId;
    public byte nIATType;
    public byte nStackCnt;
  }
}
