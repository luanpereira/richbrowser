using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using OpenCS.Common;
using OpenCS.Common.Plugin;
using OpenCS.Common.Action;

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

        /// <summary>
        /// 툴바 버튼을 추가한다.
        /// </summary>
        /// <param name="text">텍스트</param>
        /// <param name="action">버튼이 눌렸을 때 처리할 액션</param>
        /// <returns>생성된 툴바 버튼</returns>
        object AddToolBarButton(string text, IAction action);

        /// <summary>
        /// 툴바 버튼을 삭제한다.
        /// </summary>
        /// <param name="button">툴바 버튼 객체</param>
        void RemoveToolBarButton(object button);

        /// <summary>
        /// 메뉴 아이템을 추가한다.
        /// </summary>
        /// <param name="text">텍스트</param>
        /// <param name="action">메뉴를 클릭했을 때 처리할 액션</param>
        /// <returns>생성된 메뉴 아이템 객체</returns>
        object AddMenuItem(string text, IAction action);

        /// <summary>
        /// 메뉴 아이템을 삭제한다.
        /// </summary>
        /// <param name="menuItem">메뉴 아이템 객체</param>
        void RemoveMenuItem(object menuItem);

    }
}
