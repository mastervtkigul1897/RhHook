// Decompiled with JetBrains decompiler
// Type: RhHook.MapFunctions.CEntityBase
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using RhHook.Data;
using System;
using System.Runtime.InteropServices;

namespace RhHook.MapFunctions
{
  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public class CEntityBase : CIOBase
  {
    public static readonly IntPtr GetPosA = (IntPtr) 5296992;
    public static readonly CEntityBase.DGetPos GetPos = (CEntityBase.DGetPos) Marshal.GetDelegateForFunctionPointer(CEntityBase.GetPosA, typeof (CEntityBase.DGetPos));
    public static readonly IntPtr GetEpochIdA = (IntPtr) 4278208;
    public static readonly CEntityBase.DGetEpochId GetEpochId = (CEntityBase.DGetEpochId) Marshal.GetDelegateForFunctionPointer(CEntityBase.GetEpochIdA, typeof (CEntityBase.DGetEpochId));
    public IntPtr m_pNextEntity;
    public int m_nIRID;
    public int m_ir_mapindex;
    public IntPtr m_pCellManager;
    public EpochID2 m_ID;
    public EpochVector3 m_Pos;
    public EpochVector3 m_Angle;
    public float m_fSceneRadius;
    public float m_fCollisionRadius;
    public float m_fCollisionHeight;
    public IntPtr m_pSphere;
    public int m_CellX;
    public int m_CellZ;
    public CIOCriticalSection m_crit;
    public IntPtr m_pCollisionBase;
    public EpochEntityClassType m_entityType;

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate IntPtr DGetPos(IntPtr @this);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate IntPtr DGetEpochId(IntPtr @this);
  }
}
