// Decompiled with JetBrains decompiler
// Type: RhHook.Data.RohanStructs
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System.IO;
using System.Runtime.InteropServices;

namespace RhHook.Data
{
  public static class RohanStructs
  {
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct EpochID2s
    {
      public int Type;
      public int DbId;
    }

    public struct ItemInfo
    {
      public RohanStructs.EpochID2s Id;
      public byte Inventory;
      public byte Slot;
    }

    public struct MaterialInfo
    {
      public int ItemType;
      public RohanStructs.ItemInfo Material1;
      public RohanStructs.ItemInfo Material2;
      public RohanStructs.ItemInfo Option1;
      public RohanStructs.ItemInfo Option2;
      public RohanStructs.ItemInfo ConserStone;

      public void Read(BinaryReader r)
      {
        this.ItemType = r.ReadInt32();
        this.Material1.Id.Type = r.ReadInt32();
        this.Material1.Id.DbId = r.ReadInt32();
        this.Material1.Inventory = r.ReadByte();
        this.Material1.Slot = r.ReadByte();
        this.Material2.Id.Type = r.ReadInt32();
        this.Material2.Id.DbId = r.ReadInt32();
        this.Material2.Inventory = r.ReadByte();
        this.Material2.Slot = r.ReadByte();
        this.Option1.Id.Type = r.ReadInt32();
        this.Option1.Id.DbId = r.ReadInt32();
        this.Option1.Inventory = r.ReadByte();
        this.Option1.Slot = r.ReadByte();
        this.Option2.Id.Type = r.ReadInt32();
        this.Option2.Id.DbId = r.ReadInt32();
        this.Option2.Inventory = r.ReadByte();
        this.Option2.Slot = r.ReadByte();
        this.ConserStone.Id.Type = r.ReadInt32();
        this.ConserStone.Id.DbId = r.ReadInt32();
        this.ConserStone.Inventory = r.ReadByte();
        this.ConserStone.Slot = r.ReadByte();
      }
    }
  }
}
