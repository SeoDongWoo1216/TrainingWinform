namespace ButtonTestApp
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
            this.BtnFlat = new System.Windows.Forms.Button();
            this.BtnPopup = new System.Windows.Forms.Button();
            this.BtnSystem = new System.Windows.Forms.Button();
            this.BthStandard = new System.Windows.Forms.Button();
            this.LblButtonStyle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnFlat
            // 
            this.BtnFlat.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnFlat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnFlat.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnFlat.Location = new System.Drawing.Point(160, 75);
            this.BtnFlat.Name = "BtnFlat";
            this.BtnFlat.Size = new System.Drawing.Size(130, 130);
            this.BtnFlat.TabIndex = 1;
            this.BtnFlat.Text = "Flat";
            this.BtnFlat.UseVisualStyleBackColor = false;
            this.BtnFlat.Click += new System.EventHandler(this.BtnFlat_Click);
            // 
            // BtnPopup
            // 
            this.BtnPopup.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnPopup.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnPopup.Location = new System.Drawing.Point(292, 75);
            this.BtnPopup.Name = "BtnPopup";
            this.BtnPopup.Size = new System.Drawing.Size(130, 130);
            this.BtnPopup.TabIndex = 2;
            this.BtnPopup.Text = "Popup";
            this.BtnPopup.UseVisualStyleBackColor = false;
            this.BtnPopup.Click += new System.EventHandler(this.BtnPopup_Click);
            // 
            // BtnSystem
            // 
            this.BtnSystem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSystem.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnSystem.Location = new System.Drawing.Point(292, 211);
            this.BtnSystem.Name = "BtnSystem";
            this.BtnSystem.Size = new System.Drawing.Size(130, 130);
            this.BtnSystem.TabIndex = 4;
            this.BtnSystem.Text = "System";
            this.BtnSystem.UseVisualStyleBackColor = false;
            this.BtnSystem.Click += new System.EventHandler(this.BtnSystem_Click);
            // 
            // BthStandard
            // 
            this.BthStandard.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BthStandard.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BthStandard.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BthStandard.Location = new System.Drawing.Point(160, 211);
            this.BthStandard.Name = "BthStandard";
            this.BthStandard.Size = new System.Drawing.Size(130, 130);
            this.BthStandard.TabIndex = 3;
            this.BthStandard.Text = "Standard";
            this.BthStandard.UseVisualStyleBackColor = false;
            this.BthStandard.Click += new System.EventHandler(this.BthStandard_Click);
            // 
            // LblButtonStyle
            // 
            this.LblButtonStyle.AutoSize = true;
            this.LblButtonStyle.Location = new System.Drawing.Point(13, 423);
            this.LblButtonStyle.Name = "LblButtonStyle";
            this.LblButtonStyle.Size = new System.Drawing.Size(45, 15);
            this.LblButtonStyle.TabIndex = 1;
            this.LblButtonStyle.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblButtonStyle);
            this.Controls.Add(this.BthStandard);
            this.Controls.Add(this.BtnSystem);
            this.Controls.Add(this.BtnPopup);
            this.Controls.Add(this.BtnFlat);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnFlat;
        private System.Windows.Forms.Button BtnPopup;
        private System.Windows.Forms.Button BtnSystem;
        private System.Windows.Forms.Button BthStandard;
        private System.Windows.Forms.Label LblButtonStyle;
    }
}

