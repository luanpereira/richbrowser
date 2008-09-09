using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Text;
using WeifenLuo.WinFormsUI.Docking;
using OpenCS.Common.Action;
using OpenCS.RBP;

namespace MyFirstToggleableRbpPlugin
{
    public class MyFirstToggleableRbpPlugin: BaseToggleableRbpPlugin
    {
        public override ActionResult HandleAction(IAction action)
        {
            if (HandleShowAction(action) == ActionResult.Success)
            {
                return ActionResult.Success;
            }

            return ActionResult.NotHandled;
        }

        public override string Title
        {
            get { return "MyFirstToggleableRbpPlugin"; }
        }

        // See http://bytes.com/forum/thread229407.html
        public override Version Version
        {
            get { return new Version(FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion); }
        }
        
        public override void Init()
        {
            DockContent = new DockContentTest();
            InitToggleableResources();
        }

        public override void Deinit()
        {
            DeinitToggleableResources();
            DockContent.Close();
        }

        public override void ShowDockContent()
        {
            DockContent.Show(RichBrowserControl.DockPanel, DockState.DockRight);
        }
    }
}
