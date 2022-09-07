using RhHook.Util;
using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace RhHook
{
  internal class UnmanagedExports
  {
    [DllImport("kernel32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool AllocConsole();

    public static int DllMain(string msg)
    {
      try
      {
        string str;
        using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.IP))
        {
          socket.Connect("8.8.8.8", 65530);
          str = (socket.LocalEndPoint as IPEndPoint).Address.ToString();
        }
        if (str == "26.26.26.26" || str == "51.79.208.239")
        {
          UnmanagedExports.AllocConsole();
          GlobalData.Directory = GlobalData.ConfigPath + "log";
          RhHook.Util.Log.FileOutputEnabled = true;
          RhHook.Util.Log.InfoLogEnabled = true;
          RhHook.Util.Log.ErrorLogEnabled = true;
          RhHook.Util.Log.TraceLogEnabled = true;
          RhHook.Util.Log.TimeStampFormat = "HH:mm:ss.fff";
          AppDomain.CurrentDomain.SetData("APP_CONFIG_FILE", (object) (GlobalData.ConfigPath + "db.config"));
          AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(UnmanagedExports.CurrentDomainAssemblyResolve);
          AppDomain.CurrentDomain.Load("EntityFramework");
          AppDomain.CurrentDomain.Load("EntityFramework.SqlServer");
          Hooks.MemPatch();
          Hooks.FindFunctions();
          Hooks.Set();
          Application.Run((Form) (GlobalData.ControlPanel = new ControlPanel()));
          return 0;
        }
        int num = (int) MessageBox.Show("Invalid IP Address, please contact support!", "Zenon-Development");
        foreach (Process process in Process.GetProcessesByName("MapTh"))
          process.Kill();
        return 0;
      }
      catch (Exception ex)
      {
        System.IO.File.WriteAllText(GlobalData.Directory + "\\startlog.txt", "\r\nTargetSite: " + ex.TargetSite?.ToString() + "\r\nSource: " + ex.Source + "\r\nMessage: " + ex.Message + "\r\nInnerException: " + ex.InnerException?.ToString() + "\r\nStackTrace: " + ex.StackTrace + "\r\n\r\nEnd : ");
        return 0;
      }
    }

    public static Assembly CurrentDomainAssemblyResolve(
      object sender,
      ResolveEventArgs args)
    {
      return args.Name.StartsWith("Detours") ? Assembly.LoadFile(GlobalData.Directory + "log\\Detours.dll") : sender as Assembly;
    }

    public struct Message
    {
      [MarshalAs(UnmanagedType.LPWStr)]
      public string Directory;
    }
  }
}
