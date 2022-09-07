// Decompiled with JetBrains decompiler
// Type: RhHook.MapFunctions.CIOObject
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System;
using System.Runtime.InteropServices;

namespace RhHook.MapFunctions
{
  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public class CIOObject
  {
    public static readonly IntPtr ReleaseA = (IntPtr) 6181168;
    public static readonly CIOObject.DRelease Release = (CIOObject.DRelease) Marshal.GetDelegateForFunctionPointer(CIOObject.ReleaseA, typeof (CIOObject.DRelease));
    public IntPtr vfptr;
    public int m_nRef;
    public int m_nSystemRef;
    public int m_nGeneralRef;

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public unsafe delegate void DRelease(IntPtr @this, int* pRef);
  }
}
