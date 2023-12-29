using System.IO;
using System.Runtime.InteropServices;

namespace WeChatTool
{
    public class VXTool
    {
        [DllImport("multiWXLib.dll", EntryPoint = "UnLimitMultiWeChatDll", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = false, CallingConvention = CallingConvention.StdCall)]
        public extern static void UnLimitMultiWeChatDll();

        [DllImport("multiWXLib.dll", EntryPoint = "OpenWeChatDll", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = false, CallingConvention = CallingConvention.StdCall)]
        public extern static void OpenWeChatDll();
        public static void OpenWeChat(uint open = 1)
        {
            if(!File.Exists(Path.Combine( System.Environment.CurrentDirectory, "multiWXLib.dll")))
            {
                System.Windows.Forms.MessageBox.Show("缺少multiWXLib.dll");
                return;
            }
            try
            {
                for (int i = 0; i < open; i++)
                {
                    UnLimitMultiWeChatDll();//取消多开限制
                    OpenWeChatDll(); //打开微信（从注册表读取微信路径，然后运行）
                }
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("微信启动失败");
            }
        }
    }
}
