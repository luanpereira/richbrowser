using System;
using System.Collections.Generic;
using System.Text;

namespace JinwooMin.Logging
{
    /// <summary>
    /// TODO
    /// </summary>
    public interface ILoggable
    {
        /// <summary>
        /// TODO
        /// </summary>
        ILogger Logger { get; set; }
    }
}
