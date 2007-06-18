using System;
using System.Collections.Generic;
using System.Text;

namespace JinwooMin.RichBrowserPlatform
{
    /// <summary>
    /// Plugin interface
    /// </summary>
    public interface IPlugin
    {
        string Author
        {
            get;
        }

        string Group
        {
            get;
        }

        string Version
        {
            get;
        }

        IRichBrowserPlatform RBP
        {
            get;
            set;
        }

        PluginActionResult Init(object param);

        PluginActionResult Deinit(object param);
    }
}
