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
            this.cEXWBMain = new csExWB.cEXWB();
            this.SuspendLayout();
            // 
            // cEXWBMain
            // 
            this.cEXWBMain.Border3DEnabled = false;
            this.cEXWBMain.DocumentSource = "<HTML><HEAD></HEAD>\r\n<BODY></BODY></HTML>";
            this.cEXWBMain.DocumentTitle = "";
            this.cEXWBMain.DownloadActiveX = true;
            this.cEXWBMain.DownloadFrames = true;
            this.cEXWBMain.DownloadImages = true;
            this.cEXWBMain.DownloadJava = true;
            this.cEXWBMain.DownloadScripts = true;
            this.cEXWBMain.DownloadSounds = true;
            this.cEXWBMain.DownloadVideo = true;
            this.cEXWBMain.FileDownloadDirectory = "C:\\Documents and Settings\\mio\\My Documents\\";
            this.cEXWBMain.Location = new System.Drawing.Point(31, 43);
            this.cEXWBMain.LocationUrl = "about:blank";
            this.cEXWBMain.Name = "cEXWBMain";
            this.cEXWBMain.ObjectForScripting = null;
            this.cEXWBMain.OffLine = false;
            this.cEXWBMain.RegisterAsBrowser = false;
            this.cEXWBMain.RegisterAsDropTarget = false;
            this.cEXWBMain.RegisterForInternalDragDrop = true;
            this.cEXWBMain.ScrollBarsEnabled = true;
            this.cEXWBMain.SendSourceOnDocumentCompleteWBEx = false;
            this.cEXWBMain.Silent = false;
            this.cEXWBMain.Size = new System.Drawing.Size(215, 181);
            this.cEXWBMain.TabIndex = 0;
            this.cEXWBMain.Text = "cEXWBMain";
            this.cEXWBMain.TextSize = IfacesEnumsStructsClasses.TextSizeWB.Medium;
            this.cEXWBMain.UseInternalDownloadManager = true;
            this.cEXWBMain.WBDOCDOWNLOADCTLFLAG = 112;
            this.cEXWBMain.WBDOCHOSTUIDBLCLK = IfacesEnumsStructsClasses.DOCHOSTUIDBLCLK.DEFAULT;
            this.cEXWBMain.WBDOCHOSTUIFLAG = 262276;
            // 
            // WebBrowserDockContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.cEXWBMain);
            this.Name = "WebBrowserDockContent";
            this.TabText = "WebBrowserDockContent";
            this.Text = "WebBrowserDockContent";
            this.Load += new System.EventHandler(this.WebBrowserDockContent_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private csExWB.cEXWB cEXWBMain;

    }
}