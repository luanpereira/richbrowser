using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using csExWB;
using WeifenLuo.WinFormsUI;
using JinwooMin.Logging;

namespace JinwooMin.RichBrowserInterface
{
    /// <summary>
    /// TODO
    /// </summary>
    public enum PluginResult {

        /// <summary>
        /// TODO
        /// </summary>
        None,

        /// <summary>
        /// TODO
        /// </summary>
        Success,

        /// <summary>
        /// TODO
        /// </summary>
        Fail,

        /// <summary>
        /// TODO
        /// </summary>
        Cancel
    }

    /// <summary>
    /// TODO
    /// </summary>
    public enum TopMenuItem {

        /// <summary>
        /// TODO
        /// </summary>
        File,

        /// <summary>
        /// TODO
        /// </summary>
        View,

        /// <summary>
        /// TODO
        /// </summary>
        Tools,

        /// <summary>
        /// TODO
        /// </summary>
        Help
    }

    /// <summary>
    /// TODO
    /// </summary>
    public interface IPlugin : ILoggable
    {
        /// <summary>
        /// TODO
        /// </summary>
        IPluginHost PluginHost
        {
            get;
            set;
        }

        /// <summary>
        /// TODO
        /// </summary>
        string PluginPath
        {
            get;
            set;
        }

        /// <summary>
        /// TODO
        /// </summary>
        string PlatformDataPath
        {
            get;
            set;
        }

        /// <summary>
        /// TODO
        /// </summary>
        void Init();

        /// <summary>
        /// TODO
        /// </summary>
        void Deinit();

        /// <summary>
        /// TODO
        /// </summary>
        PluginResult InitResult
        {
            get;
            set;
        }

        /// <summary>
        /// TODO
        /// </summary>
        PluginResult DeinitResult
        {
            get;
            set;
        }
    }

    /// <summary>
    /// TODO
    /// </summary>
    public interface IPluginHost
    {
        /// <summary>
        /// TODO
        /// </summary>
        cEXWB ActiveWebBrowser
        {
            get;
        }

        /// <summary>
        /// TODO
        /// </summary>
        ContainerControl ContainerControl
        {
            get;
        }

        /// <summary>
        /// TODO
        /// </summary>
        ToolStripContainer ToolStripContainer
        {
            get;
        }

        /// <summary>
        /// TODO
        /// </summary>
        MenuStrip MenuStrip
        {
            get;
        }

        /// <summary>
        /// TODO
        /// </summary>
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
        /// 웹 페이지를 연다. 만약, 현재 활성화된 도큐먼트(Document)가 웹브라우저(WebBrowser)가 아니라면 웹브라우저를 새로 열고 웹 페이지를 연다.
        /// </summary>
        /// <param name="url">URL</param>		
        /// <param name="postData">Post Data</param>		
        /// <returns>웹브라우저 객체. 어떤 웹브라우저 콘트롤을 쓰느냐에 따라 달라질 수 있다.</returns>
        /// 
        cEXWB Navigate(string url, byte[] postData);

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
