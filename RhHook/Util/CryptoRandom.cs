// Decompiled with JetBrains decompiler
// Type: RhHook.Util.CryptoRandom
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography;

namespace RhHook.Util
{
  internal class CryptoRandom : RandomNumberGenerator
  {
    private static RandomNumberGenerator r;

    [HandleProcessCorruptedStateExceptions]
    public override void GetNonZeroBytes(byte[] data) => CryptoRandom.r.GetNonZeroBytes(data);

    public CryptoRandom() => CryptoRandom.r = RandomNumberGenerator.Create();

    [HandleProcessCorruptedStateExceptions]
    public override void GetBytes(byte[] buffer) => CryptoRandom.r.GetBytes(buffer);

    [HandleProcessCorruptedStateExceptions]
    public double NextDouble()
    {
      byte[] data = new byte[4];
      CryptoRandom.r.GetBytes(data);
      return (double) BitConverter.ToUInt32(data, 0) / (double) uint.MaxValue;
    }

    [HandleProcessCorruptedStateExceptions]
    public int Next(int minValue, int maxValue) => (int) Math.Round(this.NextDouble() * (double) (maxValue - minValue - 1)) + minValue;

    [HandleProcessCorruptedStateExceptions]
    public int Next() => this.Next(0, int.MaxValue);

    [HandleProcessCorruptedStateExceptions]
    public int Next(int maxValue) => this.Next(0, maxValue);
  }
}
