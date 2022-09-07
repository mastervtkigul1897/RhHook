// Decompiled with JetBrains decompiler
// Type: RhHook.Data.TagRequest_MAP_COMPOSITION_ITEM_CONSER
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System.IO;
using System.Runtime.InteropServices;

namespace RhHook.Data
{
  [StructLayout(LayoutKind.Sequential, Pack = 1)]
  internal struct TagRequest_MAP_COMPOSITION_ITEM_CONSER
  {
    public RohanStructs.EpochID2s NpcId;
    public RohanStructs.MaterialInfo MaterialInfo;

    public void Read(byte[] data)
    {
      this.NpcId = new RohanStructs.EpochID2s();
      this.MaterialInfo = new RohanStructs.MaterialInfo();
      using (MemoryStream input = new MemoryStream(data))
      {
        using (BinaryReader r = new BinaryReader((Stream) input))
        {
          this.NpcId.Type = r.ReadInt32();
          this.NpcId.DbId = r.ReadInt32();
          this.MaterialInfo.Read(r);
        }
      }
    }
  }
}
