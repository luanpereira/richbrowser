using System;
using System.Collections.Generic;
using System.Text;

namespace OpenCS.Plugin
{
    public interface IPlugin
    {
        IPluginHost PluginHost
        {
            set;
        }

        string Title
        {
            get;
        }

        Version Version
        {
            get;
        }

        void Init();
        void Deinit();
    }
}
