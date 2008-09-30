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
            rbpWebBrowserMain.NewWindow += new CancelEventHandler(rbpWebBrowserMain_NewWindow);
            rbpWebBrowserMain.StatusTextChanged += new EventHandler(rbpWebBrowserMain_StatusTextChanged);

            this.TabText = "(Untitled)";
        }

        void rbpWebBrowserMain_StatusTextChanged(object sender, EventArgs e)
        {
            if (WebBrowserStatusTextChanged != null)
            {
                WebBrowserStatusTextChanged(this, new WebBrowserStatusTextChangedEventArgs(rbpWebBrowserMain.StatusText));
            }
        }

        void rbpWebBrowserMain_DocumentTitleChanged(object sender, EventArgs e)
        {
            this.TabText = rbpWebBrowserMain.DocumentTitle;
        }

        private void rbpWebBrowserMain_NewWindow(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            if (NewWindow != null)
            {
                NewWindow(this, new NewWindowEventArgs(rbpWebBrowserMain.StatusText));
            }
        }

        #region IWebBrowserDockContent 멤버

        public IWebBrowser WebBrowser
        {
            get { return rbpWebBrowserMain; }
        }

        public event EventHandler<NewWindowEventArgs> NewWindow;

        public event EventHandler<WebBrowserStatusTextChangedEventArgs> WebBrowserStatusTextChanged;

        #endregion
    }
}