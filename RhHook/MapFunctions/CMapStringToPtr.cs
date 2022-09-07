// Decompiled with JetBrains decompiler
// Type: RhHook.MapFunctions.CMapStringToPtr
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System;
using System.Runtime.InteropServices;

namespace RhHook.MapFunctions
{
  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public class CMapStringToPtr : CObject
  {
    public IntPtr m_pHashTable;
    public uint m_nHashTableSize;
    public int m_nCount;
    public IntPtr m_pFreeList;
    public IntPtr m_pBlocks;
    public int m_nBlockSize;
  }
}
