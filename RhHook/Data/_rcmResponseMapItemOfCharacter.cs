// Decompiled with JetBrains decompiler
// Type: RhHook.Data._rcmResponseMapItemOfCharacter
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System.Runtime.InteropServices;

namespace RhHook.Data
{
  [StructLayout(LayoutKind.Sequential, Pack = 1)]
  internal struct _rcmResponseMapItemOfCharacter
  {
    public byte nResult;
    public int nInventory;
    public byte nItemCount;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 60)]
    public __tagItem[] item;
  }
}
