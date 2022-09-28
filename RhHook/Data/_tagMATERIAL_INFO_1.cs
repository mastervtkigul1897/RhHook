// Decompiled with JetBrains decompiler
// Type: RhHook.Data._tagMATERIAL_INFO_1
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System.Runtime.InteropServices;

namespace RhHook.Data
{
  [StructLayout(LayoutKind.Sequential, Pack = 1)]
  public struct _tagMATERIAL_INFO_1
  {
    public int dwItemType;
    public _tagITEM_INFO Material1;
    public _tagITEM_INFO Material2;
    public _tagITEM_INFO Option1;
    public _tagITEM_INFO Option2;
    public _tagITEM_INFO ConserStone;
  }
}
