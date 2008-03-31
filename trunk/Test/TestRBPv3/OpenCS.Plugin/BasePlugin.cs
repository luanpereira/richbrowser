using System;
using System.Collections.Generic;
using System.Text;

namespace OpenCS.Plugin
{
    abstract public class BasePlugin : IPlugin
    {
        protected IPluginHost m_host;

        public BasePlugin()
        {
        }

        #region IPlugin 멤버

        public IPluginHost PluginHost
        {
            set { m_host = value; }
        }

        abstract public string Title
        {
            get;
        }

        abstract public Version Version
        {
            get;
        }

        abstract public void Init();
        abstract public void Deinit();

        #endregion
    }
}
