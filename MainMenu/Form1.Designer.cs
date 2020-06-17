﻿namespace openFileDialog
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuNewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.열기OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.닫기CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.편집EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.잘라내기TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.복사CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.붙여넣기VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.프로그램정보AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.실행취소ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.잘라내기TToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.복사CToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.붙여넣기PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.삭제DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.모두선택AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.LblMouseLocation = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일FToolStripMenuItem,
            this.편집EToolStripMenuItem,
            this.도움말HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(563, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일FToolStripMenuItem
            // 
            this.파일FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuNewFile,
            this.열기OToolStripMenuItem,
            this.닫기CToolStripMenuItem,
            this.저장SToolStripMenuItem,
            this.종료XToolStripMenuItem});
            this.파일FToolStripMenuItem.Name = "파일FToolStripMenuItem";
            this.파일FToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.파일FToolStripMenuItem.Text = "파일(&F)";
            // 
            // MnuNewFile
            // 
            this.MnuNewFile.Name = "MnuNewFile";
            this.MnuNewFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.MnuNewFile.Size = new System.Drawing.Size(218, 26);
            this.MnuNewFile.Text = "새 파일(&N)";
            this.MnuNewFile.Click += new System.EventHandler(this.MnuNewFile_Click);
            // 
            // 열기OToolStripMenuItem
            // 
            this.열기OToolStripMenuItem.Name = "열기OToolStripMenuItem";
            this.열기OToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.열기OToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.열기OToolStripMenuItem.Text = "열기(&O)...";
            this.열기OToolStripMenuItem.Click += new System.EventHandler(this.열기OToolStripMenuItem_Click);
            // 
            // 닫기CToolStripMenuItem
            // 
            this.닫기CToolStripMenuItem.Name = "닫기CToolStripMenuItem";
            this.닫기CToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.닫기CToolStripMenuItem.Text = "닫기(&C)";
            // 
            // 저장SToolStripMenuItem
            // 
            this.저장SToolStripMenuItem.Name = "저장SToolStripMenuItem";
            this.저장SToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.저장SToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.저장SToolStripMenuItem.Text = "저장(&S)";
            this.저장SToolStripMenuItem.Click += new System.EventHandler(this.저장SToolStripMenuItem_Click);
            // 
            // 종료XToolStripMenuItem
            // 
            this.종료XToolStripMenuItem.Name = "종료XToolStripMenuItem";
            this.종료XToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.종료XToolStripMenuItem.Text = "종료(&X)";
            this.종료XToolStripMenuItem.Click += new System.EventHandler(this.종료XToolStripMenuItem_Click);
            // 
            // 편집EToolStripMenuItem
            // 
            this.편집EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.잘라내기TToolStripMenuItem,
            this.복사CToolStripMenuItem,
            this.붙여넣기VToolStripMenuItem});
            this.편집EToolStripMenuItem.Name = "편집EToolStripMenuItem";
            this.편집EToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.편집EToolStripMenuItem.Text = "편집(&E)";
            // 
            // 잘라내기TToolStripMenuItem
            // 
            this.잘라내기TToolStripMenuItem.Name = "잘라내기TToolStripMenuItem";
            this.잘라내기TToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.잘라내기TToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.잘라내기TToolStripMenuItem.Text = "잘라내기(&T)";
            // 
            // 복사CToolStripMenuItem
            // 
            this.복사CToolStripMenuItem.Name = "복사CToolStripMenuItem";
            this.복사CToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.복사CToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.복사CToolStripMenuItem.Text = "복사(&C)";
            // 
            // 붙여넣기VToolStripMenuItem
            // 
            this.붙여넣기VToolStripMenuItem.Name = "붙여넣기VToolStripMenuItem";
            this.붙여넣기VToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.붙여넣기VToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.붙여넣기VToolStripMenuItem.Text = "붙여넣기(&P)";
            // 
            // 도움말HToolStripMenuItem
            // 
            this.도움말HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.프로그램정보AToolStripMenuItem});
            this.도움말HToolStripMenuItem.Name = "도움말HToolStripMenuItem";
            this.도움말HToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.도움말HToolStripMenuItem.Text = "도움말(&H)";
            // 
            // 프로그램정보AToolStripMenuItem
            // 
            this.프로그램정보AToolStripMenuItem.Name = "프로그램정보AToolStripMenuItem";
            this.프로그램정보AToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.프로그램정보AToolStripMenuItem.Text = "프로그램 정보(&A)";
            this.프로그램정보AToolStripMenuItem.Click += new System.EventHandler(this.프로그램정보AToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 92);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(533, 159);
            this.textBox1.TabIndex = 1;
            this.textBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            this.textBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseMove);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(450, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.실행취소ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.잘라내기TToolStripMenuItem1,
            this.복사CToolStripMenuItem1,
            this.붙여넣기PToolStripMenuItem,
            this.삭제DToolStripMenuItem,
            this.toolStripMenuItem2,
            this.모두선택AToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(160, 160);
            // 
            // 실행취소ToolStripMenuItem
            // 
            this.실행취소ToolStripMenuItem.Name = "실행취소ToolStripMenuItem";
            this.실행취소ToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.실행취소ToolStripMenuItem.Text = "실행취소(&U)";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(156, 6);
            // 
            // 잘라내기TToolStripMenuItem1
            // 
            this.잘라내기TToolStripMenuItem1.Name = "잘라내기TToolStripMenuItem1";
            this.잘라내기TToolStripMenuItem1.Size = new System.Drawing.Size(159, 24);
            this.잘라내기TToolStripMenuItem1.Text = "잘라내기(&T)";
            // 
            // 복사CToolStripMenuItem1
            // 
            this.복사CToolStripMenuItem1.Name = "복사CToolStripMenuItem1";
            this.복사CToolStripMenuItem1.Size = new System.Drawing.Size(159, 24);
            this.복사CToolStripMenuItem1.Text = "복사(&C)";
            // 
            // 붙여넣기PToolStripMenuItem
            // 
            this.붙여넣기PToolStripMenuItem.Name = "붙여넣기PToolStripMenuItem";
            this.붙여넣기PToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.붙여넣기PToolStripMenuItem.Text = "붙여넣기(&P)";
            // 
            // 삭제DToolStripMenuItem
            // 
            this.삭제DToolStripMenuItem.Name = "삭제DToolStripMenuItem";
            this.삭제DToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.삭제DToolStripMenuItem.Text = "삭제(&D)";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(156, 6);
            // 
            // 모두선택AToolStripMenuItem
            // 
            this.모두선택AToolStripMenuItem.Name = "모두선택AToolStripMenuItem";
            this.모두선택AToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.모두선택AToolStripMenuItem.Text = "모두선택(&A)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "좌표 : ";
            // 
            // LblMouseLocation
            // 
            this.LblMouseLocation.AutoSize = true;
            this.LblMouseLocation.Location = new System.Drawing.Point(72, 407);
            this.LblMouseLocation.Name = "LblMouseLocation";
            this.LblMouseLocation.Size = new System.Drawing.Size(45, 15);
            this.LblMouseLocation.TabIndex = 4;
            this.LblMouseLocation.Text = "label2";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripComboBox1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(563, 28);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 25);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "New File";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 320);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(563, 26);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(152, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 28);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 346);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.LblMouseLocation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuNewFile;
        private System.Windows.Forms.ToolStripMenuItem 열기OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 닫기CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 편집EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 잘라내기TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 복사CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 붙여넣기VToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 프로그램정보AToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 실행취소ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 잘라내기TToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 복사CToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 붙여넣기PToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 삭제DToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 모두선택AToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblMouseLocation;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
    }
}

