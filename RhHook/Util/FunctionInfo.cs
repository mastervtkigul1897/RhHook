// Decompiled with JetBrains decompiler
// Type: RhHook.Util.FunctionInfo
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;

namespace RhHook.Util
{
  internal class FunctionInfo
  {
    public static readonly List<FunctionInfo> MapFunctions = new List<FunctionInfo>();
    public readonly IntPtr Address;
    public readonly string Name;
    public readonly Delegate Detour;
    public readonly Type TargetType;

    public FunctionInfo(
      IntPtr address,
      string name,
      Delegate detour,
      Delegate target,
      Type targetType)
    {
      try
      {
        this.Address = address;
        this.Name = name;
        this.Detour = detour;
        this.Target = target;
        this.TargetType = targetType;
      }
      catch (Exception ex)
      {
        Log.LogError(ex, "FunctionInfo.FunctionInfo");
      }
    }

    public Delegate Target { get; set; }

    [HandleProcessCorruptedStateExceptions]
    public void SetTarget(Delegate target)
    {
      try
      {
        this.Target = target;
      }
      catch (Exception ex)
      {
        Log.LogError(ex, "FunctionInfo.SetTarget");
      }
    }
  }
}
