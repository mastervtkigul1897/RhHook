// Decompiled with JetBrains decompiler
// Type: RhHook.MapFunctions.CGambleInfo
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System.Runtime.InteropServices;

namespace RhHook.MapFunctions
{
  [StructLayout(LayoutKind.Sequential, Pack = 8)]
  public class CGambleInfo
  {
    public int m_bLogin;
    public byte m_nChannelIndex;
    public short m_nRoomNumber;
    public byte m_nGameType;
    public long m_nMoney;
    public long m_nExchangeMoneyForMonth;
    public int m_nExchangeStartTime;
  }
}
