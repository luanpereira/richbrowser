using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using OpenCS.Common.Action;
using OpenCS.Common.Logging;
using OpenCS.Common.Plugin;
using OpenCS.RBP;

namespace OpenCS.Plugin.MyFirstPlugin
{
    public partial class DCTest : DockContent, IPanelPlugin
    {
        private IPluginHost mHost;
        private ILogger mLogger = new ConsoleLogger();
        private string mInstalledPath;

        public DCTest()
        {
            InitializeComponent();
        }

        #region IPlugin 멤버

        public IPluginHost PluginHost
        {
            get { return mHost; }
            set { mHost = value; }
        }

        public string Title
        {
            get { return "MyFirstPanelPlugin"; }
        }

        public Version Version
        {
            get { return new Version("0.1.1.1"); }
        }

        public string InstalledPath
        {
            get { return mInstalledPath; }

            set { mInstalledPath = value; }
        }

        public void Init()
        {
        }

        public void Deinit()
        {
        }

        #endregion

        #region ILoggable 멤버

        public ILogger Logger
        {
            set { mLogger = value; }
        }

        #endregion

        #region IActionHandler 멤버

        public ActionResult HandleAction(IAction action)
        {
            return ActionResult.NotHandled;
        }

        #endregion

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ActionResult result = mHost.HandleAction(new PropertyAction<string>(toolStripTextBox1.Text));
            MessageBox.Show(result.ToString());
        }
    }
}