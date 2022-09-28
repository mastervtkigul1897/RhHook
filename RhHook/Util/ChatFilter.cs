// Decompiled with JetBrains decompiler
// Type: RhHook.Util.ChatFilter
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

namespace RhHook.Util
{
  internal class ChatFilter
  {
    [HandleProcessCorruptedStateExceptions]
    public static void Common(IntPtr pData)
    {
      int num1 = (int) Marshal.ReadInt16(pData);
      int num2 = (int) Marshal.ReadInt16(pData, 2);
      byte[] destination1 = new byte[num2 + 4];
      Marshal.Copy(pData, destination1, 0, num2 + 4);
      short num3 = Marshal.ReadInt16(pData, 18);
      if (num3 > (short) byte.MaxValue)
        return;
      short num4 = 0;
      if (Marshal.ReadInt16(pData, 20) != (short) 0)
        num4 = Marshal.ReadInt16(pData, 20);
      Invoke.memmove(pData + 8, pData + 18, (int) num3 + (int) num4 + 7);
      Marshal.WriteInt16(pData, 2, (short) (11 + (int) num3 + (int) num4));
      int num5 = (int) Marshal.ReadInt16(pData, 2);
      byte[] destination2 = new byte[num5 + 4];
      Marshal.Copy(pData, destination2, 0, num5 + 4);
    }

    [HandleProcessCorruptedStateExceptions]
    public static void Alliance(IntPtr pData)
    {
      int num1 = (int) Marshal.ReadInt16(pData);
      int num2 = (int) Marshal.ReadInt16(pData, 2);
      short num3 = Marshal.ReadInt16(pData, 18);
      if (num3 > (short) byte.MaxValue)
        return;
      byte[] destination1 = new byte[num2 + 4];
      Marshal.Copy(pData, destination1, 0, num2 + 4);
      Invoke.memmove(pData + 8, pData + 18, (int) num3 + 2);
      Marshal.WriteInt16(pData, 2, (short) (6 + (int) num3));
      int num4 = (int) Marshal.ReadInt16(pData, 2);
      byte[] destination2 = new byte[num4 + 4];
      Marshal.Copy(pData, destination2, 0, num4 + 4);
    }
  }
}
