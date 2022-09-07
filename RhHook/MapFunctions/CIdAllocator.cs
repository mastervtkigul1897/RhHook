// Decompiled with JetBrains decompiler
// Type: RhHook.MapFunctions.CIdAllocator
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System;
using System.Runtime.InteropServices;

namespace RhHook.MapFunctions
{
  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public class CIdAllocator
  {
    public static readonly IntPtr AllocItemA = (IntPtr) 5069520;
    public static readonly CIdAllocator.DAllocItem AllocItem = (CIdAllocator.DAllocItem) Marshal.GetDelegateForFunctionPointer(CIdAllocator.AllocItemA, typeof (CIdAllocator.DAllocItem));
    public static IntPtr g_IdAllocator = (IntPtr) 8357164;
    public IntPtr vfptr;
    public CGOInterlocked m_ilNpcId;
    public CGOInterlocked m_ilGroundItemId;
    public CGOInterlocked m_ilEtcId;
    public CGOInterlocked m_ilItemID;
    public int m_bMaxItemID;
    public CGOInterlocked m_ilMailID;
    public int m_bMaxMailID;

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, SetLastError = true)]
    public delegate IntPtr DAllocItem(IntPtr @this, IntPtr result, uint type);
  }
}
