// Decompiled with JetBrains decompiler
// Type: RhHook.Util.LogMessageInfo
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System;
using System.Threading;

namespace RhHook.Util
{
  public sealed class LogMessageInfo : EventArgs
  {
    public readonly DateTime Timestamp;
    public readonly string ThreadId;
    public readonly string Level;
    public readonly string Logger;
    public readonly string Message;

    public bool IsError => "ERROR".Equals(this.Level, StringComparison.Ordinal);

    public bool IsWarning => "WARN".Equals(this.Level, StringComparison.Ordinal);

    public bool IsInformation => "INFO".Equals(this.Level, StringComparison.Ordinal);

    public bool IsDebug => "DEBUG".Equals(this.Level, StringComparison.Ordinal);

    public LogMessageInfo(string level, string logger, string message)
    {
      this.Timestamp = DateTime.UtcNow;
      Thread currentThread = Thread.CurrentThread;
      this.ThreadId = string.IsNullOrEmpty(currentThread.Name) ? currentThread.ManagedThreadId.ToString() : currentThread.Name;
      this.Level = level;
      this.Logger = logger;
      this.Message = message;
    }

    public override string ToString() => string.Format("{0:dd/MM/yyyy HH:mm:ss.fff} {1} {2} {3} {4}", (object) this.Timestamp, (object) this.ThreadId, (object) this.Logger, (object) this.Level, (object) this.Message);
  }
}
