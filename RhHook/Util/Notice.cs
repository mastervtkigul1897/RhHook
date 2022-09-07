// Decompiled with JetBrains decompiler
// Type: RhHook.Util.Notice
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using RhHook.MapFunctions;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;

namespace RhHook.Util
{
  internal class Notice
  {
    [HandleProcessCorruptedStateExceptions]
    public static void SendLocalNotice(IntPtr connection, string text, byte type = 2)
    {
      byte[] numArray1 = new byte[text.Length + 13];
      byte[] numArray2 = new byte[10]
      {
        (byte) 228,
        (byte) 4,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 9,
        (byte) 4
      };
      using (MemoryStream output = new MemoryStream(numArray1))
      {
        using (BinaryWriter binaryWriter = new BinaryWriter((Stream) output))
        {
          binaryWriter.Write(type);
          binaryWriter.Write((ushort) text.Length);
          binaryWriter.Write(Encoding.ASCII.GetBytes(text));
        }
      }
      CGOConnection.SendPacket(connection, (ushort) 7946, numArray1, (uint) numArray1.Length);
    }

    [HandleProcessCorruptedStateExceptions]
    public static void SendNotice(string text, byte type = 2)
    {
      byte[] numArray1 = new byte[text.Length + 13];
      byte[] numArray2 = new byte[10]
      {
        (byte) 228,
        (byte) 4,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 9,
        (byte) 4
      };
      using (MemoryStream output = new MemoryStream(numArray1))
      {
        using (BinaryWriter binaryWriter = new BinaryWriter((Stream) output))
        {
          binaryWriter.Write(type);
          binaryWriter.Write((ushort) text.Length);
          binaryWriter.Write(Encoding.ASCII.GetBytes(text));
        }
      }
      IntPtr num = CEntityManager.BroadcastAllPlayerB(CEntityManager.g_EntityManager, 7946, numArray1, numArray1.Length);
    }

    [HandleProcessCorruptedStateExceptions]
    public static void WorldNotice(string name, string text, byte type = 3)
    {
      string s = string.Format("[World] {0}: {1}", (object) name, (object) text);
      byte[] numArray1 = new byte[s.Length + 13];
      byte[] numArray2 = new byte[10]
      {
        (byte) 228,
        (byte) 4,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 9,
        (byte) 4
      };
      using (MemoryStream output = new MemoryStream(numArray1))
      {
        using (BinaryWriter binaryWriter = new BinaryWriter((Stream) output))
        {
          binaryWriter.Write(type);
          binaryWriter.Write((ushort) s.Length);
          binaryWriter.Write(Encoding.ASCII.GetBytes(s));
        }
      }
      IntPtr num = CEntityManager.BroadcastAllPlayerB(CEntityManager.g_EntityManager, 7946, numArray1, numArray1.Length);
    }

