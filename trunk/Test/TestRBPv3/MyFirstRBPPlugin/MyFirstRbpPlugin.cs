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
        private DCTest2 m_dc;
        private IActionHandler m_ah;
        private object m_button;
        private object m_menu;

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
            m_dc = new DCTest2();
            m_dc.HideOnClose = true;
            m_dc.HostDockPanel = m_rbc.DockPanel;
            m_dc.Show(m_rbc.DockPanel, DockState.DockRight);
            m_ah = m_dc;
            m_button = m_rbc.AddToolBarButton("FirstRbpPlugin", new ShowMyFirstRbpPanelAction());
            m_menu = m_rbc.AddMenuItem("FirstRbpPlugin", new ShowMyFirstRbpPanelAction());

            Debug.Print("inited");
        }

        public override void Deinit()
        {
            m_rbc.RemoveToolBarButton(m_button);
            m_rbc.RemoveMenuItem(m_menu);

            m_dc.Close();

            Debug.Print("deinited");
        }

        public override ActionResult HandleAction(IAction action)
        {
            if (action is ShowMyFirstRbpPanelAction)
            {
                if (m_dc != null)
                {
                    m_dc.Show(m_rbc.DockPanel, DockState.DockRight);

                    return ActionResult.Success;
                }
            }

            if (m_ah != null)
            {
                return m_ah.HandleAction(action);
            }

            return ActionResult.NotHandled;
        }
    }
}
