using System;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.SetWatermark("请输入用户名称....");
            textBox2.SetWatermark("请输入用户密码....");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.ClearWatermark();
            textBox2.ClearWatermark();
        }
    }
}
