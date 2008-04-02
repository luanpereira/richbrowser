using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace OpenCS.RBP.WinForms
{
    public partial class DCWebBrowser : DockContent, IWebBrowserDockContent
    {
        public DCWebBrowser()
        {
            InitializeComponent();
        }

        #region IWebBrowserDockContent 멤버

        public IWebBrowser WebBrowser
        {
            get { return rbpWebBrowser1; }
        }

        #endregion
    }
}