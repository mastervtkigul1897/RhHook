// Decompiled with JetBrains decompiler
// Type: RhHook.MapFunctions.CBattleManager
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using RhHook.Data;
using System;
using System.Runtime.InteropServices;

namespace RhHook.MapFunctions
{
  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  internal class CBattleManager
  {
    public static readonly IntPtr IsSkillAffectA = (IntPtr) 5442544;
    public static readonly CBattleManager.DIsSkillAffect IsSkillAffect = (CBattleManager.DIsSkillAffect) Marshal.GetDelegateForFunctionPointer(CBattleManager.IsSkillAffectA, typeof (CBattleManager.DIsSkillAffect));
    public SATTACKRESULT m_sar;
    public IntPtr m_pAttacker;
    public UnmanagedVector m_vecAttackee;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 76)]
    public byte[] data;

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DIsSkillAffect(
      IntPtr @this,
      IntPtr pAttackee,
      ushort wSkillKind,
      byte nSkillLevel,
      int nDamage,
      IntPtr nResult);
  }
}
