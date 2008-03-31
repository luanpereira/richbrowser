using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RBPGUI.Downloader
{
    public partial class FormInputBox : Form
    {
        public string Title
        {
            get { return labelTitle.Text; }
            set { labelTitle.Text = value; }
        }

        public string InputText
        {
            get { return textBoxInput.Text; }
            set { textBoxInput.Text = value; }
        }

        public FormInputBox()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}