// Decompiled with JetBrains decompiler
// Type: RhHook.MapFunctions.EpochItem
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System;
using System.Runtime.InteropServices;

namespace RhHook.MapFunctions
{
  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public class EpochItem : EpochItemBase
  {
    public static readonly IntPtr SetCurStackA = (IntPtr) 5611424;
    public static readonly EpochItem.DSetCurStack SetCurStack = (EpochItem.DSetCurStack) Marshal.GetDelegateForFunctionPointer(EpochItem.SetCurStackA, typeof (EpochItem.DSetCurStack));
    public uint m_dwOwnerID;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] m_szLogName;

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate int DSetCurStack(IntPtr @this, IntPtr nStack);
  }
}
