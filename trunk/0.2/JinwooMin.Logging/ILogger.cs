using System;
using System.Collections.Generic;
using System.Text;

namespace JinwooMin.Logging
{
    /// <summary>
    /// TODO
    /// </summary>
    [Flags]
    public enum LogOptions { 
        /// <summary>
        /// TODO
        /// </summary>
        NONE = 0x0, 

        /// <summary>
        /// TODO
        /// </summary>
        FATAL = 0x1,

        /// <summary>
        /// TODO
        /// </summary>
        ERROR = 0x2,

        /// <summary>
        /// TODO
        /// </summary>
        INFO = 0x4,

        /// <summary>
        /// TODO
        /// </summary>
        WARN = 0x8,

        /// <summary>
        /// TODO
        /// </summary>
        DEBUG = 0x10,

        /// <summary>
        /// TODO
        /// </summary>
        ALL = 0xff
    };

    /// <summary>
    /// TODO
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// TODO
        /// </summary>
        LogOptions Options
        {
            get;
            set;
        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="msg"></param>
        void Fatal(string msg);

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="msg"></param>
        void Error(string msg);

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="msg"></param>
        void Info(string msg);

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="msg"></param>
        void Warn(string msg);

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="msg"></param>
        void Debug(string msg);

    }
}
