// Decompiled with JetBrains decompiler
// Type: RhHook.MapFunctions.CFriendMgr
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System;
using System.Runtime.InteropServices;

namespace RhHook.MapFunctions
{
  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public class CFriendMgr
  {
    public static readonly IntPtr IsBlockListA = (IntPtr) 6207440;
    public static readonly CFriendMgr.DIsBlockList IsBlockList = (CFriendMgr.DIsBlockList) Marshal.GetDelegateForFunctionPointer(CFriendMgr.IsBlockListA, typeof (CFriendMgr.DIsBlockList));
    public IntPtr vfptr;
    public CIOCriticalSection m_crit;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
    public byte[] m_mapFriend;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
    public byte[] m_mapBlockList;

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DIsBlockList(IntPtr @this, int dwBlockID);
  }
}
