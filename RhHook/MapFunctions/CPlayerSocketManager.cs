// Decompiled with JetBrains decompiler
// Type: RhHook.MapFunctions.CPlayerSocketManager
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System;
using System.Runtime.InteropServices;

namespace RhHook.MapFunctions
{
  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public class CPlayerSocketManager
  {
    public static readonly IntPtr _SocketEquipA = (IntPtr) 5367264;
    public static readonly CPlayerSocketManager.D_SocketEquip _SocketEquip = (CPlayerSocketManager.D_SocketEquip) Marshal.GetDelegateForFunctionPointer(CPlayerSocketManager._SocketEquipA, typeof (CPlayerSocketManager.D_SocketEquip));
    public static readonly IntPtr AddA = (IntPtr) 5373936;
    public static readonly CPlayerSocketManager.DAdd Add = (CPlayerSocketManager.DAdd) Marshal.GetDelegateForFunctionPointer(CPlayerSocketManager.AddA, typeof (CPlayerSocketManager.DAdd));
    public static readonly IntPtr GetSocketInfoA = (IntPtr) 5375168;
    public static readonly CPlayerSocketManager.DGetSocketInfo GetSocketInfo = (CPlayerSocketManager.DGetSocketInfo) Marshal.GetDelegateForFunctionPointer(CPlayerSocketManager.GetSocketInfoA, typeof (CPlayerSocketManager.DGetSocketInfo));
    public static readonly IntPtr ClearSocketSlotA = (IntPtr) 5376896;
    public static readonly CPlayerSocketManager.DClearSocketSlot ClearSocketSlot = (CPlayerSocketManager.DClearSocketSlot) Marshal.GetDelegateForFunctionPointer(CPlayerSocketManager.ClearSocketSlotA, typeof (CPlayerSocketManager.DClearSocketSlot));
    public static readonly IntPtr GetSocketOptionA = (IntPtr) 5375360;
    public static readonly CPlayerSocketManager.DGetSocketOption GetSocketOption = (CPlayerSocketManager.DGetSocketOption) Marshal.GetDelegateForFunctionPointer(CPlayerSocketManager.GetSocketOptionA, typeof (CPlayerSocketManager.DGetSocketOption));
    public static readonly IntPtr GetSocketAttributeA = (IntPtr) 5375536;
    public static readonly CPlayerSocketManager.DGetSocketAttribute GetSocketAttribute = (CPlayerSocketManager.DGetSocketAttribute) Marshal.GetDelegateForFunctionPointer(CPlayerSocketManager.GetSocketOptionA, typeof (CPlayerSocketManager.DGetSocketAttribute));
    public IntPtr m_pPlayer;
    public CIOCriticalSection m_crit;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
    public byte[] m_mapPlayerSocketSlot;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
    public byte[] m_mapEquip;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
    public byte[] m_mapEquipAttribute;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
    public byte[] m_mapEquipOption;
    public CIOCriticalSection m_critAbilityInfo;

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate IntPtr D_SocketEquip(IntPtr @this, IntPtr SocketSlot);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate IntPtr DAdd(
      IntPtr @this,
      uint nItemId,
      byte nPos,
      uint nType,
      uint tAttach);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DGetSocketInfo(IntPtr @this, uint nItemId, IntPtr ItemSocketSlot);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DClearSocketSlot(IntPtr @this, uint nItemId, int nPos);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DGetSocketOption(IntPtr @this, uint nType);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DGetSocketAttribute(IntPtr @this, int nType);
  }
}