    [HandleProcessCorruptedStateExceptions]
    public static void insitem(
      string name,
      string status,
      string item_id,
      IntPtr @this,
      uint dbid,
      string itemchk)
    {
      SqlConnection sqlConnection = new SqlConnection(File.ReadAllLines("config.txt")[6]);
      SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from RohanGame.dbo.titem where id = '" + dbid.ToString() + "'", sqlConnection);
      DataTable dataTable = new DataTable();
      sqlDataAdapter.Fill(dataTable);
      for (int index = 0; index < dataTable.Rows.Count; ++index)
      {
        StringBuilder stringBuilder = new StringBuilder();
        DataRow row = dataTable.Rows[index];
        string str = row["type"].ToString();
        int num1 = int.Parse(row["char_id"].ToString());
        int num2 = int.Parse(row["user_id"].ToString());
        Console.WriteLine("--------------------------------------------------------");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Checking fireworks availability...");
        Console.WriteLine("Item ID Client : {0}, Item ID DB : {1}", (object) itemchk, (object) str);
        Console.ResetColor();
        Console.WriteLine("--------------------------------------------------------");
        if (str == itemchk)
        {
          SqlCommand sqlCommand = new SqlCommand("INSERT INTO dbo.TEventItem(type, attr, stack, rank, equip_level, char_id) VALUES(" + item_id + ", " + status + ", 1, 0, 1, " + num1.ToString() + ")", sqlConnection);
          sqlConnection.Open();
          sqlCommand.ExecuteNonQuery();
          Notice.SendLocalNotice(@this, "Success! You've successfully exchange your item. Please check your event inventory.");
          Console.WriteLine("--------------------------------------------------------");
          Console.ForegroundColor = ConsoleColor.Green;
          Console.WriteLine("Firework item check success!");
          Console.WriteLine("User : {0} has been successfully converted fireworks to Weapon / Armor...", (object) name);
          Console.ResetColor();
          Console.WriteLine("--------------------------------------------------------");
          sqlConnection.Close();
        }
        if (str != itemchk || str == "" || str == "0" || str == null)
        {
          SqlCommand sqlCommand1 = new SqlCommand("INSERT INTO RohanUser.dbo.TDisconnect (user_id, server_id, char_id) VALUES (" + num2.ToString() + ", 31, 0)", sqlConnection);
          SqlCommand sqlCommand2 = new SqlCommand("UPDATE RohanUser.dbo.TUser set grade = 0 where user_id = " + num2.ToString(), sqlConnection);
          sqlConnection.Open();
          sqlCommand1.ExecuteNonQuery();
          sqlCommand2.ExecuteNonQuery();
          Notice.SendLocalNotice(@this, "You've been banned...");
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("Firework item check failed!");
          Console.WriteLine("User : {0} has been banned...", (object) name);
          Console.ResetColor();
          sqlConnection.Close();
        }
      }
    }

    public static void RunWorldNotice(string name, IntPtr @this, IntPtr pPacket)
    {
      IntPtr zero = IntPtr.Zero;
      IntPtr num1 = Marshal.ReadIntPtr(@this, 1332);
      long num2 = Marshal.ReadInt64(num1, 6488);
      short length = (short) ((int) Marshal.ReadInt16(pPacket, 8) - 6);
      if (GlobalData.Debug)
        Log.LogString("msgLen : " + length.ToString());
      byte[] numArray = new byte[(int) length];
      Marshal.Copy(pPacket + 21, numArray, 0, (int) length);
      string text = Encoding.ASCII.GetString(numArray);
      long nDiff = 1000000;
      if (nDiff <= num2)
      {
        Notice.WorldNotice(name, text);
        CPlayer.SubMoney(num1, nDiff, (byte) 8, 1);
        CPlayer.BroadcastIncAbility(num1);
      }
      else
        Notice.SendLocalNotice(@this, "World chat of horizon cost 1,000,000 crone to use.");
    }

    [HandleProcessCorruptedStateExceptions]
    public static byte QuickCheck(IntPtr pPacket)
    {
      if (Marshal.ReadInt16(pPacket, 8) < (short) 5)
        return 0;
      if (Marshal.ReadByte(pPacket, 15) == (byte) 46)
      {
        byte[] numArray = new byte[6];
        Marshal.Copy(pPacket + 15, numArray, 0, 6);
        if (GlobalData.Debug)
          Log.LogString("String start : " + Encoding.ASCII.GetString(numArray));
        string str = Encoding.ASCII.GetString(numArray);
        if (str.Contains(".world"))
        {
          if (GlobalData.Debug)
            Log.LogString("Found a world.");
          return 1;
        }
        if (str.Contains(".help"))
        {
          if (GlobalData.Debug)
            Log.LogString("Found a help.");
          return 2;
        }
        if (GlobalData.Debug)
          Log.LogString("Not a world.");
        return 0;
      }
      if (GlobalData.Debug)
        Log.LogString("Not a world.");
      return 0;
    }
  }
}
