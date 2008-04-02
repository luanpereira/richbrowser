using System;
using System.Collections.Generic;
using System.Text;
using OpenCS.Common.Plugin;
using OpenCS.RBP;
using System.Diagnostics;
using WeifenLuo.WinFormsUI.Docking;
using OpenCS.Common.Action;

namespace MyFirstRBPPlugin
{
    public class MyFirstRbpPlugin : BaseRbpPlugin
    {
        private IActionHandler m_ah;

        public override string Title
        {
            get { return "MyFirstRbpPlugin"; }
        }

        public override Version Version
        {
            get { return new Version("0.1.1.0"); }
        }

        public override void Init()
        {
            DCTest2 dc = new DCTest2();
            dc.HostDockPanel = m_rbc.DockPanel;
            dc.Show(m_rbc.DockPanel, DockState.DockRight);
            m_ah = dc;

            Debug.Print("inited");
        }

        public override void Deinit()
        {
            Debug.Print("deinited");
        }

        public override ActionResult HandleAction(IAction action)
        {
            if (m_ah != null)
            {
                return m_ah.HandleAction(action);
            }

            return ActionResult.NotHandled;
        }
    }
}
