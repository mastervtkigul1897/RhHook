// Decompiled with JetBrains decompiler
// Type: RhHook.Util.Guard
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using RhHook.MapFunctions;
using System;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

namespace RhHook.Util
{
  internal class Guard
  {
    [HandleProcessCorruptedStateExceptions]
    public static bool isValidCrushingItem(IntPtr @this, IntPtr prcreq)
    {
      try
      {
        bool flag = false;
        int num1 = 0;
        IntPtr this1 = Marshal.ReadIntPtr(@this, 1332) + 3272;
        int nSlot = (int) Marshal.ReadByte(prcreq, 9);
        int nInventory = (int) Marshal.ReadByte(prcreq, 8);
        int num2 = Marshal.ReadInt32(CInventorySlotManager.GetItem(this1, nInventory, nSlot) + 32);
        int num3 = Marshal.ReadInt32(prcreq);
        if (num3 == num2)
        {
          flag = true;
        }
        else
        {
          Log.LogString("iActualItem = " + num2.ToString() + "; iUsedItem = " + num3.ToString());
          num1 = Marshal.ReadInt32(CInventorySlotManager.GetItem(this1, nInventory, nSlot) + 156);
        }
        return flag;
      }
      catch (Exception ex)
      {
        Log.LogError(ex, "Guard.isValidCrushingItem");
        return false;
      }
    }
  }
}
