using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public  static class TextBoxToolV2
    {
        private const int EmSetcuebanner = 0x1501;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam,
            [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        /// <summary>
        /// 清除水印文字
        /// </summary>
        /// <param name="textBox"></param>
        public static void ClearWatermark(this TextBox textBox)
        {
            SendMessage(textBox.Handle, EmSetcuebanner, 0, string.Empty);
        }

        /// <summary>
        /// 添加水印
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="watermark"></param>
        public static void SetWatermark(this TextBox textBox,string watermark)
        {
            SendMessage(textBox.Handle, EmSetcuebanner, 0, watermark);
        }
    }
}
