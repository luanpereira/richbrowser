using System;
using System.Collections.Generic;
using System.Text;
using RichBrowserPlatform;

namespace RBPcsEXWB
{
    public class csEXWBWebBrowserFactory : IWebBrowserFactory
    {
        #region IWebBrowserFactory 멤버

        public IWebBrowser Create()
        {
            return new RBPcsEXWB.WebBrowser();
        }

        #endregion
    }
}
