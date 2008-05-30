using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using WeifenLuo.WinFormsUI.Docking;
using OpenCS.Common.Action;
using OpenCS.Common.Plugin;
using OpenCS.RBP;

namespace MyFirstRBPPlugin
{
    public class MyFirstRbpPlugin : BaseRbpPlugin
    {
        private DCTest2 mDc;
        private IActionHandler mAh;
        private object mButton;
        private object mMenu;

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
            mDc = new DCTest2();
            mDc.HideOnClose = true;
            mDc.HostDockPanel = RichBrowserControl.DockPanel;
            mDc.Show(RichBrowserControl.DockPanel, DockState.DockRight);
            mAh = mDc;
            mButton = RichBrowserControl.AddToolBarButton("FirstRbpPlugin", new ShowMyFirstRbpPanelAction());
            mMenu = RichBrowserControl.AddMenuItem("FirstRbpPlugin", new ShowMyFirstRbpPanelAction());
        }

        public override void Deinit()
        {
            RichBrowserControl.RemoveToolBarButton(mButton);
            RichBrowserControl.RemoveMenuItem(mMenu);

            mDc.Close();
        }

        public override ActionResult HandleAction(IAction action)
        {
            if (action is ShowMyFirstRbpPanelAction)
            {
                if (mDc != null)
                {
                    mDc.Show(RichBrowserControl.DockPanel, DockState.DockRight);

                    return ActionResult.Success;
                }
            }

            if (mAh != null)
            {
                return mAh.HandleAction(action);
            }

            return ActionResult.NotHandled;
        }
    }
}
