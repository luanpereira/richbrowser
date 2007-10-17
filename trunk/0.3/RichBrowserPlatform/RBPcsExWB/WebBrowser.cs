using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using RichBrowserPlatform;

namespace RBPcsExWB
{
    public partial class WebBrowser : UserControl, IWebBrowser, IWebBrowserFactory
    {
        public WebBrowser()
        {
            InitializeComponent();

            cEXWBMain.Dock = DockStyle.Fill;
        }

        #region IWebBrowser 멤버

        void IWebBrowser.Navigate(string url)
        {
            cEXWBMain.Navigate(url);
        }

        #endregion

        #region IWebBrowserFactory 멤버

        IWebBrowser IWebBrowserFactory.Create()
        {
            return new RBPcsExWB.WebBrowser();
        }

        #endregion
    }
}
