using System;
using System.Diagnostics;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Detours;
using RhHook.DetouredFunctions;

namespace RhHook.Util
{
	// Token: 0x02000177 RID: 375
	internal class Hooks
	{
		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000600 RID: 1536 RVA: 0x000139BC File Offset: 0x00011BBC
		public static HookManager Manager
		{
			get
			{
				return Hooks.manager;
			}
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x000139D4 File Offset: 0x00011BD4
		[HandleProcessCorruptedStateExceptions]
		private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
		{
			Interlocked.Increment(ref Hooks.r);
			Console.WriteLine("handled. {0}", Hooks.r);
			Console.WriteLine("Terminating " + e.IsTerminating.ToString());
			Thread.CurrentThread.IsBackground = true;
			Thread.CurrentThread.Name = "Dead thread";
			for (; ; )
			{
				Thread.Sleep(TimeSpan.FromHours(1.0));
			}
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x00013A58 File Offset: 0x00011C58
		[HandleProcessCorruptedStateExceptions]
		internal static void MemPatch()
		{
			try
			{
				AppDomain.CurrentDomain.UnhandledException += Hooks.CurrentDomain_UnhandledException;
				GlobalData.Handle = Process.GetCurrentProcess().Handle;
			}
			catch (Exception e)
			{
				Log.LogError(e, "MemPatch");
			}
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x00013AB4 File Offset: 0x00011CB4
		[HandleProcessCorruptedStateExceptions]
		public static void FindFunctions()
		{
			try
			{
				Log.LogString("Mempatch Complete.");
				Console.ForegroundColor = ConsoleColor.Magenta;
				Console.WriteLine("Rohan: Geizan - Hook");
				Console.WriteLine("Automated Events Activated");
				Console.WriteLine("---------------------------------------------");
				Console.ResetColor();
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine("Hook Started at : " + DateTime.Now.ToString());
				Console.WriteLine("Waiting for connection....");
				Console.ResetColor();
				Console.WriteLine("---------------------------------------------");
				FunctionInfo.MapFunctions.AddRange(CMapConnection.FunctionInfo);
				FunctionInfo.MapFunctions.AddRange(CSkillManager.FunctionInfo);
				bool debug = GlobalData.Debug;
				if (debug)
				{
					FunctionInfo.MapFunctions.AddRange(CEntityManager.FunctionInfo);
				}
				FunctionInfo.MapFunctions.AddRange(CMapConnection.FunctionInfonull);
				foreach (FunctionInfo functionInfo in FunctionInfo.MapFunctions)
				{
					functionInfo.SetTarget(Marshal.GetDelegateForFunctionPointer(functionInfo.Address, functionInfo.TargetType));
					Log.LogFunctionAddress(functionInfo.Name, Marshal.GetFunctionPointerForDelegate(functionInfo.Target));
				}
				GlobalData.CommandConsole = new Task(delegate ()
				{
					CommandConsole.ReadCommand();
				});
				GlobalData.CommandConsole.Start();
				SummonTools.InitSummonEvent();
			}
			catch (Exception e)
			{
				Log.LogError(e, "Hooks.FindFunctions");
			}
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x00013C64 File Offset: 0x00011E64
		[HandleProcessCorruptedStateExceptions]
		public static void Set()
		{
			try
			{
				foreach (FunctionInfo functionInfo in FunctionInfo.MapFunctions)
				{
					Hooks.manager.Add(functionInfo.Target, functionInfo.Detour, functionInfo.Name);
				}
				Hooks.manager.InstallAll();
			}
			catch (Exception e)
			{
				Log.LogError(e, "Hooks.Set");
			}
		}

		// Token: 0x0400058A RID: 1418
		private static readonly HookManager manager = new HookManager();

		// Token: 0x0400058B RID: 1419
		private static int r = 0;
	}
}
