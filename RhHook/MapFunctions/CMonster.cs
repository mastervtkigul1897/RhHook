// Decompiled with JetBrains decompiler
// Type: RhHook.MapFunctions.CMonster
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System;
using System.Runtime.InteropServices;

namespace RhHook.MapFunctions
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public class CMonster : CAIBiotic
    {
        public static readonly IntPtr CalAllAbilityA = (IntPtr)5647408;
        public static readonly CMonster.DCalAllAbility CalAllAbility = (CMonster.DCalAllAbility)Marshal.GetDelegateForFunctionPointer(CMonster.CalAllAbilityA, typeof(CMonster.DCalAllAbility));
        public IntPtr m_pScript;
        public CTimer m_timerSend;
        public CTimer m_timerSkillAct;
        public int m_nRateResistStun;
        public int m_nRateResistAbsorption;
        public int m_nRateResistConfusion;
        public int m_nRateResistDispel;
        public int m_nRateResistDot;
        public int m_nRateResistEtc;
        public int m_nRateResistKnockback;
        public int m_nRateResistParalyze;
        public int m_nRateResistRoot;
        public int m_nRateResistSleep;
        public int m_nRateResistSlow;
        public int m_nRateResistSnare;
        public int m_nRateResistStatus;
        public int m_nRateResistTaunt;
        public int m_nRateResistPhysicalDamage;
        public int m_nRateResistMagicalDamage;
        public bool m_is_multiparty_quest;
        public IntPtr m_trigger;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
        public byte[] m_onetimeskill_checklist;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public byte[] m_skillqueue;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public byte[] m_oneTimeVoice_CheckLife;
        public CGeoRandom m_randomDrop;
        public CGeoRandom m_randomSkill;
        public CEntityBase entityBase;

        [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
        public delegate void DCalAllAbility(IntPtr @this);
    }
}
