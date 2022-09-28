// Decompiled with JetBrains decompiler
// Type: RhHook.MapFunctions.CEpochItemScriptManager
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using RhHook.Data;
using System;
using System.Runtime.InteropServices;

namespace RhHook.MapFunctions
{
  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public class CEpochItemScriptManager
  {
    public static readonly IntPtr GetItemEtcDetailsScriptA = (IntPtr) 6840864;
    public static readonly CEpochItemScriptManager.DGetItemEtcDetailsScript GetItemEtcDetailsScript = (CEpochItemScriptManager.DGetItemEtcDetailsScript) Marshal.GetDelegateForFunctionPointer(CEpochItemScriptManager.GetItemEtcDetailsScriptA, typeof (CEpochItemScriptManager.DGetItemEtcDetailsScript));
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
    public byte[] m_mapEpochItemScript;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
    public byte[] m_mapItemTypeScript;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
    public byte[] m_mapItemFishTypeScript;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
    public byte[] m_mapItemRegistTypeScript;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
    public byte[] m_mapItemRewardTypeScript;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
    public byte[] m_ListProcessingStoneScript;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
    public byte[] m_ListProcessingJewelScript;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
    public byte[] m_ListProcessingPlantScript;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
    public byte[] m_ListProcessingEventScript;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
    public byte[] m_ListProcessingTransScript;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
    public byte[] m_mapAttachSocketItemRate;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
    public byte[] m_ListItemRewardTypeTable;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
    public byte[] m_ListItemMallTypeTable;
    public int m_nOneHandSwordAttackSpeed;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
    public byte[] m_ListBeginItemTable;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 14)]
    public byte[] m_VecPCEventItemTable;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
    public byte[] m_ItemEtcDetailTable;
    public IntPtr m_pGameMall;
    public SetItemScritpManager m_mgrSetItemScript;
    public AchieveScriptManager m_AchieveScriptManager;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 168)]
    public byte[] trinmanagers;

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate IntPtr DGetItemEtcDetailsScript(IntPtr @this, int etcItemId);
  }
}
