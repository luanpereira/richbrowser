using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Diagnostics;
using WeifenLuo.WinFormsUI.Docking;
using OpenCS.Common;
using OpenCS.Common.Plugin;
using OpenCS.Common.Action;

namespace OpenCS.RBP.Controls
{
    /// <summary>
    /// 리치 브라우저 콘트롤
    /// </summary>
    public partial class RichBrowserControl : UserControl, IRichBrowserControl
    {
        private List<IPlugin> m_plugins = new List<IPlugin>();
        private DCPlugins m_dcPlugins;
        private GenericClassFactory<IWebBrowserDockContent> m_wbdcf;

        /// <summary>
        /// 생성자
        /// </summary>
        public RichBrowserControl()
        {
            InitializeComponent();

            InitDockPanel(dockPanelMain);

            m_dcPlugins = new DCPlugins();
            m_dcPlugins.Show(dockPanelMain, DockState.DockLeft);
        }

        private void InitDockPanel(DockPanel dp)
        {
            dp.DocumentStyle = DocumentStyle.DockingWindow;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string appPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string pluginsFolder = appPath + @"\Plugins";

            LoadPlugins(pluginsFolder);
        }

        #region IPluginHost 멤버

        /// <summary>
        /// 플러그인들을 로딩한다.
        /// </summary>
        /// <param name="baseFolder">플러그인들이 위치한 기본 폴더</param>
        public void LoadPlugins(string baseFolder)
        {
            foreach (string pluginFolder in Directory.GetDirectories(baseFolder))
            {
                foreach (string file in Directory.GetFiles(pluginFolder, "*.dll"))
                {
                    if (file.EndsWith("Plugin.dll") == true)
                    {
                        Assembly asm = Assembly.LoadFrom(file);
                        foreach (Type type in asm.GetTypes())
                        {
                            Debug.Print(type.ToString());
                            Type ifType = type.GetInterface(typeof(IPlugin).FullName, false);
                            if (ifType != null && type.IsAbstract == false)
                            {
                                Debug.Print(ifType.ToString());
                                object obj = asm.CreateInstance(type.FullName);
                                if (obj != null && obj is IPlugin)
                                {
                                    IPlugin plugin = obj as IPlugin;
                                    plugin.PluginHost = this;
                                    if (plugin is IRbpPlugin)
                                    {
                                        (plugin as IRbpPlugin).RichBrowserControl = this;
                                    }
                                    plugin.Init();

                                    m_plugins.Add(plugin);
                                    m_dcPlugins.AddPlugin(plugin);

                                    if (plugin is IPanelPlugin)
                                    {
                                        (plugin as IPanelPlugin).Show(dockPanelMain, DockState.DockLeft);
                                    }

                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 플러그인 목록을 가져온다.
        /// </summary>
        public List<IPlugin> Plugins
        {
            get { return m_plugins; }
        }

        #endregion

        #region IRichBrowserControl 멤버

        public DockPanel DockPanel
        {
            get { return dockPanelMain; }
        }

        public IWebBrowser Navigate(string url)
        {
            IWebBrowserDockContent wbdc = null;

            if (m_wbdcf != null)
            {
                wbdc = m_wbdcf.CreateClass();
                wbdc.Show(dockPanelMain, DockState.Document);
                wbdc.WebBrowser.Navigate(url);

                return wbdc.WebBrowser;
            }

            return null;
        }

        public GenericClassFactory<IWebBrowserDockContent> WebBrowserDockContentFactory
        {
            set { m_wbdcf = value; }
        }

        #endregion

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Navigate(toolStripTextBox1.Text);
        }

        private void toolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Return:
                    Navigate(toolStripTextBox1.Text);
                    e.SuppressKeyPress = true;
                    break;
            }
        }

        #region IActionHandler 멤버

        public ActionResult HandleAction(IAction action)
        {
            foreach (IPlugin plugin in m_plugins)
            {
                if (plugin.HandleAction(action) == ActionResult.Failed)
                {
                    return ActionResult.Failed;
                }
            }

            return ActionResult.Success;
        }

        #endregion
    }
}
