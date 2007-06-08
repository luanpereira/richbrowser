using System;
using System.Collections.Generic;
using System.Text;

namespace JinwooMin.Logging
{
    /// <summary>
    /// TODO
    /// </summary>
    public class ConsoleLogger : AbstractLogger
    {
        /// <summary>
        /// TODO
        /// </summary>
        protected override void Log(string prefix, string msg)
        {
            Console.WriteLine("[" + prefix + "] " + msg);
        }
    }
}
