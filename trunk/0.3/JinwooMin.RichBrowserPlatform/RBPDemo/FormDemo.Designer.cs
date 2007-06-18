namespace RBPDemo
{
    partial class FormDemo
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
            this.richBrowserControl1 = new JinwooMin.RichBrowserControl.RichBrowserControl();
            this.SuspendLayout();
            // 
            // richBrowserControl1
            // 
            this.richBrowserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richBrowserControl1.Location = new System.Drawing.Point(0, 0);
            this.richBrowserControl1.Name = "richBrowserControl1";
            this.richBrowserControl1.Size = new System.Drawing.Size(691, 321);
            this.richBrowserControl1.TabIndex = 0;
            // 
            // FormDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 321);
            this.Controls.Add(this.richBrowserControl1);
            this.Name = "FormDemo";
            this.Text = "FormDemo";
            this.ResumeLayout(false);

        }

        #endregion

        private JinwooMin.RichBrowserControl.RichBrowserControl richBrowserControl1;

    }
}