// Decompiled with JetBrains decompiler
// Type: RhHook.MapFunctions.CCellManager
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System;
using System.Runtime.InteropServices;

namespace RhHook.MapFunctions
{
  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public class CCellManager : CCellMgr
  {
    public static readonly IntPtr SetPosEntityA = (IntPtr) 5404816;
    public static readonly CCellManager.DSetPosEntity SetPosEntity = (CCellManager.DSetPosEntity) Marshal.GetDelegateForFunctionPointer(CCellManager.SetPosEntityA, typeof (CCellManager.DSetPosEntity));

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate void DSetPosEntity(
      IntPtr @this,
      IntPtr pEntity,
      IntPtr pos,
      int bMove,
      int pTargetID);
  }
}
