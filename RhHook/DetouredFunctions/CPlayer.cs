// Decompiled with JetBrains decompiler
// Type: RhHook.DetouredFunctions.CPlayer
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using Detours;
using RhHook.MapFunctions;
using RhHook.Util;
using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;

namespace RhHook.DetouredFunctions
{
  internal class CPlayer
  {
    private static object SkillLearn = new object();
    public static readonly CPlayer.DCalAbility CalAbility = new CPlayer.DCalAbility(CPlayer.DetouredCalAbility);
    public static readonly CPlayer.DBroadcastUpLevel BroadcastUpLevel = new CPlayer.DBroadcastUpLevel(CPlayer.DetouredBroadcastUpLevel);
    public static readonly RhHook.Util.FunctionInfo[] FunctionInfo = new RhHook.Util.FunctionInfo[1]
    {
      new RhHook.Util.FunctionInfo((IntPtr) 5114752, "CPlayer::BroadcastUpLevel", (Delegate) CPlayer.BroadcastUpLevel, (Delegate) CPlayer._BroadcastUpLevel, typeof (CPlayer.DBroadcastUpLevel))
    };

    [HandleProcessCorruptedStateExceptions]
    public static IntPtr FindPlayer(IntPtr biotic) => MISC.__RTDynamicCast(biotic, 0, (IntPtr) 8295944, (IntPtr) 8295992, 0);

    [HandleProcessCorruptedStateExceptions]
    private static void DetouredBroadcastUpLevel(IntPtr @this)
    {
      try
      {
        ((Dictionary<string, Hook>) Hooks.Manager)["CPlayer::BroadcastUpLevel"].CallOriginal(new object[1]
        {
          (object) @this
        });
        byte[] numArray = new byte[21];
        Marshal.Copy(RhHook.MapFunctions.CPlayer.GetName(@this), numArray, 0, 21);
        int num1 = CBioticBase.GetAbility(@this, 21U);
        int num2;
        switch (num1)
        {
          case 60:
          case 70:
          case 80:
            num2 = 1;
            break;
          default:
            num2 = num1 >= 90 ? 1 : 0;
            break;
        }
        if (num2 == 0)
          return;
        Notice.SendNotice(string.Format("Congratulations {0} For Reaching Level {1}!", (object) Encoding.ASCII.GetString(numArray).Split(new char[1])[0], (object) num1));
      }
      catch (Exception ex)
      {
        Log.LogError(ex, "CPlayer.BroadcastUpLevel");
      }
    }

    [HandleProcessCorruptedStateExceptions]
    private static int DetouredSkillLearnSkill(IntPtr @this, IntPtr prcreq)
    {
      try
      {
        ushort num1 = (ushort) Marshal.ReadInt16(prcreq);
        if (num1 >= (ushort) 36865 && num1 <= (ushort) 36939 || num1 >= (ushort) 41093 && num1 <= (ushort) 41155)
          return (int) ((Dictionary<string, Hook>) Hooks.Manager)["CPlayer::SkilLearnSkill"].CallOriginal(new object[2]
          {
            (object) @this,
            (object) prcreq
          });
        int num2 = CBioticBase.GetAbility(@this, 101U);
        lock (CPlayer.SkillLearn)
        {
          RhHook.MapFunctions.CPlayer structure1 = (RhHook.MapFunctions.CPlayer) Marshal.PtrToStructure(@this, typeof (RhHook.MapFunctions.CPlayer));
          IntPtr this1 = @this + 256;
          int nPlayerLevel = CBioticBase.GetAbility(@this, 21U) + num2;
          IntPtr ptr = CSkillSlot.GetSkill(this1, (uint) num1);
          if (ptr != IntPtr.Zero)
          {
            CSkill structure2 = (CSkill) Marshal.PtrToStructure(ptr, typeof (CSkill));
            if (structure2.m_SkillState.nLevel >= (byte) 4)
            {
              Log.LogString("pSkill->GetLearnLevel()<(MAX_SKILL_LEARN_LEVEL-1) ESKILL::E_NOT_LEARN NULL D:\\Rohan_SVN\\Source\\Server\\MapServer\\Player\\Player.cpp, 10200");
              return -84;
            }
            if (CSkillSlot.CanLearnSkill(this1, (int) structure1.m_ID.m_nType, (int) structure2.m_SkillState.nKind, (int) structure2.m_SkillState.nLevel + 1, nPlayerLevel) == 0)
            {
              Log.LogString("Failed to learn skill id " + num1.ToString());
              Log.LogString("pSkillSlot->CanLearnSkill(GetEpochId().GetType(), pSkill->GetKind(), pSkill->GetLearnLevel()+1, nPlayerLevel) ESKILL::E_NOT_LEARN g_Log.TempLog(\"[SKILL LEARN ERROR][%s] %d %d\", GetName(), pSkill->GetKind(), pSkill->GetLearnLevel()) D:\\Rohan_SVN\\Source\\Server\\MapServer\\Player\\Player.cpp, 10202");
              return -84;
            }
          }
          else if (CSkillSlot.CanLearnSkill(this1, (int) structure1.m_ID.m_nType, (int) num1, 0, nPlayerLevel) == 0)
          {
            Log.LogString("Failed to learn skill id " + num1.ToString());
            Log.LogString("pSkillSlot->CanLearnSkill(GetEpochId().GetType(), pSkill->GetKind(), pSkill->GetLearnLevel()+1, nPlayerLevel) ESKILL::E_NOT_LEARN g_Log.TempLog(\"[SKILL LEARN ERROR][%s] %d %d\", GetName(), pSkill->GetKind(), pSkill->GetLearnLevel()) D:\\Rohan_SVN\\Source\\Server\\MapServer\\Player\\Player.cpp, 10202");
            return -84;
          }
          return (int) ((Dictionary<string, Hook>) Hooks.Manager)["CPlayer::SkilLearnSkill"].CallOriginal(new object[2]
          {
            (object) @this,
            (object) prcreq
          });
        }
      }
      catch (Exception ex)
      {
        Log.LogError(ex, "CPlayer::SkilLearnSkill");
        return 0;
      }
    }

