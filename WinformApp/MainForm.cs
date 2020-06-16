using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();    // 디자이너.cs 파일의 메서드인데 매우 중요한 구문임
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void BtnMessage_Click(object sender, EventArgs e)
        { // 클릭했을때 이벤트가 발생하는 메서드
            DateTime now = DateTime.Now;  // 현재 시간을 출력하는 구문
            // MessageBox.Show($"Hell World! {now}");   
            TxtCurrentDate.Text = now.ToString(); // 왠만한 클래스는 Tostring을 가지고있다.
        }
    }
}
