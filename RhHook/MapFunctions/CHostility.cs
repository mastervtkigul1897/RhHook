// Decompiled with JetBrains decompiler
// Type: RhHook.MapFunctions.CHostility
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System.Runtime.InteropServices;

namespace RhHook.MapFunctions
{
  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public class CHostility
  {
    public int m_nTotalValue;
    public CIOCriticalSection m_csMapHostility;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)]
    public byte[] m_mapHostility;
  }
}
