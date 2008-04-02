using System;
using System.Collections.Generic;
using System.Text;
using WeifenLuo.WinFormsUI.Docking;

namespace OpenCS.RBP
{
    /// <summary>
    /// 웹 브라우저를 내장한 DockContent
    /// </summary>
    public interface IWebBrowserDockContent : IDockableContent
    {
        /// <summary>
        /// 웹 브라우저를 가져온다.
        /// </summary>
        IWebBrowser WebBrowser
        {
            get;
        }
    }
}
