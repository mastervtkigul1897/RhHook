// Decompiled with JetBrains decompiler
// Type: RhHook.DetouredFunctions.CEntityManager
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using Detours;
using RhHook.Data;
using RhHook.Util;
using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

namespace RhHook.DetouredFunctions
{
  internal class CEntityManager
  {
    public static readonly CEntityManager.DAdd Add = new CEntityManager.DAdd(CEntityManager.DetouredAdd);
    public static readonly CEntityManager.DRemove Remove = new CEntityManager.DRemove(CEntityManager.DetouredRemove);
    public static readonly RhHook.Util.FunctionInfo[] FunctionInfo = new RhHook.Util.FunctionInfo[2]
    {
      new RhHook.Util.FunctionInfo((IntPtr) 5104240, "CEntityManager::Add", (Delegate) CEntityManager.Add, (Delegate) CEntityManager._Add, typeof (CEntityManager.DAdd)),
      new RhHook.Util.FunctionInfo((IntPtr) 5104720, "CEntityManager::Remove", (Delegate) CEntityManager.Remove, (Delegate) CEntityManager._Remove, typeof (CEntityManager.DRemove))
    };

    [HandleProcessCorruptedStateExceptions]
    private static int DetouredAdd(IntPtr @this, IntPtr pBiotic, int nIRID)
    {
      try
      {
        if (GlobalData.poseditoron)
        {
          RhHook.MapFunctions.CBiotic structure = (RhHook.MapFunctions.CBiotic) Marshal.PtrToStructure(pBiotic, typeof (RhHook.MapFunctions.CBiotic));
          GlobalData.poseditor.Add(new PosEditorVariable()
          {
            nID = structure.m_ID.m_nID,
            pos = structure.m_Pos
          });
        }
        return (int) ((Dictionary<string, Hook>) Hooks.Manager)["CEntityManager::Add"].CallOriginal(new object[3]
        {
          (object) @this,
          (object) pBiotic,
          (object) nIRID
        });
      }
      catch (Exception ex)
      {
        Log.LogError(ex, "CEntityManager.Add");
        return 0;
      }
    }

    [HandleProcessCorruptedStateExceptions]
    private static void DetouredRemove(IntPtr @this, IntPtr pBiotic, uint dwDelayTime)
    {
      try
      {
        if (GlobalData.poseditoron)
        {
          RhHook.MapFunctions.CBiotic biotic = (RhHook.MapFunctions.CBiotic) Marshal.PtrToStructure(pBiotic, typeof (RhHook.MapFunctions.CBiotic));
          GlobalData.poseditor.RemoveAll((Predicate<PosEditorVariable>) (t => (int) t.nID == (int) biotic.m_ID.m_nID));
        }
        ((Dictionary<string, Hook>) Hooks.Manager)["CEntityManager::Remove"].CallOriginal(new object[3]
        {
          (object) @this,
          (object) pBiotic,
          (object) dwDelayTime
        });
      }
      catch (Exception ex)
      {
        Log.LogError(ex, "CEntityManager.Remove");
      }
    }

    public static CEntityManager.DBroadcastChat _BroadcastChat { get; set; }

    public static CEntityManager.DAdd _Add { get; set; }

    public static CEntityManager.DRemove _Remove { get; set; }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
    public delegate void DBroadcastChat(
      IntPtr @this,
      int bPKMode,
      int nProtocol,
      IntPtr pData1,
      IntPtr pData2,
      int nSize,
      IntPtr center,
      float fRange,
      int nIRID);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
    public delegate int DAdd(IntPtr @this, IntPtr pBiotic, int nIRID);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
    public delegate void DRemove(IntPtr @this, IntPtr pBiotic, uint dwDelayTime);
  }
}
