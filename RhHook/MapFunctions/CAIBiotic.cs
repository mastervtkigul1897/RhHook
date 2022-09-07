// Decompiled with JetBrains decompiler
// Type: RhHook.MapFunctions.CAIBiotic
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using RhHook.Data;
using System.Runtime.InteropServices;

namespace RhHook.MapFunctions
{
  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public class CAIBiotic : CBiotic
  {
    public uint m_dwAITargetID;
    public ushort m_wNativeSkillKind;
    public int m_nLinkIndex;
    public CQualities m_PassiveAbility;
    public int m_bStartWander;
    private EpochVector3 m_posGenerate;
  }
}
