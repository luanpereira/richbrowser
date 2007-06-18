using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace JinwooMin.RichBrowserControl
{
    public partial class RichBrowserControl : UserControl
    {
        public RichBrowserControl()
        {
            InitializeComponent();

            this.Dock = DockStyle.Fill;
            this.dockPanel1.DocumentStyle = DocumentStyle.DockingWindow;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WebBrowserDockContent web = new WebBrowserDockContent();
            web.Show(dockPanel1, DockState.Document);
        }

        private void toolStripButtonGo_Click(object sender, EventArgs e)
        {
            WebBrowserDockContent web = new WebBrowserDockContent();
            web.Show(dockPanel1, DockState.Document);
            web.WebBrowser.Navigate(toolStripTextBoxAddress.Text);
        }
    }
}
