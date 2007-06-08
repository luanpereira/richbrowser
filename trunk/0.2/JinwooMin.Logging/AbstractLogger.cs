using System;
using System.Collections.Generic;
using System.Text;

namespace JinwooMin.Logging
{
    public abstract class AbstractLogger : ILogger
    {
        protected LogOptions m_options;

        public static string LOG_PREFIX_FATAL = "FATAL";
        public static string LOG_PREFIX_ERROR = "ERROR";
        public static string LOG_PREFIX_INFO = "INFO ";
        public static string LOG_PREFIX_WARN = "WARN ";
        public static string LOG_PREFIX_DEBUG = "DEBUG";

        abstract protected void Log(string prefix, string msg);

        #region ILogger Members

        public void Fatal(string msg)
        {
            if ((Options & LogOptions.FATAL) == LogOptions.FATAL)
            {
                Log(LOG_PREFIX_FATAL, msg);
            }
        }

        public void Error(string msg)
        {
            if ((Options & LogOptions.ERROR) == LogOptions.ERROR)
            {
                Log(LOG_PREFIX_ERROR, msg);
            }
        }

        public void Info(string msg)
        {
            if ((Options & LogOptions.INFO) == LogOptions.INFO)
            {
                Log(LOG_PREFIX_INFO, msg);
            }
        }

        public void Warn(string msg)
        {
            if ((Options & LogOptions.WARN) == LogOptions.WARN)
            {
                Log(LOG_PREFIX_WARN, msg);
            }
        }

        public void Debug(string msg)
        {
            if ((Options & LogOptions.DEBUG) == LogOptions.DEBUG)
            {
                Log(LOG_PREFIX_DEBUG, msg);
            }
        }

        public LogOptions Options
        {
            get { return m_options; }
            set { m_options = value; }
        }

        #endregion
    }
}
