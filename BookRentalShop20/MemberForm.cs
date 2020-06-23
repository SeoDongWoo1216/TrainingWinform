using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace BookRentalShop20
{
    public partial class MemberForm : MetroForm
    {

        string mode = "";

        public MemberForm()
        {
            InitializeComponent();
        }

        private void MemberForm_Load(object sender, EventArgs e)
        {
            UpdateData();   // 데이터그리드 DB 데이터 로딩하기
        }

        private void GrdDivTbl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)     // 첫번째 인덱스가 0이니까 -1로해준다
            {
                DataGridViewRow data = GrdMemberTbl.Rows[e.RowIndex];
                TxtIdx.Text = data.Cells[0].Value.ToString();  // object는 Tostring을 때려주자
                TxtNames.Text = data.Cells[1].Value.ToString();
                TxtIdx.ReadOnly = true;
                TxtIdx.BackColor = Color.Beige;
                CboLevels.SelectedIndex = CboLevels.FindString(data.Cells[2].Value.ToString());
                TxtAddr.Text = data.Cells[3].Value.ToString();
                TxtMobile.Text = data.Cells[4].Value.ToString();
                TxtEmail.Text = data.Cells[5].Value.ToString();

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
            if(String.IsNullOrEmpty(TxtAddr.Text) || string.IsNullOrEmpty(TxtNames.Text)
                || string.IsNullOrEmpty(TxtMobile.Text) || string.IsNullOrEmpty(TxtEmail.Text))
            {
                MetroMessageBox.Show(this, "빈 값은 저장할 수 없습니다", "경고",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SaveProcess();
            UpdateData();    // 그리드를 다시 불러서 리프레쉬된다
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
                    strQuery = "UPDATE dbo.membertbl " +
                              "  SET Names = @Names " +
                              " , Levels = @Levels " +
                              " , Addr = @Addr " +
                              " , Mobile = @Mobile " +
                              " , Email = @Email " +
                              "  WHERE Idx = @Idx";
                }
                else if (mode == "INSERT")
                {
                    strQuery = "INSERT INTO dbo.membertbl(Names, Levels, Addr, Mobile, Email) " +
                               "VALUES(@Names, @Levels, @Addr, @Mobile, @Email) ";
                }
                cmd.CommandText = strQuery;


                SqlParameter parmNames = new SqlParameter("@Names", SqlDbType.NVarChar, 45);
                parmNames.Value = TxtNames.Text;
                cmd.Parameters.Add(parmNames);

                SqlParameter parmLevels = new SqlParameter("@Levels", SqlDbType.Char, 1);
                parmLevels.Value = CboLevels.SelectedItem;
                cmd.Parameters.Add(parmLevels);

                SqlParameter parmAddr = new SqlParameter("@Addr", SqlDbType.VarChar, 100);
                parmAddr.Value = TxtAddr.Text;
                cmd.Parameters.Add(parmAddr);

                SqlParameter parmMobile = new SqlParameter("@Mobile", SqlDbType.VarChar, 13);
                parmMobile.Value = TxtMobile.Text;
                cmd.Parameters.Add(parmMobile);

                SqlParameter parmEmail = new SqlParameter("@Email", SqlDbType.VarChar, 50);
                parmEmail.Value = TxtEmail.Text;
                cmd.Parameters.Add(parmEmail);

                if(mode == "UPDATE")
                {
                    SqlParameter parmIdx = new SqlParameter("@Idx", SqlDbType.Int);
                    parmIdx.Value = TxtIdx.Text;
                    cmd.Parameters.Add(parmIdx);
                }
                

                cmd.ExecuteNonQuery(); // 쿼리값을 돌려받지 않으니까 ExecuteNonQuery을 써준다
            }
        }

        // 삭제 버튼 클릭 이벤트
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TxtIdx.Text) || string.IsNullOrEmpty(TxtNames.Text))
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
                parmDivision.Value = TxtIdx.Text;
                cmd.Parameters.Add(parmDivision);

                cmd.ExecuteNonQuery();
            }
        }

        private void UpdateData()
        {
            using (SqlConnection conn = new SqlConnection(Commons.COONSTRING))
            {
                conn.Open(); // DB 열기
                string strQuery = "SELECT Idx ,Names ,Levels ,Addr ,Mobile ,Email " +
                                    "FROM dbo.membertbl ";
                SqlCommand cmd = new SqlCommand(strQuery, conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(strQuery, conn);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "membertbl");

                GrdMemberTbl.DataSource = ds;
                GrdMemberTbl.DataMember = "membertbl";
            }
        }

        // 버튼을 클릭했을때 빈칸으로 만들어주는 메서드
        private void ClearTextControls()  // 중복된 코드를 메서드로 묶어주기
        {
            TxtIdx.Text = TxtNames.Text = TxtAddr.Text = TxtEmail.Text = TxtMobile.Text = "";
            CboLevels.SelectedIndex = -1;  // 콤보박스를 빈칸으로 해줌(초기화)
            TxtIdx.ReadOnly = true;
            TxtIdx.BackColor = Color.Beige;
            TxtIdx.Focus();
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
