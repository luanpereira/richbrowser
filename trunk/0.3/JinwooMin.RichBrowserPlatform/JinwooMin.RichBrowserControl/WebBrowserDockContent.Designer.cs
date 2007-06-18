namespace JinwooMin.RichBrowserControl
{
    partial class WebBrowserDockContent
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
            this.webBrowserWrapperControl1 = new JinwooMin.RichBrowserControl.WebBrowserWrapperControl();
            this.SuspendLayout();
            // 
            // webBrowserWrapperControl1
            // 
            this.webBrowserWrapperControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserWrapperControl1.Location = new System.Drawing.Point(0, 0);
            this.webBrowserWrapperControl1.Name = "webBrowserWrapperControl1";
            this.webBrowserWrapperControl1.Size = new System.Drawing.Size(546, 236);
            this.webBrowserWrapperControl1.TabIndex = 0;
            // 
            // WebBrowserDockContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 236);
            this.Controls.Add(this.webBrowserWrapperControl1);
            this.Name = "WebBrowserDockContent";
            this.Text = "WebBrowserDockContent";
            this.ResumeLayout(false);

        }

        #endregion

        private WebBrowserWrapperControl webBrowserWrapperControl1;
    }
}