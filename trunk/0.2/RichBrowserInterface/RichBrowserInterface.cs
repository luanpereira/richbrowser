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
