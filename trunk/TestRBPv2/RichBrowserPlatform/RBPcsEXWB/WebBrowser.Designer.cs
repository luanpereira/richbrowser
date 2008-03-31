namespace RBPcsEXWB
{
    partial class WebBrowser
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
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
            this.cEXWBMain.FileDownloadDirectory = "C:\\Users\\mio\\Documents\\";
            this.cEXWBMain.IsLeftMouseClicked = false;
            this.cEXWBMain.Location = new System.Drawing.Point(30, 58);
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
            this.cEXWBMain.Size = new System.Drawing.Size(87, 58);
            this.cEXWBMain.TabIndex = 0;
            this.cEXWBMain.Text = "cEXWBMain";
            this.cEXWBMain.TextSize = IfacesEnumsStructsClasses.TextSizeWB.Medium;
            this.cEXWBMain.UseInternalDownloadManager = true;
            this.cEXWBMain.WBDOCDOWNLOADCTLFLAG = 112;
            this.cEXWBMain.WBDOCHOSTUIDBLCLK = IfacesEnumsStructsClasses.DOCHOSTUIDBLCLK.DEFAULT;
            this.cEXWBMain.WBDOCHOSTUIFLAG = 262276;
            // 
            // WebBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cEXWBMain);
            this.Name = "WebBrowser";
            this.ResumeLayout(false);

        }

        #endregion

        private csExWB.cEXWB cEXWBMain;
    }
}
