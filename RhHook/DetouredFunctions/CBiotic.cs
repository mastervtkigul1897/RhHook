// Decompiled with JetBrains decompiler
// Type: RhHook.DetouredFunctions.CBiotic
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using Detours;
using RhHook.Data;
using RhHook.MapFunctions;
using RhHook.Util;
using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

namespace RhHook.DetouredFunctions
{
  internal class CBiotic
  {
    public static readonly CBiotic.DGetSkillAttackForce GetSkillAttackForce = new CBiotic.DGetSkillAttackForce(CBiotic.DetouredGetSkillAttackForce);
    public static readonly CBiotic.DChangeConditionBySkill ChangeConditionBySkill = new CBiotic.DChangeConditionBySkill(CBiotic.DetouredChangeConditionBySkill);
    public static readonly RhHook.Util.FunctionInfo[] FunctionInfo = new RhHook.Util.FunctionInfo[2]
    {
      new RhHook.Util.FunctionInfo((IntPtr) 5086336, "CBiotic::GetSkillAttackForce", (Delegate) CBiotic.GetSkillAttackForce, (Delegate) CBiotic._GetSkillAttackForce, typeof (CBiotic.DGetSkillAttackForce)),
      new RhHook.Util.FunctionInfo((IntPtr) 5090560, "CBiotic::ChangeConditionBySkill", (Delegate) CBiotic.ChangeConditionBySkill, (Delegate) CBiotic._ChangeConditionBySkill, typeof (CBiotic.DChangeConditionBySkill))
    };

    [HandleProcessCorruptedStateExceptions]
    public static IntPtr GetSkillSlot(IntPtr biotic) => biotic + 256;

    [HandleProcessCorruptedStateExceptions]
    public static IntPtr GetSkillSlotOption(IntPtr SkillSlot) => SkillSlot + 96;

    [HandleProcessCorruptedStateExceptions]
    private static int DetouredGetSkillAttackForce(IntPtr @this, IntPtr pSkill, IntPtr nAttackType)
    {
      try
      {
        _tagSkill structure1 = (_tagSkill) Marshal.PtrToStructure(pSkill + 24, typeof (_tagSkill));
        byte index = RhHook.MapFunctions.CSkillManager.GetTotalDynamicLevel(@this + 256, structure1.nKind);
        IntPtr ptr = CSkillScript.GetSkillInfo((uint) structure1.nKind);
        _tagSkillInfo structure2 = (_tagSkillInfo) Marshal.PtrToStructure(ptr, typeof (_tagSkillInfo));
        if (ptr != IntPtr.Zero)
        {
          if (index >= (byte) 7)
          {
            if (GlobalData.Debug)
              Log.LogString("Error 1");
            return 0;
          }
          _tagSkillLevelInfo tagSkillLevelInfo = structure2.nLevelInfo[(int) index];
          if (structure1.nKind == (ushort) 16457)
          {
            Marshal.WriteInt32(nAttackType, 3);
            return CBioticBase.GetAbility(@this, 34U) + (int) tagSkillLevelInfo.nParam[0] * CBioticBase.GetAbility(@this, 34U) / 100;
          }
          return (int) ((Dictionary<string, Hook>) Hooks.Manager)["CBiotic::GetSkillAttackForce"].CallOriginal(new object[3]
          {
            (object) @this,
            (object) pSkill,
            (object) nAttackType
          });
        }
        if (GlobalData.Debug)
          Log.LogString("Error 2");
        return 0;
      }
      catch (Exception ex)
      {
        Log.LogError(ex, "CBiotic.GetSkillAttackForce");
        return 0;
      }
    }

    [HandleProcessCorruptedStateExceptions]
    private static void DetouredChangeConditionBySkill(
      IntPtr @this,
      uint dwCondition,
      int nMilliSecond,
      ushort wSkillKInd)
    {
      try
      {
        if ((wSkillKInd == (ushort) 187 || wSkillKInd == (ushort) 172) && dwCondition == 1073741832U)
          return;
        ((Dictionary<string, Hook>) Hooks.Manager)["CBiotic::ChangeConditionBySkill"].CallOriginal(new object[4]
        {
          (object) @this,
          (object) dwCondition,
          (object) nMilliSecond,
          (object) wSkillKInd
        });
      }
      catch (Exception ex)
      {
        Log.LogError(ex, "CBiotic.ChangeConditionBySkill");
      }
    }

    public static CBiotic.DChangeConditionBySkill _ChangeConditionBySkill { get; set; }

    public static CBiotic.DGetSkillAttackForce _GetSkillAttackForce { get; set; }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
    public delegate void DChangeConditionBySkill(
      IntPtr @this,
      uint dwCondition,
      int nMilliSecond,
      ushort wSkillKInd);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
    public delegate int DGetSkillAttackForce(IntPtr @this, IntPtr pSkill, IntPtr nAttackType);
  }
}
