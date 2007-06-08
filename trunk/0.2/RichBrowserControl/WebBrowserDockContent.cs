using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI;
using csExWB;

namespace JinwooMin.RichBrowserControl
{
    public partial class WebBrowserDockContent : DockContent
    {
        public cEXWB WebBrowser 
        {
            get { return cEXWB; }
        }

        public WebBrowserDockContent()
        {
            InitializeComponent();
        }

        private void WebBrowserDockContent_Load(object sender, EventArgs e)
        {
            cEXWB.Dock = DockStyle.Fill;
        }

        private void cEXWB_DocumentComplete(object sender, DocumentCompleteEventArgs e)
        {
        }

        private void cEXWB_TitleChange(object sender, TitleChangeEventArgs e)
        {
            this.TabText = e.title;
        }

        private void cEXWB_LocationChanged(object sender, EventArgs e)
        {
            //ToolStrip
        }
    }
}