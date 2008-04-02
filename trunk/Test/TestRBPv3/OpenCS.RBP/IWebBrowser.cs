using System;
using System.Collections.Generic;
using System.Text;
using OpenCS.Common.Plugin;

namespace OpenCS.RBP
{
    /// <summary>
    /// 웹 브라우저
    /// </summary>
    public interface IWebBrowser : IPlugin
    {
        /// <summary>
        /// 표시한다.
        /// </summary>
        void Show();
    }
}
