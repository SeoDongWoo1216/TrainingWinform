using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClockApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            label1.Text = now.ToString("HH:mm:ss");
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("진짜 닫을래?", "경고",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MessageBox.Show("진짜 닫는구나?");
                e.Cancel = false;  // 취소를 안시켜서 종료(닫기 후, 진짜 닫을래?에서 예를 클릭)
            }
            else
            {
                e.Cancel = true;   // 취소시키니까 종료안됨(닫기 후, 진짜 닫을래?에서 아니오를 클릭)
            }
        }
    }
}
