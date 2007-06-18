using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI;
using csExWB;

namespace JinwooMin.RichBrowserControl
{
    /// <summary>
    /// TODO
    /// </summary>
    public partial class WebBrowserDockContent : DockContent
    {
        /// <summary>
        /// TODO
        /// </summary>
        public cEXWB WebBrowser 
        {
            get { return cEXWBMain; }
        }

        /// <summary>
        /// TODO
        /// </summary>
        public WebBrowserDockContent()
        {
            #region DLL Register
            // dll register
            // ref: http://www.msjogren.net/dotnet/eng/samples/dotnet_dynpinvoke.asp
            DllRegServer regsvr = new DllRegServer("csExWBDLMan.dll");
            regsvr.Register(); 
            #endregion

            InitializeComponent();

            this.Icon = Icon.FromHandle(Properties.Resources.web_16.GetHicon());

            #region WebBrowser event handlers
            cEXWBMain.TitleChange += new TitleChangeEventHandler(cEXWB_TitleChange);
            #endregion
        }

        private void WebBrowserDockContent_Load(object sender, EventArgs e)
        {
            cEXWBMain.Dock = DockStyle.Fill;
        }

        private void cEXWB_TitleChange(object sender, TitleChangeEventArgs e)
        {
            this.TabText = e.title;
        }
    }
}