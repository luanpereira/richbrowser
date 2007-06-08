using System;
using System.Collections.Generic;
using System.Text;

namespace JinwooMin.Logging
{
    public interface ILoggable
    {
        ILogger Logger { set; }
    }
}
