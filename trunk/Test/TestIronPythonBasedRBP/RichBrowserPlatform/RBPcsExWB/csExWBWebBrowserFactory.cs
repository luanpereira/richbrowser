using System;
using System.Collections.Generic;
using System.Text;
using RichBrowserPlatform;

namespace RBPcsExWB
{
    public class csExWBWebBrowserFactory : IWebBrowserFactory
    {
        #region IWebBrowserFactory 멤버

        public IWebBrowser Create()
        {
            return new RBPcsExWB.WebBrowser();
        }

        #endregion
    }
}
