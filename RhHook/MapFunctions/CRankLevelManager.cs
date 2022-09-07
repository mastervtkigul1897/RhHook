// Decompiled with JetBrains decompiler
// Type: RhHook.MapFunctions.CRankLevelManager
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System;
using System.Runtime.InteropServices;

namespace RhHook.MapFunctions
{
  internal class CRankLevelManager
  {
    public static readonly IntPtr GetAddDefenceA = (IntPtr) 7160960;
    public static readonly CRankLevelManager.DGetAddDefence GetAddDefence = (CRankLevelManager.DGetAddDefence) Marshal.GetDelegateForFunctionPointer(CRankLevelManager.GetAddDefenceA, typeof (CRankLevelManager.DGetAddDefence));

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DGetAddDefence(IntPtr @this, int nRank);
  }
}
