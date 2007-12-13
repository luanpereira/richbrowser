using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using RichBrowserPlatform;

namespace RBPcsEXWB
{
    public partial class WebBrowser : UserControl, IWebBrowser
    {
        public WebBrowser()
        {
            InitializeComponent();

            cEXWBMain.Dock = DockStyle.Fill;
        }

        #region IWebBrowser 멤버

        public void Navigate(string url)
        {
            cEXWBMain.Navigate(url);
        }

        #endregion
    }
}