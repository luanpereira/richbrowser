using System;
using System.Collections.Generic;
using System.Text;

namespace JinwooMin.Logging
{
    /// <summary>
    /// TODO
    /// </summary>
    public class LogManager : ILogger
    {
        private List<ILogger> m_loggers;

        /// <summary>
        /// TODO
        /// </summary>
        public LogManager()
        {
            m_loggers = new List<ILogger>();
        }

        /// <summary>
        /// TODO
        /// </summary>
        public void AddLogger(ILogger logger)
        {
            m_loggers.Add(logger);
        }

        /// <summary>
        /// TODO
        /// </summary>
        public void AddLogger(ILogger logger, LogOptions options)
        {
            logger.Options = options;
            m_loggers.Add(logger);
        }

        /// <summary>
        /// TODO
        /// </summary>
        public void RemoveLogger(ILogger logger)
        {
            m_loggers.Remove(logger);
        }

        #region ILogger Members

        /// <summary>
        /// TODO
        /// </summary>
        public void Fatal(string msg)
        {
            foreach (ILogger logger in m_loggers)
            {
                logger.Fatal(msg);
            }
        }

        /// <summary>
        /// TODO
        /// </summary>
        public void Error(string msg)
        {
            foreach (ILogger logger in m_loggers)
            {
                logger.Error(msg);
            }
        }

        /// <summary>
        /// TODO
        /// </summary>
        public void Info(string msg)
        {
            foreach (ILogger logger in m_loggers)
            {
                logger.Info(msg);
            }
        }

        /// <summary>
        /// TODO
        /// </summary>
        public void Warn(string msg)
        {
            foreach (ILogger logger in m_loggers)
            {
                logger.Warn(msg);
            }
        }

        /// <summary>
        /// TODO
        /// </summary>
        public void Debug(string msg)
        {
            foreach (ILogger logger in m_loggers)
            {
                logger.Debug(msg);
            }
        }

        /// <summary>
        /// TODO
        /// </summary>
        public LogOptions Options
        {
            get { return LogOptions.NONE; } // 각 로그의 설정을 따른다.
            set { ; }
        }

        #endregion
    }
}
