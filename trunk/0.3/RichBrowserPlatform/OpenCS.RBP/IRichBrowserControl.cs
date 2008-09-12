using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using OpenCS.Common;
using OpenCS.Common.Plugin;
using OpenCS.Common.Action;
using OpenCS.Common.Logging;

namespace OpenCS.RBP
{
    /// <summary>
    /// 리치 브라우저 콘트롤
    /// </summary>
    public interface IRichBrowserControl : IPluginHost
    {
        /// <summary>
        /// 로거를 가져오거나 설정한다.
        /// </summary>
        ILogger Logger
        {
            get;
            set;
        }

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
        /// 활성화되어 있는 웹 브라우저를 가져온다.
        /// </summary>
        IWebBrowser ActiveWebBrowser
        {
            get;
        }

        /// <summary>
        /// Gets or Sets MenuStrip visibility.
        /// </summary>
        [Browsable(true)]
        bool ShowMenuStrip
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or Sets WebToolStrip visibility.
        /// </summary>
        [Browsable(true)]
        bool ShowWebToolStrip
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or Sets AddressToolStrip visibility.
        /// </summary>
        [Browsable(true)]
        bool ShowAddressToolStrip
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or Sets SearchToolStrip visibility.
        /// </summary>
        [Browsable(true)]
        bool ShowSearchToolStrip
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or Sets StatusStrip visibility.
        /// </summary>
        [Browsable(true)]
        bool ShowStatusStrip
        {
            get;
            set;
        }

        /// <summary>
        /// 웹 브라우저를 새로 연다.
        /// </summary>
        /// <returns>웹 브라우저 독컨텐트</returns>
        IWebBrowserDockContent NewWebBrowser();

        /// <summary>
        /// 웹 브라우저를 새로 열고 해당 웹 주소로 접속한다.
        /// </summary>
        /// <param name="url">웹 주소</param>
        /// <returns>웹 브라우저 독컨텐트</returns>
        IWebBrowserDockContent NewWebBrowser(string url);

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
        /// 툴바 버튼을 추가한다.
        /// </summary>
        /// <param name="button">툴바 버튼 객체</param>
        /// <param name="action">버튼이 눌렸을 때 처리할 액션</param>
        void AddToolBarButton(ToolStripButton button, IAction action);

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
        /// 메뉴 아이템을 추가한다.
        /// </summary>
        /// <param name="item">메뉴 아이템 객체</param>
        /// <param name="action">메뉴를 클릭했을 때 처리할 액션</param>
        void AddMenuItem(ToolStripMenuItem item, IAction action);

        /// <summary>
        /// 메뉴 아이템을 삭제한다.
        /// </summary>
        /// <param name="menuItem">메뉴 아이템 객체</param>
        void RemoveMenuItem(object menuItem);
        /// <summary>
        /// 현재 실행되고 있는 어플리케이션 폴더 밑의 Plugins 폴더로부터 플러그인을 읽어 온다.
        /// </summary>
        void LoadPlugins();
    }
}
