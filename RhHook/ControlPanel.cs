// Decompiled with JetBrains decompiler
// Type: RhHook.ControlPanel
// Assembly: RhHook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22279AC8-E869-4113-BBD2-CB246F960EEE
// Assembly location: D:\sanctum_Backup_Full\RhHook.dll

using RhHook.Data;
using RhHook.MapFunctions;
using RhHook.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace RhHook
{
  public class ControlPanel : Form
  {
    public static readonly IntPtr LoadGlobalClassA = (IntPtr) 4740624;
    public static readonly ControlPanel.DLoadGlobalClass LoadGlobalClass = (ControlPanel.DLoadGlobalClass) Marshal.GetDelegateForFunctionPointer(ControlPanel.LoadGlobalClassA, typeof (ControlPanel.DLoadGlobalClass));
    private IContainer components = (IContainer) null;
   
    private RichTextBox richTextBox1;

    int seconds = 0;
    
    private Timer timer1;
    private Timer timer2;
        private GroupBox groupBox1;
        private Label label1;
        private Timer timer3;
        private Timer timer4;
        private Label label3;
        private GroupBox groupBox2;
        private Label label4;
        private Label label2;
        private GroupBox groupBox4;
        private Label label9;
        private Label label7;
        private Label label10;
        private Label label8;
        private Timer timer5;
        private GroupBox groupBox3;
        private TextBox textBox1;
        private Button button1;
        private GroupBox groupBox5;
        private TextBox textBox2;
        private Button bnReloadEventBins;

    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlPanel));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Boss Assault - Automated Event";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Timer:";
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 81);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Normal Boss - Automated Event";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "00:00:00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Time:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(12, 184);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(247, 133);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "World Boss - Automated Event";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Day:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(99, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Monday";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 25);
            this.label9.TabIndex = 4;
            this.label9.Text = "Time:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(99, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 25);
            this.label10.TabIndex = 3;
            this.label10.Text = "00:00:00";
            // 
            // timer5
            // 
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Location = new System.Drawing.Point(277, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(549, 166);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Send Notice";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(15, 34);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(518, 93);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(371, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Send Notice";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox2);
            this.groupBox5.Location = new System.Drawing.Point(277, 184);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(549, 133);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Automated Notice every 1 Hour";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(15, 29);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(518, 90);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "This is Automated Message";
            // 
            // ControlPanel
            // 
            this.ClientSize = new System.Drawing.Size(839, 333);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ControlPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rohan: Geizan";
            this.Load += new System.EventHandler(this.ControlPanel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

    }

    public ControlPanel()
    {
      this.InitializeComponent();
      int num = 0;
      try
      {
        this.timer1.Start();
        this.timer2.Start();
        this.richTextBox1.Text = "Hook started at " + DateTime.Now.ToString();
        this.LoadDebug();
        this.richTextBox1.Text += "\r\nDebug config loaded...";
        num = 1;
        this.LoadPortals();
        this.richTextBox1.Text += "\r\nPortals config loaded...";
        num = 2;
        this.LoadStacks();
        this.richTextBox1.Text += "\r\nStacks config loaded...";
        num = 3;
        BinReader.LoadBin(BinReader.BinType.attendance);
        this.richTextBox1.Text += "\r\nAttendance bin loaded...";
        num = 6;
        this.LoadEvent();
        this.richTextBox1.Text += "\r\nEvent config loaded...";
      }
      catch (Exception ex)
      {
        Log.LogError(ex, nameof (ControlPanel));
        Log.LogString("errorlevel = " + num.ToString());
        this.richTextBox1.Text = this.richTextBox1.Text + "\r\nError " + num.ToString() + this.richTextBox1.Text;
      }
    }

    [HandleProcessCorruptedStateExceptions]
    private void GetSizes()
    {
      Log.LogString("Size of MapFunctions.CBattleManager() : 0x" + Marshal.SizeOf((object) new CBattleManager()).ToString("X"));
      Log.LogString("Size of MapFunctions.SATTACKRESULT() : 0x" + Marshal.SizeOf((object) new SATTACKRESULT()).ToString("X"));
    }

    [HandleProcessCorruptedStateExceptions]
    private void LoadStacks()
    {
      GlobalData.Stacks = new List<int>();
      foreach (string readAllLine in File.ReadAllLines("c:/Epoch/sudo/conf/item.txt"))
      {
        int result = 0;
        int.TryParse(readAllLine, out result);
        GlobalData.Stacks.Add(result);
      }
    }

    [HandleProcessCorruptedStateExceptions]
    private void LoadPortals()
    {
      GlobalData.Portals = new List<GlobalData.Portal>();
      foreach (string readAllLine in File.ReadAllLines("C:/Epoch/sudo/conf/portals.txt"))
      {
        float result1 = 0.0f;
        float result2 = 0.0f;
        float result3 = 0.0f;
        int result4 = 0;
        string[] strArray = readAllLine.Split(' ');
        float.TryParse(strArray[0], out result1);
        float.TryParse(strArray[1], out result2);
        float.TryParse(strArray[2], out result3);
        int.TryParse(strArray[3], out result4);
        GlobalData.Portals.Add(new GlobalData.Portal()
        {
          pos = new _tagEpochVector3()
          {
            x = result1,
            y = result2,
            z = result3
          },
          nType = result4
        });
      }
    }

    [HandleProcessCorruptedStateExceptions]
    private void LoadDebug()
    {
      string[] strArray = File.ReadAllLines("c:/Epoch/sudo/conf/config.txt");
      if (strArray[0] == "Debug:True")
      {
        GlobalData.Debug = true;
      }
      if (strArray[0] == "Debug:False")
      {
        GlobalData.Debug = false;
      }
      if (strArray[2] == "Gen:True")
      {
        GlobalData.Gen = true;
      }
      if (strArray[2] == "Gen:False")
      {
        GlobalData.Gen = false;
      }
      if (strArray[3] == "All:True")
      {
        GlobalData.All = true;
      }
      if (strArray[3] == "All:False")
      {
        GlobalData.All = false;
      }
      if (strArray[4] == "Par:True")
      {
        GlobalData.Par = true;
      }
      if (strArray[4] == "Par:False")
      {
        GlobalData.Par = false;
      }
      if (strArray[5] == "Gui:True")
      {
        GlobalData.Gui = true;
      }
      if (!(strArray[5] == "Gui:False"))
        return;
      GlobalData.Gui = false;
    }

    private void LoadEvent()
    {
      string[] strArray = File.ReadAllLines("c:/Epoch/sudo/conf/config.txt");
      if (strArray[1] == "Event:True")
      {
        GlobalData.Debug = true;
      }
      else
      {
        if (!(strArray[0] == "Event:False"))
          return;
        GlobalData.Debug = false;
      }
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void carbonFiberButton1_Click(object sender, EventArgs e)
    {
      this.LoadPortals();
      this.LoadStacks();
      this.LoadDebug();
      this.LoadEvent();
      this.richTextBox1.Text += "\r\nConguration text has been loaded...";
    }

    private void txtInput_TextChanged(object sender, EventArgs e)
    {
    }

    private void richTextBox1_TextChanged(object sender, EventArgs e)
    {
      if (!this.richTextBox1.Visible)
        return;
      this.richTextBox1.SelectionStart = this.richTextBox1.TextLength;
      this.richTextBox1.ScrollToCaret();
    }

    private void carbonFiberButton4_Click(object sender, EventArgs e)
    {
    }

    private void chkDebug_CheckedChanged(object sender)
    {
       
    }

    private void chkEvent_CheckedChanged(object sender)
    {
     
    }

    private void carbonFiberCheckbox13_CheckedChanged(object sender)
    {
     
    }

    private void chkGen_CheckedChanged(object sender)
    {
      
    }

    private void chkAll_CheckedChanged(object sender)
    {
      
    }

    private void chkGui_CheckedChanged(object sender)
    {
      
    }


    private void timer2_Tick(object sender, EventArgs e)
    {
     
    }


    [UnmanagedFunctionPointer(CallingConvention.Cdecl, SetLastError = true)]
    public delegate int DLoadGlobalClass();

        private void timer3_Tick(object sender, EventArgs e)
        {
            seconds++;
            this.label3.Text = seconds.ToString();

            if (seconds == 10800)
            {
                try
                {
                    string[] array = File.ReadAllLines("config.txt");
                    SqlConnection selectConnection = new SqlConnection(array[6]);
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM RohanEvents.dbo.TBossAssault", selectConnection);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        StringBuilder stringBuilder = new StringBuilder();
                        DataRow dataRow = dataTable.Rows[i];
                        uint idx = Convert.ToUInt32(dataRow["monster_id"].ToString());
                        float x = (float)int.Parse(dataRow["x_pos"].ToString());
                        float y = (float)int.Parse(dataRow["y_pos"].ToString());
                        float z = (float)int.Parse(dataRow["z_pos"].ToString());
                        string noticex = dataRow["notice"].ToString();
                        SummonTools.AutoBoss(idx, x, y, z, noticex);
                        foreach (SummonTools.sumlist2 sum in SummonTools.summonlist2)
                        {
                            SummonTools.SummBossEvent(sum);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                seconds = 0;
            }

            if(seconds == 3600 || seconds == 7200 || seconds == 10800)
            {
                Notice.SendNotice(this.textBox2.Text, 1);
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            this.label2.Text = DateTime.Now.ToString("HH:mm:ss");

            try
            {
                string[] array = File.ReadAllLines("config.txt");
                SqlConnection selectConnection = new SqlConnection(array[6]);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM RohanEvents.dbo.TNormalBoss where respawn_time = '" + this.label2.Text + "'", selectConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    StringBuilder stringBuilder = new StringBuilder();
                    DataRow dataRow = dataTable.Rows[i];
                    uint idx = Convert.ToUInt32(dataRow["monster_id"].ToString());
                    float x = (float)int.Parse(dataRow["x_pos"].ToString());
                    float y = (float)int.Parse(dataRow["y_pos"].ToString());
                    float z = (float)int.Parse(dataRow["z_pos"].ToString());
                    string noticex = dataRow["notice"].ToString();
                    SummonTools.AutoBoss(idx, x, y, z, noticex);
                    foreach (SummonTools.sumlist2 sum in SummonTools.summonlist2)
                    {
                        SummonTools.SummBossEvent(sum);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ControlPanel_Load(object sender, EventArgs e)
        {
            timer3.Start();
            timer4.Start();
            timer5.Start();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            this.label10.Text = DateTime.Now.ToString("HH:mm:ss");
            this.label8.Text = DateTime.Now.DayOfWeek.ToString();

            try
            {
                string[] array = File.ReadAllLines("config.txt");
                SqlConnection selectConnection = new SqlConnection(array[6]);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM RohanEvents.dbo.TWorldBoss where respawn_time = '" + this.label10.Text + "' and day = '" + this.label8.Text + "'", selectConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    StringBuilder stringBuilder = new StringBuilder();
                    DataRow dataRow = dataTable.Rows[i];
                    uint idx = Convert.ToUInt32(dataRow["monster_id"].ToString());
                    float x = (float)int.Parse(dataRow["x_pos"].ToString());
                    float y = (float)int.Parse(dataRow["y_pos"].ToString());
                    float z = (float)int.Parse(dataRow["z_pos"].ToString());
                    string noticex = dataRow["notice"].ToString();
                    SummonTools.AutoBoss(idx, x, y, z, noticex);
                    foreach (SummonTools.sumlist2 sum in SummonTools.summonlist2)
                    {
                        SummonTools.SummBossEvent(sum);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Notice.SendNotice(this.textBox1.Text, 1);
        }
    }
}
