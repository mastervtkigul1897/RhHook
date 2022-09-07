// Decompiled with JetBrains decompiler
// Type: RhHook.MapFunctions.CEpochItemScript
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using RhHook.Data;
using System;
using System.Runtime.InteropServices;

namespace RhHook.MapFunctions
{
  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public class CEpochItemScript
  {
    public static readonly IntPtr GetAttrA = (IntPtr) 6789600;
    public static readonly CEpochItemScript.DGetAttr GetAttr = (CEpochItemScript.DGetAttr) Marshal.GetDelegateForFunctionPointer(CEpochItemScript.GetAttrA, typeof (CEpochItemScript.DGetAttr));
    public IntPtr vfptr;
    public int m_nType;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)]
    public byte[] m_strName;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)]
    public byte[] m_strKoreanName;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)]
    public byte[] m_strImageName;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)]
    public byte[] m_strItemLargeImage;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)]
    public byte[] m_strImageName2;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)]
    public byte[] m_strItemLargeImage2;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)]
    public byte[] m_strImageName3;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)]
    public byte[] m_strItemLargeImage3;
    public int m_nAttackAni;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
    public byte[] m_mapEquipMesh;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
    public byte[] m_mapEquipMesh_Change;
    public int m_nItemEntityType;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)]
    public byte[] m_Material1;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)]
    public byte[] m_Material2;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)]
    public byte[] m_szEquipSound;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)]
    public byte[] m_szDropSound;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)]
    public byte[] m_szPickUpsound;
    public int m_DecoLevel;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
    public int[] m_nLevelEnchantPrice;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
    public int[] m_nLevelEnchantRate;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)]
    public byte[] m_strRegion;
    public int m_nMaxlevel;
    public int m_nMinLevel;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)]
    public byte[] m_strExplain;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)]
    public byte[] m_strExplainFileName;
    public IntPtr m_AddonBuildingType;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    public SITEMOPTIONATTR[] m_ItemOptionAttr;
    public CQualities m_attribute;
    public CQualities m_option;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
    public int[] m_bInitStatus;
    public int m_nGuildBankFee;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
    public short[] m_nAttributeType;

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DGetAttr(IntPtr @this, uint nAttribyteType);
  }
}
