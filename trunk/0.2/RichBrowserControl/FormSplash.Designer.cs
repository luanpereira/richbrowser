namespace JinwooMin.RichBrowserControl
{
    /// <summary>
    /// TODO
    /// </summary>
    partial class FormSplash
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSplash));
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.labelMessage = new System.Windows.Forms.Label();
            this.progressBarMain = new System.Windows.Forms.ProgressBar();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxLog
            // 
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.ItemHeight = 12;
            this.listBoxLog.Location = new System.Drawing.Point(12, 12);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.Size = new System.Drawing.Size(406, 112);
            this.listBoxLog.TabIndex = 0;
            this.listBoxLog.Visible = false;
            // 
            // labelMessage
            // 
            this.labelMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMessage.BackColor = System.Drawing.Color.Transparent;
            this.labelMessage.Location = new System.Drawing.Point(10, 94);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(362, 19);
            this.labelMessage.TabIndex = 1;
            this.labelMessage.Text = "Loading...";
            this.labelMessage.Visible = false;
            // 
            // progressBarMain
            // 
            this.progressBarMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBarMain.Location = new System.Drawing.Point(0, 116);
            this.progressBarMain.MarqueeAnimationSpeed = 30;
            this.progressBarMain.Name = "progressBarMain";
            this.progressBarMain.Size = new System.Drawing.Size(386, 23);
            this.progressBarMain.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBarMain.TabIndex = 2;
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxMain.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMain.Image")));
            this.pictureBoxMain.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(386, 116);
            this.pictureBoxMain.TabIndex = 3;
            this.pictureBoxMain.TabStop = false;
            this.pictureBoxMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxMain_Paint);
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.Font = new System.Drawing.Font("Gulim", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelTitle.Location = new System.Drawing.Point(10, 72);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(362, 22);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "Title";
            this.labelTitle.Visible = false;
            // 
            // FormSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 139);
            this.ControlBox = false;
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.pictureBoxMain);
            this.Controls.Add(this.progressBarMain);
            this.Controls.Add(this.listBoxLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSplash";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading...";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxLog;
        private System.Windows.Forms.ProgressBar progressBarMain;
        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label labelTitle;
    }
}