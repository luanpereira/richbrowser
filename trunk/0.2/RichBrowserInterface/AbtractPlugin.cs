using System;
using System.Collections.Generic;
using System.Text;
using JinwooMin.Logging;

namespace JinwooMin.RichBrowserInterface
{
    public abstract class AbstractPlugin : IPlugin
    {
        protected IPluginHost m_pluginHost;
        protected string m_pluginPath;
        protected ILogger m_logger;

        #region IPlugin Members

        public IPluginHost PluginHost
        {
            get { return m_pluginHost; }
            set { m_pluginHost = value; }
        }

        public string PluginPath
        {
            get
            {
                return m_pluginPath;
            }
            set
            {
                m_pluginPath = value;
            }
        }

        private PluginResult m_initResult;

        public PluginResult InitResult
        {
            get
            {
                return m_initResult;
            }
            set
            {
                m_initResult = value;
            }
        }

        private PluginResult m_deinitResult;

        public PluginResult DeinitResult
        {
            get
            {
                return m_deinitResult;
            }
            set
            {
                m_deinitResult = value;
            }
        }

        public abstract void Init();

        public abstract void Deinit();

        #endregion

        #region ILoggable Members

        public ILogger Logger
        {
            get { return m_logger; }
            set { m_logger = value; }
        }

        #endregion
    }
}
