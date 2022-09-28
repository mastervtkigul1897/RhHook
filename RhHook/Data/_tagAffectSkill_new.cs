// Decompiled with JetBrains decompiler
// Type: RhHook.Data._tagAffectSkill_new
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System.Runtime.InteropServices;

namespace RhHook.Data
{
  [StructLayout(LayoutKind.Sequential, Pack = 1)]
  internal struct _tagAffectSkill_new
  {
    public ushort nKind;
    public byte nLevel;
    public uint nAffectTime;
    public uint nEventTime;
    public byte nEventType;
    public uint dwDurationTime;
    public uint dwEntityID;
    public uint unknown;
    public _tagEpochVector3 Pos;
  }
}
