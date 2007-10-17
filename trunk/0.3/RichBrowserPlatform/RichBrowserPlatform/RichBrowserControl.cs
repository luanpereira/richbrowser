using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using RichBrowserPlatform;

namespace RichBrowserPlatform
{
    public partial class RichBrowserControl : UserControl
    {
        private IWebBrowserFactory m_webBrowserFactory;

        public IWebBrowserFactory WebBrowserFactory
        {
            get { return m_webBrowserFactory; }
            set { m_webBrowserFactory = value; }
        }

        public DockPanel dp { get { return dockPanelMain; } }

        public ToolStripMenuItem miNew { get { return newToolStripMenuItem; } }
        public ToolStripMenuItem miClose { get { return closeToolStripMenuItem; } }
        public ToolStripMenuItem miExit { get { return exitToolStripMenuItem; } }

        public ToolStripButton btNew { get { return toolStripButtonNew; } }
        public ToolStripButton btBack { get { return toolStripButtonBack; } }
        public ToolStripButton btForward { get { return toolStripButtonForward; } }

        public ToolStripTextBox tbUrl { get { return toolStripTextBoxUrl; } }
        public ToolStripButton btGo { get { return toolStripButtonGo; } }

        public ToolStripStatusLabel lbMessage { get { return toolStripStatusLabelMessage; } }
        public ToolStripProgressBar pb { get { return toolStripProgressBarMain; } }

        public RichBrowserControl()
        {
            InitializeComponent();

            dockPanelMain.DocumentStyle = DocumentStyle.DockingWindow;

            toolStripTextBoxUrl.GotFocus += new EventHandler(tbUrl_GotFocus);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
#if !FOR_IRONPTYHON
            DockContentWebBrowser dc = new DockContentWebBrowser();
            dc.WebBrowser = m_webBrowserFactory.Create();
            dc.Show(dockPanelMain, DockState.Document);
#endif
        }

        private void toolStripButtonGo_Click(object sender, EventArgs e)
        {
#if !FOR_IRONPTYHON
            DockContentWebBrowser dc = new DockContentWebBrowser();
            dc.WebBrowser = m_webBrowserFactory.Create();
            dc.Show(dockPanelMain, DockState.Document);
            dc.WebBrowser.Navigate(toolStripTextBoxUrl.Text);
#endif
        }

        private void toolStripTextBoxUrl_KeyDown(object sender, KeyEventArgs e)
        {
#if !FOR_IRONPTYHON
            if (e.KeyCode == Keys.Return)
            {
                DockContentWebBrowser dc = new DockContentWebBrowser();
                dc.WebBrowser = m_webBrowserFactory.Create();
                dc.Show(dockPanelMain, DockState.Document);
                dc.WebBrowser.Navigate(toolStripTextBoxUrl.Text);

                e.SuppressKeyPress = true;
            }
#endif
        }

        private void tbUrl_GotFocus(object sender, EventArgs e)
        {
#if !FOR_IRONPTYHON
            tbUrl.SelectAll();
#endif
        }
    }
}