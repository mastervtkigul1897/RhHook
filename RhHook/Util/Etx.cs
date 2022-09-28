// Decompiled with JetBrains decompiler
// Type: RhHook.Util.Etx
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System.Runtime.ExceptionServices;

namespace RhHook.Util
{
  internal static class Etx
  {
    [HandleProcessCorruptedStateExceptions]
    public static int LongToInt(this long value)
    {
      int result = 0;
      if (!int.TryParse(value.ToString(), out result))
        result = int.MaxValue;
      return result;
    }

    [HandleProcessCorruptedStateExceptions]
    public static uint LongToInt(this ulong value)
    {
      uint result = 0;
      if (!uint.TryParse(value.ToString(), out result))
        result = uint.MaxValue;
      return result;
    }
  }
}
