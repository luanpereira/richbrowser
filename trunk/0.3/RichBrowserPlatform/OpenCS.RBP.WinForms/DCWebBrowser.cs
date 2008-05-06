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

            rbpWebBrowserMain.DocumentTitleChanged += new EventHandler(rbpWebBrowserMain_DocumentTitleChanged);

            this.TabText = "(Untitled)";
        }

        void rbpWebBrowserMain_DocumentTitleChanged(object sender, EventArgs e)
        {
            this.TabText = rbpWebBrowserMain.DocumentTitle;
        }

        #region IWebBrowserDockContent 멤버

        public IWebBrowser WebBrowser
        {
            get { return rbpWebBrowserMain; }
        }

        #endregion
    }
}