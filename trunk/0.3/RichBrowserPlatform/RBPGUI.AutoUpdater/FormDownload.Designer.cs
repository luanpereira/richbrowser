namespace RBPGUI.AutoUpdater
{
    partial class FormDownload
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelMessage = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.timerSkip = new System.Windows.Forms.Timer(this.components);
            this.progressBarMain = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(12, 9);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(108, 12);
            this.labelMessage.TabIndex = 6;
            this.labelMessage.Text = "Wait a moments...";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(221, 72);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(142, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // progressBarMain
            // 
            this.progressBarMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarMain.Location = new System.Drawing.Point(12, 33);
            this.progressBarMain.Name = "progressBarMain";
            this.progressBarMain.Size = new System.Drawing.Size(558, 23);
            this.progressBarMain.TabIndex = 4;
            // 
            // FormDownload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 107);
            this.ControlBox = false;
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.progressBarMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormDownload";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Downloading...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Timer timerSkip;
        private System.Windows.Forms.ProgressBar progressBarMain;

    }
}