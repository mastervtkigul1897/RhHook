// Decompiled with JetBrains decompiler
// Type: RhHook.Util.CommandConsole
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using RhHook.MapFunctions;
using System;
using System.Runtime.ExceptionServices;
using System.Text;

namespace RhHook.Util
{
  internal class CommandConsole
  {
    public static IntPtr GM = IntPtr.Zero;

    [HandleProcessCorruptedStateExceptions]
    public static void ReadCommand()
    {
      while (true)
      {
        string[] strArray = Console.ReadLine().Split(' ');
        string str = strArray[0];
        if (!(str == "/notice"))
        {
          if (!(str == "/sumi"))
          {
            if (!(str == "/summ"))
            {
              if (!(str == "/setgm"))
              {
                if (!(str == "/npc"))
                {
                  if (!(str == "/randomboss"))
                  {
                    if (str == "/randomworldboss")
                      SummonTools.InitWorldBossSummon();
                  }
                  else
                    SummonTools.InitBossSummon();
                }
                else
                {
                  foreach (SummonTools.sumlist sum in SummonTools.summonlist)
                    SummonTools.CreateEntityBioticEvent(sum);
                }
              }
              else
                CommandConsole.ProccessCommand(CommandConsole.command.setgm, strArray);
            }
            else
              CommandConsole.ProccessCommand(CommandConsole.command.summ, strArray);
          }
          else
            CommandConsole.ProccessCommand(CommandConsole.command.sumi, strArray);
        }
        else
          CommandConsole.ProccessCommand(CommandConsole.command.notice, strArray);
      }
    }

    [HandleProcessCorruptedStateExceptions]
    public static void ProccessCommand(CommandConsole.command cmd, string[] param)
    {
      try
      {
        switch (cmd)
        {
          case CommandConsole.command.sumi:
            uint result1 = 0;
            uint.TryParse(param[1], out result1);
            SummonTools.CreateItemBitoic(result1);
            break;
          case CommandConsole.command.summ:
            uint result2 = 0;
            uint.TryParse(param[1], out result2);
            SummonTools.CreateEntityBiotic(result2);
            break;
          case CommandConsole.command.setgm:
            CommandConsole.GM = CommandConsole.GetPlayer(param[1]);
            if (!(CommandConsole.GM != IntPtr.Zero))
              break;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Fake has been generated, reference has been set to #" + CommandConsole.GM.ToString());
            Console.ResetColor();
            break;
          case CommandConsole.command.notice:
            Notice.SendNotice(param[1]);
            break;
        }
      }
      catch (Exception ex)
      {
        Log.LogError(ex, "CommandConsole.ProccessCommand");
      }
    }

    [HandleProcessCorruptedStateExceptions]
    private static IntPtr GetPlayer(string player) => CEntityManager.FindBiotic(CEntityManager.g_EntityManager, Encoding.ASCII.GetBytes(player), 0U);

    public enum command
    {
      sumi,
      summ,
      setgm,
      notice,
    }
  }
}
