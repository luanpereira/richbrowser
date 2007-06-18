namespace JinwooMin.RichBrowserControl
{
    /// <summary>
    /// TODO
    /// </summary>
    partial class RichBrowserControl
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolbarsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.nextTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previousTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBarMain = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripContainerMain = new System.Windows.Forms.ToolStripContainer();
            this.dockPanelMain = new WeifenLuo.WinFormsUI.DockPanel();
            this.toolStripTab = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonCloseTab = new System.Windows.Forms.ToolStripButton();
            this.toolStripWeb = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelWeb = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonBack = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonForward = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonStop = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonHome = new System.Windows.Forms.ToolStripButton();
            this.toolStripAddress = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelAddress = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxAddress = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonGo = new System.Windows.Forms.ToolStripButton();
            this.menuStripMain.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.toolStripContainerMain.ContentPanel.SuspendLayout();
            this.toolStripContainerMain.TopToolStripPanel.SuspendLayout();
            this.toolStripContainerMain.SuspendLayout();
            this.toolStripTab.SuspendLayout();
            this.toolStripWeb.SuspendLayout();
            this.toolStripAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(657, 24);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeTabToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = global::JinwooMin.RichBrowserControl.Properties.Resources.MENU_FILE;
            // 
            // closeTabToolStripMenuItem
            // 
            this.closeTabToolStripMenuItem.Name = "closeTabToolStripMenuItem";
            this.closeTabToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.closeTabToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.closeTabToolStripMenuItem.Text = global::JinwooMin.RichBrowserControl.Properties.Resources.MENU_CLOSE_TAB;
            this.closeTabToolStripMenuItem.Click += new System.EventHandler(this.closeTabToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(172, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.exitToolStripMenuItem.Text = global::JinwooMin.RichBrowserControl.Properties.Resources.MENU_EXIT;
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbarsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.nextTabToolStripMenuItem,
            this.previousTabToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.viewToolStripMenuItem.Text = global::JinwooMin.RichBrowserControl.Properties.Resources.MENU_VIEW;
            // 
            // toolbarsToolStripMenuItem
            // 
            this.toolbarsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addressToolStripMenuItem,
            this.tabToolStripMenuItem,
            this.webToolStripMenuItem});
            this.toolbarsToolStripMenuItem.Name = "toolbarsToolStripMenuItem";
            this.toolbarsToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.toolbarsToolStripMenuItem.Text = global::JinwooMin.RichBrowserControl.Properties.Resources.MENU_TOOLBARS;
            // 
            // addressToolStripMenuItem
            // 
            this.addressToolStripMenuItem.Checked = true;
            this.addressToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.addressToolStripMenuItem.Name = "addressToolStripMenuItem";
            this.addressToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.addressToolStripMenuItem.Text = global::JinwooMin.RichBrowserControl.Properties.Resources.MENU_ADDRESS;
            this.addressToolStripMenuItem.Click += new System.EventHandler(this.addressToolStripMenuItem_Click);
            // 
            // tabToolStripMenuItem
            // 
            this.tabToolStripMenuItem.Checked = true;
            this.tabToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tabToolStripMenuItem.Name = "tabToolStripMenuItem";
            this.tabToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.tabToolStripMenuItem.Text = global::JinwooMin.RichBrowserControl.Properties.Resources.MENU_TAB;
            this.tabToolStripMenuItem.Click += new System.EventHandler(this.tabToolStripMenuItem_Click);
            // 
            // webToolStripMenuItem
            // 
            this.webToolStripMenuItem.Checked = true;
            this.webToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.webToolStripMenuItem.Name = "webToolStripMenuItem";
            this.webToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.webToolStripMenuItem.Text = global::JinwooMin.RichBrowserControl.Properties.Resources.MENU_WEB;
            this.webToolStripMenuItem.Click += new System.EventHandler(this.webToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(237, 6);
            // 
            // nextTabToolStripMenuItem
            // 
            this.nextTabToolStripMenuItem.Name = "nextTabToolStripMenuItem";
            this.nextTabToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Tab)));
            this.nextTabToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.nextTabToolStripMenuItem.Text = global::JinwooMin.RichBrowserControl.Properties.Resources.MENU_NEXT_TAB;
            this.nextTabToolStripMenuItem.Click += new System.EventHandler(this.nextTabToolStripMenuItem_Click);
            // 
            // previousTabToolStripMenuItem
            // 
            this.previousTabToolStripMenuItem.Name = "previousTabToolStripMenuItem";
            this.previousTabToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.Tab)));
            this.previousTabToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.previousTabToolStripMenuItem.Text = global::JinwooMin.RichBrowserControl.Properties.Resources.MENU_PREV_TAB;
            this.previousTabToolStripMenuItem.Click += new System.EventHandler(this.previousTabToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.toolsToolStripMenuItem.Text = global::JinwooMin.RichBrowserControl.Properties.Resources.MENU_TOOLS;
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.optionsToolStripMenuItem.Text = global::JinwooMin.RichBrowserControl.Properties.Resources.MENU_OPTIONS;
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.toolStripMenuItem3});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.helpToolStripMenuItem.Text = global::JinwooMin.RichBrowserControl.Properties.Resources.MENU_HELP;
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.aboutToolStripMenuItem.Text = global::JinwooMin.RichBrowserControl.Properties.Resources.MENU_INFORMATION;
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(105, 6);
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelMessage,
            this.toolStripProgressBarMain});
            this.statusStripMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStripMain.Location = new System.Drawing.Point(0, 230);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(657, 22);
            this.statusStripMain.TabIndex = 5;
            // 
            // toolStripStatusLabelMessage
            // 
            this.toolStripStatusLabelMessage.Name = "toolStripStatusLabelMessage";
            this.toolStripStatusLabelMessage.Size = new System.Drawing.Size(41, 17);
            this.toolStripStatusLabelMessage.Text = global::JinwooMin.RichBrowserControl.Properties.Resources.MSG_READY;
            // 
            // toolStripProgressBarMain
            // 
            this.toolStripProgressBarMain.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripProgressBarMain.Name = "toolStripProgressBarMain";
            this.toolStripProgressBarMain.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripContainerMain
            // 
            // 
            // toolStripContainerMain.ContentPanel
            // 
            this.toolStripContainerMain.ContentPanel.Controls.Add(this.dockPanelMain);
            this.toolStripContainerMain.ContentPanel.Size = new System.Drawing.Size(657, 156);
            this.toolStripContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainerMain.Location = new System.Drawing.Point(0, 24);
            this.toolStripContainerMain.Name = "toolStripContainerMain";
            this.toolStripContainerMain.Size = new System.Drawing.Size(657, 206);
            this.toolStripContainerMain.TabIndex = 6;
            this.toolStripContainerMain.Text = "toolStripContainer1";
            // 
            // toolStripContainerMain.TopToolStripPanel
            // 
            this.toolStripContainerMain.TopToolStripPanel.Controls.Add(this.toolStripTab);
            this.toolStripContainerMain.TopToolStripPanel.Controls.Add(this.toolStripWeb);
            this.toolStripContainerMain.TopToolStripPanel.Controls.Add(this.toolStripAddress);
            // 
            // dockPanelMain
            // 
            this.dockPanelMain.ActiveAutoHideContent = null;
            this.dockPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanelMain.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.dockPanelMain.Location = new System.Drawing.Point(0, 0);
            this.dockPanelMain.Name = "dockPanelMain";
            this.dockPanelMain.ShowDocumentIcon = true;
            this.dockPanelMain.Size = new System.Drawing.Size(657, 156);
            this.dockPanelMain.TabIndex = 0;
            // 
            // toolStripTab
            // 
            this.toolStripTab.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripTab.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator4,
            this.toolStripButtonCloseTab});
            this.toolStripTab.Location = new System.Drawing.Point(3, 0);
            this.toolStripTab.Name = "toolStripTab";
            this.toolStripTab.Size = new System.Drawing.Size(110, 25);
            this.toolStripTab.TabIndex = 3;
            this.toolStripTab.Text = "Tab";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(27, 22);
            this.toolStripLabel1.Text = global::JinwooMin.RichBrowserControl.Properties.Resources.LABEL_TAB;
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonCloseTab
            // 
            this.toolStripButtonCloseTab.Image = global::JinwooMin.RichBrowserControl.Properties.Resources.Close;
            this.toolStripButtonCloseTab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCloseTab.Name = "toolStripButtonCloseTab";
            this.toolStripButtonCloseTab.Size = new System.Drawing.Size(65, 22);
            this.toolStripButtonCloseTab.Text = global::JinwooMin.RichBrowserControl.Properties.Resources.LABEL_CLOSE_TAB;
            this.toolStripButtonCloseTab.Click += new System.EventHandler(this.toolStripButtonCloseTab_Click);
            // 
            // toolStripWeb
            // 
            this.toolStripWeb.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripWeb.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelWeb,
            this.toolStripSeparator3,
            this.toolStripButtonNew,
            this.toolStripSeparator1,
            this.toolStripButtonBack,
            this.toolStripButtonForward,
            this.toolStripSeparator2,
            this.toolStripButtonStop,
            this.toolStripButtonRefresh,
            this.toolStripButtonHome});
            this.toolStripWeb.Location = new System.Drawing.Point(113, 0);
            this.toolStripWeb.Name = "toolStripWeb";
            this.toolStripWeb.Size = new System.Drawing.Size(255, 25);
            this.toolStripWeb.TabIndex = 1;
            this.toolStripWeb.Text = "Web";
            // 
            // toolStripLabelWeb
            // 
            this.toolStripLabelWeb.Name = "toolStripLabelWeb";
            this.toolStripLabelWeb.Size = new System.Drawing.Size(29, 22);
            this.toolStripLabelWeb.Text = global::JinwooMin.RichBrowserControl.Properties.Resources.LABEL_WEB;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonNew
            // 
            this.toolStripButtonNew.Image = global::JinwooMin.RichBrowserControl.Properties.Resources.new_16;
            this.toolStripButtonNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNew.Name = "toolStripButtonNew";
            this.toolStripButtonNew.Size = new System.Drawing.Size(51, 22);
            this.toolStripButtonNew.Text = global::JinwooMin.RichBrowserControl.Properties.Resources.LABEL_NEW;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonBack
            // 
            this.toolStripButtonBack.Image = global::JinwooMin.RichBrowserControl.Properties.Resources.back_16;
            this.toolStripButtonBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBack.Name = "toolStripButtonBack";
            this.toolStripButtonBack.Size = new System.Drawing.Size(53, 22);
            this.toolStripButtonBack.Text = global::JinwooMin.RichBrowserControl.Properties.Resources.LABEL_BACK;
            // 
            // toolStripButtonForward
            // 
            this.toolStripButtonForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonForward.Image = global::JinwooMin.RichBrowserControl.Properties.Resources.forwd_16;
            this.toolStripButtonForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonForward.Name = "toolStripButtonForward";
            this.toolStripButtonForward.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonForward.Text = global::JinwooMin.RichBrowserControl.Properties.Resources.LABEL_FORWARD;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonStop
            // 
            this.toolStripButtonStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonStop.Image = global::JinwooMin.RichBrowserControl.Properties.Resources.cancl_16;
            this.toolStripButtonStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStop.Name = "toolStripButtonStop";
            this.toolStripButtonStop.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonStop.Text = global::JinwooMin.RichBrowserControl.Properties.Resources.LABEL_STOP;
            // 
            // toolStripButtonRefresh
            // 
            this.toolStripButtonRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRefresh.Image = global::JinwooMin.RichBrowserControl.Properties.Resources.ref_16;
            this.toolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRefresh.Name = "toolStripButtonRefresh";
            this.toolStripButtonRefresh.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRefresh.Text = global::JinwooMin.RichBrowserControl.Properties.Resources.LABEL_REFRESH;
            // 
            // toolStripButtonHome
            // 
            this.toolStripButtonHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonHome.Image = global::JinwooMin.RichBrowserControl.Properties.Resources.Home;
            this.toolStripButtonHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonHome.Name = "toolStripButtonHome";
            this.toolStripButtonHome.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonHome.Text = global::JinwooMin.RichBrowserControl.Properties.Resources.LABEL_HOME;
            // 
            // toolStripAddress
            // 
            this.toolStripAddress.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripAddress.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelAddress,
            this.toolStripTextBoxAddress,
            this.toolStripButtonGo});
            this.toolStripAddress.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStripAddress.Location = new System.Drawing.Point(3, 25);
            this.toolStripAddress.Name = "toolStripAddress";
            this.toolStripAddress.Size = new System.Drawing.Size(489, 25);
            this.toolStripAddress.TabIndex = 2;
            this.toolStripAddress.Text = "A&ddress";
            // 
            // toolStripLabelAddress
            // 
            this.toolStripLabelAddress.Name = "toolStripLabelAddress";
            this.toolStripLabelAddress.Size = new System.Drawing.Size(52, 22);
            this.toolStripLabelAddress.Text = global::JinwooMin.RichBrowserControl.Properties.Resources.LABEL_ADDRESS;
            // 
            // toolStripTextBoxAddress
            // 
            this.toolStripTextBoxAddress.Name = "toolStripTextBoxAddress";
            this.toolStripTextBoxAddress.Size = new System.Drawing.Size(400, 25);
            // 
            // toolStripButtonGo
            // 
            this.toolStripButtonGo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonGo.Image = global::JinwooMin.RichBrowserControl.Properties.Resources.Play;
            this.toolStripButtonGo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGo.Name = "toolStripButtonGo";
            this.toolStripButtonGo.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonGo.Text = global::JinwooMin.RichBrowserControl.Properties.Resources.LABEL_GO;
            // 
            // RichBrowserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStripContainerMain);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.menuStripMain);
            this.Name = "RichBrowserControl";
            this.Size = new System.Drawing.Size(657, 252);
            this.Load += new System.EventHandler(this.RichBrowserControl_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.toolStripContainerMain.ContentPanel.ResumeLayout(false);
            this.toolStripContainerMain.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainerMain.TopToolStripPanel.PerformLayout();
            this.toolStripContainerMain.ResumeLayout(false);
            this.toolStripContainerMain.PerformLayout();
            this.toolStripTab.ResumeLayout(false);
            this.toolStripTab.PerformLayout();
            this.toolStripWeb.ResumeLayout(false);
            this.toolStripWeb.PerformLayout();
            this.toolStripAddress.ResumeLayout(false);
            this.toolStripAddress.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMessage;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBarMain;
        private System.Windows.Forms.ToolStripContainer toolStripContainerMain;
        private WeifenLuo.WinFormsUI.DockPanel dockPanelMain;
        private System.Windows.Forms.ToolStrip toolStripWeb;
        private System.Windows.Forms.ToolStripButton toolStripButtonNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonBack;
        private System.Windows.Forms.ToolStripButton toolStripButtonForward;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonStop;
        private System.Windows.Forms.ToolStripButton toolStripButtonRefresh;
        private System.Windows.Forms.ToolStripButton toolStripButtonHome;
        private System.Windows.Forms.ToolStrip toolStripAddress;
        private System.Windows.Forms.ToolStripLabel toolStripLabelAddress;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxAddress;
        private System.Windows.Forms.ToolStripButton toolStripButtonGo;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previousTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabelWeb;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStrip toolStripTab;
        private System.Windows.Forms.ToolStripButton toolStripButtonCloseTab;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolbarsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;

    }
}
