using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ChartControlApp
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Using Chart Control 이거 왜이래 ";  // 속성창에서 Text 수정하는것과 같은 함수
            //10명의 학생 랜덤점수 생성 및 차트 바인딩
            Random rand = new Random();
            chart1.Titles.Add("중간고사 성적");
            for(int i = 0; i<10; i++)
            {
                chart1.Series["Score"].Points.Add(rand.Next(100));
            }
            chart1.Series["Score"].LegendText = "수학점수";
            chart1.Series["Score"].ChartType = SeriesChartType.Line;   // 차트의 유형을 선 그래프로 바꿔줌
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series["Score"].Points.Clear();
            MetroMessageBox.Show(this, "데이터를 지웠습니다", "처리", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
