// Decompiled with JetBrains decompiler
// Type: RhHook.MapFunctions.CEntityScriptManager
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System;
using System.Runtime.InteropServices;

namespace RhHook.MapFunctions
{
  internal class CEntityScriptManager
  {
    public static readonly IntPtr GetA = (IntPtr) 6995792;
    public static readonly CEntityScriptManager.DGet Get = (CEntityScriptManager.DGet) Marshal.GetDelegateForFunctionPointer(CEntityScriptManager.GetA, typeof (CEntityScriptManager.DGet));
    public static IntPtr g_pEntityScriptManager = (IntPtr) 7929056;

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate IntPtr DGet(IntPtr @this, uint id);
  }
}
