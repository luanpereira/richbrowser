using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using JinwooMin.RichBrowserPlatform;

namespace JinwooMin.RichBrowserControl
{
    public partial class WebBrowserWrapperControl : UserControl, IWebBrowser
    {
        public WebBrowserWrapperControl()
        {
            InitializeComponent();
        }

        #region IWebBrowser Members

        public void Navigate(string url)
        {
            webBrowser1.Navigate(url);
        }

        #endregion

        #region IWebBrowser Members


        public BeforeNavigateEventHandler BeforeNavigate
        {
            get
            {
                return null;
            }
            set
            {
            }
        }

        #endregion
    }
}