// Decompiled with JetBrains decompiler
// Type: RhHook.MapFunctions.CItemSocketScirpt
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System.Runtime.InteropServices;

namespace RhHook.MapFunctions
{
  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  internal class CItemSocketScirpt : CEpochItemScript
  {
    public int m_SocketGrade;
    public int m_SocketDuration;
    public int m_SocketSuccessRate;
    public int m_SocketBrokenRate;
    public int m_SocketKind;
    public int m_SocketType;
    public int m_SocketValue;
  }
}
