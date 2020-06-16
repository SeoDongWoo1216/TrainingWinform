using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBoxTestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void UpdateLabel()
        {
            string strchk1 = "";
            string strchk4 = "";
            string strchk5 = "";
            string strchk6 = "";

            if (checkBox1.Checked) strchk1 = checkBox1.Text;       // 체크박스의 텍스트를 체크하면 strchk1에 문자를 집어넣음
            else strchk1 = "";                                     // 반대가 되면 "" (공백)을 준다
            if (checkBox4.Checked) strchk4 = checkBox4.Text;       
            else strchk4 = "";
            if (checkBox5.Checked) strchk5 = checkBox5.Text;
            else strchk5 = "";
            if (checkBox6.Checked) strchk6 = checkBox6.Text;
            else strchk6 = "";

            label1.Text = strchk1 + " " + strchk4 + " " + strchk5 + " " + strchk6;

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabel();
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabel();
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabel();
        }
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabel();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "좋아하는 과일을 선택하세요 ";    // 시작했을때 "label1" 으로 출력되던 레이블을 "좋아하는 과일"로 수정
        }
    }
}
