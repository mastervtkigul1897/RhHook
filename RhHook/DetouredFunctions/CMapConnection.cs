

using Detours;
using RhHook.Data;
using RhHook.MapFunctions;
using RhHook.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;

namespace RhHook.DetouredFunctions
{
    internal class CMapConnection
    {
        private static object dblock = new object();
        private static object dblockpvp = new object();
        private static List<CMapConnection.HKCheck> dropitemcheck = new List<CMapConnection.HKCheck>();
        public static readonly CMapConnection.DGenericpacket Comm_OnPacket = new CMapConnection.DGenericpacket(CMapConnection.DetouredComm_OnPacket);
        public static readonly CMapConnection.DGenericpacket OnIndunBuyItem = new CMapConnection.DGenericpacket(CMapConnection.DetouredOnIndunBuyItem);
        public static readonly CMapConnection.DGenericreq OnTeleport = new CMapConnection.DGenericreq(CMapConnection.DetouredOnTeleport);
        public static readonly CMapConnection.DGenericreq OnPlainPacket = new CMapConnection.DGenericreq(CMapConnection.DetouredOnPlainPacket);
        public static readonly CMapConnection.DGenericreq OnUseFirecracker = new CMapConnection.DGenericreq(CMapConnection.DetouredOnUseFirecracker);
        public static readonly RhHook.Util.FunctionInfo[] FunctionInfo = new RhHook.Util.FunctionInfo[3]
        {
      new RhHook.Util.FunctionInfo((IntPtr) 4641552, "CMapConnection::OnIndunBuyItem", (Delegate) CMapConnection.OnIndunBuyItem, (Delegate) CMapConnection._Genericreq, typeof (CMapConnection.DGenericreq)),
      new RhHook.Util.FunctionInfo((IntPtr) 4422240, "CMapConnection::OnTeleport", (Delegate) CMapConnection.OnTeleport, (Delegate) CMapConnection._Genericreq, typeof (CMapConnection.DGenericreq)),
      new RhHook.Util.FunctionInfo((IntPtr) 4499104, "CMapConnection::OnUseFirecracker", (Delegate) CMapConnection.OnUseFirecracker, (Delegate) CMapConnection._Genericreq, typeof (CMapConnection.DGenericreq))
        };
        public static readonly CMapConnection.DGeneric OnMoveItemPKToInven = new CMapConnection.DGeneric(CMapConnection.DetouredOnMoveItemPKToInven);
        public static readonly CMapConnection.DGeneric OnGet_Reward_Result_Cron = new CMapConnection.DGeneric(CMapConnection.DetouredOnGet_Reward_Result_Cron);
        public static readonly CMapConnection.DGeneric OnMoveItemRewardToInven = new CMapConnection.DGeneric(CMapConnection.DetouredOnMoveItemRewardToInven);
        public static readonly CMapConnection.DGeneric OnGet_Reward_Expect_Inven = new CMapConnection.DGeneric(CMapConnection.DetouredOnGet_Reward_Expect_Inven);
        public static readonly CMapConnection.DGeneric OnGet_Reward_Result_Inven = new CMapConnection.DGeneric(CMapConnection.DetouredOnGet_Reward_Result_Inven);
        public static readonly CMapConnection.DGeneric OnPetCheckAutoHealing = new CMapConnection.DGeneric(CMapConnection.DetouredOnPetCheckAutoHealing);
        public static readonly CMapConnection.DGeneric OnChangeGuildRankNew = new CMapConnection.DGeneric(CMapConnection.DetouredOnChangeGuildRankNew);
        public static readonly CMapConnection.DGeneric OnDeportGuildNew = new CMapConnection.DGeneric(CMapConnection.DetouredOnDeportGuildNew);
        public static readonly CMapConnection.DGenericT OnSetDivorce = new CMapConnection.DGenericT(CMapConnection.DetouredOnSetDivorce);
        public static readonly CMapConnection.DGenericT OnLeaveGuildNew = new CMapConnection.DGenericT(CMapConnection.DetouredOnLeaveGuildNew);
        public static readonly CMapConnection.DOnGMAnswer OnGMAnswer = new CMapConnection.DOnGMAnswer(CMapConnection.DetouredOnGMAnswer);
        public static readonly RhHook.Util.FunctionInfo[] FunctionInfonull = new RhHook.Util.FunctionInfo[10]
        {
      new RhHook.Util.FunctionInfo((IntPtr) 4655952, "CMapConnection::OnMoveItemPKToInven", (Delegate) CMapConnection.OnMoveItemPKToInven, (Delegate) CMapConnection._Generic, typeof (CMapConnection.DGeneric)),
      new RhHook.Util.FunctionInfo((IntPtr) 4655840, "CMapConnection::OnGet_Reward_Result_Cron", (Delegate) CMapConnection.OnGet_Reward_Result_Cron, (Delegate) CMapConnection._Generic, typeof (CMapConnection.DGeneric)),
      new RhHook.Util.FunctionInfo((IntPtr) 4655888, "CMapConnection::OnMoveItemRewardToInven", (Delegate) CMapConnection.OnMoveItemRewardToInven, (Delegate) CMapConnection._Generic, typeof (CMapConnection.DGeneric)),
      new RhHook.Util.FunctionInfo((IntPtr) 4655680, "CMapConnection::OnGet_Reward_Expect_Inven", (Delegate) CMapConnection.OnGet_Reward_Expect_Inven, (Delegate) CMapConnection._Generic, typeof (CMapConnection.DGeneric)),
      new RhHook.Util.FunctionInfo((IntPtr) 4655760, "CMapConnection::OnGet_Reward_Result_Inven", (Delegate) CMapConnection.OnGet_Reward_Result_Inven, (Delegate) CMapConnection._Generic, typeof (CMapConnection.DGeneric)),
      new RhHook.Util.FunctionInfo((IntPtr) 4524272, "CMapConnection::OnPetCheckAutoHealing", (Delegate) CMapConnection.OnPetCheckAutoHealing, (Delegate) CMapConnection._Generic, typeof (CMapConnection.DGeneric)),
      new RhHook.Util.FunctionInfo((IntPtr) 4673680, "CMapConnection::OnChangeGuildRankNew", (Delegate) CMapConnection.OnChangeGuildRankNew, (Delegate) CMapConnection._Generic, typeof (CMapConnection.DGeneric)),
      new RhHook.Util.FunctionInfo((IntPtr) 4673152, "CMapConnection::OnDeportGuildNew", (Delegate) CMapConnection.OnDeportGuildNew, (Delegate) CMapConnection._Generic, typeof (CMapConnection.DGeneric)),
      new RhHook.Util.FunctionInfo((IntPtr) 4561504, "CMapConnection::OnSetDivorce", (Delegate) CMapConnection.OnSetDivorce, (Delegate) CMapConnection._GenericT, typeof (CMapConnection.DGenericT)),
      new RhHook.Util.FunctionInfo((IntPtr) 4673424, "CMapConnection::OnLeaveGuildNew", (Delegate) CMapConnection.OnLeaveGuildNew, (Delegate) CMapConnection._GenericT, typeof (CMapConnection.DGenericT))
        };


