using System;
using System.Collections.Generic;
using System.Text;

namespace JinwooMin.RichBrowserPlatform
{
    /// <summary>
    /// TODO
    /// </summary>
    public interface IPluginHost
    {
        List<IPlugin> Plugins
        {
            get;
            set;
        }

        PluginActionResult Init(object param);

        PluginActionResult Deinit(object param);
    }
}
