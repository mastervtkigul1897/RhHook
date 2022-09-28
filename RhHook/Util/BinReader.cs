// Decompiled with JetBrains decompiler
// Type: RhHook.Util.BinReader
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using RhHook.Data;
using System.IO;
using System.Runtime.ExceptionServices;

namespace RhHook.Util
{
  internal class BinReader
  {
    [HandleProcessCorruptedStateExceptions]
    public static void LoadBin(BinReader.BinType bin)
    {
      switch (bin)
      {
        case BinReader.BinType.attendance:
          Log.LogString("Atempting to load attendance.bin");
          Bins.Attendance = new Bin<Bins._tagROHANATTENDANCE>(File.ReadAllBytes("C:/Epoch/US_OUT/data/attendance.bin")).items;
          Log.LogString("attendance.bin Loaded.");
          break;
        case BinReader.BinType.itemcostume:
          Log.LogString("Atempting to load itemcostume_t.bin");
          Log.LogString("itemcostume_t.bin Loaded.");
          break;
        case BinReader.BinType.itemtrademallevent:
          Log.LogString("Atempting to load itemtrademall_e.bin");
          Bins.ItemTradeMallEvent = new Bin<Bins._tagROHANITEMTRADEMALLINFO_New>(File.ReadAllBytes("C:/Epoch/US_OUT/data/itemtrademall_e.bin")).items;
          Log.LogString("itemtrademall_e.bin Loaded.");
          break;
      }
    }

    public enum BinType
    {
      attendance,
      itemcostume,
      itemtrademallevent,
    }
  }
}
