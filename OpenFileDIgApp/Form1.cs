using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenFileDIgApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = "C:\\";  // 역슬래시를 문자열로 출력하려면 두번써야한다
            openFileDialog1.Filter = "텍스트 파일(*.*)|*.*";
            openFileDialog1.Multiselect = true;
            openFileDialog1.ShowDialog();

            foreach ( var item in openFileDialog1.FileNames)
            {
                textBox1.Text = textBox1.Text + item;
                textBox1.Text = textBox1.Text + Environment.NewLine;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                BackColor = colorDialog1.Color;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button3.BackColor = colorDialog1.Color;
            }

        }
    }
}
