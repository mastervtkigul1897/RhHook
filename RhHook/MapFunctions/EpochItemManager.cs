// Decompiled with JetBrains decompiler
// Type: RhHook.MapFunctions.EpochItemManager
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System;
using System.Runtime.InteropServices;

namespace RhHook.MapFunctions
{
  internal class EpochItemManager
  {
    public static readonly IntPtr CreateItemA = (IntPtr) 5617040;
    public static readonly EpochItemManager.DCreateItem CreateItem = (EpochItemManager.DCreateItem) Marshal.GetDelegateForFunctionPointer(EpochItemManager.CreateItemA, typeof (EpochItemManager.DCreateItem));
    public static IntPtr g_pItemManager = (IntPtr) 8330404;

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate IntPtr DCreateItem(IntPtr @this, IntPtr id, uint nStack);
  }
}
