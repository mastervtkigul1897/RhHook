// Decompiled with JetBrains decompiler
// Type: RhHook.Data.ECONDITIONSTATE
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

namespace RhHook.Data
{
  public enum ECONDITIONSTATE : uint
  {
    CS_NORMAL = 0,
    CS_BLIND = 16, // 0x00000010
    CS_SILENCE = 32, // 0x00000020
    CS_POISON = 64, // 0x00000040
    CS_ROOT = 1073741832, // 0x40000008
    CS_DONT_ACTION = 2147487744, // 0x80001000
    CS_STUN = 3221225473, // 0xC0000001
    CS_CONFUSION = 3221225474, // 0xC0000002
    CS_SLEEP = 3221225476, // 0xC0000004
    CS_PALSY = 3221226496, // 0xC0000400
    CS_CASTING = 3221227520, // 0xC0000800
    CS_COMA = 3758096512, // 0xE0000080
    CS_ROBBER = 3758096896, // 0xE0000200
    CS_STUN_DONOT_RELEASE = 4026532096, // 0xF0000100
  }
}
