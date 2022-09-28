// Decompiled with JetBrains decompiler
// Type: RhHook.MapFunctions.SBattleContext
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System;
using System.Runtime.InteropServices;

namespace RhHook.MapFunctions
{
  internal class SBattleContext
  {
    public static readonly IntPtr InitA = (IntPtr) 5427760;
    public static readonly SBattleContext.DInit Init = (SBattleContext.DInit) Marshal.GetDelegateForFunctionPointer(SBattleContext.InitA, typeof (SBattleContext.DInit));

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DInit(IntPtr @this);
  }
}
