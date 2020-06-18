using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace BookRentalShop20
{
    public partial class LoginForm : MetroForm
    {
        string strConnString = "Data Source=192.168.0.124;Initial Catalog=BookRentalShopDB;Persist Security Info=True;User ID=sa;Password=p@ssw0rd!"; //  
        public LoginForm()
        {
            InitializeComponent();
        }

        // 캔슬 버튼 클릭 이벤트
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            //종료하는방법은 2가지가있다
            //Application.Exit(); // 작업 표시줄에서 종료안될때가있음
            Environment.Exit(0);  // 주로 이걸 쓴다
        }


        // 로그인 처리버튼 이벤트
        private void BtnOk_Click(object sender, EventArgs e)
        {
            LoginProcess();
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)   // ID창에서 엔터치면 포커싱됨
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)   // 패스워드 창에서 엔터치면 OK 포커싱
            {
                LoginProcess();   // 일단 메서드 이름을 만들고 Alt + 엔터를 눌러서 메서드를 생성할 수 있다
            }
        }

        private void LoginProcess() // Alt + 엔터로 생성된 메서드
        {
            // throw new NotImplementedException();
            if (string.IsNullOrEmpty(txtId.Text) ||
                 string.IsNullOrEmpty(txtPassword.Text))
            {
                MetroMessageBox.Show(this, "아이디/패스워드를 입력하세요!", "오류",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string struserID = string.Empty;

            using (SqlConnection conn = new SqlConnection(strConnString))  // strConnStiring의 출처가 알고싶으면 커서를 두고 정의로 이동 또는 F12를 누른다
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT userID FROm userTbl " +
                                  " WHERE userID = @userID " +
                                  "   AND password = @password ";     // sql 명령문 입력(이 구문만 입력하면 Sql 인젝션으로 해킹당할 수 있으므로 밑의 구문도 입력해준다)

                // ID
                SqlParameter parmUserId = new SqlParameter("@userID", SqlDbType.VarChar, 12);
                //DB userID라는 필드가 varchar(12)로 지정되어있어서 지정
                parmUserId.Value = txtId.Text;
                cmd.Parameters.Add(parmUserId);

                // 패스워드
                SqlParameter parmUserPassword = new SqlParameter("@password", SqlDbType.VarChar, 20);
                parmUserPassword.Value = txtPassword.Text;
                cmd.Parameters.Add(parmUserPassword);

                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read(); // sql 데이터를 읽음
                struserID = reader["userID"].ToString();  // 돌려받는 값이라서 @userID가 아니라 userID이다.

                MetroMessageBox.Show(this, "접속성공", "로그인");
                Debug.WriteLine("On the Debug");
            }
        }
    }
}


