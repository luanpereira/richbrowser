using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using OpenCS.RBP;
using OpenCS.Common.Plugin;
using System.Diagnostics;
using OpenCS.Common.Action;
using OpenCS.Common.Logging;

namespace OpenCS.Plugin.MyFirstPlugin
{
    public partial class DCTest : DockContent, IPanelPlugin
    {
        private IPluginHost m_host;
        private ILogger m_logger = new ConsoleLogger();

        public DCTest()
        {
            InitializeComponent();
        }

        #region IPlugin 멤버

        public IPluginHost PluginHost
        {
            set { m_host = value; }
        }

        public string Title
        {
            get { return "MyFirstPanelPlugin"; }
        }

        public Version Version
        {
            get { return new Version("0.1.1.1"); }
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
            set { m_logger = value; }
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
            ActionResult result = m_host.HandleAction(new PropertyAction<string>(toolStripTextBox1.Text));
            MessageBox.Show(result.ToString());
        }

    }
}