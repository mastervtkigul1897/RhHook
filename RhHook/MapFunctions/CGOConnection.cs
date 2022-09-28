// Decompiled with JetBrains decompiler
// Type: RhHook.MapFunctions.CGOConnection
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using RhHook.Data;
using System;
using System.Runtime.InteropServices;

namespace RhHook.MapFunctions
{
  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public class CGOConnection : CIOSocket
  {
    public static readonly IntPtr SendPacketA = (IntPtr) 6439088;
    public static readonly CGOConnection.DSendPacket SendPacket = (CGOConnection.DSendPacket) Marshal.GetDelegateForFunctionPointer(CGOConnection.SendPacketA, typeof (CGOConnection.DSendPacket));
    public static readonly IntPtr CloseA = (IntPtr) 6437392;
    public static readonly CGOConnection.DClose Close = (CGOConnection.DClose) Marshal.GetDelegateForFunctionPointer(CGOConnection.CloseA, typeof (CGOConnection.DClose));
    public int m_nVarRef;
    public CLink m_link;
    public uint m_dwWriteLimit;
    public sockaddr_in m_peer;
    public sockaddr_in m_local;
    public uint m_socket;
    public IntPtr m_pServer;
    public CGOInterlocked m_ilLastHeartbeat;
    public int m_nConnectTime;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] m_nConnectionType;
    public CGOProtocol m_Protocol;
    public uint m_dwLastLocalTime;
    public uint m_dwReadBytes;
    public uint m_dwWriteBytes;
    public uint m_dwPacketCount;
    public uint m_dwLocalRBPS;
    public uint m_dwLocalWBPS;
    public uint m_dwLocalPPS;
    public int m_bUserWorker;
    public uint m_nMaxPacketSize;
    public int m_bSending;

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate void DSendPacket(IntPtr @this, ushort nType, byte[] pData, uint nSize);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate void DClose(IntPtr @this, IntPtr lpszCloseReason);
  }
}
