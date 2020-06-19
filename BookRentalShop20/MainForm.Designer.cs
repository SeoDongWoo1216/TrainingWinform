namespace BookRentalShop20
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MnuMain = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemDivMng = new System.Windows.Forms.ToolStripMenuItem();
            this.사용자관리UToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuMain});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(760, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MnuMain
            // 
            this.MnuMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuItemDivMng,
            this.사용자관리UToolStripMenuItem});
            this.MnuMain.Name = "MnuMain";
            this.MnuMain.Size = new System.Drawing.Size(107, 24);
            this.MnuMain.Text = "메인관리(&M)";
            // 
            // MnuItemDivMng
            // 
            this.MnuItemDivMng.Name = "MnuItemDivMng";
            this.MnuItemDivMng.Size = new System.Drawing.Size(224, 26);
            this.MnuItemDivMng.Text = "구분코드관리(&D)";
            this.MnuItemDivMng.Click += new System.EventHandler(this.MnuItemDivMng_Click);
            // 
            // 사용자관리UToolStripMenuItem
            // 
            this.사용자관리UToolStripMenuItem.Name = "사용자관리UToolStripMenuItem";
            this.사용자관리UToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.사용자관리UToolStripMenuItem.Text = "사용자관리(&U)";
            this.사용자관리UToolStripMenuItem.Click += new System.EventHandler(this.사용자관리UToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Book Rentalshop v1.0";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnuMain;
        private System.Windows.Forms.ToolStripMenuItem MnuItemDivMng;
        private System.Windows.Forms.ToolStripMenuItem 사용자관리UToolStripMenuItem;
    }
}

