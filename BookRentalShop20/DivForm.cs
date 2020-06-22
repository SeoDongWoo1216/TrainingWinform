using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace BookRentalShop20
{
    public partial class DivForm : MetroForm
    {
        
        string mode = "";

        public DivForm()
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
                DataGridViewRow data = GrdDivTbl.Rows[e.RowIndex];
                TxtDivision.Text = data.Cells[0].Value.ToString();  // object는 Tostring을 때려주자
                TxtNames.Text = data.Cells[1].Value.ToString();
                // 구분 코드는 SSMS에서 기본키로 지정되어있기때문에 수정할 수 없고 이름은 수정할 수 있다
                TxtDivision.ReadOnly = true;
                TxtDivision.BackColor = Color.Beige;

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
            if(String.IsNullOrEmpty(TxtDivision.Text) || string.IsNullOrEmpty(TxtNames.Text))
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
                    strQuery = "UPDATE dbo.divtbl" +
                               "   SET Names = @Names " +
                               "WHERE Division = @Division";     // SQL문에서 복사해오기
                   
                }
                else if (mode == "INSERT")
                {
                    strQuery = "INSERT INTO dbo.divtbl (Division, Names) " +
                               "VALUES (@Division, @Names)";
                }
                cmd.CommandText = strQuery;


                SqlParameter parmNames = new SqlParameter("@Names", SqlDbType.NVarChar, 45);
                parmNames.Value = TxtNames.Text;
                cmd.Parameters.Add(parmNames);

                SqlParameter parmDivision = new SqlParameter("@Division", SqlDbType.Char, 4);
                parmDivision.Value = TxtDivision.Text;
                cmd.Parameters.Add(parmDivision);

                cmd.ExecuteNonQuery(); // 쿼리값을 돌려받지 않으니까 ExecuteNonQuery을 써준다
            }
        }

        // 삭제 버튼 클릭 이벤트
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TxtDivision.Text) || string.IsNullOrEmpty(TxtNames.Text))
            {
                MetroMessageBox.Show(this, "빈 값은 삭제할 수 없습니다", "경고",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DeleteProcess();
            UpdateData();
            ClearTextControls();
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
                parmDivision.Value = TxtDivision.Text;
                cmd.Parameters.Add(parmDivision);

                cmd.ExecuteNonQuery();
            }
        }

        private void ClearTextControls()  // 중복된 코드를 메서드로 묶어주기
        {
            TxtDivision.Text = TxtNames.Text = "";
            TxtDivision.ReadOnly = false;
            TxtDivision.BackColor = Color.White;
            TxtDivision.Focus();
        }



        private void UpdateData()
        {
            using (SqlConnection conn = new SqlConnection(Commons.COONSTRING))
            {
                conn.Open(); // DB 열기
                string strQuery = "SELECT Division, Names FROM dbo.divtbl";  // SSMS에서 복사해서 넣기
                SqlCommand cmd = new SqlCommand(strQuery, conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(strQuery, conn);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "divtbl");

                GrdDivTbl.DataSource = ds;
                GrdDivTbl.DataMember = "divtbl";
            }
        }
        private void TxtNames_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BtnSave_Click(sender, new EventArgs());
            }
        }
    }
}
