// Decompiled with JetBrains decompiler
// Type: RhHook.Util.Logger
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System;
using System.IO;
using System.Text;
using System.Threading;

namespace RhHook.Util
{
  public sealed class Logger
  {
    public static bool LogToConsole = false;
    public static int BatchInterval = 1000;
    public static bool IgnoreDebug = false;
    private static readonly Timer Timer = new Timer(new TimerCallback(Logger.Tick));
    private static readonly StringBuilder LogQueue = new StringBuilder();
    private bool _startedErrorShown = false;
    public readonly string Name;
    public EventHandler<LogMessageInfo> LogMessageAdded;
    public const string DEBUG = "DEBUG";
    public const string INFO = "INFO";
    public const string WARN = "WARN";
    public const string ERROR = "ERROR";

    public static bool Listening { get; private set; }

    public static FileInfo TargetLogFile { get; private set; }

    public static DirectoryInfo TargetDirectory => Logger.TargetLogFile?.Directory;

    public static void Start(FileInfo targetLogFile)
    {
      if (Logger.Listening)
        return;
      Logger.Listening = true;
      Logger.TargetLogFile = targetLogFile;
      Logger.VerifyTargetDirectory();
      Logger.Timer.Change(Logger.BatchInterval, -1);
    }

    private static void VerifyTargetDirectory()
    {
      if (Logger.TargetDirectory == null)
        throw new DirectoryNotFoundException("Target logging directory not found.");
      Logger.TargetDirectory.Refresh();
      if (Logger.TargetDirectory.Exists)
        return;
      Logger.TargetDirectory.Create();
    }

    private static void Tick(object state)
    {
      try
      {
        string contents = "";
        lock (Logger.LogQueue)
        {
          contents = Logger.LogQueue.ToString();
          Logger.LogQueue.Length = 0;
        }
        if (string.IsNullOrEmpty(contents))
          return;
        if (Logger.LogToConsole)
          Console.Write(contents);
        Logger.VerifyTargetDirectory();
        File.AppendAllText(Logger.TargetLogFile.FullName, contents);
      }
      finally
      {
        if (Logger.Listening)
          Logger.Timer.Change(Logger.BatchInterval, -1);
      }
    }

    public static void ShutDown()
    {
      if (!Logger.Listening)
        return;
      Logger.Listening = false;
      Logger.Timer.Dispose();
      Logger.Tick((object) null);
    }

    public Logger(Type t)
      : this(t.Name)
    {
    }

    public Logger(string name) => this.Name = name;

    public void Debug(string message)
    {
      if (Logger.IgnoreDebug)
        return;
      this.Log("DEBUG", message);
    }

    public void Info(string message) => this.Log("INFO", message);

    public void Warn(string message, Exception ex = null) => this.Log("WARN", message, ex);

    public void Error(string message, Exception ex = null) => this.Log("ERROR", message);

    public void Log(string level, string message, Exception ex = null)
    {
      if (!this.CheckListening())
        return;
      if (ex != null)
        message += string.Format("\r\n{0}\r\n{1}", (object) ex.Message, (object) ex.StackTrace);
      LogMessageInfo e = new LogMessageInfo(level, this.Name, message);
      string str = e.ToString();
      lock (Logger.LogQueue)
        Logger.LogQueue.AppendLine(str);
      EventHandler<LogMessageInfo> logMessageAdded = this.LogMessageAdded;
      if (logMessageAdded == null)
        return;
      logMessageAdded((object) this, e);
    }

    private bool CheckListening()
    {
      if (Logger.Listening)
        return true;
      if (!this._startedErrorShown)
      {
        Console.WriteLine("Logging has not been started.");
        this._startedErrorShown = true;
      }
      return false;
    }
  }
}
