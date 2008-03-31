using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace RichBrowserPlatform
{
    public partial class DockContentWebBrowser : DockContent
    {
        private IWebBrowser m_webBrowser;

        public IWebBrowser WebBrowser
        {
            get { return m_webBrowser; }
            set
            {
                m_webBrowser = value;
                if (m_webBrowser is Control)
                {
                    Control c = m_webBrowser as Control;
                    c.Dock = DockStyle.Fill;
                    Controls.Add(c);
                }
            }
        }

        public DockContentWebBrowser()
        {
            InitializeComponent();
        }
    }
}