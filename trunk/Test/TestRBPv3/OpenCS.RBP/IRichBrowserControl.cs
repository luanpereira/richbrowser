using System;
using System.Collections.Generic;
using System.Text;
using WeifenLuo.WinFormsUI.Docking;
using OpenCS.Common;
using OpenCS.Common.Plugin;

namespace OpenCS.RBP
{
    /// <summary>
    /// 리치 브라우저 콘트롤
    /// </summary>
    public interface IRichBrowserControl : IPluginHost
    {
        /// <summary>
        /// DockPanel을 가져온다.
        /// </summary>
        DockPanel DockPanel
        {
            get;
        }

        /// <summary>
        /// 웹 브라우저 DockContent 공장을 설정한다.
        /// </summary>
        GenericClassFactory<IWebBrowserDockContent> WebBrowserDockContentFactory
        {
            set;
        }

        /// <summary>
        /// 웹 주소에 접속한다.
        /// </summary>
        /// <param name="url">웹 주소</param>
        /// <returns>접속한 웹브라우저</returns>
        IWebBrowser Navigate(string url);
    }
}
