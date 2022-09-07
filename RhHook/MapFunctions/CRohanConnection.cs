// Decompiled with JetBrains decompiler
// Type: RhHook.MapFunctions.CRohanConnection
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using RhHook.Data;
using System;
using System.Runtime.InteropServices;

namespace RhHook.MapFunctions
{
  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public class CRohanConnection : CGOConnection
  {
    public static readonly IntPtr SendPacketExA = (IntPtr) 6726336;
    public static readonly CRohanConnection.DSendPacketEx SendPacketEx = (CRohanConnection.DSendPacketEx) Marshal.GetDelegateForFunctionPointer(CRohanConnection.SendPacketExA, typeof (CRohanConnection.DSendPacketEx));
    public static readonly CRohanConnection.DSendPacketExPtr SendPacketExPtr = (CRohanConnection.DSendPacketExPtr) Marshal.GetDelegateForFunctionPointer(CRohanConnection.SendPacketExA, typeof (CRohanConnection.DSendPacketExPtr));
    public static readonly IntPtr SendCryptPacketA = (IntPtr) 6726224;
    public static readonly CRohanConnection.DSendCryptPacket_o SendCryptPacket_o = (CRohanConnection.DSendCryptPacket_o) Marshal.GetDelegateForFunctionPointer(CRohanConnection.SendCryptPacketA, typeof (CRohanConnection.DSendCryptPacket_o));
    public rc4_key_st m_RC4Key;
    public int m_bKeyInitialized;
    public IntPtr m_pLogConnection;
    public IntPtr m_pDBConnection;
    public uint m_dwUserId;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] m_szCharName;
    public CGOInterlocked m_ilReconnecting;

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DSendPacketEx(IntPtr @this, ushort nType, byte[] pData, uint nSize);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DSendPacketExPtr(IntPtr @this, ushort nType, IntPtr pData, uint nSize);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DSendCryptPacket_o(IntPtr @this, ushort nType, byte[] pData, uint nSize);
  }
}
