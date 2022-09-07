// Decompiled with JetBrains decompiler
// Type: RhHook.Util.Hooks
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using Detours;
using RhHook.DetouredFunctions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace RhHook.Util
{
  internal class Hooks
  {
    private static readonly HookManager manager = new HookManager();
    private static int r = 0;

    public static HookManager Manager => Hooks.manager;

    [HandleProcessCorruptedStateExceptions]
    private static void CurrentDomain_UnhandledException(
      object sender,
      UnhandledExceptionEventArgs e)
    {
      Interlocked.Increment(ref Hooks.r);
      Console.WriteLine("handled. {0}", (object) Hooks.r);
      Console.WriteLine("Terminating " + e.IsTerminating.ToString());
      Thread.CurrentThread.IsBackground = true;
      Thread.CurrentThread.Name = "Dead thread";
      while (true)
        Thread.Sleep(TimeSpan.FromHours(1.0));
    }

    [HandleProcessCorruptedStateExceptions]
    internal static void MemPatch()
    {
      try
      {
        AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(Hooks.CurrentDomain_UnhandledException);
        GlobalData.Handle = Process.GetCurrentProcess().Handle;
      }
      catch (Exception ex)
      {
        Log.LogError(ex, nameof (MemPatch));
      }
    }

    [HandleProcessCorruptedStateExceptions]
    public static void FindFunctions()
    {
      try
      {
        Log.LogString("Mempatch Complete.");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("NewEra-Development Hook | Create by ChowZenon");
        Console.WriteLine("---------------------------------------------");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Hook Started at : " + DateTime.Now.ToString());
        Console.WriteLine("Waiting for connection....");
        Console.ResetColor();
        Console.WriteLine("---------------------------------------------");
        FunctionInfo.MapFunctions.AddRange((IEnumerable<FunctionInfo>) CMapConnection.FunctionInfo);
        FunctionInfo.MapFunctions.AddRange((IEnumerable<FunctionInfo>) CSkillManager.FunctionInfo);
        if (GlobalData.Debug)
          FunctionInfo.MapFunctions.AddRange((IEnumerable<FunctionInfo>) CEntityManager.FunctionInfo);
        FunctionInfo.MapFunctions.AddRange((IEnumerable<FunctionInfo>) CMapConnection.FunctionInfonull);
        foreach (FunctionInfo mapFunction in FunctionInfo.MapFunctions)
        {
          mapFunction.SetTarget(Marshal.GetDelegateForFunctionPointer(mapFunction.Address, mapFunction.TargetType));
          Log.LogFunctionAddress(mapFunction.Name, Marshal.GetFunctionPointerForDelegate(mapFunction.Target));
        }
        GlobalData.CommandConsole = new Task((Action) (() => CommandConsole.ReadCommand()));
        GlobalData.CommandConsole.Start();
        SummonTools.InitSummonEvent();
      }
      catch (Exception ex)
      {
        Log.LogError(ex, "Hooks.FindFunctions");
      }
    }

    [HandleProcessCorruptedStateExceptions]
    public static void Set()
    {
      try
      {
        foreach (FunctionInfo mapFunction in FunctionInfo.MapFunctions)
          Hooks.manager.Add(mapFunction.Target, mapFunction.Detour, mapFunction.Name);
        Hooks.manager.InstallAll();
      }
      catch (Exception ex)
      {
        Log.LogError(ex, "Hooks.Set");
      }
    }
  }
}
