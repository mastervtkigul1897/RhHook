// Decompiled with JetBrains decompiler
// Type: RhHook.DetouredFunctions.CSkillManager
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
    internal class CSkillManager
    {
        public static readonly CSkillManager.DCalAffect CalAffect = new CSkillManager.DCalAffect(CSkillManager.DetouredCalAffect);
        public static readonly CSkillManager.DOnAffect_Active OnAffect_Active = new CSkillManager.DOnAffect_Active(CSkillManager.DetouredOnAffect_Active);
        public static readonly CSkillManager.DAddAffectSkill AddAffectSkill = new CSkillManager.DAddAffectSkill(CSkillManager.DetouredAddAffectSkill);
        public static readonly RhHook.Util.FunctionInfo[] FunctionInfo = new RhHook.Util.FunctionInfo[2]
        {
      new RhHook.Util.FunctionInfo((IntPtr) 4882208, "CSkillManager::CalAffect", (Delegate) CSkillManager.CalAffect, (Delegate) CSkillManager._CalAffect, typeof (CSkillManager.DCalAffect)),
      new RhHook.Util.FunctionInfo((IntPtr) 4846448, "CSkillManager::OnAffect_Active", (Delegate) CSkillManager.OnAffect_Active, (Delegate) CSkillManager._OnAffect_Active, typeof (CSkillManager.DOnAffect_Active))
        };

        [HandleProcessCorruptedStateExceptions]
        private static void DetouredOnAffect_Active(IntPtr @this, IntPtr pASkill, int bActive)
        {
            try
            {
                IntPtr inptr = Marshal.ReadIntPtr(@this + 88);
                RhHook.Data._tagAffectSkill structure1 = (RhHook.Data._tagAffectSkill)Marshal.PtrToStructure(pASkill, typeof(RhHook.Data._tagAffectSkill));
                IntPtr ptr = CSkillScript.GetSkillInfo((uint)structure1.nKind);
                IntPtr num1 = ptr + 88;
                _tagSkillInfo structure2 = (_tagSkillInfo)Marshal.PtrToStructure(ptr, typeof(_tagSkillInfo));
                RhHook.MapFunctions.CSkillManager structure3 = (RhHook.MapFunctions.CSkillManager)Marshal.PtrToStructure(@this, typeof(RhHook.MapFunctions.CSkillManager));
                IntPtr num2 = @this + 96;
                if (!(ptr != IntPtr.Zero) || structure1.nLevel >= (byte)7)
                    return;
                _tagSkillLevelInfo tagSkillLevelInfo = structure2.nLevelInfo[(int)structure1.nLevel];
                uint num3 = tagSkillLevelInfo.nParam[0];
                switch ((SkillIdx)structure1.nKind)
                {
                    case SkillIdx.POLEARM_MASTERY:
                    case SkillIdx.AIM_BLOW:
                    case SkillIdx.HEROIC_POWER_TEMPLAR:
                    case SkillIdx.ROYAL_MASK:
                    case SkillIdx.FORCE_LOCK:
                        CSkillManager.DetouredCalAffect(@this, structure1.dwEntityID, structure1.nKind, tagSkillLevelInfo.nParam, bActive);
                        IntPtr this1 = MISC.__RTDynamicCast(inptr, 0, (IntPtr)7890312, (IntPtr)7890360, 0);
                        if (!(this1 != IntPtr.Zero))
                            break;
                        RhHook.MapFunctions.CPlayer.SendStatus(this1);
                        break;
                    default:
                        ((Dictionary<string, Hook>)Hooks.Manager)["CSkillManager::OnAffect_Active"].CallOriginal(new object[3]
                        {
              (object) @this,
              (object) pASkill,
              (object) bActive
                        });
                        break;
                }
            }
            catch (Exception ex)
            {
                Log.LogError(ex, "CSkillManager.DetouredOnAffect_Active");
            }
        }

        [HandleProcessCorruptedStateExceptions]
        private static void DetouredCalAffect(
          IntPtr @this,
          uint dwCasterId,
          ushort wKind,
          uint[] pdwParams,
          int bAdd)
        {
            try
            {
                IntPtr inptr = Marshal.ReadIntPtr(@this, 88);
                if (GlobalData.Debug)
                    Log.LogString("CSkillManager::CalAffect Hooked. wKind " + wKind.ToString());
                IntPtr this1 = @this + 96;
                IntPtr num = @this + 256;
                uint[] numArray = pdwParams;
                switch ((SkillIdx)wKind)
                {
                    case SkillIdx.POLEARM_MASTERY:
                        CQualitiesOption.CalOption(this1, 218, (int)numArray[0], bAdd);
                        CQualitiesOption.CalOption(this1, 233, (int)numArray[0], bAdd);
                        CQualitiesOption.CalOption(this1, 255, (int)numArray[0], bAdd);
                        break;
                    case SkillIdx.AIM_BLOW:
                        CQualitiesOption.CalOption(this1, 54, (int)numArray[0], bAdd);
                        CQualitiesOption.CalOption(this1, 115, (int)numArray[1], bAdd);
                        break;
                    case SkillIdx.HEROIC_POWER_TEMPLAR:
                        CQualitiesOption.CalOption(this1, 33, 25, bAdd);
                        CQualitiesOption.CalOption(this1, 61, 25, bAdd);
                        CQualitiesOption.CalOption(this1, 1, 25, bAdd);
                        CQualitiesOption.CalOption(this1, 3, 25, bAdd);
                        CQualitiesOption.CalOption(this1, 5, 25, bAdd);
                        CQualitiesOption.CalOption(this1, 7, 25, bAdd);
                        break;
                    case SkillIdx.ROYAL_MASK:
                        CQualitiesOption.CalOption(this1, 125, (int)numArray[0], bAdd);
                        CQualitiesOption.CalOption(this1, 9, (int)numArray[1], bAdd);
                        CQualitiesOption.CalOption(this1, 11, (int)numArray[1], bAdd);
                        CQualitiesOption.CalOption(this1, 13, (int)numArray[1], bAdd);
                        CQualitiesOption.CalOption(this1, 16, (int)numArray[1], bAdd);
                        CQualitiesOption.CalOption(this1, 18, (int)numArray[1], bAdd);
                        CQualitiesOption.CalOption(this1, 20, (int)numArray[1], bAdd);
                        break;
                }
                IntPtr this2 = MISC.__RTDynamicCast(inptr, 0, (IntPtr)7890312, (IntPtr)7890360, 0);
                if (this2 != IntPtr.Zero)
                {
                    RhHook.MapFunctions.CPlayer.CalAllAbility(this2);
                }
                else
                {
                    IntPtr this3 = MISC.__RTDynamicCast(inptr, 0, (IntPtr)7890312, (IntPtr)7892656, 0);
                    if (this3 != IntPtr.Zero)
                        CMonster.CalAllAbility(this3);
                }
            }
            catch (Exception ex)
            {
                Log.LogError(ex, "CSkillManager.CalAffect");
                Console.WriteLine(ex.ToString());
            }
        }

        [HandleProcessCorruptedStateExceptions]
        private static void DetouredCalAffect(
          IntPtr @this,
          uint dwCasterId,
          ushort wKind,
          IntPtr pdwParams,
          int bAdd)
        {
            try
            {
                Marshal.ReadIntPtr(@this, 88);
                if (GlobalData.Debug)
                    Log.LogString("CSkillManager::CalAffect Hooked. wKind " + wKind.ToString());
                IntPtr this1 = @this + 96;
                IntPtr num = @this + 256;
                SkillParams structure = (SkillParams)Marshal.PtrToStructure(pdwParams, typeof(SkillParams));
                switch ((SkillIdx)wKind)
                {
                    case SkillIdx.ROYAL_MASK:
                        CQualitiesOption.CalOption(this1, 125, (int)structure.nParam[0], bAdd);
                        CQualitiesOption.CalOption(this1, 8, (int)structure.nParam[1], bAdd);
                        CQualitiesOption.CalOption(this1, 10, (int)structure.nParam[1], bAdd);
                        CQualitiesOption.CalOption(this1, 12, (int)structure.nParam[1], bAdd);
                        CQualitiesOption.CalOption(this1, 15, (int)structure.nParam[1], bAdd);
                        CQualitiesOption.CalOption(this1, 17, (int)structure.nParam[1], bAdd);
                        CQualitiesOption.CalOption(this1, 19, (int)structure.nParam[1], bAdd);
                        break;
                }
              ((Dictionary<string, Hook>)Hooks.Manager)["CSkillManager::CalAffect"].CallOriginal(new object[5]
              {
          (object) @this,
          (object) dwCasterId,
          (object) wKind,
          (object) pdwParams,
          (object) bAdd
              });
            }
            catch (Exception ex)
            {
                Log.LogError(ex, "CSkillManager.CalAffect");
            }
        }

        [HandleProcessCorruptedStateExceptions]
        private static int DetouredAddAffectSkill(IntPtr @this, IntPtr pAffectedSkill)
        {
            int result;
            try
            {
                ushort num = (ushort)Marshal.ReadInt16(pAffectedSkill);
                bool flag = Marshal.ReadInt32(Marshal.ReadIntPtr(@this, 88), 44) == 200743;
                if (flag)
                {
                    RhHook.Data._tagAffectSkill tagAffectSkill = (RhHook.Data._tagAffectSkill)Marshal.PtrToStructure(pAffectedSkill, typeof(RhHook.Data._tagAffectSkill));
                    tagAffectSkill.dwDurationTime = 120000U;
                    Marshal.StructureToPtr(tagAffectSkill, pAffectedSkill, true);
                    result = (int)Hooks.Manager["CSkillManager::AddAffectSkill"].CallOriginal(new object[]
                    {
                        @this,
                        pAffectedSkill
                    });
                }
                else
                {
                    result = (int)Hooks.Manager["CSkillManager::AddAffectSkill"].CallOriginal(new object[]
                    {
                        @this,
                        pAffectedSkill
                    });
                }
            }
            catch (Exception e)
            {
                Log.LogError(e, "CSkillManager.AddAffectSkill");
                result = 0;
            }
            return result;
        }

        public static CSkillManager.DCalAffect _CalAffect { get; set; }

        public static CSkillManager.DOnAffect_Event _OnAffect_Event { get; set; }

        public static CSkillManager.DOnAffect_Active _OnAffect_Active { get; set; }

        [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
        public delegate void DOnAffectSkillEvent(
          IntPtr @this,
          uint dwEventType,
          IntPtr pASkill,
          byte nReason,
          uint dwParam);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate int DGetAffectSkillList(IntPtr @this, IntPtr pASkillList, int nBufferSize);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate void DCalAffect(
          IntPtr @this,
          uint dwCasterId,
          ushort wKind,
          IntPtr pdwParams,
          int bAdd);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate void DOnAffect_Active(IntPtr @this, IntPtr pASkill, int bActive);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate void DOnAffect_Event(IntPtr @this, IntPtr pASkill, IntPtr dwParam);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate int DIsResistStunOnCombat(
          IntPtr @this,
          ushort skillkind,
          IntPtr bStunTypeSkill,
          IntPtr bNoDamage);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate int DProcessdDamageDecrement(IntPtr @this, int nDamage, int bCriticalHit);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate int DAddAffectSkill(IntPtr @this, IntPtr pAffectedSkill);
    }
}
