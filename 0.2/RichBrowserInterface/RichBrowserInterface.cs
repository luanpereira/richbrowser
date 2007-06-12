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
        /// ��������(WebBrowser)�� ���� ����.
        /// </summary>
        /// 
        void NewWebBrowser();

        /// <summary>
        /// �� �������� ����. ����, ���� Ȱ��ȭ�� ��ť��Ʈ(Document)�� ��������(WebBrowser)�� �ƴ϶�� ���������� ���� ���� �� �������� ����.
        /// </summary>
        /// <param name="url">URL</param>		
        /// <returns>�������� ��ü. � �������� ��Ʈ���� �����Ŀ� ���� �޶��� �� �ִ�.</returns>
        /// 
        cEXWB Navigate(string url);

        /// <summary>
        /// �� �������� ����. ����, ���� Ȱ��ȭ�� ��ť��Ʈ(Document)�� ��������(WebBrowser)�� �ƴ϶�� ���������� ���� ���� �� �������� ����.
        /// </summary>
        /// <param name="url">URL</param>		
        /// <param name="postData">Post Data</param>		
        /// <returns>�������� ��ü. � �������� ��Ʈ���� �����Ŀ� ���� �޶��� �� �ִ�.</returns>
        /// 
        cEXWB Navigate(string url, byte[] postData);

        /// <summary>
        /// �� ���� �޴�������(ToolStripMenuItem) �� �����´�.
        /// </summary>
        /// <param name="topMenuItem">�� ���� �޴��������� ID</param>		
        /// <returns>ToolStripMenuItem</returns>
        /// 
        ToolStripMenuItem GetTopMenuItem(TopMenuItem topMenuItem);

        /// <summary>
        /// �޴��� ���ο� �޴�������(ToolStripMenuItem)�� �߰��Ѵ�. �߰��Ǵ� ��ġ�� ���� �޴� ���ʿ� �߰��ȴ�.
        /// </summary>
        /// <param name="menuItem">�߰��� �޴�������</param>		
        /// 
        void AddMenuItem(ToolStripMenuItem menuItem);

    }
}
