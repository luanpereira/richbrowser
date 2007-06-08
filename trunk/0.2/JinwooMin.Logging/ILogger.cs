using System;
using System.Collections.Generic;
using System.Text;

namespace JinwooMin.Logging
{
    [Flags]
    public enum LogOptions { NONE = 0x0, FATAL = 0x1, ERROR = 0x2, INFO = 0x4, WARN = 0x8, DEBUG = 0x10, ALL = 0xff };

    public interface ILogger
    {
        LogOptions Options
        {
            get;
            set;
        }
        void Fatal(string msg);
        void Error(string msg);
        void Info(string msg);
        void Warn(string msg);
        void Debug(string msg);

    }
}
