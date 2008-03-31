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
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonPasteContents = new System.Windows.Forms.Button();
            this.buttonCopyContents = new System.Windows.Forms.Button();
            this.textBoxFilename = new System.Windows.Forms.TextBox();
            this.comboBoxUserAgent = new System.Windows.Forms.ComboBox();
            this.checkBoxIgnoreCase = new System.Windows.Forms.CheckBox();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMatchDetails = new System.Windows.Forms.TextBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.listBoxMatches = new System.Windows.Forms.ListBox();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.buttonWeb = new System.Windows.Forms.Button();
            this.textBoxContents = new System.Windows.Forms.TextBox();
            this.textBoxPattern = new System.Windows.Forms.TextBox();
            this.buttonMatch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.Location = new System.Drawing.Point(457, 192);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 47;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // buttonPasteContents
            // 
            this.buttonPasteContents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPasteContents.Location = new System.Drawing.Point(619, 192);
            this.buttonPasteContents.Name = "buttonPasteContents";
            this.buttonPasteContents.Size = new System.Drawing.Size(75, 23);
            this.buttonPasteContents.TabIndex = 46;
            this.buttonPasteContents.Text = "Paste";
            this.buttonPasteContents.UseVisualStyleBackColor = true;
            // 
            // buttonCopyContents
            // 
            this.buttonCopyContents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCopyContents.Location = new System.Drawing.Point(538, 192);
            this.buttonCopyContents.Name = "buttonCopyContents";
            this.buttonCopyContents.Size = new System.Drawing.Size(75, 23);
            this.buttonCopyContents.TabIndex = 45;
            this.buttonCopyContents.Text = "Copy";
            this.buttonCopyContents.UseVisualStyleBackColor = true;
            // 
            // textBoxFilename
            // 
            this.textBoxFilename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFilename.Location = new System.Drawing.Point(275, 12);
            this.textBoxFilename.Name = "textBoxFilename";
            this.textBoxFilename.Size = new System.Drawing.Size(419, 21);
            this.textBoxFilename.TabIndex = 44;
            // 
            // comboBoxUserAgent
            // 
            this.comboBoxUserAgent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxUserAgent.FormattingEnabled = true;
            this.comboBoxUserAgent.Items.AddRange(new object[] {
            "Windows-Media-Player/9.00.00.3349",
            "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1)",
            "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.8.1.3) Gecko/20070309 Firefo" +
                "x/2.0.0.3"});
            this.comboBoxUserAgent.Location = new System.Drawing.Point(89, 41);
            this.comboBoxUserAgent.Name = "comboBoxUserAgent";
            this.comboBoxUserAgent.Size = new System.Drawing.Size(605, 20);
            this.comboBoxUserAgent.TabIndex = 43;
            // 
            // checkBoxIgnoreCase
            // 
            this.checkBoxIgnoreCase.AutoSize = true;
            this.checkBoxIgnoreCase.Location = new System.Drawing.Point(89, 121);
            this.checkBoxIgnoreCase.Name = "checkBoxIgnoreCase";
            this.checkBoxIgnoreCase.Size = new System.Drawing.Size(93, 16);
            this.checkBoxIgnoreCase.TabIndex = 42;
            this.checkBoxIgnoreCase.Text = "Ignore Case";
            this.checkBoxIgnoreCase.UseVisualStyleBackColor = true;
            // 
            // textBoxCount
            // 
            this.textBoxCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxCount.Location = new System.Drawing.Point(89, 194);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(100, 21);
            this.textBoxCount.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 12);
            this.label7.TabIndex = 40;
            this.label7.Text = "Count:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 39;
            this.label1.Text = "User Agent:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 38;
            this.label6.Text = "Details:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 12);
            this.label5.TabIndex = 37;
            this.label5.Text = "Matches:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 36;
            this.label4.Text = "Contents:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 12);
            this.label3.TabIndex = 35;
            this.label3.Text = "Pattern:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 12);
            this.label2.TabIndex = 34;
            this.label2.Text = "URL:";
            // 
            // textBoxMatchDetails
            // 
            this.textBoxMatchDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMatchDetails.Location = new System.Drawing.Point(89, 333);
            this.textBoxMatchDetails.Multiline = true;
            this.textBoxMatchDetails.Name = "textBoxMatchDetails";
            this.textBoxMatchDetails.Size = new System.Drawing.Size(605, 110);
            this.textBoxMatchDetails.TabIndex = 33;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(182, 12);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(87, 21);
            this.buttonLoad.TabIndex = 32;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(89, 12);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(87, 21);
            this.buttonSave.TabIndex = 31;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // listBoxMatches
            // 
            this.listBoxMatches.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxMatches.FormattingEnabled = true;
            this.listBoxMatches.ItemHeight = 12;
            this.listBoxMatches.Location = new System.Drawing.Point(89, 221);
            this.listBoxMatches.Name = "listBoxMatches";
            this.listBoxMatches.Size = new System.Drawing.Size(605, 100);
            this.listBoxMatches.TabIndex = 30;
            // 
            // textBoxURL
            // 
            this.textBoxURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxURL.Location = new System.Drawing.Point(89, 67);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(514, 21);
            this.textBoxURL.TabIndex = 29;
            // 
            // buttonWeb
            // 
            this.buttonWeb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonWeb.Location = new System.Drawing.Point(609, 66);
            this.buttonWeb.Name = "buttonWeb";
            this.buttonWeb.Size = new System.Drawing.Size(85, 21);
            this.buttonWeb.TabIndex = 28;
            this.buttonWeb.Text = "Web";
            this.buttonWeb.UseVisualStyleBackColor = true;
            // 
            // textBoxContents
            // 
            this.textBoxContents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxContents.Location = new System.Drawing.Point(89, 143);
            this.textBoxContents.Multiline = true;
            this.textBoxContents.Name = "textBoxContents";
            this.textBoxContents.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxContents.Size = new System.Drawing.Size(605, 43);
            this.textBoxContents.TabIndex = 27;
            // 
            // textBoxPattern
            // 
            this.textBoxPattern.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPattern.Location = new System.Drawing.Point(89, 94);
            this.textBoxPattern.Name = "textBoxPattern";
            this.textBoxPattern.Size = new System.Drawing.Size(514, 21);
            this.textBoxPattern.TabIndex = 26;
            // 
            // buttonMatch
            // 
            this.buttonMatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMatch.Location = new System.Drawing.Point(609, 94);
            this.buttonMatch.Name = "buttonMatch";
            this.buttonMatch.Size = new System.Drawing.Size(85, 21);
            this.buttonMatch.TabIndex = 25;
            this.buttonMatch.Text = "Match";
            this.buttonMatch.UseVisualStyleBackColor = true;
            // 
            // DockContentRegEx2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 455);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonPasteContents);
            this.Controls.Add(this.buttonCopyContents);
            this.Controls.Add(this.textBoxFilename);
            this.Controls.Add(this.comboBoxUserAgent);
            this.Controls.Add(this.checkBoxIgnoreCase);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxMatchDetails);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.listBoxMatches);
            this.Controls.Add(this.textBoxURL);
            this.Controls.Add(this.buttonWeb);
            this.Controls.Add(this.textBoxContents);
            this.Controls.Add(this.textBoxPattern);
            this.Controls.Add(this.buttonMatch);
            this.Name = "DockContentRegEx2";
            this.Text = "DockContentRegEx2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonPasteContents;
        private System.Windows.Forms.Button buttonCopyContents;
        private System.Windows.Forms.TextBox textBoxFilename;
        private System.Windows.Forms.ComboBox comboBoxUserAgent;
        private System.Windows.Forms.CheckBox checkBoxIgnoreCase;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMatchDetails;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ListBox listBoxMatches;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.Button buttonWeb;
        private System.Windows.Forms.TextBox textBoxContents;
        private System.Windows.Forms.TextBox textBoxPattern;
        private System.Windows.Forms.Button buttonMatch;
    }
}