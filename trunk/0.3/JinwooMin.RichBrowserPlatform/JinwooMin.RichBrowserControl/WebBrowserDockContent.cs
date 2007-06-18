using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using JinwooMin.RichBrowserPlatform;

namespace JinwooMin.RichBrowserControl
{
    public partial class WebBrowserDockContent : DockContent
    {
        public IWebBrowser WebBrowser
        {
            get { return webBrowserWrapperControl1; }
        }

        public WebBrowserDockContent()
        {
            InitializeComponent();
        }
    }
}