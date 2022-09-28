// Decompiled with JetBrains decompiler
// Type: RhHook.MapFunctions.CEntityManager
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using RhHook.Data;
using System;
using System.Runtime.InteropServices;

namespace RhHook.MapFunctions
{
  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public class CEntityManager : CIOObject
  {
    public static readonly IntPtr GetPlayerA = (IntPtr) 5105136;
    public static readonly CEntityManager.DGetPlayer GetPlayer = (CEntityManager.DGetPlayer) Marshal.GetDelegateForFunctionPointer(CEntityManager.GetPlayerA, typeof (CEntityManager.DGetPlayer));
    public static readonly IntPtr BroadcastAllPlayerA = (IntPtr) 5017920;
    public static readonly CEntityManager.DBroadcastAllPlayer BroadcastAllPlayer = (CEntityManager.DBroadcastAllPlayer) Marshal.GetDelegateForFunctionPointer(CEntityManager.BroadcastAllPlayerA, typeof (CEntityManager.DBroadcastAllPlayer));
    public static readonly CEntityManager.DBroadcastAllPlayerB BroadcastAllPlayerB = (CEntityManager.DBroadcastAllPlayerB) Marshal.GetDelegateForFunctionPointer(CEntityManager.BroadcastAllPlayerA, typeof (CEntityManager.DBroadcastAllPlayerB));
    public static readonly IntPtr FindPlayerA = (IntPtr) 5106912;
    public static readonly CEntityManager.DFindPlayer FindPlayer = (CEntityManager.DFindPlayer) Marshal.GetDelegateForFunctionPointer(CEntityManager.FindPlayerA, typeof (CEntityManager.DFindPlayer));
    public static readonly IntPtr FindBioticA = (IntPtr) 5016128;
    public static readonly CEntityManager.DFindBiotic FindBiotic = (CEntityManager.DFindBiotic) Marshal.GetDelegateForFunctionPointer(CEntityManager.FindBioticA, typeof (CEntityManager.DFindBiotic));
    public static readonly IntPtr FindBioticIDA = (IntPtr) 5104864;
    public static readonly CEntityManager.DFindBioticID FindBioticID = (CEntityManager.DFindBioticID) Marshal.GetDelegateForFunctionPointer(CEntityManager.FindBioticIDA, typeof (CEntityManager.DFindBioticID));
    public static readonly IntPtr GetMonsterA = (IntPtr) 5105168;
    public static readonly CEntityManager.DGetMonster GetMonster = (CEntityManager.DGetMonster) Marshal.GetDelegateForFunctionPointer(CEntityManager.GetMonsterA, typeof (CEntityManager.DGetMonster));
    public static IntPtr g_EntityManager = (IntPtr) 7956744;
    public CTimer timer;
    public int nCount;
    public int nDiff;
    public CTimer timerFrame;
    public int nLoopCount;
    public int nTotalCount;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
    public CRWLock[] m_locks;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 98304)]
    public byte[] m_mapBiotics;
    public CMapStringToPtr m_mapPlayerName;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)]
    public byte[] m_mapPlayer;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)]
    public byte[] m_mapGM;
    public CRWLock m_lock;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
    public byte[] m_queue;

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate IntPtr DGetPlayer(IntPtr @this, uint dwEntityID);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate IntPtr DBroadcastAllPlayer(
      IntPtr @this,
      int nProtocal,
      IntPtr pData,
      int size);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate IntPtr DBroadcastAllPlayerB(
      IntPtr @this,
      int nProtocal,
      byte[] pData,
      int size);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate IntPtr DFindPlayer(IntPtr @this, byte[] lpszName);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate IntPtr DFindBiotic(IntPtr @this, byte[] lpszName, uint dwFlag);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate IntPtr DFindBioticID(IntPtr @this, uint dwEntityID);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate IntPtr DGetMonster(IntPtr @this, uint dwEntityID);
  }
}
