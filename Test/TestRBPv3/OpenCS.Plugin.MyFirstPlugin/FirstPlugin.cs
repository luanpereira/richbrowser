﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace OpenCS.Plugin.MyFirstPlugin
{
    public class FirstPlugin : BasePlugin
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
            Debug.Print("inited");
            DCTest dc = new DCTest();
        }

        public override void Deinit()
        {
            Debug.Print("deinited");
        }
    }
}