        [HandleProcessCorruptedStateExceptions]
        private static int DetouredOnShopOpen(IntPtr @this, IntPtr prcreq)
        {
            try
            {
                if (GlobalData.Debug)
                    Log.LogString("Hooked CMapConnection::OnShopOpen");
                IntPtr num1 = Marshal.AllocHGlobal((int)Marshal.ReadInt16(prcreq, 2) + 10);
                Invoke.memmove(num1, prcreq, 101);
                Invoke.memmove(num1 + 101, prcreq + 111, 421);
                int num2 = (int)((Dictionary<string, Hook>)Hooks.Manager)["CMapConnection::OnShopOpen"].CallOriginal(new object[2]
                {
          (object) @this,
          (object) num1
                });
                Marshal.FreeHGlobal(num1);
                return num2;
            }
            catch (Exception ex)
            {
                Log.LogError(ex, "CMapConnection.OnShopOpen");
                return 1;
            }
        }

        [HandleProcessCorruptedStateExceptions]
        private static int Detoured_OnPacket(IntPtr @this, IntPtr prcreq)
        {
            try
            {
                Console.WriteLine("Pet ID : {0}", (object)((_rcmRequestMapPetPickupItem)Marshal.PtrToStructure(prcreq, typeof(_rcmRequestMapPetPickupItem))).dummy.ToString());
                return (int)((Dictionary<string, Hook>)Hooks.Manager)["CMapConnection__OnPacket"].CallOriginal(new object[2]
                {
          (object) @this,
          (object) prcreq
                });
            }
            catch (Exception ex)
            {
                Log.LogError(ex, "CMapConnection.Comm_OnPacket");
                return 1;
            }
        }

        [HandleProcessCorruptedStateExceptions]
        private static int DetouredComm_OnPacket(IntPtr @this, IntPtr pPacket)
        {
            try
            {
                IntPtr this1 = Marshal.ReadIntPtr(@this, 1332);
                ushort num = (ushort)Marshal.ReadInt16(pPacket);
                byte[] numArray = new byte[21];
                Marshal.Copy(RhHook.MapFunctions.CPlayer.GetName(this1), numArray, 0, 21);
                if (GlobalData.Debug)
                    Log.LogString("PType = " + num.ToString());
                if (num == (ushort)7937)
                {
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(Encoding.ASCII.GetString(numArray).Split(new char[1])[0] + " has logged in...");
                    Console.ResetColor();
                }
                return (int)((Dictionary<string, Hook>)Hooks.Manager)["CMapConnection::Comm_OnPacket"].CallOriginal(new object[2]
                {
          (object) @this,
          (object) pPacket
                });
            }
            catch (Exception ex)
            {
                Log.LogError(ex, "CMapConnection.Comm_OnPacket");
                return 1;
            }
        }

        [HandleProcessCorruptedStateExceptions]
        private static void DetouredOnGMNotice(IntPtr @this, IntPtr prcreq, int nSize)
        {
            try
            {
                IntPtr ptr = Marshal.ReadIntPtr(@this, 1332);
                if (!(ptr != IntPtr.Zero))
                    return;
                int num1 = (int)Marshal.ReadByte(ptr, 252);
                if (Marshal.ReadInt16(prcreq, 1) >= (short)2000 || num1 < 11)
                    return;
                IntPtr num2 = RhHook.MapFunctions.CEntityManager.BroadcastAllPlayer((IntPtr)8358496, 7946, prcreq, nSize);
            }
            catch (Exception ex)
            {
                Log.LogError(ex, "CMapConnection.OnGMNotice");
            }
        }

