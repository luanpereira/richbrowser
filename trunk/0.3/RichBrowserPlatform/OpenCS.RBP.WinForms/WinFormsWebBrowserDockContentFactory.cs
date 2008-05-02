using System;
using System.Collections.Generic;
using System.Text;
using OpenCS.Common;

namespace OpenCS.RBP.WinForms
{
    public class WinFormsWebBrowserDockContentFactory : GenericClassFactory<IWebBrowserDockContent>
    {
        #region GenericClassFactory<IWebBrowserDockContent> 멤버

        public IWebBrowserDockContent CreateClass()
        {
            return new DCWebBrowser();
        }

        #endregion
    }
}
