// Decompiled with JetBrains decompiler
// Type: RhHook.MapFunctions.CInventorySlot
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System;
using System.Runtime.InteropServices;

namespace RhHook.MapFunctions
{
  internal class CInventorySlot
  {
    public static readonly IntPtr InitA = (IntPtr) 6918336;
    public static readonly CInventorySlot.DInit Init = (CInventorySlot.DInit) Marshal.GetDelegateForFunctionPointer(CInventorySlot.InitA, typeof (CInventorySlot.DInit));

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DInit(IntPtr @this, IntPtr pBagItem);
  }
}
