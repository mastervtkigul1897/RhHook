// Decompiled with JetBrains decompiler
// Type: RhHook.MapFunctions.Mercenary_Task_Manager
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System.Runtime.InteropServices;

namespace RhHook.MapFunctions
{
  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public class Mercenary_Task_Manager
  {
    public CIOCriticalSection m_crit;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
    public byte[] m_list;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 52)]
    public byte[] m_pool;
  }
}
