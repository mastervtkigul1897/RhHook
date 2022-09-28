// Decompiled with JetBrains decompiler
// Type: RhHook.MapFunctions.CMapConnection
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using RhHook.Data;
using System;
using System.Runtime.InteropServices;

namespace RhHook.MapFunctions
{
  [StructLayout(LayoutKind.Sequential, Pack = 8)]
  public class CMapConnection : CRohanConnection
  {
    public static readonly IntPtr GetCharConnectionA = (IntPtr) 4321184;
    public static readonly CMapConnection.DGetCharConnection GetCharConnection = (CMapConnection.DGetCharConnection) Marshal.GetDelegateForFunctionPointer(CMapConnection.GetCharConnectionA, typeof (CMapConnection.DGetCharConnection));
    public static readonly IntPtr OnIndunBuyItemA = (IntPtr) 4691648;
    public static readonly CMapConnection.DOnIndunBuyItem OnIndunBuyItem = (CMapConnection.DOnIndunBuyItem) Marshal.GetDelegateForFunctionPointer(CMapConnection.OnIndunBuyItemA, typeof (CMapConnection.DOnIndunBuyItem));
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 37)]
    public byte[] m_szSessionId;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] m_strBillSession;
    public uint m_dwCharId;
    public byte m_nCurrWorld;
    public IntPtr m_pPlayer;
    public uint m_dwConnStatus;
    public int m_nLoginIndex;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
    public byte[] m_szBillUserStatus;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 21)]
    public byte[] m_szLoginID;
    public int m_nBillNo;
    public byte m_nGrade;
    public int m_bPCBang;
    public int m_bBillLogin;
    public byte m_nBillMethod;
    public int m_nInterKey;
    public int m_bReservedClose;
    public CIOCriticalSection m_CSection;
    public CCSAuth3 m_csAuth30;
    public byte m_bClosed;
    public int iCheckCsAuthErrCnt;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
    private byte[] m_listPacketTime;
    public CGateCharManager m_gateCharManager;
    public uint m_iCSAUTHSIZE;
    public _tagSetfileinfo m_Setfileinfo;
    public bool m_bOpenPostWithItem;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = true)]
    public delegate IntPtr DGetCharConnection(uint dwCharId);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DOnIndunBuyItem(IntPtr @this, byte[] prcreq);
  }
}
