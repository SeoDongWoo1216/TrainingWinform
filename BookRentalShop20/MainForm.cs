using MetroFramework;
using MetroFramework.Forms;
using System.Windows.Forms;

namespace BookRentalShop20
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void MainForm_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            
                if (MetroMessageBox.Show(this, "종료하시겠습니까?", "종료",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                foreach  (Form item in this.MdiChildren)
                {
                    item.Close();
                }
                
                    e.Cancel = false;  // 취소안했을때
                }
                else
                {
                    e.Cancel = true;  // 취소했을때
                }
            
        }

private void InitChildForm(Form form, string strFormTitle)
        {
            form.Text = strFormTitle;
            form.Dock = DockStyle.Fill;     // 메인폼이 부모, DivForm이 자식 
            form.MdiParent = this;         // 자기 자신을 나타내는게 this임
            form.Show();                    // Mdi가 창 여러개가 겹쳐있을때 하나씩 빼는걸 말하는거임
            form.WindowState = FormWindowState.Maximized;                 
        }

        private void MnuItemDivMng_Click(object sender, System.EventArgs e)
        {
            DivForm form = new DivForm();
            InitChildForm(form, "구분코드 관리");
        }

        private void 사용자관리UToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            UserForm form = new UserForm();
            InitChildForm(form, "사용자 관리");
        }

        private void 회원관리MToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            MemberForm form = new MemberForm();
            InitChildForm(form, "회원관리");
        }

        private void MainForm_Activated(object sender, System.EventArgs e)
        {
            // 메인폼이 활성화됬을때의 메서드
            LblUserID.Text = Commons.LOGINUSERID;
        }

        private void 책관리BToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            BooksForm form = new BooksForm();
            InitChildForm(form, "책 관리");
        }
    }
}
