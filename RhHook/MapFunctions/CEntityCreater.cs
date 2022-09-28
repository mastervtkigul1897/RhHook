// Decompiled with JetBrains decompiler
// Type: RhHook.MapFunctions.CEntityCreater
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System;
using System.Runtime.InteropServices;

namespace RhHook.MapFunctions
{
  [StructLayout(LayoutKind.Sequential)]
  public class CEntityCreater
  {
    public static readonly IntPtr CreatePlayerA = (IntPtr) 5098128;
    public static readonly CEntityCreater.DCreatePlayer CreatePlayer = (CEntityCreater.DCreatePlayer) Marshal.GetDelegateForFunctionPointer(CEntityCreater.CreatePlayerA, typeof (CEntityCreater.DCreatePlayer));
    public static readonly IntPtr CreateBioticA = (IntPtr) 5012816;
    public static readonly CEntityCreater.DCreateBiotic CreateBiotic = (CEntityCreater.DCreateBiotic) Marshal.GetDelegateForFunctionPointer(CEntityCreater.CreateBioticA, typeof (CEntityCreater.DCreateBiotic));
    public static readonly CEntityCreater.DCreateBioticEvent CreateBioticEvent = (CEntityCreater.DCreateBioticEvent) Marshal.GetDelegateForFunctionPointer(CEntityCreater.CreateBioticA, typeof (CEntityCreater.DCreateBioticEvent));
    public static IntPtr g_EntityCreater = (IntPtr) 7956744;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = true)]
    public delegate void DCreatePlayer(byte[] pdbres);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate IntPtr DCreateBiotic(
      IntPtr @this,
      int nType,
      int nIRID,
      IntPtr pos,
      byte[] angle,
      uint dwGenID,
      int genpatrolindex,
      int nLinkIndex,
      IntPtr pItem,
      IntPtr parentID,
      uint dwOwnerID);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate IntPtr DCreateBioticEvent(
      IntPtr @this,
      int nType,
      int nIRID,
      byte[] pos,
      byte[] angle,
      uint dwGenID,
      int genpatrolindex,
      int nLinkIndex,
      IntPtr pItem,
      IntPtr parentID,
      uint dwOwnerID);
  }
}
