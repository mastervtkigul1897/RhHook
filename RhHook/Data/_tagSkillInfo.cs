// Decompiled with JetBrains decompiler
// Type: RhHook.Data._tagSkillInfo
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System.Runtime.InteropServices;

namespace RhHook.Data
{
  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public struct _tagSkillInfo
  {
    public ushort nKind;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 40)]
    public byte[] szKorName;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 40)]
    public byte[] szEngName;
    public byte nType;
    public byte nSubType;
    public int nTarget;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
    public _tagSkillLevelInfo[] nLevelInfo;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
    public byte[] szDescription;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 30)]
    public byte[] szIconFileName;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 30)]
    public byte[] szIconPushFileName;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 30)]
    public byte[] szIconSmallFileName;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 30)]
    public byte[] szIconLargeFileName;
    public int nRange;
    public int bCountinuous_Attack;
    public int bAssistance;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 30)]
    public byte[] szIconAffectFileName;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
    public byte[] szAffectDescription;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 30)]
    public byte[] szIconAffectSmallFileName;
    public byte nAddPoint;
    public int nAddPointProbability;
    public int nAddPointProbability2;
    public uint nTimeFlag;
  }
}
