using System;
using System.Collections.Generic;
using System.Text;
using JinwooMin.Logging;

namespace JinwooMin.RichBrowserInterface
{
    /// <summary>
    /// TODO
    /// </summary>
    public abstract class AbstractPlugin : IPlugin
    {
        /// <summary>
        /// TODO
        /// </summary>
        protected IPluginHost m_pluginHost;

        /// <summary>
        /// TODO
        /// </summary>
        protected string m_pluginPath;

        /// <summary>
        /// TODO
        /// </summary>
        protected ILogger m_logger;

        /// <summary>
        /// TODO
        /// </summary>
        protected string m_platformDataPath;

        #region IPlugin Members

        /// <summary>
        /// TODO
        /// </summary>
        public IPluginHost PluginHost
        {
            get { return m_pluginHost; }
            set { m_pluginHost = value; }
        }

        /// <summary>
        /// TODO
        /// </summary>
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

        /// <summary>
        /// TODO
        /// </summary>
        public string PlatformDataPath
        {
            get
            {
                return m_platformDataPath;
            }
            set
            {
                m_platformDataPath = value;
            }
        }

        private PluginResult m_initResult;

        /// <summary>
        /// TODO
        /// </summary>
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

        /// <summary>
        /// TODO
        /// </summary>
        private PluginResult m_deinitResult;

        /// <summary>
        /// TODO
        /// </summary>
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

        /// <summary>
        /// TODO
        /// </summary>
        public abstract void Init();

        /// <summary>
        /// TODO
        /// </summary>
        public abstract void Deinit();

        #endregion

        #region ILoggable Members

        /// <summary>
        /// TODO
        /// </summary>
        public ILogger Logger
        {
            get { return m_logger; }
            set { m_logger = value; }
        }

        #endregion
    }
}