    [HandleProcessCorruptedStateExceptions]
    private static unsafe void DetouredCalAbility(IntPtr @this, int nAbilityType)
    {
      try
      {
        RhHook.MapFunctions.CPlayer structure = (RhHook.MapFunctions.CPlayer) Marshal.PtrToStructure(@this, typeof (RhHook.MapFunctions.CPlayer));
        IntPtr this1 = @this;
        IntPtr num1 = @this + 256;
        IntPtr this2 = @this + 7744;
        IntPtr this3 = num1 + 96;
        IntPtr this4 = @this + 3272;
        IntPtr this5 = this4 + 40;
        IntPtr this6 = this4 + 56;
        IntPtr this7 = @this + 4416;
        if (nAbilityType == 8)
        {
          int nLevel = CBioticBase.GetAbility(this1, 21U);
          int nIntelligence = CBioticBase.GetAbility(this1, 2U);
          int num2 = CEntityBaseStatus.CalMeleeAttackForce(this7, nIntelligence, nLevel);
          int optionValue1 = CQualitiesOption.GetOptionValue(this3, 59);
          if (optionValue1 != 0)
            num2 = num2 * (optionValue1 + 100) / 100;
          int num3 = 0;
          int num4 = 0;
          if (CQualitiesOption.GetOptionValue(this5, 7) == 3)
          {
            int num5 = CQualitiesOption.GetOptionValue(this5, 0);
            if (CQualitiesOption.GetOptionValue(this3, 179) > 0)
              num5 = 1;
            int num6 = CQualitiesOption.GetOptionValue(this3, 34) + CQualitiesOption.GetOptionValue(this6, 7) + CQualitiesOption.GetOptionValue(this3, 60);
            int num7 = 0;
            if (RhHook.MapFunctions.CPlayerItemSlotManager.GetEquipItemType(this4, &num7) != 0 && num7 == 10)
            {
              int num8 = num6 + CQualitiesOption.GetOptionValue(this3, 40);
              int optionValue2 = CQualitiesOption.GetOptionValue(this3, 41);
              int num9 = CBioticBase.GetAbility(this1, 2U);
              num5 = num5 + optionValue2 * num9 / 100 + CQualitiesOption.GetOptionValue(this3, 210) * CBioticBase.GetAbility(this1, 4U) / 100;
              num6 = num8 + CQualitiesOption.GetOptionValue(this3, 185) + CQualitiesOption.GetOptionValue(this3, 186);
            }
            if (num6 != 0)
              num5 = num5 * (num6 + 100) / 100;
            num3 += num5;
          }
          int num10 = num3 + CQualitiesOption.GetOptionValue(this3, 33) + CQualitiesOption.GetOptionValue(this5, 33) + CQualitiesOption.GetOptionValue(this5, 34);
          int num11 = num4 + CQualitiesOption.GetOptionValue(this5, 59);
          int num12 = num10 + CQualitiesOption.GetOptionValue(this5, 46);
          int num13 = num11 + CQualitiesOption.GetOptionValue(this5, 61);
          int num14 = num12 + CPlayerSocketManager.GetSocketOption(this2, 93U) + CPlayerSocketManager.GetSocketAttribute(this2, 70) + CPlayerSocketManager.GetSocketAttribute(this2, 100) + CQualitiesOption.GetOptionValue(this5, 65) + CQualitiesOption.GetOptionValue(this6, 93) + CQualitiesOption.GetOptionValue(this3, 237);
          int nValue1 = num13 + num14 + num2;
          int nValue2 = num14 + (num13 + num2) / 4;
          int num15 = CQualitiesOption.GetOptionValue(this6, 25) + CQualitiesOption.GetOptionValue(this6, 71) + CPlayerSocketManager.GetSocketOption(this2, 71U) + CQualitiesOption.GetOptionValue(this3, 47) + CPlayerSocketManager.GetSocketOption(this2, 25U);
          if (num15 != 0)
          {
            nValue1 = nValue1 * (num15 + 100) / 100;
            nValue2 = nValue2 * (num15 + 100) / 100;
          }
          int num16 = CBioticBase.SetAbility(@this, 34, nValue2);
          if (nValue1 < 0)
            nValue1 = 0;
          int num17 = CBioticBase.SetAbility(@this, nAbilityType, nValue1);
        }
        else
          ((Dictionary<string, Hook>) Hooks.Manager)["CPlayer::CalAbility"].CallOriginal(new object[2]
          {
            (object) @this,
            (object) nAbilityType
          });
      }
      catch (Exception ex)
      {
        Log.LogError(ex, "CPlayer.CalAbility");
      }
    }

    public static CPlayer.DBroadcastUpLevel _BroadcastUpLevel { get; set; }

    public static CPlayer.DSkilLearnSkill _SkilLearnSkill { get; set; }

    public static CPlayer.DCalAbility _CalAbility { get; set; }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
    public delegate void DBroadcastUpLevel(IntPtr @this);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
    public delegate int DSkilLearnSkill(IntPtr @this, IntPtr prcreq);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
    public delegate void DCalAbility(IntPtr @this, int nAbilityType);
  }
}
