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
            this.cEXWB = new csExWB.cEXWB();
            this.SuspendLayout();
            // 
            // cEXWB
            // 
            this.cEXWB.Location = new System.Drawing.Point(24, 23);
            this.cEXWB.LocationUrl = "about:blank";
            this.cEXWB.Name = "cEXWB";
            this.cEXWB.OffLine = false;
            this.cEXWB.RegisterAsBrowser = false;
            this.cEXWB.RegisterAsDropTarget = false;
            this.cEXWB.RegisterForInternalDragDrop = true;
            this.cEXWB.SendSourceOnDocumentCompleteWBEx = false;
            this.cEXWB.Silent = false;
            this.cEXWB.Size = new System.Drawing.Size(206, 173);
            this.cEXWB.TabIndex = 0;
            this.cEXWB.Text = "cEXWB1";
            this.cEXWB.TextSize = IfacesEnumsStructsClasses.TextSizeWB.Medium;
            this.cEXWB.WBDOCDOWNLOADCTLFLAG = 112;
            this.cEXWB.WBDOCHOSTUIDBLCLK = IfacesEnumsStructsClasses.DOCHOSTUIDBLCLK.DEFAULT;
            this.cEXWB.WBDOCHOSTUIFLAG = 262276;
            this.cEXWB.TitleChange += new csExWB.TitleChangeEventHandler(this.cEXWB_TitleChange);
            this.cEXWB.LocationChanged += new System.EventHandler(this.cEXWB_LocationChanged);
            this.cEXWB.DocumentComplete += new csExWB.DocumentCompleteEventHandler(this.cEXWB_DocumentComplete);
            // 
            // WebBrowserDockContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.cEXWB);
            this.Name = "WebBrowserDockContent";
            this.TabText = "WebBrowserDockContent";
            this.Text = "WebBrowserDockContent";
            this.Load += new System.EventHandler(this.WebBrowserDockContent_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private csExWB.cEXWB cEXWB;
    }
}