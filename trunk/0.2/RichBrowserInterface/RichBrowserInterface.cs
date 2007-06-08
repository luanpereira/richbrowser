using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using csExWB;
using WeifenLuo.WinFormsUI;
using JinwooMin.Logging;

namespace JinwooMin.RichBrowserInterface
{
    public enum PluginResult { None, Success, Fail, Cancel }
    public enum TopMenuItem { File, View, Tools, Help }

    public interface IPlugin : ILoggable
    {
        IPluginHost PluginHost
        {
            get;
            set;
        }

        string PluginPath
        {
            get;
            set;
        }

        void Init();
        void Deinit();

        PluginResult InitResult
        {
            get;
            set;
        }

        PluginResult DeinitResult
        {
            get;
            set;
        }
    }

    public interface IPluginHost
    {
        cEXWB ActiveWebBrowser
        {
            get;
        }

        ContainerControl ContainerControl
        {
            get;
        }

        ToolStripContainer ToolStripContainer
        {
            get;
        }

        MenuStrip MenuStrip
        {
            get;
        }

        DockPanel DockPanel
        {
            get;
        }

        /// <summary>
        /// 웹브라우저(WebBrowser)를 새로 연다.
        /// </summary>
        /// 
        void NewWebBrowser();

        /// <summary>
        /// 웹 페이지를 연다. 만약, 현재 활성화된 도큐먼트(Document)가 웹브라우저(WebBrowser)가 아니라면 웹브라우저를 새로 열고 웹 페이지를 연다.
        /// </summary>
        /// <param name="url">URL</param>		
        /// <returns>웹브라우저 객체. 어떤 웹브라우저 콘트롤을 쓰느냐에 따라 달라질 수 있다.</returns>
        /// 
        cEXWB Navigate(string url);

        /// <summary>
        /// 최 상위 메뉴아이템(ToolStripMenuItem) 을 가져온다.
        /// </summary>
        /// <param name="topMenuItem">최 상위 메뉴아이템의 ID</param>		
        /// <returns>ToolStripMenuItem</returns>
        /// 
        ToolStripMenuItem GetTopMenuItem(TopMenuItem topMenuItem);

        /// <summary>
        /// 메뉴에 새로운 메뉴아이템(ToolStripMenuItem)을 추가한다. 추가되는 위치는 도움말 메뉴 왼쪽에 추가된다.
        /// </summary>
        /// <param name="menuItem">추가할 메뉴아이템</param>		
        /// 
        void AddMenuItem(ToolStripMenuItem menuItem);

    }
}
