// Decompiled with JetBrains decompiler
// Type: RhHook.MapFunctions._tagAffectSkill
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using RhHook.Data;
using System;
using System.Runtime.InteropServices;

namespace RhHook.MapFunctions
{
  [StructLayout(LayoutKind.Sequential, Pack = 1)]
  internal class _tagAffectSkill
  {
    public static readonly IntPtr InitA = (IntPtr) 4285936;
    public static readonly _tagAffectSkill.DInit Init = (_tagAffectSkill.DInit) Marshal.GetDelegateForFunctionPointer(_tagAffectSkill.InitA, typeof (_tagAffectSkill.DInit));
    public ushort nKind;
    public byte nLevel;
    public uint nAffectTime;
    public uint nEventTime;
    public byte nEventType;
    public uint dwDurationTime;
    public uint dwEntityID;
    public _tagEpochVector3 Pos;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = true)]
    public delegate void DInit(IntPtr @this);
  }
}
