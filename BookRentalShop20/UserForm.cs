using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace BookRentalShop20
{
    public partial class UserForm : MetroForm
    {
       
        string mode = "";

        public UserForm()
        {
            InitializeComponent();
        }

        private void DivForm_Load(object sender, EventArgs e)
        {
            UpdateData();   // 데이터그리드 DB 데이터 로딩하기
        }

        private void GrdDivTbl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)     // 첫번째 인덱스가 0이니까 -1로해준다
            {
                DataGridViewRow data = GrdUserTbl.Rows[e.RowIndex];
                TxtId.Text = data.Cells[0].Value.ToString();
                TxtUserID.Text = data.Cells[1].Value.ToString();  
                TxtPassword.Text = data.Cells[2].Value.ToString();

                mode = "UPDATE";  // 수정은 UPDATE
            }
        }

        // 신규 버튼 클릭 이벤트
        private void BtnNew_Click(object sender, EventArgs e)
        {
            ClearTextControls();
            mode = "INSERT";   // 신규는 INSERT
        }

        // 저장 버튼 클릭 이벤트
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(TxtUserID.Text) || string.IsNullOrEmpty(TxtPassword.Text))
            {
                MetroMessageBox.Show(this, "빈 값은 저장할 수 없습니다", "경고",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SaveProcess();
            UpdateData();
            ClearTextControls();  
        }
        

        // 저장 버튼의 메서드
        private void SaveProcess()
        {
            if (String.IsNullOrEmpty(mode)) // 아무것도 입력안했을때 오류메세지
            {
                MetroMessageBox.Show(this, "신규버튼을 누르고 데이터를 저장하십시오", "경고",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //DB저장 프로세스
            using (SqlConnection conn = new SqlConnection(Commons.COONSTRING))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                string strQuery = "";

                if (mode == "UPDATE")
                {
                    strQuery = "UPDATE dbo.userTbl " +
                               "SET userID = @userID, " +
                               " password = @password " +
                               " WHERE Id = @Id";
                }
                else if (mode == "INSERT")
                {
                    strQuery = "INSERT INTO dbo.userTbl( userID, password) " +
                               " VALUES(@userID, @password) ";
                }
                cmd.CommandText = strQuery;

                SqlParameter parmUserID = new SqlParameter("@userID", SqlDbType.VarChar, 12);
                parmUserID.Value = TxtUserID.Text;
                cmd.Parameters.Add(parmUserID);

                SqlParameter parmPassword = new SqlParameter("@password", SqlDbType.VarChar, 20);
                parmPassword.Value = TxtPassword.Text;
                cmd.Parameters.Add(parmPassword);

                if (mode == "UPDATE")  // 인서트할때는 ID가 필요없으므로 UPDATE문에만 걸리게 설정
                {
                    SqlParameter parmId = new SqlParameter("@Id", SqlDbType.Int);
                    parmId.Value = TxtId.Text;
                    cmd.Parameters.Add(parmId);
                }

                cmd.ExecuteNonQuery(); // 쿼리값을 돌려받지 않으니까 ExecuteNonQuery을 써준다
            }
        }

        // 삭제 버튼 클릭 이벤트
        private void BtnDelete_Click(object sender, EventArgs e)
        {
          
        }

        // 삭제 메서드
        private void DeleteProcess()
        {
            using (SqlConnection conn = new SqlConnection(Commons.COONSTRING))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM dbo.divtbl WHERE Division = @Division ";
                SqlParameter parmDivision = new SqlParameter("@Division", SqlDbType.Char, 4);
                parmDivision.Value = TxtUserID.Text;
                cmd.Parameters.Add(parmDivision);

                cmd.ExecuteNonQuery();
            }
        }

        private void ClearTextControls()  // 중복된 코드를 메서드로 묶어주기
        {
            TxtId.Text = TxtUserID.Text = TxtPassword.Text = "";
            //TxtUserID.ReadOnly = false;
            //TxtUserID.BackColor = Color.White;
            TxtUserID.Focus();
        }


        // 사용자 데이터 가져오기
        private void UpdateData()
        {
            using (SqlConnection conn = new SqlConnection(Commons.COONSTRING))
            {
                conn.Open(); // DB 열기
                string strQuery = "SELECT id, userID, password, lastLoginDt, loginIpAddr" +
                                  "  FROM dbo.userTbl";  
                SqlCommand cmd = new SqlCommand(strQuery, conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(strQuery, conn);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "userTbl");

                GrdUserTbl.DataSource = ds;
                GrdUserTbl.DataMember = "userTbl";
            }
            DataGridViewColumn column = GrdUserTbl.Columns[0]; // id컬럼
            column.Width = 40;
            column.HeaderText = "순번";
            column = GrdUserTbl.Columns[1];  // userID 컬럼
            column.Width = 80;
            column.HeaderText = "아이디";
            column = GrdUserTbl.Columns[2];  // Password 컬럼
            column.Width = 100;
            column.HeaderText = "패스워드";
            column = GrdUserTbl.Columns[3];  // 최종접속 시간 컬럼
            column.Width = 120;
            column.HeaderText = "최종접속시간";
            column = GrdUserTbl.Columns[4];  // 접속IP주소 컬럼
            column.Width = 150;
            column.HeaderText = "접속IP주소";
        }
    }
}
