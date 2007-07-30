using System;
using System.Collections.Generic;
using System.Text;

namespace JinwooMin.Logging
{
    /// <summary>
    /// TODO
    /// </summary>
    public abstract class AbstractLogger : ILogger
    {
        /// <summary>
        /// TODO
        /// </summary>
        protected LogOptions m_options;

        /// <summary>
        /// TODO
        /// </summary>
        public static string LOG_PREFIX_FATAL = "FATAL";

        /// <summary>
        /// TODO
        /// </summary>
        public static string LOG_PREFIX_ERROR = "ERROR";

        /// <summary>
        /// TODO
        /// </summary>
        public static string LOG_PREFIX_INFO = "INFO ";

        /// <summary>
        /// TODO
        /// </summary>
        public static string LOG_PREFIX_WARN = "WARN ";

        /// <summary>
        /// TODO
        /// </summary>
        public static string LOG_PREFIX_DEBUG = "DEBUG";

        /// <summary>
        /// TODO
        /// </summary>
        abstract protected void Log(string prefix, string msg);

        #region ILogger Members

        /// <summary>
        /// TODO
        /// </summary>
        public void Fatal(string msg)
        {
            if ((Options & LogOptions.FATAL) == LogOptions.FATAL)
            {
                Log(LOG_PREFIX_FATAL, msg);
            }
        }

        /// <summary>
        /// TODO
        /// </summary>
        public void Error(string msg)
        {
            if ((Options & LogOptions.ERROR) == LogOptions.ERROR)
            {
                Log(LOG_PREFIX_ERROR, msg);
            }
        }

        /// <summary>
        /// TODO
        /// </summary>
        public void Info(string msg)
        {
            if ((Options & LogOptions.INFO) == LogOptions.INFO)
            {
                Log(LOG_PREFIX_INFO, msg);
            }
        }

        /// <summary>
        /// TODO
        /// </summary>
        public void Warn(string msg)
        {
            if ((Options & LogOptions.WARN) == LogOptions.WARN)
            {
                Log(LOG_PREFIX_WARN, msg);
            }
        }

        /// <summary>
        /// TODO
        /// </summary>
        public void Debug(string msg)
        {
            if ((Options & LogOptions.DEBUG) == LogOptions.DEBUG)
            {
                Log(LOG_PREFIX_DEBUG, msg);
            }
        }

        /// <summary>
        /// TODO
        /// </summary>
        public LogOptions Options
        {
            get { return m_options; }
            set { m_options = value; }
        }

        #endregion
    }
}
