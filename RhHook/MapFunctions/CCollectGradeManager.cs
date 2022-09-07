// Decompiled with JetBrains decompiler
// Type: RhHook.MapFunctions.CCollectGradeManager
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System;
using System.Runtime.InteropServices;

namespace RhHook.MapFunctions
{
  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public class CCollectGradeManager
  {
    public static readonly IntPtr GetCollectExpA = (IntPtr) 6922432;
    public static readonly CCollectGradeManager.DGetCollectExp GetCollectExp = (CCollectGradeManager.DGetCollectExp) Marshal.GetDelegateForFunctionPointer(CCollectGradeManager.GetCollectExpA, typeof (CCollectGradeManager.DGetCollectExp));
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
    public byte[] m_CollectExpInfo;

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DGetCollectExp(IntPtr @this, int nGrade);
  }
}
