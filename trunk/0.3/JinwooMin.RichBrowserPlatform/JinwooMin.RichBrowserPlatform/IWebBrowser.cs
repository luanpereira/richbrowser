using System;
using System.Collections.Generic;
using System.Text;

namespace JinwooMin.RichBrowserPlatform
{
    public class BeforeNavigateEventArgs
    {
    }

    public delegate void BeforeNavigateEventHandler(object sender, BeforeNavigateEventArgs e);

    /// <summary>
    /// WebBrowser interface.
    /// </summary>
    public interface IWebBrowser
    {
        /// <summary>
        /// Navigate web page.
        /// </summary>
        /// <param name="url">url to navigate</param>
        void Navigate(string url);

        BeforeNavigateEventHandler BeforeNavigate
        {
            get;
            set;
        }
        
    }
}
