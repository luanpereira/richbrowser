using System;
using System.Collections.Generic;
using System.Text;

namespace JinwooMin.Logging
{
    public class DefaultLoggable : ILoggable
    {
        private ILogger m_logger;

        #region ILoggable Members

        public ILogger Logger
        {
            get { return m_logger; }
            set { m_logger = value; }
        }

        #endregion
    }
}
