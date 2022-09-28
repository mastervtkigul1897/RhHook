// Decompiled with JetBrains decompiler
// Type: RhHook.Util.Log
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System;
using System.Collections.Concurrent;
using System.IO;
using System.Threading;

namespace RhHook.Util
{
  public static class Log
  {
    public static string TimeStampFormat = "HH:mm:ss.fff";
    public static bool FileOutputEnabled = true;
    public static bool InfoLogEnabled = true;
    public static bool ErrorLogEnabled = true;
    public static bool TraceLogEnabled = true;
    private static int _currentDay = -1;
    private static readonly BlockingCollection<string> LogQueue = new BlockingCollection<string>();
    private const string DateTimeStampFormat = "yyyy-MM-dd HH:mm:ss.fff";
    public static bool ConsoleOutputEnabled;
    private static readonly Thread _writingThread;
    private static StreamWriter _currentFileStream;

    public static void DoGracefullExit()
    {
      try
      {
        Log.LogQueue.CompleteAdding();
        Log._writingThread.Join();
      }
      catch
      {
      }
    }

    public static void Info(string msg, params object[] par)
    {
      if (!Log.InfoLogEnabled)
        return;
      Log.LogQueue.Add(string.Format("{0} INFO {1}\r\n\r\n", (object) DateTime.UtcNow.ToString(Log.TimeStampFormat), par == null || par.Length == 0 ? (object) msg : (object) string.Format(msg, par)));
    }

    public static void LogError(Exception e, string Location)
    {
      if (!Log.ErrorLogEnabled)
        return;
      Log.LogQueue.Add(string.Format("{0} Location: {1}\r\n{0} TargetSite: {2}\r\n{0} Source: {3}\r\n{0} Message: {4}\r\n{0} InnerException: {5}\r\n{0} StackTrace: {6}\r\n{0} nEnd : {1}\r\n\r\n", (object) DateTime.UtcNow.ToString(Log.TimeStampFormat), (object) Location, (object) e.TargetSite, (object) e.Source, (object) e.Message, (object) e.InnerException, (object) e.StackTrace));
    }

    public static void LogFunctionAddress(string name, IntPtr address) => Log.LogQueue.Add(string.Format("{0}: {1}\r\n", (object) name, (object) address.ToString("X8")));

    public static void LogString(string str)
    {
      if (!Log.InfoLogEnabled)
        return;
      Log.LogQueue.Add(string.Format("{0} INFO {1}{2}{1}\r\n\r\n", (object) DateTime.UtcNow.ToString(Log.TimeStampFormat), (object) '"', (object) str));
    }

    public static void Error(string msg, params object[] par)
    {
      if (!Log.ErrorLogEnabled)
        return;
      Log.LogQueue.Add(string.Format("{0} ERR {1}\r\n\r\n", (object) DateTime.UtcNow.ToString(Log.TimeStampFormat), par == null || par.Length == 0 ? (object) msg : (object) string.Format(msg, par)));
    }

    static Log()
    {
      AppDomain.CurrentDomain.ProcessExit += (EventHandler) ((s, a) => Log.DoGracefullExit());
      Log._writingThread = new Thread(new ThreadStart(Log.Write));
      Log._writingThread.Name = "Log writer thread";
      Log._writingThread.IsBackground = true;
      Log._writingThread.Priority = ThreadPriority.BelowNormal;
      Log._writingThread.Start();
      Log.LogQueue.Add(string.Format("-------------------------------------------------\r\n{0} Logging system is initialized\r\n-------------------------------------------------\r\n", (object) DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss.fff")));
    }

    private static StreamWriter LogFile
    {
      get
      {
        if (DateTime.UtcNow.Day == Log._currentDay)
          return Log._currentFileStream;
        DateTime utcNow = DateTime.UtcNow;
        Log._currentDay = utcNow.Day;
        string path1 = Path.Combine(Path.GetDirectoryName(GlobalData.Directory), nameof (Log));
        if (!Directory.Exists(path1))
          Directory.CreateDirectory(path1);
        string path1_1 = path1;
        utcNow = DateTime.UtcNow;
        string path2 = utcNow.ToString("R\\h\\Hook_yyMMdd.lo\\g");
        string path3 = Path.Combine(path1_1, path2);
        if (Log._currentFileStream != null)
          Log._currentFileStream.Dispose();
        Log._currentFileStream = new StreamWriter((Stream) File.Open(path3, FileMode.Append, FileAccess.Write, FileShare.ReadWrite));
        Log._currentFileStream.AutoFlush = true;
        return Log._currentFileStream;
      }
    }

    private static void Write()
    {
      try
      {
        while (true)
        {
          string str1 = Log.LogQueue.Take();
          if (Log.FileOutputEnabled)
            Log.LogFile.Write(str1);
          if (Log.ConsoleOutputEnabled)
          {
            ConsoleColor foregroundColor = Console.ForegroundColor;
            string str2 = str1.Substring(9, 3);
            if (!(str2 == "ERR"))
            {
              if (str2 == "INF")
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            else
              Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(str1);
            Console.ForegroundColor = foregroundColor;
          }
        }
      }
      catch
      {
        string str = string.Format("---------------------------------------------------\r\n{0} Logging system is shutting down\r\n---------------------------------------------------\r\n", (object) DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss.fff"));
        if (Log.FileOutputEnabled)
          Log.LogFile.Write(str);
        if (!Log.ConsoleOutputEnabled)
          return;
        Console.Write(str);
      }
    }
  }
}