        [HandleProcessCorruptedStateExceptions]
        private static int DetouredSendCharItem(IntPtr @this, int nInventory)
        {
            try
            {
                _rcmResponseMapItemOfCharacter str = new _rcmResponseMapItemOfCharacter();
                IntPtr num1 = Marshal.ReadIntPtr(@this, 1332);
                IntPtr this1 = num1 + 3272;
                if (num1 == IntPtr.Zero)
                    return 6;
                str.nResult = (byte)0;
                str.nInventory = 0;
                str.nItemCount = (byte)0;
                str.item = new RhHook.Data.__tagItem[60];
                for (int index = 0; index < 60; ++index)
                {
                    str.item[index].nSlot = (sbyte)-1;
                    str.item[index].nInventory = (sbyte)-1;
                }
                str.nInventory = nInventory;
                str.nItemCount = (byte)RhHook.MapFunctions.CInventorySlotManager.GetCurCount(this1, nInventory);
                if (str.nItemCount <= (byte)0)
                {
                    byte[] numArray = new byte[6];
                    numArray[0] = str.nResult;
                    Array.Copy((Array)BitConverter.GetBytes(str.nInventory), 0, (Array)numArray, 1, 4);
                    numArray[5] = str.nItemCount;
                    int num2 = CRohanConnection.SendPacketEx(@this, (ushort)53506, numArray, 6U);
                    return 0;
                }
                int num3 = RhHook.MapFunctions.CInventorySlotManager.GetAllowCount(this1, nInventory);
                int index1 = 0;
                for (int nSlot = 0; nSlot < num3; ++nSlot)
                {
                    IntPtr inptr = RhHook.MapFunctions.CInventorySlotManager.GetItem(this1, nInventory, nSlot);
                    IntPtr num4 = MISC.__RTDynamicCast(inptr, 0, (IntPtr)8296312, (IntPtr)8296340, 0);
                    EpochItemBase structure = (EpochItemBase)Marshal.PtrToStructure(num4, typeof(EpochItemBase));
                    if (num4 != IntPtr.Zero && structure.m_ID.m_nID != 0U && structure.m_ID.m_nType > 0U)
                    {
                        IntPtr num5 = Marshal.AllocHGlobal(Marshal.SizeOf((object)new RhHook.Data.__tagItem()));
                        Marshal.StructureToPtr((object)str.item[index1], num5, true);
                        EpochItemBase.GetItemGR(num4, num5);
                        str.item[index1] = (RhHook.Data.__tagItem)Marshal.PtrToStructure(num5, typeof(RhHook.Data.__tagItem));
                        Marshal.FreeHGlobal(num5);
                        ++index1;
                    }
                }
                int num6;
                if (index1 == (int)str.nItemCount)
                {
                    int nSize = 3666 - 61 * (60 - (int)str.nItemCount);
                    int num7 = CRohanConnection.SendPacketEx(@this, (ushort)53506, Misc.getBytes((object)str), (uint)nSize);
                    num6 = 0;
                }
                else
                    num6 = 14;
                return num6;
            }
            catch (Exception ex)
            {
                Log.LogError(ex, "CMapConnection.SendCharItem");
                return 1;
            }
        }

        [HandleProcessCorruptedStateExceptions]
        private static int DetouredOnRegisterRecipe(IntPtr @this, IntPtr prcreq)
        {
            try
            {
                int num = 1;
                if (Guard.isValidCrushingItem(@this, prcreq))
                    num = (int)((Dictionary<string, Hook>)Hooks.Manager)["CMapConnection::OnRegisterRecipe"].CallOriginal(new object[2]
                    {
            (object) @this,
            (object) prcreq
                    });
                return num;
            }
            catch (Exception ex)
            {
                Log.LogError(ex, "CMapConnection.OnRegisterRecipe");
                return 1;
            }
        }


        [HandleProcessCorruptedStateExceptions]
        private static int DetouredOnIndunBuyItem(IntPtr @this, IntPtr prcreq)
        {
            int result;
            try
            {
                _tagRequestMapIndunBuyItem tagRequestMapIndunBuyItem = (_tagRequestMapIndunBuyItem)Marshal.PtrToStructure(prcreq, typeof(_tagRequestMapIndunBuyItem));
                tagRequestMapIndunBuyItem.nStackCnt = 1;
                bool flag = tagRequestMapIndunBuyItem.ItemId.nType == 2820649U || tagRequestMapIndunBuyItem.ItemId.nType == 2820650U || tagRequestMapIndunBuyItem.ItemId.nType == 2818553U;
                if (flag)
                {
                    tagRequestMapIndunBuyItem.nStackCnt = 10;
                }
                Marshal.StructureToPtr(tagRequestMapIndunBuyItem, prcreq, false);
                result = (int)Hooks.Manager["CMapConnection::OnIndunBuyItem"].CallOriginal(new object[]
                {
                @this,
                prcreq
                });
            }
            catch (Exception e)
            {
                Log.LogError(e, "CMapConnection.OnIndunBuyItem");
                result = 1;
            }
            return result;
        }

        [HandleProcessCorruptedStateExceptions]
        private static int DetouredOnCompositionPacket(IntPtr @this, IntPtr pPacket)
        {
            try
            {
                ushort num1 = (ushort)Marshal.ReadInt16(pPacket);
                int num2;
                switch (num1)
                {
                    case 5121:
                    case 5122:
                    case 5155:
                    case 5159:
                    case 5160:
                    case 5162:
                    case 5179:
                    case 5180:
                    case 5181:
                    case 5182:
                    case 5184:
                    case 5197:
                    case 7468:
                        num2 = 1;
                        break;
                    default:
                        num2 = num1 == (ushort)7465 ? 1 : 0;
                        break;
                }
                int num3;
                if (num2 != 0)
                {
                    TagRequest_MAP_COMPOSITION_ITEM_CONSER compositionItemConser = new TagRequest_MAP_COMPOSITION_ITEM_CONSER();
                    num3 = (int)((Dictionary<string, Hook>)Hooks.Manager)["CMapConnection::OnCompositionPacket"].CallOriginal(new object[2]
                    {
            (object) @this,
            (object) pPacket
                    });
                    byte[] numArray1 = new byte[100];
                    Marshal.Copy(pPacket, numArray1, 0, 100);
                    compositionItemConser.Read(numArray1);
                    byte[] numArray2 = new byte[21];
                    IntPtr this1 = Marshal.ReadIntPtr(@this, 1332);
                    Marshal.Copy(RhHook.MapFunctions.CPlayer.GetName(this1), numArray2, 0, 21);
                    Console.WriteLine("{0} is forging...", (object)Encoding.ASCII.GetString(numArray2).Split(new char[1])[0]);
                }
                else
                    num3 = 13;
                return num3;
            }
            catch (Exception ex)
            {
                Log.LogError(ex, "CMapConnection.OnCompositionPacket");
                return 1;
            }
        }

