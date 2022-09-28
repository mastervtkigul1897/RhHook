// Decompiled with JetBrains decompiler
// Type: RhHook.DetouredFunctions.CBattleManager
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
    internal class CBattleManager
    {
        public static readonly CBattleManager.DCalAffectedSkillDamage CalAffectedSkillDamage = new CBattleManager.DCalAffectedSkillDamage(CBattleManager.DetouredCalAffectedSkillDamage);
        public static readonly CBattleManager.DIsUseItem IsUseItem = new CBattleManager.DIsUseItem(CBattleManager.DetouredIsUseItem);
        public static readonly CBattleManager.DIsUseItem_AllInShot_Only IsUseItem_AllInShot_Only = new CBattleManager.DIsUseItem_AllInShot_Only(CBattleManager.DetouredIsUseItem_AllInShot_Only);
        public static readonly CBattleManager.DIsSkillAffect IsSkillAffect = new CBattleManager.DIsSkillAffect(CBattleManager.DetouredIsSkillAffect);
        public static readonly CBattleManager.DSkillAttackAttackeeAction SkillAttackAttackeeAction = new CBattleManager.DSkillAttackAttackeeAction(CBattleManager.DetouredSkillAttackAttackeeAction);
        public static readonly CBattleManager.DProcess Process = new CBattleManager.DProcess(CBattleManager.DetouredProcess);
        public static readonly CBattleManager.DIsAttackable IsAttackable = new CBattleManager.DIsAttackable(CBattleManager.DetouredIsAttackable);
        public static readonly CBattleManager.DCriticalDamageAttackeeAction CriticalDamageAttackeeAction = new CBattleManager.DCriticalDamageAttackeeAction(CBattleManager.DetouredCriticalDamageAttackeeAction);
        public static readonly CBattleManager.DCalSkillDamage CalSkillDamage = new CBattleManager.DCalSkillDamage(CBattleManager.DetouredCalSkillDamage);
        public static readonly RhHook.Util.FunctionInfo[] FunctionInfo = new RhHook.Util.FunctionInfo[7]
        {
      new RhHook.Util.FunctionInfo((IntPtr) 5454832, "CBattleManager::CalAffectedSkillDamage", (Delegate) CBattleManager.CalAffectedSkillDamage, (Delegate) CBattleManager._CalAffectedSkillDamage, typeof (CBattleManager.DCalAffectedSkillDamage)),
      new RhHook.Util.FunctionInfo((IntPtr) 5439472, "CBattleManager::IsUseItem", (Delegate) CBattleManager.IsUseItem, (Delegate) CBattleManager._IsUseItem, typeof (CBattleManager.DIsUseItem)),
      new RhHook.Util.FunctionInfo((IntPtr) 5442544, "CBattleManager::IsSkillAffect", (Delegate) CBattleManager.IsSkillAffect, (Delegate) CBattleManager._IsSkillAffect, typeof (CBattleManager.DIsSkillAffect)),
      new RhHook.Util.FunctionInfo((IntPtr) 5453216, "CBattleManager::SkillAttackAttackeeAction", (Delegate) CBattleManager.SkillAttackAttackeeAction, (Delegate) CBattleManager._SkillAttackAttackeeAction, typeof (CBattleManager.DSkillAttackAttackeeAction)),
      new RhHook.Util.FunctionInfo((IntPtr) 5412432, "CBattleManager::IsAttackable", (Delegate) CBattleManager.IsAttackable, (Delegate) CBattleManager._IsAttackable, typeof (CBattleManager.DIsAttackable)),
      new RhHook.Util.FunctionInfo((IntPtr) 5454112, "CBattleManager::CriticalDamageAttackeeAction", (Delegate) CBattleManager.CriticalDamageAttackeeAction, (Delegate) CBattleManager._CriticalDamageAttackeeAction, typeof (CBattleManager.DCriticalDamageAttackeeAction)),
      new RhHook.Util.FunctionInfo((IntPtr) 5413392, "CBattleManager::CalSkillDamage", (Delegate) CBattleManager.CalSkillDamage, (Delegate) CBattleManager._CalSkillDamage, typeof (CBattleManager.DCalSkillDamage))
        };

        [HandleProcessCorruptedStateExceptions]
        private static int DetouredIsUseItem(IntPtr @this, uint dwItemID, byte nCount)
        {
            int num1 = 0;
            try
            {
                IntPtr inptr = Marshal.ReadIntPtr(@this, 460);
                IntPtr this1 = MISC.__RTDynamicCast(inptr, 0, (IntPtr)8295944, (IntPtr)8295992, 0) + 3272;
                int ItemId = Marshal.ReadInt32(RhHook.MapFunctions.CInventorySlotManager.GetItem(this1, 0, 13), 32);
                int num2;
                if (GlobalData.Stacks.Exists((Predicate<int>)(t => t == ItemId)))
                    num2 = 1;
                else
                    num2 = (int)((Dictionary<string, Hook>)Hooks.Manager)["CBattleManager::IsUseItem"].CallOriginal(new object[3]
                    {
            (object) @this,
            (object) dwItemID,
            (object) nCount
                    });
                return num2;
            }
            catch (Exception ex)
            {
                Log.LogError(ex, "CBattleManager.IsUseItem");
                return num1;
            }
        }

        [HandleProcessCorruptedStateExceptions]
        private static int DetouredIsUseItem_AllInShot_Only(
          IntPtr @this,
          uint dwItemID,
          byte require_count,
          IntPtr use_count,
          IntPtr nUseGhostArrow)
        {
            int num1 = 0;
            try
            {
                IntPtr inptr = Marshal.ReadIntPtr(@this, 460);
                IntPtr this1 = MISC.__RTDynamicCast(inptr, 0, (IntPtr)8295944, (IntPtr)8295992, 0) + 3272;
                int ItemId = Marshal.ReadInt32(RhHook.MapFunctions.CInventorySlotManager.GetItem(this1, 0, 13), 32);
                int num2;
                if (GlobalData.Stacks.Exists((Predicate<int>)(t => t == ItemId)))
                    num2 = 1;
                else
                    num2 = (int)((Dictionary<string, Hook>)Hooks.Manager)["CBattleManager::IsUseItem_AllInShot_Only"].CallOriginal(new object[5]
                    {
            (object) @this,
            (object) dwItemID,
            (object) require_count,
            (object) use_count,
            (object) nUseGhostArrow
                    });
                return num2;
            }
            catch (Exception ex)
            {
                Log.LogError(ex, "CBattleManager.IsUseItem_AllInShot_Only");
                return num1;
            }
        }

        [HandleProcessCorruptedStateExceptions]
        private static int DetouredCalAffectedSkillDamage(
          IntPtr @this,
          IntPtr BC,
          IntPtr sao,
          int nDamage,
          IntPtr pAttackee)
        {
            try
            {
                int num1 = Marshal.ReadInt32(sao, 92);
                int num2 = (int)((Dictionary<string, Hook>)Hooks.Manager)["CBattleManager::CalAffectedSkillDamage"].CallOriginal(new object[5]
                {
          (object) @this,
          (object) BC,
          (object) sao,
          (object) nDamage,
          (object) pAttackee
                });
                if (GlobalData.Debug)
                    Log.LogString("Hooked CBattleManager::CalAffectedSkillDamage");
                IntPtr this1 = Marshal.ReadIntPtr(@this, 460);
                IntPtr num3 = this1 + 256;
                IntPtr this2 = pAttackee + 256;
                IntPtr num4 = num3 + 96;
                IntPtr this3 = this2 + 96;
                SATTACKORDER structure1 = (SATTACKORDER)Marshal.PtrToStructure(sao, typeof(SATTACKORDER));
                if (this1 == IntPtr.Zero)
                    return 1;
                if (CSkillSlot.IsAffectSkill(num3, 1125U) == 1)
                {
                    IntPtr this4 = CSkillSlot.GetSkill(num3, 1125U);
                    if (this4 != IntPtr.Zero)
                    {
                        int num5 = Marshal.ReadInt32(CSkill.GetSkillLevelInfo(this4), 17);
                        if (structure1.wSkillKind == (ushort)1101 || structure1.wSkillKind == (ushort)1123 || structure1.wSkillKind == (ushort)8193)
                            num2 += (int)((double)(num2 * (num5 + 100)) / 100.0);
                    }
                }
                if (CSkillSlot.IsAffectSkill(this2, 1125U) == 1)
                {
                    EpochID2 structure2 = (EpochID2)Marshal.PtrToStructure(CEntityBase.GetEpochId(pAttackee), typeof(EpochID2));
                    if ((int)structure1.dwAttackeeID[0] != (int)structure2.m_nID)
                    {
                        Marshal.WriteInt32(BC, 12, 0);
                        return 0;
                    }
                }
                if (CSkillSlot.IsAffectSkill(num3, 1110U) == 1)
                {
                    IntPtr this5 = CSkillSlot.GetSkill(num3, 1110U);
                    if (this5 != IntPtr.Zero)
                    {
                        int nValue = Marshal.ReadInt32(CSkill.GetSkillLevelInfo(this5), 17);
                        int num6 = CBioticBase.SetAbility(this1, 106, nValue);
                    }
                }
                if (CSkillSlot.IsAffectSkill(this2, 32990U) == 1)
                {
                    if (CQualitiesOption.GetOptionValue(this3, 513) == 1)
                    {
                        CQualitiesOption.SetOption(this3, 513, 0);
                    }
                    else
                    {
                        int optionValue = CQualitiesOption.GetOptionValue(this3, 512);
                        num2 += (int)((double)(num2 * (optionValue + 100)) / 100.0);
                    }
                }
                else
                    CQualitiesOption.SetOption(this3, 512, 0);
                if (CSkillSlot.IsAffectSkill(num3, 2118U) == 1)
                {
                    IntPtr this6 = CSkillSlot.GetSkill(num3, 2118U);
                    if (this6 != IntPtr.Zero)
                    {
                        int num7 = Marshal.ReadInt32(num3, 248);
                        int num8;
                        Marshal.WriteInt32(num3, 248, num8 = num7 + 1);
                        int num9;
                        int num10 = num9 = num8 + 1;
                        int num11 = Marshal.ReadInt32(CSkill.GetSkillLevelInfo(this6), 17);
                        num2 += num10 * num11 * num2 / 100;
                    }
                }
                if (num1 == 0 && CSkillSlot.IsAffectSkill(this2, 16443U) == 1)
                {
                    IntPtr this7 = CSkillSlot.GetSkill(this2, 16443U);
                    if (this7 != IntPtr.Zero)
                    {
                        _tagSkillLevelInfo structure3 = (_tagSkillLevelInfo)Marshal.PtrToStructure(CSkill.GetSkillLevelInfo(this7), typeof(_tagSkillLevelInfo));
                        num2 -= (int)((double)((long)num2 * (long)(structure3.nParam[0] + 100U)) / 100.0);
                    }
                }
                if (GlobalData.Debug)
                    Log.LogString("oDamage = " + num2.ToString());
                return num2;
            }
            catch (Exception ex)
            {
                Log.LogError(ex, "CBattleManager.CalAffectedSkillDamage");
                return 1;
            }
        }

        [HandleProcessCorruptedStateExceptions]
        private static int DetouredIsSkillAffect(
          IntPtr @this,
          IntPtr pAttackee,
          ushort wSkillKind,
          byte nSkillLevel,
          int nDamage,
          IntPtr nResult)
        {
            try
            {
                IntPtr num1 = Marshal.ReadIntPtr(@this, 460) + 256;
                IntPtr num2 = pAttackee + 256;
                IntPtr num3 = num1 + 96;
                IntPtr num4 = num2 + 96;
                int num5 = Marshal.ReadInt32(nResult);
                if ((num5 != 263 || num5 != 259) && (wSkillKind == (ushort)583 || wSkillKind == (ushort)32990 || wSkillKind == (ushort)598 || wSkillKind == (ushort)32991))
                    return 1;
                return (int)((Dictionary<string, Hook>)Hooks.Manager)["CBattleManager::IsSkillAffect"].CallOriginal(new object[6]
                {
          (object) @this,
          (object) pAttackee,
          (object) wSkillKind,
          (object) nSkillLevel,
          (object) nDamage,
          (object) nResult
                });
            }
            catch (Exception ex)
            {
                Log.LogError(ex, "CBattleManager.IsSkillAffect");
                return 1;
            }
        }

        [HandleProcessCorruptedStateExceptions]
        private static int DetouredSkillAttackAttackeeAction(
          IntPtr @this,
          IntPtr BC,
          IntPtr sao,
          int nDamage,
          IntPtr nResult)
        {
            try
            {
                int num1 = (int)((Dictionary<string, Hook>)Hooks.Manager)["CBattleManager::SkillAttackAttackeeAction"].CallOriginal(new object[5]
                {
          (object) @this,
          (object) BC,
          (object) sao,
          (object) nDamage,
          (object) nResult
                });
                RhHook.Data.SBattleContext structure1 = (RhHook.Data.SBattleContext)Marshal.PtrToStructure(BC, typeof(RhHook.Data.SBattleContext));
                SATTACKORDER structure2 = (SATTACKORDER)Marshal.PtrToStructure(sao, typeof(SATTACKORDER));
                RhHook.MapFunctions.CBattleManager structure3 = (RhHook.MapFunctions.CBattleManager)Marshal.PtrToStructure(@this, typeof(RhHook.MapFunctions.CBattleManager));
                if (@this == IntPtr.Zero)
                    return 1;
                int num2 = Marshal.ReadInt32(nResult);
                if (num2 == 263 || num2 == 259)
                    return num1;
                IntPtr this1 = structure3.m_pAttacker + 256;
                IntPtr this2 = structure1.pAttackee + 256;
                byte num3 = RhHook.MapFunctions.CSkillManager.GetTotalDynamicLevel(this1, structure2.wSkillKind);
                IntPtr num4 = CSkillScript.GetSkillInfo((uint)structure2.wSkillKind);
                IntPtr zero1 = IntPtr.Zero;
                IntPtr this3 = this2 + 96;
                _tagSkillLevelInfo tagSkillLevelInfo1 = new _tagSkillLevelInfo();
                if (num4 != IntPtr.Zero)
                {
                    if (num3 >= (byte)7)
                        return nDamage;
                    tagSkillLevelInfo1 = (_tagSkillLevelInfo)Marshal.PtrToStructure(num4 + 88 + 421 * (int)num3, typeof(_tagSkillLevelInfo));
                }
                if (CSkillSlot.IsAffectSkill(this1, 4177U) == 1)
                {
                    IntPtr num5 = CSkillSlot.GetSkill(this1, 4177U);
                    if (num5 != IntPtr.Zero)
                    {
                        RhHook.Data._tagAffectSkill structure4 = (RhHook.Data._tagAffectSkill)Marshal.PtrToStructure(num5, typeof(RhHook.Data._tagAffectSkill));
                        _tagSkillLevelInfo structure5 = (_tagSkillLevelInfo)Marshal.PtrToStructure(CSkill.GetSkillLevelInfo(num5), typeof(_tagSkillLevelInfo));
                        num1 += (int)((double)num1 * ((double)structure5.nParam[0] / 100.0));
                    }
                }
                if (CSkillSlot.IsAffectSkill(this1, 598U) == 1)
                {
                    IntPtr num6 = CSkillScript.GetSkillInfo(598U);
                    IntPtr zero2 = IntPtr.Zero;
                    _tagSkillLevelInfo tagSkillLevelInfo2 = new _tagSkillLevelInfo();
                    if (num6 != IntPtr.Zero)
                    {
                        if (num3 >= (byte)7)
                            return nDamage;
                        tagSkillLevelInfo2 = (_tagSkillLevelInfo)Marshal.PtrToStructure(num6 + 88 + 421 * (int)num3, typeof(_tagSkillLevelInfo));
                    }
                    int num7 = RhHook.MapFunctions.CSkillManager.EraseBuffSkill(this2, (int)tagSkillLevelInfo2.nParam[1]);
                }
                return num1;
            }
            catch (Exception ex)
            {
                Log.LogError(ex, "CBattleManager::SkillAttackAttackeeAction");
                return 1;
            }
        }

        [HandleProcessCorruptedStateExceptions]
        private static int ReadVectorSize<T>(UnmanagedVector Vector) where T : new()
        {
            Marshal.SizeOf((object)new T());
            return ((int)Vector.LastElement - (int)Vector.Start) / 4;
        }

        [HandleProcessCorruptedStateExceptions]
        private static List<IntPtr> ReadObjectVectorToPtrList(UnmanagedVector Vector)
        {
            int num = ((int)Vector.LastElement - (int)Vector.Start) / 4;
            List<IntPtr> ptrList = new List<IntPtr>();
            IntPtr start = Vector.Start;
            while ((int)start < (int)Vector.LastElement)
            {
                ptrList.Add(Marshal.ReadIntPtr(start));
                start += 4;
            }
            return ptrList;
        }

        [HandleProcessCorruptedStateExceptions]
        private static List<T> ReadObjectVectorToManagedList<T>(UnmanagedVector Vector) where T : new()
        {
            int num = ((int)Vector.LastElement - (int)Vector.Start) / 4;
            List<T> managedList = new List<T>();
            IntPtr start = Vector.Start;
            while ((int)start < (int)Vector.LastElement)
            {
                managedList.Add((T)Marshal.PtrToStructure(Marshal.ReadIntPtr(start), typeof(T)));
                start += 4;
            }
            return managedList;
        }

        [HandleProcessCorruptedStateExceptions]
        private static void DetouredProcess(IntPtr @this, IntPtr sao)
        {
            CBattleManager.ReadObjectVectorToManagedList<RhHook.MapFunctions.CBiotic>(((RhHook.MapFunctions.CBattleManager)Marshal.PtrToStructure(@this, typeof(RhHook.MapFunctions.CBattleManager))).m_vecAttackee);
            ((Dictionary<string, Hook>)Hooks.Manager)["CBattleManager::Process"].CallOriginal(new object[2]
            {
        (object) @this,
        (object) sao
            });
        }

        [HandleProcessCorruptedStateExceptions]
        private static int DetouredIsAttackable(
          IntPtr @this,
          IntPtr BC,
          IntPtr sao,
          IntPtr attack_result)
        {
            RhHook.Data.SBattleContext structure = (RhHook.Data.SBattleContext)Marshal.PtrToStructure(BC, typeof(RhHook.Data.SBattleContext));
            IntPtr this1 = structure.pAttackee + 256;
            IntPtr num1 = this1 + 96;
            if (CSkillSlot.IsAffectSkill(this1, 1125U) == 1)
            {
                IntPtr num2 = Marshal.ReadIntPtr(@this, 460) + 256 + 96;
                if ((int)((SATTACKORDER)Marshal.PtrToStructure(sao, typeof(SATTACKORDER))).dwAttackeeID[0] != (int)((EpochID2)Marshal.PtrToStructure(CEntityBase.GetEpochId(structure.pAttackee), typeof(EpochID2))).m_nID)
                {
                    Marshal.WriteInt32(attack_result, 999);
                    return 0;
                }
            }
            return (int)((Dictionary<string, Hook>)Hooks.Manager)["CBattleManager::IsAttackable"].CallOriginal(new object[4]
            {
        (object) @this,
        (object) BC,
        (object) sao,
        (object) attack_result
            });
        }

        [HandleProcessCorruptedStateExceptions]
        private static unsafe void DetouredCriticalDamageAttackeeAction(IntPtr @this)
        {
            try
            {
                RhHook.MapFunctions.CBattleManager structure1 = (RhHook.MapFunctions.CBattleManager)Marshal.PtrToStructure(@this, typeof(RhHook.MapFunctions.CBattleManager));
                IntPtr this1 = structure1.m_pAttacker + 256;
                Hooks.Manager["CBattleManager::CriticalDamageAttackeeAction"].CallOriginal((object)@this);
                if (CSkillSlot.IsAffectSkill(this1, 2101U) != 1)
                    return;
                IntPtr num1 = MISC.__RTDynamicCast(structure1.m_pAttacker, 0, (IntPtr)8295944, (IntPtr)8295992, 0);
                if (num1 != IntPtr.Zero)
                {
                    int num2 = 0;
                    if ((uint)RhHook.MapFunctions.CPlayerItemSlotManager.GetEquipItemType(num1 + 3272, &num2) > 0U && num2 == 7)
                    {
                        List<IntPtr> ptrList = CBattleManager.ReadObjectVectorToPtrList(structure1.m_vecAttackee);
                        if ((uint)ptrList.Count > 0U)
                        {
                            EpochID2 structure2 = (EpochID2)Marshal.PtrToStructure(structure1.m_pAttacker + 44, typeof(EpochID2));
                            RhHook.Data._tagAffectSkill tagAffectSkill = new RhHook.Data._tagAffectSkill()
                            {
                                dwEntityID = structure2.m_nID,
                                nAffectTime = Invoke.MM_GetTime(),
                                nKind = 32983,
                                nEventType = 5,
                                dwDurationTime = 0
                            };
                            tagAffectSkill.nLevel = RhHook.MapFunctions.CSkillManager.GetTotalDynamicLevel(this1, (ushort)2101);
                            tagAffectSkill.nEventTime = tagAffectSkill.nAffectTime;
                            IntPtr num3 = Marshal.AllocHGlobal(32);
                            Marshal.StructureToPtr((object)tagAffectSkill, num3, true);
                            IntPtr this2 = ptrList[0] + 256;
                            int num4 = RhHook.MapFunctions.CSkillManager.AddAffectSkill(this2, num3);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log.LogError(ex, "CBattleManager.CriticalDamageAttackeeAction");
            }
        }

        [HandleProcessCorruptedStateExceptions]
        public static int DetouredCalSkillDamage(IntPtr @this, IntPtr BC, IntPtr sao, int nDamage)
        {
            if (GlobalData.Debug)
                Log.LogString("Hooked CBattleManager::CalSkillAttackForce");
            int num1 = 0;
            try
            {
                IntPtr this1 = Marshal.ReadIntPtr(@this, 460);
                IntPtr this2 = this1 + 256;
                IntPtr num2 = this2 + 96;
                switch ((SkillIdx)((SATTACKORDER)Marshal.PtrToStructure(sao, typeof(SATTACKORDER))).wSkillKind)
                {
                    case SkillIdx.PENTAGRAM_OF_LIGHT:
                        int num3 = CBioticBase.GetAbility(this1, 0U);
                        int num4 = CBioticBase.GetAbility(this1, 4U);
                        IntPtr this3 = CSkillSlot.GetSkill(this2, 8193U);
                        if (this3 != IntPtr.Zero)
                        {
                            _tagSkillLevelInfo structure = (_tagSkillLevelInfo)Marshal.PtrToStructure(CSkill.GetSkillLevelInfo(this3), typeof(_tagSkillLevelInfo));
                            nDamage += (int)((double)((long)structure.nParam[0] * (long)num3 + ((long)structure.nParam[1] + (long)num4)) / 100.0);
                            num1 = nDamage;
                            break;
                        }
                        break;
                    case SkillIdx.DARKNESS_CALL:
                        int num5 = CBioticBase.GetAbility(this1, 0U);
                        int num6 = CBioticBase.GetAbility(this1, 4U);
                        IntPtr this4 = CSkillSlot.GetSkill(this2, 8194U);
                        if (this4 != IntPtr.Zero)
                        {
                            _tagSkillLevelInfo structure = (_tagSkillLevelInfo)Marshal.PtrToStructure(CSkill.GetSkillLevelInfo(this4), typeof(_tagSkillLevelInfo));
                            nDamage += (int)((double)((long)structure.nParam[0] * (long)num5 + ((long)structure.nParam[1] + (long)num6)) / 100.0);
                            num1 = nDamage;
                            break;
                        }
                        break;
                    case SkillIdx.WOUND_OF_RESTRICTION:
                        int num7 = CBioticBase.GetAbility(this1, 0U);
                        IntPtr this5 = CSkillSlot.GetSkill(this2, 8220U);
                        if (this5 != IntPtr.Zero)
                        {
                            _tagSkillLevelInfo structure = (_tagSkillLevelInfo)Marshal.PtrToStructure(CSkill.GetSkillLevelInfo(this5), typeof(_tagSkillLevelInfo));
                            nDamage += (int)((double)((long)structure.nParam[0] * (long)num7) / 100.0);
                            num1 = nDamage;
                            break;
                        }
                        break;
                    case SkillIdx.PENETRATING_DARK:
                        int num8 = CBioticBase.GetAbility(this1, 6U);
                        IntPtr this6 = CSkillSlot.GetSkill(this2, 8224U);
                        if (this6 != IntPtr.Zero)
                        {
                            _tagSkillLevelInfo structure = (_tagSkillLevelInfo)Marshal.PtrToStructure(CSkill.GetSkillLevelInfo(this6), typeof(_tagSkillLevelInfo));
                            nDamage += (int)((double)((long)structure.nParam[0] * (long)num8) / 100.0);
                            num1 = nDamage;
                            break;
                        }
                        break;
                    case SkillIdx.WINDY_CHAIN:
                        int num9 = CBioticBase.GetAbility(this1, 6U);
                        IntPtr this7 = CSkillSlot.GetSkill(this2, 8253U);
                        if (this7 != IntPtr.Zero)
                        {
                            _tagSkillLevelInfo structure = (_tagSkillLevelInfo)Marshal.PtrToStructure(CSkill.GetSkillLevelInfo(this7), typeof(_tagSkillLevelInfo));
                            nDamage += (int)((double)((long)structure.nParam[0] * (long)num9) / 100.0);
                            num1 = nDamage;
                            break;
                        }
                        break;
                    case SkillIdx.THUNDERSTROKE:
                        int num10 = CBioticBase.GetAbility(this1, 6U);
                        IntPtr this8 = CSkillSlot.GetSkill(this2, 8230U);
                        if (this8 != IntPtr.Zero)
                        {
                            _tagSkillLevelInfo structure = (_tagSkillLevelInfo)Marshal.PtrToStructure(CSkill.GetSkillLevelInfo(this8), typeof(_tagSkillLevelInfo));
                            nDamage += (int)((double)((long)structure.nParam[0] * (long)num10) / 100.0);
                            num1 = nDamage;
                            break;
                        }
                        break;
                    case SkillIdx.DISTORTION_CLAW_OBLIVION:
                        int num11 = CBioticBase.GetAbility(this1, 6U);
                        IntPtr this9 = CSkillSlot.GetSkill(this2, 8232U);
                        if (this9 != IntPtr.Zero)
                        {
                            _tagSkillLevelInfo structure = (_tagSkillLevelInfo)Marshal.PtrToStructure(CSkill.GetSkillLevelInfo(this9), typeof(_tagSkillLevelInfo));
                            nDamage += (int)((double)((long)structure.nParam[0] * (long)num11) / 100.0);
                            num1 = nDamage;
                            break;
                        }
                        break;
                    case SkillIdx.AIRBURST:
                        int num12 = CBioticBase.GetAbility(this1, 6U);
                        IntPtr this10 = CSkillSlot.GetSkill(this2, 8233U);
                        if (this10 != IntPtr.Zero)
                        {
                            _tagSkillLevelInfo structure = (_tagSkillLevelInfo)Marshal.PtrToStructure(CSkill.GetSkillLevelInfo(this10), typeof(_tagSkillLevelInfo));
                            nDamage += (int)((double)((long)structure.nParam[0] * (long)num12) / 100.0);
                            num1 = nDamage;
                            break;
                        }
                        break;
                    case SkillIdx.DISTORTION_CLAW_CHAOS:
                        int num13 = CBioticBase.GetAbility(this1, 6U);
                        IntPtr this11 = CSkillSlot.GetSkill(this2, 8252U);
                        if (this11 != IntPtr.Zero)
                        {
                            _tagSkillLevelInfo structure = (_tagSkillLevelInfo)Marshal.PtrToStructure(CSkill.GetSkillLevelInfo(this11), typeof(_tagSkillLevelInfo));
                            nDamage += (int)((double)((long)structure.nParam[0] * (long)num13) / 100.0);
                            num1 = nDamage;
                            break;
                        }
                        break;
                    case SkillIdx.DIMENSION_SCAR:
                        int num14 = CBioticBase.GetAbility(this1, 6U);
                        IntPtr this12 = CSkillSlot.GetSkill(this2, 8253U);
                        if (this12 != IntPtr.Zero)
                        {
                            _tagSkillLevelInfo structure = (_tagSkillLevelInfo)Marshal.PtrToStructure(CSkill.GetSkillLevelInfo(this12), typeof(_tagSkillLevelInfo));
                            nDamage += (int)((double)((long)structure.nParam[0] * (long)num14) / 100.0);
                            num1 = nDamage;
                            break;
                        }
                        break;
                    case SkillIdx.A_REAR_BLAST:
                        int num15 = CBioticBase.GetAbility(this1, 6U);
                        IntPtr this13 = CSkillSlot.GetSkill(this2, 32989U);
                        if (this13 != IntPtr.Zero)
                        {
                            _tagSkillLevelInfo structure = (_tagSkillLevelInfo)Marshal.PtrToStructure(CSkill.GetSkillLevelInfo(this13), typeof(_tagSkillLevelInfo));
                            nDamage += (int)((double)((long)structure.nParam[0] * (long)num15) / 100.0);
                            num1 = nDamage;
                            break;
                        }
                        break;
                    default:
                        num1 = (int)((Dictionary<string, Hook>)Hooks.Manager)["CBattleManager::CalSkillDamage"].CallOriginal(new object[4]
                        {
              (object) @this,
              (object) BC,
              (object) sao,
              (object) nDamage
                        });
                        break;
                }
                return num1;
            }
            catch (Exception ex)
            {
                Log.LogError(ex, "CBattleManager.CalSkillDamage");
                return num1;
            }
        }

        public static CBattleManager.DIsUseItem_AllInShot_Only _IsUseItem_AllInShot_Only { get; set; }

        public static CBattleManager.DIsUseItem _IsUseItem { get; set; }

        public static CBattleManager.DCalSkillDamage _CalSkillDamage { get; set; }

        public static CBattleManager.DCalAffectedSkillDamage _CalAffectedSkillDamage { get; set; }

        public static CBattleManager.DIsSkillAffect _IsSkillAffect { get; set; }

        public static CBattleManager.DSkillAttackAttackeeAction _SkillAttackAttackeeAction { get; set; }

        public static CBattleManager.DProcess _Process { get; set; }

        public static CBattleManager.DIsAttackable _IsAttackable { get; set; }

        public static CBattleManager.DCriticalDamageAttackeeAction _CriticalDamageAttackeeAction { get; set; }

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate int DIsUseItem_AllInShot_Only(
          IntPtr @this,
          uint dwItemID,
          byte require_count,
          IntPtr use_count,
          IntPtr nUseGhostArrow);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate int DIsUseItem(IntPtr @this, uint dwItemID, byte nCount);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate int DCalSkillDamage(IntPtr @this, IntPtr BC, IntPtr sao, int nDamage);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate int DCalAffectedSkillDamage(
          IntPtr @this,
          IntPtr BC,
          IntPtr sao,
          int nDamage,
          IntPtr pAttackee);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate int DIsSkillAffect(
          IntPtr @this,
          IntPtr pAttackee,
          ushort wSkillKind,
          byte nSkillLevel,
          int nDamage,
          IntPtr nResult);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate int DSkillAttackAttackeeAction(
          IntPtr @this,
          IntPtr BC,
          IntPtr sao,
          int nDamage,
          IntPtr nResult);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate void DProcess(IntPtr @this, IntPtr sao);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate int DIsAttackable(IntPtr @this, IntPtr BC, IntPtr sao, IntPtr attack_result);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate void DCriticalDamageAttackeeAction(IntPtr @this);
    }
}
