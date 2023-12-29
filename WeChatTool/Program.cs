using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WeChatTool
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool isRun;
            System.Threading.Mutex run = new System.Threading.Mutex(true, "WeChatTool", out isRun);
            if (isRun)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new WeChatTool());
            }
            else
            {
                VXTool.OpenWeChat();
                //MessageBox.Show("程序已经在运行了");
            }
        }
    }
}
