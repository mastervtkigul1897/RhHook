// Decompiled with JetBrains decompiler
// Type: RhHook.Util.Misc
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using RhHook.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

namespace RhHook.Util
{
  internal class Misc
  {
    [HandleProcessCorruptedStateExceptions]
    private static int ReadVectorSize<T>(UnmanagedVector Vector) where T : new()
    {
      Marshal.SizeOf((object) new T());
      return ((int) Vector.LastElement - (int) Vector.Start) / 4;
    }

    [HandleProcessCorruptedStateExceptions]
    public static List<T> ReadObjectVectorToManagedList<T>(UnmanagedVector Vector) where T : new()
    {
      int num = ((int) Vector.LastElement - (int) Vector.Start) / 4;
      List<T> managedList = new List<T>();
      IntPtr start = Vector.Start;
      while ((int) start < (int) Vector.LastElement)
      {
        managedList.Add((T) Marshal.PtrToStructure(Marshal.ReadIntPtr(start), typeof (T)));
        start += 4;
      }
      return managedList;
    }

    [HandleProcessCorruptedStateExceptions]
    public static unsafe T ByteArrayToStructure<T>(byte[] bytes) where T : struct
    {
      fixed (byte* ptr = &bytes[0])
        return (T) Marshal.PtrToStructure((IntPtr) (void*) ptr, typeof (T));
    }

    [HandleProcessCorruptedStateExceptions]
    public static void WriteProcessMemory(IntPtr address, byte[] buffer, bool vp = true)
    {
      uint lpflOldProtect = 0;
      Invoke.VirtualProtectEx(GlobalData.Handle, address, (uint) buffer.Length, 64U, out lpflOldProtect);
      Marshal.Copy(buffer, 0, address, buffer.Length);
      Invoke.VirtualProtectEx(GlobalData.Handle, address, (uint) buffer.Length, lpflOldProtect, out lpflOldProtect);
    }

    [HandleProcessCorruptedStateExceptions]
    public static uint VirtualProtectEasy(IntPtr address, int length, uint protect = 64)
    {
      uint lpflOldProtect = 0;
      Invoke.VirtualProtectEx(GlobalData.Handle, address, (uint) length, protect, out lpflOldProtect);
      return lpflOldProtect;
    }

    [HandleProcessCorruptedStateExceptions]
    public static void MarshalMemMove(IntPtr ptr, int dest, int src, int size)
    {
      byte[] numArray = new byte[size];
      Marshal.Copy(ptr, numArray, 0, dest);
      Marshal.Copy(ptr + src, numArray, dest, size - dest);
      Marshal.Copy(numArray, 0, ptr, size);
    }

    [HandleProcessCorruptedStateExceptions]
    public static byte[] getBytes(object str)
    {
      int length = Marshal.SizeOf(str);
      byte[] destination = new byte[length];
      IntPtr num = Marshal.AllocHGlobal(length);
      Marshal.StructureToPtr(str, num, true);
      Marshal.Copy(num, destination, 0, length);
      Marshal.FreeHGlobal(num);
      return destination;
    }

    [HandleProcessCorruptedStateExceptions]
    private static unsafe bool AlmostEqualUlps(float A, float B, int maxUlps)
    {
      try
      {
        Debug.Assert(true);
        return (double) A == (double) B || Math.Abs(*(int*) &A - *(int*) &B) <= maxUlps;
      }
      catch (Exception ex)
      {
        Log.LogError(ex, "Misc.AlmostEqualUplps");
        return false;
      }
    }

    [HandleProcessCorruptedStateExceptions]
    public static bool CheckPortal(GlobalData.Portal portal)
    {
      try
      {
        if (GlobalData.Debug)
        {
          string[] strArray = new string[6];
          strArray[0] = "Check Portal x = ";
          _tagEpochVector3 pos = portal.pos;
          strArray[1] = pos.x.ToString();
          strArray[2] = " y = ";
          pos = portal.pos;
          strArray[3] = pos.y.ToString();
          strArray[4] = " z = ";
          pos = portal.pos;
          strArray[5] = pos.z.ToString();
          Log.LogString(string.Concat(strArray));
        }
        return GlobalData.Portals.Any<GlobalData.Portal>((Func<GlobalData.Portal, bool>) (t => Misc.AlmostEqualUlps(t.pos.x, portal.pos.x, 100) & Misc.AlmostEqualUlps(t.pos.y, portal.pos.y, 100) & Misc.AlmostEqualUlps(t.pos.z, portal.pos.z, 100) & t.nType == portal.nType));
      }
      catch (Exception ex)
      {
        Log.LogError(ex, "Misc.CheckPortal");
        return false;
      }
    }
  }
}
