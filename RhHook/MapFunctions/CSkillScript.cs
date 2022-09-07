// Decompiled with JetBrains decompiler
// Type: RhHook.MapFunctions.CSkillScript
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System;
using System.Runtime.InteropServices;

namespace RhHook.MapFunctions
{
  [StructLayout(LayoutKind.Sequential)]
  public class CSkillScript
  {
    public static readonly IntPtr GetSkillInfoA = (IntPtr) 4404384;
    public static readonly CSkillScript.DGetSkillInfo GetSkillInfo = (CSkillScript.DGetSkillInfo) Marshal.GetDelegateForFunctionPointer(CSkillScript.GetSkillInfoA, typeof (CSkillScript.DGetSkillInfo));
    public static readonly IntPtr GetAffectSkillA = (IntPtr) 6556480;
    public static readonly CSkillScript.DGetAffectSkill GetAffectSkill = (CSkillScript.DGetAffectSkill) Marshal.GetDelegateForFunctionPointer(CSkillScript.GetAffectSkillA, typeof (CSkillScript.DGetAffectSkill));

    [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = true)]
    public delegate IntPtr DGetSkillInfo(uint dwSkillIdx);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate IntPtr DGetAffectSkill(IntPtr @this, uint nKind);
  }
}
