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

        /// <summary>
        /// 새 창을 띄우려고 할 때 발생한다. WebBrowser가 새창을 띄우지 않고, RBP가 다른 탭으로 띄우게 한다.
        /// </summary>
        event EventHandler<NewWindowEventArgs> NewWindow;
    }
}
