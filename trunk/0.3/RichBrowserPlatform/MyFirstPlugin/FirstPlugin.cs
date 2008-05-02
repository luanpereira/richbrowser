using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using OpenCS.Common.Plugin;
using OpenCS.Common.Action;

namespace OpenCS.Plugin.MyFirstPlugin
{
    public class FirstPlugin : BasePlugin, IPlugin
    {
        public override string Title
        {
            get { return "MyFirstPlugin"; }
        }

        public override Version Version
        {
            get { return new Version("0.1.1.1"); }
        }

        public override void Init()
        {
        }

        public override void Deinit()
        {
        }

        public override ActionResult HandleAction(IAction action)
        {
            return ActionResult.NotHandled;            
        }
    }
}
