using System;
using System.Collections.Generic;
using System.Text;

namespace JinwooMin.Logging
{
    public class ConsoleLogger : AbstractLogger
    {
        protected override void Log(string prefix, string msg)
        {
            Console.WriteLine("[" + prefix + "] " + msg);
        }
    }
}
