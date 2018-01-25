using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ZaiPangWin
{
    public partial class Form1 : Form
    {
        private string adbFilePath = null;
        private List<string> machines = null;
        private Timer timer = null;

        public Form1()
        {
            InitializeComponent();

            this.SetNormalSetting();
            this.Text = "在旁抢菜";

            this.txt_adb.Text = AppConfigHelper.Get("adbDir");
            this.txt_adb.TextChanged += Txt_adb_TextChanged;

            pointX.Text = AppConfigHelper.Get("pointx");
            pointY.Text = AppConfigHelper.Get("pointy");

            CheckConfig();

            timer = new Timer();
            timer.Tick += Timer_Tick; ;
        }

        private void Txt_adb_TextChanged(object sender, EventArgs e)
        {
            if (CheckConfig())
            {
                AppConfigHelper.Save("adbDir", txt_adb.Text);
            }
        }

        private bool CheckConfig()
        {
            string adbFile = Path.Combine(txt_adb.Text.Trim(), "adb.exe");
            if (File.Exists(adbFile))
            {
                lbl_CheckMsg.Text = "配置正确";
                lbl_CheckMsg.ForeColor = Color.Blue;
                adbFilePath = adbFile;
                return true;
            }
            else
            {
                lbl_CheckMsg.Text = "配置错误";
                lbl_CheckMsg.ForeColor = Color.Red;
                return false;
            }

        }

        private void btn_loadMachine_Click(object sender, EventArgs e)
        {
            try
            {
                string result = CmdHelper.ExecutCmd(adbFilePath, "devices");
                List<string> list = RegexHelper.GetIP(result);
                if (list.Count == 0)
                {
                    ShowMsg("没有可以连接的手机设备，请打开模拟器");
                }
                else
                {
                    ShowMsg("模拟器获取成功");
                    ConnectMachine(list);
                }
                machines = list;
                listbox_machine.DataSource = list;
            }
            catch (Exception ex)
            {
                ShowMsg("错误：" + ex.Message);
            }
        }

        private void ConnectMachine(List<string> ips)
        {
            ShowMsg("模拟器连接中......");
            foreach (var item in ips)
            {
                string result = CmdHelper.ExecutCmd(adbFilePath, "connect " + item);
                if (result.Contains("already connected to"))
                {
                    ShowMsg($"模拟器 {item} 连接成功  √√√");
                }
            }
        }

        private void ShowMsg(string msg)
        {
            rtbMsg.Invoke(new Action<string>((m) =>
            {
                if (this.rtbMsg.Text.Length > 2000)
                    this.rtbMsg.Text = "";

                this.rtbMsg.Text = DateTime.Now.ToString("HH:mm:ss") + " " + msg + "\r\n" + rtbMsg.Text;
            }), "");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (machines == null || machines.Count == 0)
            {
                ShowMsg("没有可用的模拟器");
                return;
            }

            AppConfigHelper.Save("pointx", pointX.Text);
            AppConfigHelper.Save("pointy", pointY.Text);

            timer.Interval = (int)(Convert.ToDouble(txtInterval.Text) * 1000);
            if (timer.Interval == 0)
                timer.Interval = 1 * 1000;

            if(btnStart.Text == "停止")
            {
                timer.Stop();
                this.btnStart.Text = "开始";
            }
            else
            {
                timer.Start();
                this.btnStart.Text = "停止";
            }
            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            new System.Threading.Thread(Tap).Start();
        }

        private void Tap()
        {
            string cmd = $"shell input tap {pointX.Text} {pointY.Text}";
            ShowMsg(cmd);
            CmdHelper.ExecutCmd(adbFilePath, cmd);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}
