using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace openFileDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MnuNewFile_Click(object sender, EventArgs e)  // 새 파일 클릭 이벤트
        {
            textBox1.Text += MnuNewFile.Text + Environment.NewLine;
            toolStripStatusLabel1.Text = MnuNewFile.Text;
            //실제 새 파일 로직을 넣어야함
        }
        private void 열기OToolStripMenuItem_Click(object sender, EventArgs e)  // 열기 클릭
        {
            textBox1.Text += 열기OToolStripMenuItem.Text + Environment.NewLine;
            
            //실제 새 파일 로직을 넣어야함
        }
        private void 저장SToolStripMenuItem_Click(object sender, EventArgs e)  // 저장 클릭
        {
            textBox1.Text += 저장SToolStripMenuItem.Text + Environment.NewLine;
            MessageBox.Show("저장이 완료되었습니다");
        }

        private void 종료XToolStripMenuItem_Click(object sender, EventArgs e) // 종료 클릭
        {
            Application.Exit();   // 종료 명령
        }

        private void 프로그램정보AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();  
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e) // 텍스트박스에 우클릭했을때 이벤트
        {
            if(e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(e.Location);
            }
        }

        private void textBox1_MouseMove(object sender, MouseEventArgs e)
        {
            LblMouseLocation.Text = $"(X, Y)= ( {e.X}, { e.Y})";
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            button1.Focus();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MnuNewFile_Click(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripComboBox1.Items.Add("Python");
            toolStripComboBox1.Items.Add("C");
            toolStripComboBox1.Items.Add("C++");
            toolStripComboBox1.Items.Add("Java");
            toolStripComboBox1.Items.Add("C#");
        }
    }
}
