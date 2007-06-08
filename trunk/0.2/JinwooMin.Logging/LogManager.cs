using System;
using System.Collections.Generic;
using System.Text;

namespace JinwooMin.Logging
{
    public class LogManager : ILogger
    {
        private List<ILogger> m_loggers;

        public LogManager()
        {
            m_loggers = new List<ILogger>();
        }

        public void AddLogger(ILogger logger)
        {
            m_loggers.Add(logger);
        }

        public void AddLogger(ILogger logger, LogOptions options)
        {
            logger.Options = options;
            m_loggers.Add(logger);
        }

        public void RemoveLogger(ILogger logger)
        {
            m_loggers.Remove(logger);
        }

        #region ILogger Members

        public void Fatal(string msg)
        {
            foreach (ILogger logger in m_loggers)
            {
                logger.Fatal(msg);
            }
        }

        public void Error(string msg)
        {
            foreach (ILogger logger in m_loggers)
            {
                logger.Error(msg);
            }
        }

        public void Info(string msg)
        {
            foreach (ILogger logger in m_loggers)
            {
                logger.Info(msg);
            }
        }

        public void Warn(string msg)
        {
            foreach (ILogger logger in m_loggers)
            {
                logger.Warn(msg);
            }
        }

        public void Debug(string msg)
        {
            foreach (ILogger logger in m_loggers)
            {
                logger.Debug(msg);
            }
        }

        public LogOptions Options
        {
            get { return LogOptions.NONE; } // 각 로그의 설정을 따른다.
            set { ; }
        }

        #endregion
    }
}