        [HandleProcessCorruptedStateExceptions]
        public static int DetouredOnTeleport(IntPtr @this, IntPtr prcreq)
        {
            int num1 = 1;
            try
            {
                IntPtr num2 = Marshal.ReadIntPtr(@this, 1332);
                if (GlobalData.Debug)
                    Log.LogString("Hooked CMapConnection::OnTeleport");
                _tagRequestMAP_TELEPORT structure1 = (_tagRequestMAP_TELEPORT)Marshal.PtrToStructure(prcreq, typeof(_tagRequestMAP_TELEPORT));
                RhHook.MapFunctions.CPlayer structure2 = (RhHook.MapFunctions.CPlayer)Marshal.PtrToStructure(num2, typeof(RhHook.MapFunctions.CPlayer));
                if (GlobalData.Debug)
                {
                    Log.LogString("m_nScrollBindIndex = " + structure2.m_nScrollBindIndex.ToString() + "; nBind = " + structure1.nBind.ToString() + "; nPortal = " + structure1.nPortal.ToString());
                    Log.LogString("xyz ntype " + structure1.pos.x.ToString() + " " + structure1.pos.y.ToString() + " " + structure1.pos.z.ToString() + " " + structure1.nType.ToString());
                    Log.LogString("m_nIRID = " + structure2.m_nIRID.ToString());
                }
                if (Misc.CheckPortal(new GlobalData.Portal()
                {
                    pos = structure1.pos,
                    nType = (int)structure1.nType
                }) & structure2.m_nIRID <= 0)
                {
                    if (GlobalData.Debug)
                        Log.LogString("Found Check Portal");
                    num1 = 0;
                    Marshal.WriteInt32(num2, 4404, 0);
                    CCellManager.SetPosEntity((IntPtr)11752696, num2, prcreq, 0, 0);
                    RhHook.MapFunctions.CBiotic.BroadcastTeleport(num2, prcreq);
                }
                else
                    num1 = (int)((Dictionary<string, Hook>)Hooks.Manager)["CMapConnection::OnTeleport"].CallOriginal(new object[2]
                    {
            (object) @this,
            (object) prcreq
                    });
                return num1;
            }
            catch (Exception ex)
            {
                Log.LogError(ex, "CMapConnection.OnTeleports");
                return num1;
            }
        }

        [HandleProcessCorruptedStateExceptions]
        private static int DetouredOnPlainPacket(IntPtr @this, IntPtr prcreq)
        {
            try
            {
                Log.LogString("nType = " + ((ushort)Marshal.ReadInt16(prcreq)).ToString());
                return (int)((Dictionary<string, Hook>)Hooks.Manager)["CMapConnection::OnPlainPacket"].CallOriginal(new object[2]
                {
          (object) @this,
          (object) prcreq
                });
            }
            catch (Exception ex)
            {
                Log.LogError(ex, "CMapConnection.OnPlainPacket");
                return 1;
            }
        }

        [HandleProcessCorruptedStateExceptions]
        private static int DetouredOnBankPacket(IntPtr @this, IntPtr prcreq)
        {
            try
            {
                if (Marshal.ReadInt16(prcreq) == (short)7467)
                    Marshal.WriteInt16(prcreq, (short)7466);
                return (int)((Dictionary<string, Hook>)Hooks.Manager)["CMapConnection::OnBankPacket"].CallOriginal(new object[2]
                {
          (object) @this,
          (object) prcreq
                });
            }
            catch (Exception ex)
            {
                Log.LogError(ex, "CMapConnection.OnBankPacket");
                return 0;
            }
        }

       

        [HandleProcessCorruptedStateExceptions]
        private static int DetouredOnMoveItem(IntPtr @this, IntPtr prcreq)
        {
            try
            {
                if (((_rcmRequestMapMoveItem)Marshal.PtrToStructure(prcreq, typeof(_rcmRequestMapMoveItem))).nToInventory == (byte)5)
                    return 33;
                return (int)((Dictionary<string, Hook>)Hooks.Manager)["CMapConnection::OnMoveItem"].CallOriginal(new object[2]
                {
          (object) @this,
          (object) prcreq
                });
            }
            catch (Exception ex)
            {
                Log.LogError(ex, "CMapConnection::OnMoveItem");
                return 0;
            }
        }

        [HandleProcessCorruptedStateExceptions]
        private static void SpawnNPC(uint id, IntPtr Player)
        {
            IntPtr entityBiotic = SummonTools.CreateEntityBiotic(id, Player);
            RhHook.MapFunctions.CBiotic.RemoveBiotic(entityBiotic, 300000U);
        }

