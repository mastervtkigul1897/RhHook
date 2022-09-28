// Decompiled with JetBrains decompiler
// Type: RhHook.Data.Bin`1
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace RhHook.Data
{
  public class Bin<T> : IBin
  {
    public List<T> items;

    public Bin(byte[] reader) => this.ReadStaticBin(reader);

    public void ReadStaticBin(byte[] reader)
    {
      this.items = new List<T>();
      List<byte> byteList = new List<byte>((IEnumerable<byte>) reader);
      int count = Marshal.SizeOf(typeof (T));
      int length = reader.Length;
      for (int index = 0; length - index >= count; index += count)
      {
        GCHandle gcHandle = GCHandle.Alloc((object) byteList.GetRange(index, count).ToArray(), GCHandleType.Pinned);
        this.items.Add((T) Marshal.PtrToStructure(gcHandle.AddrOfPinnedObject(), typeof (T)));
        gcHandle.Free();
      }
    }
  }
}
