namespace RBPGUI.RegEx
{
    partial class DockContentRegEx
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DockContentRegEx));
            this.textBoxContent = new System.Windows.Forms.TextBox();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonLoad = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBoxPattern = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonMatch = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabelCount = new System.Windows.Forms.ToolStripLabel();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripTextBoxUserAgent = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonClear = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCopy = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPaste = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonIgnoreCase = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMain.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxContent
            // 
            this.textBoxContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxContent.Location = new System.Drawing.Point(0, 50);
            this.textBoxContent.Multiline = true;
            this.textBoxContent.Name = "textBoxContent";
            this.textBoxContent.Size = new System.Drawing.Size(358, 162);
            this.textBoxContent.TabIndex = 0;
            // 
            // toolStripMain
            // 
            this.toolStripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonLoad,
            this.toolStripButtonSave,
            this.toolStripSeparator4,
            this.toolStripTextBoxPattern,
            this.toolStripButtonMatch,
            this.toolStripSeparator3,
            this.toolStripLabelCount});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(358, 25);
            this.toolStripMain.TabIndex = 1;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // toolStripButtonLoad
            // 
            this.toolStripButtonLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonLoad.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLoad.Image")));
            this.toolStripButtonLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLoad.Name = "toolStripButtonLoad";
            this.toolStripButtonLoad.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonLoad.Text = "toolStripButton1";
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSave.Text = "toolStripButton1";
            // 
            // toolStripTextBoxPattern
            // 
            this.toolStripTextBoxPattern.Name = "toolStripTextBoxPattern";
            this.toolStripTextBoxPattern.Size = new System.Drawing.Size(200, 25);
            // 
            // toolStripButtonMatch
            // 
            this.toolStripButtonMatch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonMatch.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonMatch.Image")));
            this.toolStripButtonMatch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMatch.Name = "toolStripButtonMatch";
            this.toolStripButtonMatch.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonMatch.Text = "toolStripButton2";
            // 
            // toolStripLabelCount
            // 
            this.toolStripLabelCount.Name = "toolStripLabelCount";
            this.toolStripLabelCount.Size = new System.Drawing.Size(38, 22);
            this.toolStripLabelCount.Text = "Count";
            // 
            // listBoxResult
            // 
            this.listBoxResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.ItemHeight = 12;
            this.listBoxResult.Location = new System.Drawing.Point(0, 212);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(358, 76);
            this.listBoxResult.TabIndex = 2;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxResult.Location = new System.Drawing.Point(0, 288);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(358, 65);
            this.textBoxResult.TabIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxUserAgent,
            this.toolStripButtonIgnoreCase,
            this.toolStripSeparator1,
            this.toolStripButtonClear,
            this.toolStripSeparator2,
            this.toolStripButtonCopy,
            this.toolStripButtonPaste});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(358, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripTextBoxUserAgent
            // 
            this.toolStripTextBoxUserAgent.Name = "toolStripTextBoxUserAgent";
            this.toolStripTextBoxUserAgent.Size = new System.Drawing.Size(200, 25);
            // 
            // toolStripButtonClear
            // 
            this.toolStripButtonClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonClear.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonClear.Image")));
            this.toolStripButtonClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClear.Name = "toolStripButtonClear";
            this.toolStripButtonClear.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonClear.Text = "toolStripButton1";
            // 
            // toolStripButtonCopy
            // 
            this.toolStripButtonCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCopy.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCopy.Image")));
            this.toolStripButtonCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCopy.Name = "toolStripButtonCopy";
            this.toolStripButtonCopy.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonCopy.Text = "toolStripButton2";
            // 
            // toolStripButtonPaste
            // 
            this.toolStripButtonPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPaste.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPaste.Image")));
            this.toolStripButtonPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPaste.Name = "toolStripButtonPaste";
            this.toolStripButtonPaste.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonPaste.Text = "toolStripButton3";
            // 
            // toolStripButtonIgnoreCase
            // 
            this.toolStripButtonIgnoreCase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonIgnoreCase.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonIgnoreCase.Image")));
            this.toolStripButtonIgnoreCase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonIgnoreCase.Name = "toolStripButtonIgnoreCase";
            this.toolStripButtonIgnoreCase.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonIgnoreCase.Text = "toolStripButton1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // DockContentRegEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 353);
            this.Controls.Add(this.textBoxContent);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.toolStripMain);
            this.Name = "DockContentRegEx";
            this.TabText = "DockContentRegEx";
            this.Text = "DockContentRegEx";
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxContent;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton toolStripButtonLoad;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxPattern;
        private System.Windows.Forms.ListBox listBoxResult;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.ToolStripButton toolStripButtonMatch;
        private System.Windows.Forms.ToolStripLabel toolStripLabelCount;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxUserAgent;
        private System.Windows.Forms.ToolStripButton toolStripButtonIgnoreCase;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonClear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonCopy;
        private System.Windows.Forms.ToolStripButton toolStripButtonPaste;
    }
}