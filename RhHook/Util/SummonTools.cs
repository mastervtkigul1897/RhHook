// Decompiled with JetBrains decompiler
// Type: RhHook.Util.SummonTools
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using RhHook.Data;
using RhHook.MapFunctions;
using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Timers;

namespace RhHook.Util
{
  internal class SummonTools
  {
    private static CryptoRandom rand = new CryptoRandom();
    private static Timer timerboss;
    private static Timer timerworld;
    public static List<SummonTools.sumlist> summonlist;
    public static List<SummonTools.sumlist2> summonlist2;

    public static void InitTimer()
    {
      SummonTools.timerboss = new Timer();
      SummonTools.timerworld = new Timer();
      SummonTools.timerboss.Elapsed += new ElapsedEventHandler(SummonTools._InitBossSummon);
      SummonTools.timerworld.Elapsed += new ElapsedEventHandler(SummonTools._InitWorldBossSummon);
      SummonTools.timerboss.AutoReset = false;
      SummonTools.timerworld.AutoReset = false;
      SummonTools.timerboss.Interval = (double) SummonTools.rand.Next(TimeSpan.FromMinutes(30.0).Milliseconds, TimeSpan.FromHours(6.0).Milliseconds);
      SummonTools.timerboss.Start();
      SummonTools.timerworld.Interval = (double) SummonTools.rand.Next(TimeSpan.FromHours(1.0).Milliseconds, TimeSpan.FromHours(24.0).Milliseconds);
      SummonTools.timerworld.Start();
    }

    [HandleProcessCorruptedStateExceptions]
    public static void AutoBoss(uint idx, float x, float y, float z, string noticex)
    {
      SummonTools.summonlist2 = new List<SummonTools.sumlist2>();
      SummonTools.summonlist2.Add(new SummonTools.sumlist2()
      {
        id = idx,
        pos = new EpochVector3() { x = x, y = y, z = z },
        hint = noticex
      });
    }

    [HandleProcessCorruptedStateExceptions]
    public static void InitSummonEvent()
    {
      SummonTools.summonlist = new List<SummonTools.sumlist>();
      SummonTools.summonlist.Add(new SummonTools.sumlist()
      {
        id = 328031U,
        pos = new EpochVector3()
        {
          x = 570625f,
          y = 3801f,
          z = 104186f
        }
      });
    }

    public static void _InitBossSummon(object sender, ElapsedEventArgs e)
    {
      SummonTools.InitBossSummon();
      SummonTools.timerboss.Interval = (double) SummonTools.rand.Next(TimeSpan.FromMinutes(30.0).Milliseconds, TimeSpan.FromHours(6.0).Milliseconds);
      SummonTools.timerboss.Start();
    }

    public static void _InitWorldBossSummon(object sender, ElapsedEventArgs e)
    {
      SummonTools.InitWorldBossSummon();
      SummonTools.timerworld.Interval = (double) SummonTools.rand.Next(TimeSpan.FromHours(1.0).Milliseconds, TimeSpan.FromHours(24.0).Milliseconds);
      SummonTools.timerworld.Start();
    }

    [HandleProcessCorruptedStateExceptions]
    public static void InitBossSummon()
    {
      List<uint> list1 = new List<uint>();
      List<SummonTools.bosspos> list2 = new List<SummonTools.bosspos>();
      SummonTools.GenerateProbabilityID(282157U, 333, ref list1);
      SummonTools.GenerateProbabilityID(265185U, 333, ref list1);
      SummonTools.GenerateProbabilityID(282168U, 333, ref list1);
      SummonTools.GenerateProbabilityID(282170U, 333, ref list1);
      SummonTools.GenerateProbabilityID(282169U, 333, ref list1);
      SummonTools.bosspos bosspos = new SummonTools.bosspos();
      bosspos.hint = "Random boss has been summoned at Gathering Hall [B-6].";
      bosspos.pos = new EpochVector3()
      {
        x = 549218f,
        y = 8924f,
        z = 100130f
      };
      SummonTools.GenerateProbabilityPos(bosspos, 500, ref list2);
      bosspos.hint = "Random boss has been summoned at Hazy Ravine [D-2].";
      bosspos.pos = new EpochVector3()
      {
        x = 57130f,
        y = 5257f,
        z = 742068f
      };
      SummonTools.GenerateProbabilityPos(bosspos, 500, ref list2);
      bosspos.hint = "Random boss has been summoned at Mangrove Bay [H-6].";
      bosspos.pos = new EpochVector3()
      {
        x = 173100f,
        y = 6606f,
        z = 1152186f
      };
      SummonTools.GenerateProbabilityPos(bosspos, 500, ref list2);
      int index1 = SummonTools.rand.Next(list1.Count);
      int index2 = SummonTools.rand.Next(list2.Count);
      SummonTools.CreateEntityBioticEvent(list1[index1], list2[index2]);
    }

