// Decompiled with JetBrains decompiler
// Type: RhHook.MapFunctions.CFriendManager
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using RhHook.Data;
using System;
using System.Runtime.InteropServices;

namespace RhHook.MapFunctions
{
  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public class CFriendManager : CFriendMgr
  {
    public IntPtr m_pPlayer;
    public _tagFriendInfo m_grMyInfo;
    public uint m_dwSearchCursor;
  }
}
