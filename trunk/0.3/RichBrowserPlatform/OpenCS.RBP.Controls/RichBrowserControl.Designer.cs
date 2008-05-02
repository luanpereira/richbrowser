namespace OpenCS.RBP.Controls
{
    partial class RichBrowserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RichBrowserControl));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pluginsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainerMain = new System.Windows.Forms.ToolStripContainer();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.dockPanelMain = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.toolStripPlugins = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelPlugins = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonLoad = new System.Windows.Forms.ToolStripButton();
            this.toolStripAddress = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxUrl = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonGo = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelWeb = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonBack = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonForward = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonStop = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonHome = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStripMain.SuspendLayout();
            this.toolStripContainerMain.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainerMain.ContentPanel.SuspendLayout();
            this.toolStripContainerMain.TopToolStripPanel.SuspendLayout();
            this.toolStripContainerMain.SuspendLayout();
            this.toolStripPlugins.SuspendLayout();
            this.toolStripAddress.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.pluginsToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(824, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // pluginsToolStripMenuItem
            // 
            this.pluginsToolStripMenuItem.Name = "pluginsToolStripMenuItem";
            this.pluginsToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.pluginsToolStripMenuItem.Text = "Plugins";
            // 
            // toolStripContainerMain
            // 
            // 
            // toolStripContainerMain.BottomToolStripPanel
            // 
            this.toolStripContainerMain.BottomToolStripPanel.Controls.Add(this.statusStripMain);
            // 
            // toolStripContainerMain.ContentPanel
            // 
            this.toolStripContainerMain.ContentPanel.Controls.Add(this.dockPanelMain);
            this.toolStripContainerMain.ContentPanel.Size = new System.Drawing.Size(824, 302);
            this.toolStripContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainerMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainerMain.Name = "toolStripContainerMain";
            this.toolStripContainerMain.Size = new System.Drawing.Size(824, 398);
            this.toolStripContainerMain.TabIndex = 1;
            this.toolStripContainerMain.Text = "toolStripContainer1";
            // 
            // toolStripContainerMain.TopToolStripPanel
            // 
            this.toolStripContainerMain.TopToolStripPanel.Controls.Add(this.menuStripMain);
            this.toolStripContainerMain.TopToolStripPanel.Controls.Add(this.toolStripPlugins);
            this.toolStripContainerMain.TopToolStripPanel.Controls.Add(this.toolStripAddress);
            this.toolStripContainerMain.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // statusStripMain
            // 
            this.statusStripMain.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStripMain.Location = new System.Drawing.Point(0, 0);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(824, 22);
            this.statusStripMain.TabIndex = 0;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // dockPanelMain
            // 
            this.dockPanelMain.ActiveAutoHideContent = null;
            this.dockPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanelMain.Location = new System.Drawing.Point(0, 0);
            this.dockPanelMain.Name = "dockPanelMain";
            this.dockPanelMain.Size = new System.Drawing.Size(824, 302);
            this.dockPanelMain.TabIndex = 0;
            // 
            // toolStripPlugins
            // 
            this.toolStripPlugins.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripPlugins.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelPlugins,
            this.toolStripButtonLoad});
            this.toolStripPlugins.Location = new System.Drawing.Point(445, 24);
            this.toolStripPlugins.Name = "toolStripPlugins";
            this.toolStripPlugins.Size = new System.Drawing.Size(151, 25);
            this.toolStripPlugins.TabIndex = 1;
            // 
            // toolStripLabelPlugins
            // 
            this.toolStripLabelPlugins.Name = "toolStripLabelPlugins";
            this.toolStripLabelPlugins.Size = new System.Drawing.Size(49, 22);
            this.toolStripLabelPlugins.Text = "Plugins:";
            // 
            // toolStripButtonLoad
            // 
            this.toolStripButtonLoad.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLoad.Image")));
            this.toolStripButtonLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLoad.Name = "toolStripButtonLoad";
            this.toolStripButtonLoad.Size = new System.Drawing.Size(92, 22);
            this.toolStripButtonLoad.Text = "LoadPlugins";
            this.toolStripButtonLoad.Click += new System.EventHandler(this.toolStripButtonLoad_Click);
            // 
            // toolStripAddress
            // 
            this.toolStripAddress.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripAddress.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripTextBoxUrl,
            this.toolStripButtonGo});
            this.toolStripAddress.Location = new System.Drawing.Point(3, 49);
            this.toolStripAddress.Name = "toolStripAddress";
            this.toolStripAddress.Size = new System.Drawing.Size(506, 25);
            this.toolStripAddress.TabIndex = 2;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(52, 22);
            this.toolStripLabel1.Text = "Address:";
            // 
            // toolStripTextBoxUrl
            // 
            this.toolStripTextBoxUrl.Name = "toolStripTextBoxUrl";
            this.toolStripTextBoxUrl.Size = new System.Drawing.Size(400, 25);
            this.toolStripTextBoxUrl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox1_KeyDown);
            // 
            // toolStripButtonGo
            // 
            this.toolStripButtonGo.Image = global::OpenCS.RBP.Controls.Properties.Resources.Play;
            this.toolStripButtonGo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGo.Name = "toolStripButtonGo";
            this.toolStripButtonGo.Size = new System.Drawing.Size(42, 22);
            this.toolStripButtonGo.Text = "Go";
            this.toolStripButtonGo.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelWeb,
            this.toolStripButtonNew,
            this.toolStripSeparator2,
            this.toolStripButtonBack,
            this.toolStripButtonForward,
            this.toolStripSeparator1,
            this.toolStripButtonStop,
            this.toolStripButtonRefresh,
            this.toolStripButtonHome});
            this.toolStrip1.Location = new System.Drawing.Point(3, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(438, 25);
            this.toolStrip1.TabIndex = 3;
            // 
            // toolStripLabelWeb
            // 
            this.toolStripLabelWeb.Name = "toolStripLabelWeb";
            this.toolStripLabelWeb.Size = new System.Drawing.Size(34, 36);
            this.toolStripLabelWeb.Text = "Web:";
            // 
            // toolStripButtonNew
            // 
            this.toolStripButtonNew.Image = global::OpenCS.RBP.Controls.Properties.Resources.new_16;
            this.toolStripButtonNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNew.Name = "toolStripButtonNew";
            this.toolStripButtonNew.Size = new System.Drawing.Size(67, 36);
            this.toolStripButtonNew.Text = "New";
            this.toolStripButtonNew.Click += new System.EventHandler(this.OnWebButtonClick);
            // 
            // toolStripButtonBack
            // 
            this.toolStripButtonBack.Image = global::OpenCS.RBP.Controls.Properties.Resources.back_16;
            this.toolStripButtonBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBack.Name = "toolStripButtonBack";
            this.toolStripButtonBack.Size = new System.Drawing.Size(68, 36);
            this.toolStripButtonBack.Text = "Back";
            this.toolStripButtonBack.Click += new System.EventHandler(this.OnWebButtonClick);
            // 
            // toolStripButtonForward
            // 
            this.toolStripButtonForward.Image = global::OpenCS.RBP.Controls.Properties.Resources.forwd_16;
            this.toolStripButtonForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonForward.Name = "toolStripButtonForward";
            this.toolStripButtonForward.Size = new System.Drawing.Size(86, 36);
            this.toolStripButtonForward.Text = "Forward";
            this.toolStripButtonForward.Click += new System.EventHandler(this.OnWebButtonClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripButtonStop
            // 
            this.toolStripButtonStop.Image = global::OpenCS.RBP.Controls.Properties.Resources.stop_16;
            this.toolStripButtonStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStop.Name = "toolStripButtonStop";
            this.toolStripButtonStop.Size = new System.Drawing.Size(68, 36);
            this.toolStripButtonStop.Text = "Stop";
            this.toolStripButtonStop.Click += new System.EventHandler(this.OnWebButtonClick);
            // 
            // toolStripButtonRefresh
            // 
            this.toolStripButtonRefresh.Image = global::OpenCS.RBP.Controls.Properties.Resources.Refresh;
            this.toolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRefresh.Name = "toolStripButtonRefresh";
            this.toolStripButtonRefresh.Size = new System.Drawing.Size(82, 36);
            this.toolStripButtonRefresh.Text = "Refresh";
            this.toolStripButtonRefresh.Click += new System.EventHandler(this.OnWebButtonClick);
            // 
            // toolStripButtonHome
            // 
            this.toolStripButtonHome.Image = global::OpenCS.RBP.Controls.Properties.Resources.home_16;
            this.toolStripButtonHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonHome.Name = "toolStripButtonHome";
            this.toolStripButtonHome.Size = new System.Drawing.Size(76, 36);
            this.toolStripButtonHome.Text = "Home";
            this.toolStripButtonHome.Click += new System.EventHandler(this.OnWebButtonClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // RichBrowserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStripContainerMain);
            this.Name = "RichBrowserControl";
            this.Size = new System.Drawing.Size(824, 398);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.toolStripContainerMain.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainerMain.BottomToolStripPanel.PerformLayout();
            this.toolStripContainerMain.ContentPanel.ResumeLayout(false);
            this.toolStripContainerMain.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainerMain.TopToolStripPanel.PerformLayout();
            this.toolStripContainerMain.ResumeLayout(false);
            this.toolStripContainerMain.PerformLayout();
            this.toolStripPlugins.ResumeLayout(false);
            this.toolStripPlugins.PerformLayout();
            this.toolStripAddress.ResumeLayout(false);
            this.toolStripAddress.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripContainer toolStripContainerMain;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanelMain;
        private System.Windows.Forms.ToolStrip toolStripPlugins;
        private System.Windows.Forms.ToolStripButton toolStripButtonLoad;
        private System.Windows.Forms.ToolStrip toolStripAddress;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxUrl;
        private System.Windows.Forms.ToolStripButton toolStripButtonGo;
        private System.Windows.Forms.ToolStripMenuItem pluginsToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabelPlugins;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabelWeb;
        private System.Windows.Forms.ToolStripButton toolStripButtonBack;
        private System.Windows.Forms.ToolStripButton toolStripButtonForward;
        private System.Windows.Forms.ToolStripButton toolStripButtonNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonStop;
        private System.Windows.Forms.ToolStripButton toolStripButtonRefresh;
        private System.Windows.Forms.ToolStripButton toolStripButtonHome;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}
