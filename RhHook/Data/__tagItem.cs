// Decompiled with JetBrains decompiler
// Type: RhHook.Data.__tagItem
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System.Runtime.InteropServices;

namespace RhHook.Data
{
  [StructLayout(LayoutKind.Sequential, Pack = 1)]
  public struct __tagItem
  {
    public _tagEpochID2 id;
    public __tagOptions nOptions;
    public sbyte nInventory;
    public sbyte nSlot;
    public byte nStack;
    public byte nRank;
    public byte nEquipLevel;
    public short nEquipStrength;
    public short nEquipDexterity;
    public short nEquipIntelligence;
  }
}
