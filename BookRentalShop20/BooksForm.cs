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
    public partial class BooksForm : MetroForm
    {

        string mode = "";

        public BooksForm()
        {
            InitializeComponent();
        }

        
        
        private void GrdDivTbl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)     // 첫번째 인덱스가 0이니까 -1로해준다
            {
                DataGridViewRow data = GrdBooksTbl.Rows[e.RowIndex];
                TxtIdx.Text = data.Cells[0].Value.ToString();  // object는 Tostring을 때려주자
                TxtAuthor.Text = data.Cells[1].Value.ToString();
                TxtIdx.ReadOnly = true;
                TxtIdx.BackColor = Color.Beige;

                // Cells[3] : "로맨스", "SF/판타지"
                // CboDivision.SelectedIndex = CboDivision.FindString(data.Cells[3].Value.ToString());

                // cells[2] : "B001", "B006"
                CboDivision.SelectedValue = data.Cells[2].Value;
                TxtName.Text = data.Cells[4].Value.ToString();

                DtpReleaseDate.Format = DateTimePickerFormat.Custom;
                DtpReleaseDate.CustomFormat = "yyyy-MM-dd";

                DtpReleaseDate.Value = DateTime.Parse(data.Cells[5].Value.ToString());
                TxtISBN.Text = data.Cells[6].Value.ToString();
                TxtPrice.Text = data.Cells[7].Value.ToString();

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
            if(String.IsNullOrEmpty(TxtName.Text) || string.IsNullOrEmpty(TxtAuthor.Text)
                || string.IsNullOrEmpty(TxtISBN.Text) )   // 나머지 컨트롤(총 6개) 검사해야한다
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
                    strQuery = " UPDATE dbo.bookstbl " +
                               "  SET Author = @Author " +
                               ", Division = @Division " +
                               ", Names = @Names " +
                               ", ReleaseDate = @ReleaseDate " +
                               ", ISBN = @ISBN " +
                               ", Price = @Price " +
                               "  WHERE Idx = @Idx";
                }
                else if (mode == "INSERT")
                {
                    strQuery = "INSERT INTO dbo.bookstbl(Author, Division, Names, ReleaseDate, ISBN, Price) " +
                               " VALUES(@Author, @Division, @Names, @ReleaseDate, @ISBN, @Price)";
                }
                cmd.CommandText = strQuery;


                SqlParameter parmAuthor = new SqlParameter("@Author", SqlDbType.VarChar, 45);
                parmAuthor.Value = TxtAuthor.Text;
                cmd.Parameters.Add(parmAuthor);

                SqlParameter parmDivision = new SqlParameter("@Division", SqlDbType.Char, 4);
                parmDivision.Value = CboDivision.SelectedValue;
                cmd.Parameters.Add(parmDivision);

                SqlParameter parmNames = new SqlParameter("@Names", SqlDbType.Char, 100);
                parmNames.Value = TxtName.Text;
                cmd.Parameters.Add(parmNames);

                SqlParameter parmReleaseDate = new SqlParameter("@ReleaseDate", SqlDbType.Date);
                parmReleaseDate.Value = DtpReleaseDate.Value;
                cmd.Parameters.Add(parmReleaseDate);

                SqlParameter parmISBN = new SqlParameter("@ISBN", SqlDbType.VarChar, 200);
                parmISBN.Value = TxtISBN.Text;
                cmd.Parameters.Add(parmISBN);

                SqlParameter parmPrice = new SqlParameter("@Price", SqlDbType.Decimal, 10);
                parmPrice.Value = TxtPrice.Text;
                cmd.Parameters.Add(parmPrice);

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
            if (String.IsNullOrEmpty(TxtIdx.Text) || string.IsNullOrEmpty(TxtAuthor.Text))
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
                string strQuery = "SELECT b.Idx, b.Author, b.Division, " +
                                  "       d.Names AS '장르', b.Names, b.ReleaseDate, b.ISBN, " +
	                              "        REPLACE(CONVERT(VARCHAR, CONVERT(Money, b.Price), 1), '.00', '') AS Price " +
                                  " FROM dbo.bookstbl AS b " +
                                  " INNER JOIN dbo.divtbl AS d " +
                                  "  ON b.Division = d.Division ";

                //SqlCommand cmd = new SqlCommand(strQuery, conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(strQuery, conn);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "bookstbl");

                GrdBooksTbl.DataSource = ds;
                GrdBooksTbl.DataMember = "bookstbl";
            }
            DataGridViewColumn column = GrdBooksTbl.Columns[1]; // 컬럼
            column.Visible = false;
        }

        // 버튼을 클릭했을때 빈칸으로 만들어주는 메서드
        private void ClearTextControls()  // 중복된 코드를 메서드로 묶어주기
        {
            TxtIdx.Text = TxtAuthor.Text = TxtName.Text = TxtISBN.Text = TxtPrice.Text =  "";
            CboDivision.SelectedIndex = -1;  // 콤보박스를 빈칸으로 해줌(초기화)
            TxtIdx.ReadOnly = true;
            TxtIdx.BackColor = Color.Beige;

            // DateTimePicker 
            DtpReleaseDate.CustomFormat = " ";  
            DtpReleaseDate.Format = DateTimePickerFormat.Custom;

            TxtName.Focus();
        }

       
        private void TxtNames_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BtnSave_Click(sender, new EventArgs());
            }
        }

        private void MemberForm_Load(object sender, EventArgs e)
        {
            DtpReleaseDate.CustomFormat = "yyyy-MM-dd";
            DtpReleaseDate.Format = DateTimePickerFormat.Custom;
            UpdateData();   // 데이터그리드 DB 데이터 로딩하기

            UpdateCboDivision();
        }

        private void UpdateCboDivision()
        {
            using (SqlConnection conn = new SqlConnection(Commons.COONSTRING))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT Division, Names FROM dbo.divtbl";// SQL데이터를 리더에 가져옴
                SqlDataReader reader = cmd.ExecuteReader();                // 하나씩 읽어줌
                Dictionary<string, string> temps = new Dictionary<string, string>();  // <키, 값> (사전처럼 단어와 뜻이 있는 것을 생각)
                while (reader.Read())
                {
                    temps.Add(reader[0].ToString(), reader[1].ToString());
                }
                CboDivision.DataSource = new BindingSource(temps, null);
                CboDivision.DisplayMember = "Value";
                CboDivision.ValueMember = "Key";
                CboDivision.SelectedIndex = -1;
            }
        }

        private void DtpReleaseDate_ValueChanged(object sender, EventArgs e)
        {
            DtpReleaseDate.CustomFormat = "yyyy-MM-dd";
            DtpReleaseDate.Format = DateTimePickerFormat.Custom;
        }
    }
}