    [HandleProcessCorruptedStateExceptions]
    public static void InitWorldBossSummon()
    {
      List<uint> list1 = new List<uint>();
      List<SummonTools.bosspos> list2 = new List<SummonTools.bosspos>();
      SummonTools.GenerateProbabilityID(262209U, 333, ref list1);
      SummonTools.GenerateProbabilityID(262211U, 333, ref list1);
      SummonTools.GenerateProbabilityID(262221U, 333, ref list1);
      SummonTools.bosspos bosspos = new SummonTools.bosspos();
      bosspos.hint = "hint";
      bosspos.pos = new EpochVector3()
      {
        x = 581427f,
        y = 4348f,
        z = 122719f
      };
      SummonTools.GenerateProbabilityPos(bosspos, 500, ref list2);
      bosspos.hint = "hint2";
      bosspos.pos = new EpochVector3()
      {
        x = 582225f,
        y = 4381f,
        z = 125045f
      };
      SummonTools.GenerateProbabilityPos(bosspos, 500, ref list2);
      int index1 = SummonTools.rand.Next(list1.Count);
      int index2 = SummonTools.rand.Next(list2.Count);
      SummonTools.CreateEntityBioticEvent(list1[index1], list2[index2]);
    }

    [HandleProcessCorruptedStateExceptions]
    public static void GenerateProbabilityPos(
      SummonTools.bosspos bosspos,
      int amt,
      ref List<SummonTools.bosspos> list)
    {
      for (int index = 0; index < amt; ++index)
        list.Add(bosspos);
    }

    [HandleProcessCorruptedStateExceptions]
    public static void GenerateProbabilityID(uint id, int amt, ref List<uint> list)
    {
      for (int index = 0; index < amt; ++index)
        list.Add(id);
    }

    [HandleProcessCorruptedStateExceptions]
    public static IntPtr CreateEntityBioticEvent(uint id, SummonTools.bosspos sum)
    {
      IntPtr zero = IntPtr.Zero;
      byte[] angle = new byte[12];
      IntPtr num1 = Marshal.AllocHGlobal(12);
      Marshal.StructureToPtr((object) sum.pos, num1, true);
      Marshal.AllocHGlobal(216);
      IntPtr num2 = CEntityScriptManager.Get(Marshal.ReadIntPtr(CEntityScriptManager.g_pEntityScriptManager), id);
      int nType = Marshal.ReadInt32(num2, 4);
      IntPtr entityBioticEvent = CEntityCreater.CreateBiotic(CEntityCreater.g_EntityCreater, nType, 0, num1, angle, 0U, 0, 0, IntPtr.Zero, IntPtr.Zero, 0U);
      Marshal.FreeHGlobal(num2);
      Marshal.FreeHGlobal(num1);
      Notice.SendNotice(sum.hint);
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("Monster {0} spawned via automated event at {0}", (object) nType, (object) DateTime.Now);
      Console.ResetColor();
      return entityBioticEvent;
    }

    [HandleProcessCorruptedStateExceptions]
    public static IntPtr CreateEntityBioticEvent(SummonTools.sumlist sum)
    {
      IntPtr zero = IntPtr.Zero;
      byte[] angle = new byte[12];
      IntPtr num1 = Marshal.AllocHGlobal(12);
      Marshal.StructureToPtr((object) sum.pos, num1, true);
      Marshal.AllocHGlobal(216);
      IntPtr num2 = CEntityScriptManager.Get(Marshal.ReadIntPtr(CEntityScriptManager.g_pEntityScriptManager), sum.id);
      int nType = Marshal.ReadInt32(num2, 4);
      IntPtr entityBioticEvent = CEntityCreater.CreateBiotic(CEntityCreater.g_EntityCreater, nType, 0, num1, angle, 0U, 0, 0, IntPtr.Zero, IntPtr.Zero, 0U);
      Marshal.FreeHGlobal(num2);
      Marshal.FreeHGlobal(num1);
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("NPC {0} spawned via automated NPC Command at {0}", (object) nType, (object) DateTime.Now);
      Console.ResetColor();
      return entityBioticEvent;
    }

    [HandleProcessCorruptedStateExceptions]
    public static IntPtr SummBossEvent(SummonTools.sumlist2 sum)
    {
      IntPtr zero = IntPtr.Zero;
      byte[] angle = new byte[12];
      IntPtr num1 = Marshal.AllocHGlobal(12);
      Marshal.StructureToPtr((object) sum.pos, num1, true);
      Marshal.AllocHGlobal(216);
      IntPtr num2 = CEntityScriptManager.Get(Marshal.ReadIntPtr(CEntityScriptManager.g_pEntityScriptManager), sum.id);
      int nType = Marshal.ReadInt32(num2, 4);
      IntPtr num3 = CEntityCreater.CreateBiotic(CEntityCreater.g_EntityCreater, nType, 0, num1, angle, 0U, 0, 0, IntPtr.Zero, IntPtr.Zero, 0U);
      Marshal.FreeHGlobal(num2);
      Marshal.FreeHGlobal(num1);
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("Monster {0} spawned via automated boss spawner {0}", (object) nType, (object) DateTime.Now);
      Console.ResetColor();
      Notice.SendNotice(sum.hint, (byte) 3);
      return num3;
    }

