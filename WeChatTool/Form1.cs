using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace WeChatTool
{
    public partial class WeChatTool : Form
    {
      
        public WeChatTool()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            for (int i = 2; i < 11; i++)
            {
                comboBox1.Items.Add(i.ToString());
            }
            comboBox1.Text = "2";
        }    
        private void button1_Click(object sender, EventArgs e)
        {
            VXTool.OpenWeChat();
            return;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            CreateShortCut("微信多开", Environment.CurrentDirectory + "/WeChatTool.exe", Environment.SpecialFolder.Desktop);
        }
        public static void CreateShortCut(string name, string exePath, Environment.SpecialFolder path)
        {
            string DesktopPath = System.Environment.GetFolderPath(path);//得到桌面文件夹
            CreateShortCut(name, exePath, DesktopPath);
        }
        private static void CreateShortCut(string name, string exePath, string targerPath)
        {
            IWshRuntimeLibrary.WshShell shell = new IWshRuntimeLibrary.WshShell();
            IWshRuntimeLibrary.IWshShortcut shortcut = (IWshRuntimeLibrary.IWshShortcut)shell.CreateShortcut(targerPath + "\\" + name + ".lnk");
            shortcut.TargetPath = exePath;
            shortcut.Arguments = "";// 参数
            shortcut.Description = "微信多开程序";
            shortcut.WorkingDirectory = Environment.CurrentDirectory;//程序所在文件夹，在快捷方式图标点击右键可以看到此属性
            shortcut.IconLocation = Environment.CurrentDirectory + "/WeChatTool.exe"; //图标
            //shortcut.Hotkey = "CTRL+SHIFT+Z";//热键
            shortcut.WindowStyle = 1;
            shortcut.Save();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            VXTool.OpenWeChat(uint.Parse(comboBox1.Text));
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://mp.weixin.qq.com/s/DWN_5slsq-CQT8jAaSOHRw");
        }

        //private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    Form3 form3 = new Form3();
        //    form3.Show();
        //}

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //this.Visible = true;
            //this.ShowInTaskbar = true;
            //this.WindowState = FormWindowState.Normal;//在Visible激活后调用才有效
            VXTool.OpenWeChat();
        }

        private void WeChatTool_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.vx.Visible = true; //显示托盘图标
            this.ShowInTaskbar = false;//图标不显示在任务栏
            this.Visible = false;
            VXTool.OpenWeChat();
        }

        private void WeChatTool_Deactivate(object sender, EventArgs e)
        {
            //当窗体为最小化状态时
            if (this.WindowState == FormWindowState.Minimized)
            {
                //this.vx.Visible = true; //显示托盘图标
                this.Visible = false;//隐藏窗体
                this.ShowInTaskbar = false;//图标不显示在任务栏
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void 显示主页面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            this.ShowInTaskbar = true;
            this.WindowState = FormWindowState.Normal;//在Visible激活后调用才有效
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 开启一个微信ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VXTool.OpenWeChat();
        }

        private void 关于本软件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("晨光出品,必属精品");
        }

        private void 隐藏主页面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;//隐藏窗体
            this.ShowInTaskbar = false;//图标不显示在任务栏
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.7li7li.cn");
        }
    }
}
