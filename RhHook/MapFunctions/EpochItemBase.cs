// Decompiled with JetBrains decompiler
// Type: RhHook.MapFunctions.EpochItemBase
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using RhHook.Data;
using RhHook.Util;
using System;
using System.Runtime.InteropServices;

namespace RhHook.MapFunctions
{
  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public class EpochItemBase : CIOBase
  {
    public static readonly IntPtr GetItemEntityTypeA = (IntPtr) 6862064;
    public static readonly EpochItemBase.DGetItemEntityType GetItemEntityType = (EpochItemBase.DGetItemEntityType) Marshal.GetDelegateForFunctionPointer(EpochItemBase.GetItemEntityTypeA, typeof (EpochItemBase.DGetItemEntityType));
    public static readonly IntPtr GetAttributeA = (IntPtr) 6861536;
    public static readonly EpochItemBase.DGetAttribute GetAttribute = (EpochItemBase.DGetAttribute) Marshal.GetDelegateForFunctionPointer(EpochItemBase.GetAttributeA, typeof (EpochItemBase.DGetAttribute));
    public static readonly IntPtr GetOptionA = (IntPtr) 6861920;
    public static readonly EpochItemBase.DGetOption GetOption = (EpochItemBase.DGetOption) Marshal.GetDelegateForFunctionPointer(EpochItemBase.GetOptionA, typeof (EpochItemBase.DGetOption));
    public static readonly IntPtr SetAttributeA = (IntPtr) 6861888;
    public static readonly EpochItemBase.DSetAttribute SetAttribute = (EpochItemBase.DSetAttribute) Marshal.GetDelegateForFunctionPointer(EpochItemBase.SetAttributeA, typeof (EpochItemBase.DSetAttribute));
    public static readonly IntPtr SetOptionA = (IntPtr) 6861968;
    public static readonly EpochItemBase.DSetOption SetOption = (EpochItemBase.DSetOption) Marshal.GetDelegateForFunctionPointer(EpochItemBase.SetOptionA, typeof (EpochItemBase.DSetOption));
    public static readonly IntPtr GetItemGRA = (IntPtr) 6862272;
    public static readonly EpochItemBase.DGetItemGR GetItemGR = (EpochItemBase.DGetItemGR) Marshal.GetDelegateForFunctionPointer(EpochItemBase.GetItemGRA, typeof (EpochItemBase.DGetItemGR));
    public IntPtr m_pEpochItemScript;
    public EpochID2 m_ID;
    public CQualities m_attribute;
    public CQualities m_option;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
    public byte[] m_szName;
    public CIOCriticalSection m_crit;
    public int m_bIsUse;
    public volatile int m_nState;

    public static void GetItemGRExt(IntPtr @this, ref RhHook.Data.__tagItem item)
    {
      EpochItemBase structure = (EpochItemBase) Marshal.PtrToStructure(@this, typeof (EpochItemBase));
      if (structure.m_dwBits > 0U)
        return;
      if (structure.m_pEpochItemScript != IntPtr.Zero)
      {
        Log.LogString("0-1");
        lock (structure)
        {
          Log.LogString("0-2");
          item.id.nId = structure.m_ID.m_nID;
          item.id.nType = structure.m_ID.m_nType;
          item.nInventory = (sbyte) EpochItemBase.GetAttribute(@this, 12);
          item.nSlot = (sbyte) EpochItemBase.GetAttribute(@this, 13);
          item.nStack = (byte) EpochItemBase.GetAttribute(@this, 9);
          item.nRank = (byte) EpochItemBase.GetAttribute(@this, 11);
          item.nEquipLevel = (byte) EpochItemBase.GetAttribute(@this, 5);
          item.nEquipStrength = (short) EpochItemBase.GetAttribute(@this, 6);
          item.nEquipDexterity = (short) EpochItemBase.GetAttribute(@this, 7);
          item.nEquipIntelligence = (short) EpochItemBase.GetAttribute(@this, 8);
          Log.LogString("0-3");
          int num1 = 0;
          for (int nOptionType = 1; nOptionType < 90 && num1 < 14; ++nOptionType)
          {
            int num2 = EpochItemBase.GetOption(@this, nOptionType);
            if (num2 != 0)
            {
              Log.LogString("0-4");
              item.nOptions.option[3 * num1].nType = (byte) nOptionType;
              item.nOptions.option[3 * num1++ + 1].nValue = (short) num2;
            }
          }
        }
      }
      else
        Log.LogString("Error item script is null");
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DGetItemEntityType(IntPtr @this);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DGetAttribute(IntPtr @this, int nAttributeType);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DGetOption(IntPtr @this, int nOptionType);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate void DSetAttribute(IntPtr @this, int nAttributeType, int nValue);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DSetOption(IntPtr @this, int nOptionType, int nValue);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate void DGetItemGR(IntPtr @this, IntPtr item);
  }
}
