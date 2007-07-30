namespace RichBrowser
{
    partial class FormMain
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
            JinwooMin.Logging.LogManager logManager1 = new JinwooMin.Logging.LogManager();
            this.richBrowserControl1 = new JinwooMin.RichBrowserControl.RichBrowserControl();
            this.SuspendLayout();
            // 
            // richBrowserControl1
            // 
            this.richBrowserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richBrowserControl1.Location = new System.Drawing.Point(0, 0);
            logManager1.Options = JinwooMin.Logging.LogOptions.NONE;
            this.richBrowserControl1.Logger = logManager1;
            this.richBrowserControl1.Name = "richBrowserControl1";
            this.richBrowserControl1.ShowAddressToolbar = true;
            this.richBrowserControl1.ShowMenubar = true;
            this.richBrowserControl1.ShowTabToolbar = true;
            this.richBrowserControl1.ShowWebToolbar = true;
            this.richBrowserControl1.Size = new System.Drawing.Size(524, 370);
            this.richBrowserControl1.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 370);
            this.Controls.Add(this.richBrowserControl1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rich Browser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private JinwooMin.RichBrowserControl.RichBrowserControl richBrowserControl1;
    }
}

