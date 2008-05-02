using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using OpenCS.Common.Plugin;
using WeifenLuo.WinFormsUI.Docking;
using OpenCS.Common.Action;

namespace OpenCS.RBP
{
    /// <summary>
    /// 웹 브라우저
    /// </summary>
    public interface IWebBrowser : IActionHandler
    {
        /// <summary>
        /// 상태바의 문자열을 가져온다.
        /// </summary>
        string StatusText
        {
            get;
        }

        /// <summary>
        /// 표시한다.
        /// </summary>
        void Show();

        /// <summary>
        /// 웹 주소에 접속한다.
        /// </summary>
        /// <param name="url">웹 주소</param>
        void Navigate(string url);

        /// <summary>
        /// WebBrowser의 Navigated 이벤트 핸들러
        /// </summary>
        event WebBrowserNavigatedEventHandler Navigated;

        /// <summary>
        /// WebBrowser의 DocumentCompleted 이벤트 핸들러
        /// </summary>
        event WebBrowserDocumentCompletedEventHandler DocumentCompleted;

        /// <summary>
        /// WebBrowser의 StatusTextChanged 이벤트 핸들러
        /// </summary>
        event EventHandler StatusTextChanged;

    }
}
