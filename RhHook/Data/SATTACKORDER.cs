// Decompiled with JetBrains decompiler
// Type: RhHook.Data.SATTACKORDER
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System.Runtime.InteropServices;

namespace RhHook.Data
{
  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public struct SATTACKORDER
  {
    public int nBattleIndex;
    public uint dwAttackerID;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
    public uint[] dwAttackeeID;
    public byte nAttackType;
    public int nDurationTime;
    public uint dwStartTime;
    public byte nMissRate;
    public byte nCriticalRate;
    public short nCriticalFactor;
    public short nHitParam;
    public short nHitRate;
    public int nAttackRange;
    public int nAttackForce;
    public ushort wSkillKind;
    public byte nSkillLevel;
    public int nElementForce;
    public uint dwUseItemID;
    public byte nUseItemCount;
    public int bIsSkillAttack;
  }
}
