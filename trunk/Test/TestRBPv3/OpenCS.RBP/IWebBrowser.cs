using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using OpenCS.Common.Plugin;
using WeifenLuo.WinFormsUI.Docking;

namespace OpenCS.RBP
{
    /// <summary>
    /// 웹 브라우저
    /// </summary>
    public interface IWebBrowser
    {
        /// <summary>
        /// 표시한다.
        /// </summary>
        void Show();

        /// <summary>
        /// 웹 주소에 접속한다.
        /// </summary>
        /// <param name="url">웹 주소</param>
        void Navigate(string url);

        event WebBrowserNavigatedEventHandler Navigated;
        event WebBrowserDocumentCompletedEventHandler DocumentCompleted;
        event EventHandler StatusTextChanged;

    }
}
