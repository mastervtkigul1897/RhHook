// Decompiled with JetBrains decompiler
// Type: RhHook.Data._tagGR_PRIVATE_SHOP_INFO
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System.Runtime.InteropServices;

namespace RhHook.Data
{
  [StructLayout(LayoutKind.Sequential, Pack = 1)]
  public struct _tagGR_PRIVATE_SHOP_INFO
  {
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 21)]
    public byte[] szSellerName;
    public __tagItem Item;
    public long nPrice;
    public int nLocationIndex;
  }
}
