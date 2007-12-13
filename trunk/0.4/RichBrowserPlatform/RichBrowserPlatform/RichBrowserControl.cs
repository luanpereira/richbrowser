using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace RichBrowserPlatform
{
    public partial class RichBrowserControl : UserControl
    {
        #region Fields

        private IWebBrowserFactory m_webBrowserFactory;

        #endregion Fields

        #region Properties

        public IWebBrowserFactory WebBrowserFactory
        {
            get { return m_webBrowserFactory; }
            set { m_webBrowserFactory = value; }
        }

        #endregion Properties

        #region Properties for extensions

        public DockPanel dp { get { return dockPanelMain; } }

        #region Menus

        public MenuStrip ms { get { return menuStripMain; } }

        public ToolStripMenuItem miNew { get { return newToolStripMenuItem; } }
        public ToolStripMenuItem miClose { get { return closeToolStripMenuItem; } }
        public ToolStripMenuItem miExit { get { return exitToolStripMenuItem; } }

        public ToolStripMenuItem miEdit { get { return editToolStripMenuItem; } }
        public ToolStripMenuItem miView { get { return viewToolStripMenuItem; } }

        public ToolStripMenuItem miTools { get { return toolsToolStripMenuItem; } }
        public ToolStripMenuItem miWebSearch { get { return webSearchToolStripMenuItem; } }

        public ToolStripMenuItem miHelp { get { return helpToolStripMenuItem; } }

        #endregion Menu

        #region ToolStrips

        public ToolStripContainer tsc { get { return toolStripContainerMain; } }

        #region Web

        public ToolStrip tsWeb { get { return toolStripWeb; } }

        public ToolStripLabel lbWeb { get { return toolStripLabelWeb; } }

        public ToolStripButton btNew { get { return toolStripButtonNew; } }
        public ToolStripButton btBack { get { return toolStripButtonBack; } }
        public ToolStripButton btForward { get { return toolStripButtonForward; } }

        public ToolStripButton btStop { get { return toolStripButtonStop; } }
        public ToolStripButton btRefresh { get { return toolStripButtonRefresh; } }
        public ToolStripButton btHome { get { return toolStripButtonHome; } }

        #endregion Web

        #region Address

        public ToolStrip tsAdreess { get { return toolStripAddress; } }

        public ToolStripLabel lbAddress { get { return toolStripLabelAddress; } }

        public ToolStripTextBox tbUrl { get { return toolStripTextBoxUrl; } }
        public ToolStripButton btGo { get { return toolStripButtonGo; } }

        #endregion Address

        #region Search

        public ToolStrip tsSearch { get { return toolStripSearch; } }

        public ToolStripLabel lbSearch { get { return toolStripLabelSearch; } }

        public ToolStripTextBox tbSearch { get { return toolStripTextBoxSearch; } }
        public ToolStripButton btSearch { get { return toolStripButtonSearch; } }

        #endregion

        #endregion ToolStrips

        #region StatusStrip

        public StatusStrip ss { get { return statusStripMain; } }

        public ToolStripStatusLabel lbMessage { get { return toolStripStatusLabelMessage; } }
        public ToolStripProgressBar pb { get { return toolStripProgressBarMain; } }

        #endregion StatusBar

        #endregion Properties for IronPython

        public RichBrowserControl()
        {
            InitializeComponent();

            dockPanelMain.DocumentStyle = DocumentStyle.DockingWindow;

#if !FOR_IRONPTYHON
            tbUrl.GotFocus += new EventHandler(tbUrl_GotFocus);
            tbSearch.GotFocus += new EventHandler(tbSearch_GotFocus);
#endif
        }

        private void tbUrl_GotFocus(object sender, EventArgs e)
        {
#if !FOR_IRONPTYHON
            tbUrl.SelectAll();
#endif
        }

        public void tbSearch_GotFocus(object sender, EventArgs e)
        {
#if !FOR_IRONPTYHON
            tbSearch.SelectAll();
#endif
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
#if !FOR_IRONPTYHON
            NewWebBrowser();
#endif
        }

#if !FOR_IRONPTYHON

        private DockContentWebBrowser NewWebBrowser()
        {
            DockContentWebBrowser dc = new DockContentWebBrowser();
            dc.WebBrowser = m_webBrowserFactory.Create();
            dc.Show(dockPanelMain, DockState.Document);

            return dc;
        }

        private void Navigate(DockContentWebBrowser dc, string url)
        {
            dc.WebBrowser.Navigate(url);
        }

        private void Navigate(string url)
        {
            DockContentWebBrowser dc = NewWebBrowser();
            dc.WebBrowser.Navigate(url);
        }

        private void Navigate(DockContentWebBrowser dc)
        {
            dc.WebBrowser.Navigate(toolStripTextBoxUrl.Text);
        }

        private void Navigate()
        {
            Navigate(NewWebBrowser());
        }

        private void Search(string query)
        {
            Navigate("http://www.google.co.kr/search?q=" + query);
        }

        private void Search()
        {
            Search(tbSearch.Text);
        }

        private void toolStripButtonGo_Click(object sender, EventArgs e)
        {
#if !FOR_IRONPTYHON
            Navigate();
#endif
        }

        private void toolStripTextBoxUrl_KeyDown(object sender, KeyEventArgs e)
        {
#if !FOR_IRONPTYHON
            if (e.KeyCode == Keys.Return)
            {
                Navigate();

                e.SuppressKeyPress = true;
            }
#endif
        }

        private void toolStripButtonSearch_Click(object sender, EventArgs e)
        {
#if !FOR_IRONPTYHON
            Search();
#endif
        }

        private void toolStripTextBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
#if !FOR_IRONPTYHON
            if (e.KeyCode == Keys.Return)
            {
                Search();

                e.SuppressKeyPress = true;
            }
#endif
        }

#endif

    }
}