    [HandleProcessCorruptedStateExceptions]
    public static IntPtr CreateEntityBiotic(uint type, IntPtr player)
    {
      IntPtr zero = IntPtr.Zero;
      byte[] angle = new byte[12];
      IntPtr parentID = CEntityBase.GetEpochId(player);
      IntPtr pos = CEntityBase.GetPos(player);
      Marshal.AllocHGlobal(216);
      IntPtr num = CEntityScriptManager.Get(Marshal.ReadIntPtr(CEntityScriptManager.g_pEntityScriptManager), type);
      int nType = Marshal.ReadInt32(num, 4);
      IntPtr entityBiotic = CEntityCreater.CreateBiotic(CEntityScriptManager.g_pEntityScriptManager, nType, 0, pos, angle, 0U, 0, 0, IntPtr.Zero, parentID, 0U);
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("{0} spawned via fireworks at {0}", (object) nType, (object) DateTime.Now);
      Console.ResetColor();
      Marshal.FreeHGlobal(num);
      return entityBiotic;
    }

    [HandleProcessCorruptedStateExceptions]
    public static IntPtr CreateEntityBiotic(uint type)
    {
      IntPtr zero = IntPtr.Zero;
      byte[] angle = new byte[12];
      IntPtr parentID = CEntityBase.GetEpochId(CommandConsole.GM);
      IntPtr pos = CEntityBase.GetPos(CommandConsole.GM);
      Marshal.AllocHGlobal(216);
      IntPtr num = CEntityScriptManager.Get(Marshal.ReadIntPtr(CEntityScriptManager.g_pEntityScriptManager), type);
      int nType = Marshal.ReadInt32(num, 4);
      IntPtr entityBiotic = CEntityCreater.CreateBiotic(CEntityCreater.g_EntityCreater, nType, 0, pos, angle, 0U, 0, 0, IntPtr.Zero, parentID, 0U);
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("{0} spawned via fake memory at {0}", (object) nType, (object) DateTime.Now);
      Console.ResetColor();
      Notice.SendNotice(type.ToString() + " is roaming at GH now!");
      Marshal.FreeHGlobal(num);
      return entityBiotic;
    }

    [HandleProcessCorruptedStateExceptions]
    public static IntPtr CreateItemBitoic(uint type)
    {
      Console.WriteLine("Creating Biotic.");
      IntPtr zero = IntPtr.Zero;
      byte[] angle = new byte[12];
      Console.WriteLine("Getting ID.");
      IntPtr parentID = CEntityBase.GetEpochId(CommandConsole.GM);
      Console.WriteLine("Getting Pos.");
      IntPtr pos = CEntityBase.GetPos(CommandConsole.GM);
      Console.WriteLine("Complete with ID and Pos.");
      IntPtr num1 = Marshal.AllocHGlobal(8);
      Marshal.AllocHGlobal(164);
      Console.WriteLine("Allocating Item.");
      Console.WriteLine(num1.ToString());
      IntPtr num2 = CIdAllocator.AllocItem(CIdAllocator.g_IdAllocator, num1, type);
      Console.WriteLine("Allocating Item Complete.");
      Console.WriteLine(num1.ToString());
      Console.WriteLine("Creating Item.");
      IntPtr num3 = EpochItemManager.CreateItem(Marshal.ReadIntPtr(EpochItemManager.g_pItemManager), num1, 1U);
      Console.WriteLine("Creating Item Complete.");
      Console.WriteLine("Getting Entity Type.");
      int nType = EpochItemBase.GetItemEntityType(num3);
      Console.WriteLine("Getting Entity Type Complete.");
      Console.WriteLine("Spawing Item.");
      IntPtr itemBitoic = CEntityCreater.CreateBiotic(CEntityCreater.g_EntityCreater, nType, 0, pos, angle, 0U, 0, 0, num3, parentID, 0U);
      Console.WriteLine("Spawing Item Complete.");
      return itemBitoic;
    }

    public struct sumlist
    {
      public uint id;
      public EpochVector3 pos;
    }

    public struct sumlist2
    {
      public uint id;
      public EpochVector3 pos;
      public string hint;
    }

    public struct bosspos
    {
      public EpochVector3 pos;
      public string hint;
    }
  }
}
