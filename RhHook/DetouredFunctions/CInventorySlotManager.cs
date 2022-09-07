// Decompiled with JetBrains decompiler
// Type: RhHook.DetouredFunctions.CInventorySlotManager
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using Detours;
using RhHook.Util;
using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

namespace RhHook.DetouredFunctions
{
  internal class CInventorySlotManager
  {
    public static readonly CInventorySlotManager.DInitStaticInventory InitStaticInventory = new CInventorySlotManager.DInitStaticInventory(CInventorySlotManager.DetouredInitStaticInventory);
    public static readonly RhHook.Util.FunctionInfo[] FunctionInfo = new RhHook.Util.FunctionInfo[1]
    {
      new RhHook.Util.FunctionInfo((IntPtr) 6919776, "CInventorySlotManager::InitStaticInventory", (Delegate) CInventorySlotManager.InitStaticInventory, (Delegate) CInventorySlotManager._InitStaticInventory, typeof (CInventorySlotManager.DInitStaticInventory))
    };

    [HandleProcessCorruptedStateExceptions]
    private static int DetouredInitStaticInventory(IntPtr @this, int nInventory, int nSlotCount) => nInventory == 0 ? (int) ((Dictionary<string, Hook>) Hooks.Manager)["CInventorySlotManager::InitStaticInventory"].CallOriginal(new object[3]
    {
      (object) @this,
      (object) nInventory,
      (object) 30
    }) : (int) ((Dictionary<string, Hook>) Hooks.Manager)["CInventorySlotManager::InitStaticInventory"].CallOriginal(new object[3]
    {
      (object) @this,
      (object) nInventory,
      (object) nSlotCount
    });

    public static CInventorySlotManager.DInitStaticInventory _InitStaticInventory { get; set; }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
    public delegate int DInitStaticInventory(IntPtr @this, int nInventory, int nSlotCount);
  }
}
