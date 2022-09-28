// Decompiled with JetBrains decompiler
// Type: RhHook.MapFunctions.CAIConnection
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System;
using System.Runtime.InteropServices;

namespace RhHook.MapFunctions
{
  [StructLayout(LayoutKind.Sequential, Pack = 1)]
  public class CAIConnection : CRohanConnection
  {
    public static readonly IntPtr SendMoveSpeedA = (IntPtr) 4208672;
    public static readonly CAIConnection.DSendMoveSpeed SendMoveSpeed = (CAIConnection.DSendMoveSpeed) Marshal.GetDelegateForFunctionPointer(CAIConnection.SendMoveSpeedA, typeof (CAIConnection.DSendMoveSpeed));
    public CIOCriticalSection m_crit;
    public int m_nAIIndex;
    public int m_nIRCount;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
    public byte[] m_nAIMapInfo;

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate void DSendMoveSpeed(IntPtr @this, int nIRID, uint dwEntityID, int nMoveSpeed);
  }
}