        [HandleProcessCorruptedStateExceptions]
        private static int DetouredOnUseFirecracker(IntPtr @this, IntPtr prcreq)
        {
            try
            {
                _tagRequestMAP_USEFIRECRACKER structure = (_tagRequestMAP_USEFIRECRACKER)Marshal.PtrToStructure(prcreq, typeof(_tagRequestMAP_USEFIRECRACKER));
                IntPtr this1 = Marshal.ReadIntPtr(@this, 1332);
                SqlConnection selectConnection = new SqlConnection(File.ReadAllLines("config.txt")[6]);
                byte[] numArray = new byte[21];
                Marshal.Copy(RhHook.MapFunctions.CPlayer.GetName(this1), numArray, 0, 21);
                string name = Encoding.ASCII.GetString(numArray).Split(new char[1])[0];
                IntPtr zero = IntPtr.Zero;
                IntPtr Player = Marshal.ReadIntPtr(@this, 1332);
                if (Player == IntPtr.Zero)
                    return 0;
                switch (((_tagRequestMAP_USEFIRECRACKER)Marshal.PtrToStructure(prcreq, typeof(_tagRequestMAP_USEFIRECRACKER))).itemID.nType)
                {
                    case 2884128:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x0132001a2300221900", "2632445", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884129:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x053200172300221900", "2632445", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884130:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x023200170a000d0700", "2632445", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884131:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x063200170a000d0700", "2632445", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884132:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x0132001a2300221900", "2632447", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884133:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x0332001a2300221900", "2632447", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884134:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x043200172300221900", "2632447", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884135:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x013200172300221900", "2632447", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884136:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x0132001a2300221900", "2632449", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884137:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x053200172300221900", "2632449", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884138:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x0132001a2300071400", "2632449", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884139:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x033200192300221900", "2632451", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884140:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x043200172300221900", "2632451", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884141:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x053200172300221900", "2632451", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884142:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x0132001a2300221900", "2632450", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884143:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x053200172300221900", "2632450", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884144:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x0132001a2300071400", "2632450", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884145:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x063200170a000d0700", "2632450", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884146:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x0232001b2300221900", "2632443", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884147:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x053200172300221900", "2632443", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884148:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x0532001b23000d0700", "2632443", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884149:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x0232001b2300071900", "2632443", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884150:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x0232001b2300221900", "2632444", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884151:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x053200172300221900", "2632444", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884152:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x0232001b23000d0700", "2632444", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884153:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x0232001b2300071400", "2632444", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884154:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x0132001a2300221900", "2632452", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884155:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x053200172300221900", "2632452", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884156:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x033200192300221900", "2632452", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884157:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x0132001a2300221900", "2632454", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884158:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x053200172300221900", "2632454", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884159:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x0132001a2300071400", "2632454", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884160:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x0132001a2300221900", "2632455", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884161:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x053200172300221900", "2632455", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884162:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x0132001a2300071400", "2632455", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884164:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x0132001a2800221e000e02000f0200", "2621482", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884165:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x053200172800221e000e02000f0200", "2621482", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884166:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x026400170a000d07000e02000f0200", "2621482", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884167:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x066400170a000d07000e02000f0200", "2621482", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884168:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x0132001a2800221e000e02000f0200", "2621782", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884169:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x0332001a2800221e000e02000f0200", "2621782", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884170:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x043200172800221e000e02000f0200", "2621782", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884171:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x053200172800221e000e02000f0200", "2621782", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884172:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x0132001a2800221e000e02000f0200", "2621583", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884173:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x053200172800221e000e02000f0200", "2621583", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884174:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x0132001a28000719000e02000f0200", "2621583", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884175:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x033200192800221e000e02000f0200", "2622182", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884176:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x043200192800221e000e02000f0200", "2622182", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884177:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x0132001a2800221e000e02000f0200", "2622482", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884178:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x053200172800221e000e02000f0200", "2622482", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884179:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x0132001a28000719000e02000f0200", "2622482", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884180:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x066400170a000d07000e02000f0200", "2622482", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884181:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x0232001b2800221e000e02000f0200", "2622283", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884182:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x053200172800221e000e02000f0200", "2622283", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884183:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x0232001b28000d07000e02000f0200", "2622283", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884203:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x0232001b28000719000e02000f0200", "2622283", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884204:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x0232001b2800221e000e02000f0200", "2622381", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884220:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x053200172800221e000e02000f0200", "2622381", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884229:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x0232001b28000d07000e02000f0200", "2622381", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884230:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x0232001a28000719000e02000f0200", "2622381", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884231:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x0132001a2800221e000e02000f0200", "2622704", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884232:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x053200172800221e000e02000f0200", "2622704", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884233:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x033200192800221e000e02000f0200", "2622704", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884242:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x0132001a2800221e000e02000f0200", "2621690", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884244:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x053200172800221e000e02000f0200", "2621690", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884245:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x0132001a28000719000e02000f0200", "2621690", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884246:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x0132001a2800221e000e02000f0200", "2621988", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884247:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x053200172800221e000e02000f0200", "2621988", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884248:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x0132001a28000719000e02000f0200", "2621988", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884253:
                        SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter("Select * from RohanGame.dbo.titem where id = '" + structure.itemID.nId.ToString() + "'", selectConnection);
                        DataTable dataTable1 = new DataTable();
                        sqlDataAdapter1.Fill(dataTable1);
                        for (int index = 0; index < dataTable1.Rows.Count; ++index)
                        {
                            StringBuilder stringBuilder = new StringBuilder();
                            if ((long)int.Parse(dataTable1.Rows[index]["type"].ToString()) == (long)structure.itemID.nType)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Player : {0} obtain NPC item at {1}", (object)name, (object)DateTime.Now);
                                Console.ResetColor();
                                CMapConnection.SpawnNPC(372683U, Player);
                            }
                        }
                        break;
                    case 2884254:
                        SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter("Select * from RohanGame.dbo.titem where id = '" + structure.itemID.nId.ToString() + "'", selectConnection);
                        DataTable dataTable2 = new DataTable();
                        sqlDataAdapter2.Fill(dataTable2);
                        for (int index = 0; index < dataTable2.Rows.Count; ++index)
                        {
                            StringBuilder stringBuilder = new StringBuilder();
                            if ((long)int.Parse(dataTable2.Rows[index]["type"].ToString()) == (long)structure.itemID.nType)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Player : {0} obtain NPC item at {1}", (object)name, (object)DateTime.Now);
                                Console.ResetColor();
                                CMapConnection.SpawnNPC(328036U, Player);
                            }
                        }
                        break;
                    case 2884255:
                        SqlDataAdapter sqlDataAdapter3 = new SqlDataAdapter("Select * from RohanGame.dbo.titem where id = '" + structure.itemID.nId.ToString() + "'", selectConnection);
                        DataTable dataTable3 = new DataTable();
                        sqlDataAdapter3.Fill(dataTable3);
                        for (int index = 0; index < dataTable3.Rows.Count; ++index)
                        {
                            StringBuilder stringBuilder = new StringBuilder();
                            if ((long)int.Parse(dataTable3.Rows[index]["type"].ToString()) == (long)structure.itemID.nType)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Player : {0} obtain NPC item at {1}", (object)name, (object)DateTime.Now);
                                Console.ResetColor();
                                CMapConnection.SpawnNPC(357700U, Player);
                            }
                        }
                        break;
                    case 2884257:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x046400171400183200221e000e02000f0200", "2622182", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884288:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x013c001a3700222800", "2621473", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884289:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x053c00173700222800", "2621473", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884290:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x026400220f000d0a00", "2621473", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884291:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x066400220f000d0a00", "2621473", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884292:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x253700220f00066400", "2621473", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884293:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x013c001a3700071800", "2621473", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884309:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x033c001a3700222800", "2621474", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884310:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x013c001a3700222800", "2621474", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884316:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x053c00173700222800", "2621474", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884317:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x013c001a3700222800", "2621476", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884318:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x053c00173700222800", "2621476", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884319:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x013c001a3700071800", "2621476", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884320:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x033c00193700222800184f00", "2621477", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884321:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x046400191e00222800", "2621477", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884322:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x053c00173700222800", "2621477", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884323:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x013c001a3700222800", "2621478", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884324:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x053c00173700222800", "2621478", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884325:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x066400220f000d0a00", "2621478", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884326:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x253700220f00066400", "2621478", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884327:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x013c001a3700071800", "2621478", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884328:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x023c001b3700222800236400", "2621489", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884329:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x023c001b1e000d0a00236400", "2621489", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884330:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x053c00173700222800236400", "2621489", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884331:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x023c001b3700071800", "2621489", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884332:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x0264001b1e00253700", "2621489", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884333:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x023c001b3700222800236400", "2621498", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884334:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x023c001b1e000d0a00236400", "2621498", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884335:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x053c00173700222800236400", "2621498", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884336:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x023c001b3700071800", "2621498", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884337:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x0264001b1e00253700", "2621498", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884338:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x053c00173700222800", "2621499", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884339:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x013c001a3700222800", "2621499", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884340:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x033c00193700222800", "2621499", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884341:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x013c001a3700222800", "2621500", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884342:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x053c00173700222800", "2621500", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884343:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x013c001a3700071800", "2621500", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884344:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x0164001a1e000d0a00220f00", "2621500", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884345:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x013c001a3700222800", "2621501", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884346:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x053c00173700222800", "2621501", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884347:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x013c001a3700071800", "2621501", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884348:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x0164001a1e000d0a00220f00", "2621501", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                    case 2884349:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player : {0} obtain fireworks item at {1}", (object)name, (object)DateTime.Now);
                        Console.ResetColor();
                        Notice.insitem(name, "0x0264001a1e000d0a00220f00", "2621501", @this, structure.itemID.nId, structure.itemID.nType.ToString());
                        break;
                }
                return (int)((Dictionary<string, Hook>)Hooks.Manager)["CMapConnection::OnUseFirecracker"].CallOriginal(new object[2]
                {
          (object) @this,
          (object) prcreq
                });
            }
            catch (Exception ex)
            {
                Log.LogError(ex, "CMapConnection.OnUseFirecracker");
                return 1;
            }
        }

        [HandleProcessCorruptedStateExceptions]
        private static int DetouredOnSellItemToNpc1(IntPtr @this, IntPtr prcreq)
        {
            try
            {
                _tagRequestMAP_SELLITEMTONPC_1 structure = (_tagRequestMAP_SELLITEMTONPC_1)Marshal.PtrToStructure(prcreq, typeof(_tagRequestMAP_SELLITEMTONPC_1));
                IntPtr this1 = Marshal.ReadIntPtr(@this, 1332);
                byte[] numArray = new byte[21];
                Marshal.Copy(RhHook.MapFunctions.CPlayer.GetName(this1), numArray, 0, 21);
                SqlConnection sqlConnection = new SqlConnection(File.ReadAllLines("config.txt")[6]);
                SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter("Select * from RohanGame.dbo.TCharacter where name = '" + Encoding.ASCII.GetString(numArray).Split(new char[1])[0] + "'", sqlConnection);
                DataTable dataTable1 = new DataTable();
                sqlDataAdapter1.Fill(dataTable1);
                for (int index1 = 0; index1 < dataTable1.Rows.Count; ++index1)
                {
                    StringBuilder stringBuilder1 = new StringBuilder();
                    DataRow row1 = dataTable1.Rows[index1];
                    int num1 = int.Parse(row1["id"].ToString());
                    int num2 = int.Parse(row1["user_id"].ToString());
                    if (num1 > 0)
                    {
                        SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter("Select * from RohanGame.dbo.TItem where char_id = " + num1.ToString() + " and inventory = " + structure.nInventory.ToString() + " and slot = " + structure.nSlot.ToString(), sqlConnection);
                        DataTable dataTable2 = new DataTable();
                        sqlDataAdapter2.Fill(dataTable2);
                        for (int index2 = 0; index2 < dataTable2.Rows.Count; ++index2)
                        {
                            StringBuilder stringBuilder2 = new StringBuilder();
                            DataRow row2 = dataTable2.Rows[index2];
                            int num3 = int.Parse(row2["type"].ToString());
                            int num4 = int.Parse(row2["stack"].ToString());
                            int num5 = int.Parse(row2["equip_level"].ToString());
                            if ((long)structure.itemID.nType == (long)num3)
                            {
                                if (num3 == 111 && num4 == 10 && num5 == 100)
                                {
                                    int npc1 = (int)((Dictionary<string, Hook>)Hooks.Manager)["CMapConnection::OnSellItemToNpc1"].CallOriginal(new object[2]
                                    {
                    (object) @this,
                    (object) prcreq
                                    });
                                    if (npc1 > 0)
                                    {
                                        Notice.SendNotice(Encoding.ASCII.GetString(numArray).Split(new char[1])[0] + " is cheating.", (byte)1);
                                        return 0;
                                    }
                                    SqlCommand sqlCommand = new SqlCommand("INSERT INTO dbo.TEventItem(type, attr, stack, rank, equip_level, char_id) VALUES(2621482, 0x0132001a2800221e000e02000f0200, 1, 0, 1, " + num1.ToString() + ")", sqlConnection);
                                    sqlConnection.Open();
                                    sqlCommand.ExecuteNonQuery();
                                    Notice.SendLocalNotice(@this, "You have successfully exchange your [ZenonX's 180 PDEF / MDEF (ARMOR)]. Check your event inventory now!");
                                    sqlConnection.Close();
                                    return npc1;
                                }
                            }
                            else
                            {
                                SqlCommand sqlCommand1 = new SqlCommand("UPDATE RohanUser.dbo.TUser set grade = 0 where user_id = " + num2.ToString(), sqlConnection);
                                SqlCommand sqlCommand2 = new SqlCommand("INSERT INTO RohanUser.dbo.TDisconnect (user_id, server_id, char_id) VALUES (" + num2.ToString() + ", 31, 0)", sqlConnection);
                                sqlConnection.Open();
                                sqlCommand1.ExecuteNonQuery();
                                sqlCommand2.ExecuteNonQuery();
                                Notice.SendLocalNotice(@this, "You have been banned!");
                                sqlConnection.Close();
                                return 0;
                            }
                        }
                    }
                }
                return (int)((Dictionary<string, Hook>)Hooks.Manager)["CMapConnection::OnSellItemToNpc1"].CallOriginal(new object[2]
                {
          (object) @this,
          (object) prcreq
                });
            }
            catch (Exception ex)
            {
                Log.LogError(ex, "CMapConnection.OnSellItemToNpc1");
                return 1;
            }
        }


        public static CMapConnection.DSendCharItem _SendCharItem { get; set; }

        public static CMapConnection.DOnOpen _OnOpen { get; set; }

        public static CMapConnection.DOnClose _OnClose { get; set; }

        public static CMapConnection.DGenericreq _Genericreq { get; set; }

        public static CMapConnection.DGenericpacket _Genericpacket { get; set; }

        public static CMapConnection.DComm_OnOneToOneMsg _Comm_OnOneToOneMsg { get; set; }

        public static CMapConnection.DOnGMNotice _OnGMNotice { get; set; }

        [HandleProcessCorruptedStateExceptions]
        private static int DetouredOnMoveItemPKToInven(IntPtr @this, IntPtr _prcreq)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[OnMoveItemPKToInven] attack found, packets are now cleaned!");
                Console.ResetColor();
                IntPtr zero = IntPtr.Zero;
                if (Marshal.ReadIntPtr(@this, 1332) == IntPtr.Zero)
                    return 0;
                return (int)((Dictionary<string, Hook>)Hooks.Manager)["CMapConnection::OnMoveItemPKToInven"].CallOriginal(new object[2]
                {
          (object) @this,
          (object) _prcreq
                });
            }
            catch (Exception ex)
            {
                Log.LogError(ex, "CMapConnection.OnMoveItemPKToInven");
                return 0;
            }
        }

        [HandleProcessCorruptedStateExceptions]
        private static int DetouredOnGet_Reward_Result_Cron(IntPtr @this, IntPtr _prcreq)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[OnGet_Reward_Result_Cron] attack found, packets are now cleaned!");
                Console.ResetColor();
                IntPtr zero = IntPtr.Zero;
                if (Marshal.ReadIntPtr(@this, 1332) == IntPtr.Zero)
                    return 0;
                return (int)((Dictionary<string, Hook>)Hooks.Manager)["CMapConnection::OnGet_Reward_Result_Cron"].CallOriginal(new object[2]
                {
          (object) @this,
          (object) _prcreq
                });
            }
            catch (Exception ex)
            {
                Log.LogError(ex, "CMapConnection.OnGet_Reward_Result_Cron");
                return 0;
            }
        }

        [HandleProcessCorruptedStateExceptions]
        private static int DetouredOnMoveItemRewardToInven(IntPtr @this, IntPtr _prcreq)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[OnMoveItemRewardToInven] attack found, packets are now cleaned!");
                Console.ResetColor();
                IntPtr zero = IntPtr.Zero;
                if (Marshal.ReadIntPtr(@this, 1332) == IntPtr.Zero)
                    return 0;
                return (int)((Dictionary<string, Hook>)Hooks.Manager)["CMapConnection::OnMoveItemRewardToInven"].CallOriginal(new object[2]
                {
          (object) @this,
          (object) _prcreq
                });
            }
            catch (Exception ex)
            {
                Log.LogError(ex, "CMapConnection.OnMoveItemRewardToInven");
                return 0;
            }
        }

        [HandleProcessCorruptedStateExceptions]
        private static int DetouredOnGet_Reward_Expect_Inven(IntPtr @this, IntPtr _prcreq)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[OnGet_Reward_Expect_Inven] attack found, packets are now cleaned!");
                Console.ResetColor();
                IntPtr zero = IntPtr.Zero;
                if (Marshal.ReadIntPtr(@this, 1332) == IntPtr.Zero)
                    return 0;
                return (int)((Dictionary<string, Hook>)Hooks.Manager)["CMapConnection::OnGet_Reward_Expect_Inven"].CallOriginal(new object[2]
                {
          (object) @this,
          (object) _prcreq
                });
            }
            catch (Exception ex)
            {
                Log.LogError(ex, "CMapConnection.OnGet_Reward_Expect_Inven");
                return 0;
            }
        }

        [HandleProcessCorruptedStateExceptions]
        private static int DetouredOnGet_Reward_Result_Inven(IntPtr @this, IntPtr _prcreq)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[OnGet_Reward_Result_Inven] attack found, packets are now cleaned!");
                Console.ResetColor();
                IntPtr zero = IntPtr.Zero;
                if (Marshal.ReadIntPtr(@this, 1332) == IntPtr.Zero)
                    return 0;
                return (int)((Dictionary<string, Hook>)Hooks.Manager)["CMapConnection::OnGet_Reward_Result_Inven"].CallOriginal(new object[2]
                {
          (object) @this,
          (object) _prcreq
                });
            }
            catch (Exception ex)
            {
                Log.LogError(ex, "CMapConnection.OnGet_Reward_Result_Inven");
                return 0;
            }
        }

        [HandleProcessCorruptedStateExceptions]
        private static int DetouredOnPetCheckAutoHealing(IntPtr @this, IntPtr _prcreq)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[OnPetCheckAutoHealing] attack found, packets are now cleaned!");
                Console.ResetColor();
                IntPtr zero = IntPtr.Zero;
                if (Marshal.ReadIntPtr(@this, 1332) == IntPtr.Zero)
                    return 0;
                return (int)((Dictionary<string, Hook>)Hooks.Manager)["CMapConnection::OnPetCheckAutoHealing"].CallOriginal(new object[2]
                {
          (object) @this,
          (object) _prcreq
                });
            }
            catch (Exception ex)
            {
                Log.LogError(ex, "CMapConnection.OnPetCheckAutoHealing");
                return 0;
            }
        }

        [HandleProcessCorruptedStateExceptions]
        private static int DetouredIndunLoadStage(IntPtr @this, IntPtr _prcreq)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[IndunLoadStage] attack found, can't fix the packet!");
                Console.ResetColor();
                IntPtr zero = IntPtr.Zero;
                if (Marshal.ReadIntPtr(@this, 1332) == IntPtr.Zero)
                    return 0;
                return (int)((Dictionary<string, Hook>)Hooks.Manager)["CMapConnection::IndunLoadStage"].CallOriginal(new object[2]
                {
          (object) @this,
          (object) _prcreq
                });
            }
            catch (Exception ex)
            {
                Log.LogError(ex, "CMapConnection.IndunLoadStage");
                return 0;
            }
        }

        [HandleProcessCorruptedStateExceptions]
        private static int DetouredOnChangeGuildRankNew(IntPtr @this, IntPtr _prcreq)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[OnChangeGuildRankNew] attack found, packets are now cleaned!");
                Console.ResetColor();
                IntPtr zero = IntPtr.Zero;
                if (Marshal.ReadIntPtr(@this, 1332) == IntPtr.Zero)
                    return 0;
                return (int)((Dictionary<string, Hook>)Hooks.Manager)["CMapConnection::OnChangeGuildRankNew"].CallOriginal(new object[2]
                {
          (object) @this,
          (object) _prcreq
                });
            }
            catch (Exception ex)
            {
                Log.LogError(ex, "CMapConnection.OnChangeGuildRankNew");
                return 0;
            }
        }

        [HandleProcessCorruptedStateExceptions]
        private static int DetouredOnDeportGuildNew(IntPtr @this, IntPtr _prcreq)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[OnDeportGuildNew] attack found, packets are now cleaned!");
                Console.ResetColor();
                IntPtr zero = IntPtr.Zero;
                if (Marshal.ReadIntPtr(@this, 1332) == IntPtr.Zero)
                    return 0;
                return (int)((Dictionary<string, Hook>)Hooks.Manager)["CMapConnection::OnDeportGuildNew"].CallOriginal(new object[2]
                {
          (object) @this,
          (object) _prcreq
                });
            }
            catch (Exception ex)
            {
                Log.LogError(ex, "CMapConnection.OnDeportGuildNew");
                return 0;
            }
        }

        [HandleProcessCorruptedStateExceptions]
        private static int DetouredOnSetDivorce(IntPtr @this)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[OnSetDivorce] attack found, packets are now cleaned!");
                Console.ResetColor();
                IntPtr zero = IntPtr.Zero;
                if (Marshal.ReadIntPtr(@this, 1332) == IntPtr.Zero)
                    return 0;
                return (int)((Dictionary<string, Hook>)Hooks.Manager)["CMapConnection::OnSetDivorce"].CallOriginal(new object[1]
                {
          (object) @this
                });
            }
            catch (Exception ex)
            {
                Log.LogError(ex, "CMapConnection.OnSetDivorce");
                return 0;
            }
        }

        [HandleProcessCorruptedStateExceptions]
        private static int DetouredOnLeaveGuildNew(IntPtr @this)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[OnLeaveGuildNew] attack found, packets are now cleaned!");
                Console.ResetColor();
                IntPtr zero = IntPtr.Zero;
                if (Marshal.ReadIntPtr(@this, 1332) == IntPtr.Zero)
                    return 0;
                return (int)((Dictionary<string, Hook>)Hooks.Manager)["CMapConnection::OnLeaveGuildNew"].CallOriginal(new object[1]
                {
          (object) @this
                });
            }
            catch (Exception ex)
            {
                Log.LogError(ex, "CMapConnection.OnLeaveGuildNew");
                return 0;
            }
        }

        [HandleProcessCorruptedStateExceptions]
        private static int DetouredOnGMAnswer(IntPtr @this, IntPtr _prcreq, int nSize)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[OnGMAnswer] attack found, packets are now cleaned!");
                Console.ResetColor();
                if (nSize >= 2000)
                    return 0;
                return (int)((Dictionary<string, Hook>)Hooks.Manager)["CMapConnection::OnGMAnswer"].CallOriginal(new object[3]
                {
          (object) @this,
          (object) _prcreq,
          (object) nSize
                });
            }
            catch (Exception ex)
            {
                Log.LogError(ex, "CMapConnection.OnGMAnswer");
                return 0;
            }
        }

        public static CMapConnection.DGeneric _Generic { get; set; }

        public static CMapConnection.DOnGMAnswer _OnGMAnswer { get; set; }

        public static CMapConnection.DGenericT _GenericT { get; set; }

        private struct HKCheck
        {
            public IntPtr player { get; set; }

            public int count { get; set; }

            public DateTime Last { get; set; }
        }

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate int DSendCharItem(IntPtr @this, int nInventory);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate void DOnGMNotice(IntPtr @this, IntPtr prcreq, int nSize);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate int DOnOpen(IntPtr @this);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate void DOnClose(IntPtr @this);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate int DGenericreq(IntPtr @this, IntPtr prcreq);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate int DGenericpacket(IntPtr @this, IntPtr pPacket);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate int DComm_OnOneToOneMsg(IntPtr @this, IntPtr prcreq);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate int DGeneric(IntPtr @this, IntPtr _prcreq);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate int DGenericT(IntPtr @this);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate int DOnGMAnswer(IntPtr @this, IntPtr _prcreq, int nSize);
    }
}
