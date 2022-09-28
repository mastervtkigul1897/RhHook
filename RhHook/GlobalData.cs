// Decompiled with JetBrains decompiler
// Type: RhHook.GlobalData
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using RhHook.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RhHook
{
  internal class GlobalData
  {
    public static bool Event = false;
    public static bool Debug = false;
    public static bool All = false;
    public static bool Gen = false;
    public static bool Par = false;
    public static bool Gui = false;
    public static string ConfigPath = "C:\\\\EPoch\\\\sudo\\\\";
    public static int min = 0;
    public static int max = 0;
    public static bool poseditoron = true;
    public static List<PosEditorVariable> poseditor = new List<PosEditorVariable>();
    public static IntPtr Handle;

    public static string Directory { get; set; }

    public static ControlPanel ControlPanel { get; set; }

    public static List<int> Stacks { get; set; }

    public static Task CommandConsole { get; set; }

    public static List<GlobalData.Portal> Portals { get; set; }

    public struct Portal
    {
      public _tagEpochVector3 pos { get; set; }

      public int nType { get; set; }
    }
  }
}
