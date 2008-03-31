using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using RichBrowserPlatform;

namespace RBPDefaultWebBrowser
{
    public partial class WebBrowser : UserControl, IWebBrowser
    {
        public WebBrowser()
        {
            InitializeComponent();
        }

        #region IWebBrowser 멤버

        public void Navigate(string url)
        {
            webBrowser1.Navigate(url);
        }

        #endregion
    }
}