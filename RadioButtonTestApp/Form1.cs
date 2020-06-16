using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace RadioButtonTestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = radioButton1.Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = radioButton2.Text;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = radioButton4.Text;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = radioButton4.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = string.Empty;   // 공백을 출력
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(linkLabel1.Text);   // 링크를 클릭하면 링크사이트로 이동된다
        }
    }
}
