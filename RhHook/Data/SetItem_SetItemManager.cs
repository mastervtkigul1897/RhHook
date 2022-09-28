// Decompiled with JetBrains decompiler
// Type: RhHook.Data.SetItem_SetItemManager
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System;
using System.Runtime.InteropServices;

namespace RhHook.Data
{
  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public struct SetItem_SetItemManager
  {
    public IntPtr m_mgrUsrSlot;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
    public byte[] m_lstUserSetItem;
  }
}
