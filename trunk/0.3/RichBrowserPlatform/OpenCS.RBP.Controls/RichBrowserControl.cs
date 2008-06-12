using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using WeifenLuo.WinFormsUI.Docking;
using OpenCS.Common;
using OpenCS.Common.Plugin;
using OpenCS.Common.Action;
using OpenCS.Common.Logging;
using OpenCS.RBP.Actions;

namespace OpenCS.RBP.Controls
{
    /// <summary>
    /// 리치 브라우저 콘트롤
    /// </summary>
    public partial class RichBrowserControl : UserControl, IRichBrowserControl
    {
        #region Fields

        private List<IPlugin> m_plugins = new List<IPlugin>();
        private DCPlugins m_dcPlugins;
        private GenericClassFactory<IWebBrowserDockContent> m_wbdcf;
        private ILogger m_logger = new ConsoleLogger();

        #endregion Fields

        #region Properties

        #endregion Properties

        #region Constructors

        /// <summary>
        /// 생성자
        /// </summary>
        public RichBrowserControl()
        {
            InitializeComponent();

            InitDockPanel(dockPanelMain);

            m_dcPlugins = new DCPlugins();
            //m_dcPlugins.Show(dockPanelMain, DockState.DockLeft);

            dockPanelMain.ContentAdded += new EventHandler<DockContentEventArgs>(OnContentAdded);
            dockPanelMain.ContentRemoved += new EventHandler<DockContentEventArgs>(OnContentRemoved);
        }

        #endregion Constructors

        #region Private Functions

        #region Initialization

        private void InitDockPanel(DockPanel dp)
        {
            dp.DocumentStyle = DocumentStyle.DockingWindow;
        }

        #endregion Initialization

        #region Event handling

        #region Form

        #endregion Form

        #region Buttons

        private void toolStripButtonLoad_Click(object sender, EventArgs e)
        {
            string appPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string pluginsFolder = appPath + @"\Plugins";

            LoadPlugins(pluginsFolder);
        }

        private void toolStripButtonGo_Click(object sender, EventArgs e)
        {
            Navigate(toolStripTextBoxUrl.Text);
        }

        private void toolStripButtonShowPlugins_Click(object sender, EventArgs e)
        {
            m_dcPlugins.Show(dockPanelMain, DockState.DockLeft);
        }

        private void OnWebButtonClick(object sender, EventArgs e)
        {
            if (sender == toolStripButtonNew)
            {
                this.NewWebBrowser();
            }
            else
            {
                IWebBrowser wb = ActiveWebBrowser;
                if (wb == null)
                {
                    return;
                }

                else if (sender == toolStripButtonBack)
                {
                    wb.HandleAction(new GoBackwardAction());
                }
                else if (sender == toolStripButtonForward)
                {
                    wb.HandleAction(new GoForwardAction());
                }
            }
        }

        #endregion Buttons

        #region Menus

        private void pluginsToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            toolStripPlugins.Visible = pluginsToolStripMenuItem.Checked;
        }

        #endregion Menus

        private void toolStripTextBoxUrl_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Return:
                    Navigate(toolStripTextBoxUrl.Text);
                    e.SuppressKeyPress = true;
                    break;
            }
        }

        void OnContentAdded(object sender, DockContentEventArgs e)
        {
            if (e.Content is IWebBrowserDockContent)
            {
                IWebBrowserDockContent wbdc = e.Content as IWebBrowserDockContent;
                wbdc.NewWindow += new EventHandler<NewWindowEventArgs>(OnNewWindow);
            }
        }

        void OnContentRemoved(object sender, DockContentEventArgs e)
        {
            if (e.Content is IWebBrowserDockContent)
            {
                IWebBrowserDockContent wbdc = e.Content as IWebBrowserDockContent;
                wbdc.NewWindow -= OnNewWindow;
            }
        }

        #endregion Event handling

        #endregion Private Functions

        #region Protected Functions

        #endregion Protected Functions

        #region Public Functions

        #endregion Public Functions

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

        #region IPluginHost 멤버

        /// <summary>
        /// 플러그인 목록을 가져온다.
        /// </summary>
        public List<IPlugin> Plugins
        {
            get { return m_plugins; }
        }

        /// <summary>
        /// 플러그인들을 로딩한다.
        /// </summary>
        /// <param name="baseFolder">플러그인들이 위치한 기본 폴더</param>
        public void LoadPlugins(string baseFolder)
        {
            if (Directory.Exists(baseFolder) == false)
            {
                m_logger.Warn("Plugins folder is not found.");
                return;
            }

            foreach (string pluginFolder in Directory.GetDirectories(baseFolder))
            {
                foreach (string file in Directory.GetFiles(pluginFolder, "*.dll"))
                {
                    //if (file.EndsWith("Plugin.dll") == true)
                    {
                        Assembly asm = Assembly.LoadFrom(file);
                        foreach (Type type in asm.GetTypes())
                        {
                            m_logger.Debug(type.ToString());
                            Type ifType = type.GetInterface(typeof(IPlugin).FullName, false);
                            if (ifType != null && type.IsAbstract == false)
                            {
                                m_logger.Info("Found plugin: " + type.FullName);
                                object obj = asm.CreateInstance(type.FullName);
                                if (obj != null && obj is IPlugin)
                                {
                                    IPlugin plugin = obj as IPlugin;
                                    m_logger.Info("Plugin: " + plugin.Title);
                                    plugin.PluginHost = this;
                                    if (plugin is IRbpPlugin)
                                    {
                                        (plugin as IRbpPlugin).RichBrowserControl = this;
                                    }
                                    plugin.Init();
                                    m_logger.Info("Plugin Inited: " + plugin.Title);

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

        public void UnloadPlugins()
        {
            foreach (IPlugin plugin in m_plugins)
            {
                plugin.Deinit();
                m_logger.Info("Plugin Deinited: " + plugin.Title);
            }
        }

        #endregion

        #region IRichBrowserControl 멤버

        public DockPanel DockPanel
        {
            get { return dockPanelMain; }
        }

        public ILogger Logger
        {
            get
            {
                return m_logger;
            }
            set
            {
                m_logger = value;
            }
        }

        public IWebBrowser ActiveWebBrowser
        {
            get
            {
                if (DockPanel.ActiveDocument != null && DockPanel.ActiveDocument is IWebBrowserDockContent)
                {
                    return (DockPanel.ActiveDocument as IWebBrowserDockContent).WebBrowser;
                }

                return null;
            }

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

            m_logger.Fatal("Can't found WebBrowserDockContentFactory");

            return null;
        }

        void OnNewWindow(object sender, NewWindowEventArgs e)
        {
            Navigate(e.Url);
        }

        public GenericClassFactory<IWebBrowserDockContent> WebBrowserDockContentFactory
        {
            set { m_wbdcf = value; }
        }

        public object AddToolBarButton(string text, IAction action)
        {
            ToolStripButton button = new ToolStripButton(text);

            AddToolBarButton(button, action);

            return button;
        }

        public void AddToolBarButton(ToolStripButton button, IAction action)
        {
            button.Click += new EventHandler(OnToolBarButtonClick);
            button.Tag = action;
            toolStripPlugins.Items.Add(button);
        }

        public void RemoveToolBarButton(object button)
        {
            toolStripPlugins.Items.Remove(button as ToolStripItem);
        }

        void OnToolBarButtonClick(object sender, EventArgs e)
        {
            if (sender is ToolStripButton)
            {
                ToolStripButton button = sender as ToolStripButton;
                if (button.Tag is IAction)
                {
                    HandleAction(button.Tag as IAction);
                }
            }
        }

        public object AddMenuItem(string text, IAction action)
        {
            ToolStripMenuItem item = new ToolStripMenuItem(text);

            AddMenuItem(item, action);

            return item;
        }

        public void AddMenuItem(ToolStripMenuItem item, IAction action)
        {
            item.Tag = action;
            item.Click += new EventHandler(OnMenuItemClick);
            toolsToolStripMenuItem.DropDownItems.Add(item);
        }

        void OnMenuItemClick(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem)
            {
                ToolStripMenuItem item = (sender as ToolStripMenuItem);
                if (item.Tag is IAction)
                {
                    HandleAction(item.Tag as IAction);
                }
            }
        }

        public void RemoveMenuItem(object menuItem)
        {
            toolsToolStripMenuItem.DropDownItems.Remove(menuItem as ToolStripItem);
        }

        public IWebBrowserDockContent NewWebBrowser()
        {
            IWebBrowserDockContent wbdc = null;

            if (m_wbdcf != null)
            {
                wbdc = m_wbdcf.CreateClass();
                wbdc.Show(dockPanelMain, DockState.Document);
            }

            return wbdc;
        }

        public IWebBrowserDockContent NewWebBrowser(string url)
        {
            IWebBrowserDockContent wbdc = NewWebBrowser();
            if (wbdc != null)
            {
                wbdc.WebBrowser.Navigate(url);
            }

            return wbdc;
        }

        public void LoadPlugins()
        {
            string appPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string pluginsFolder = appPath + @"\Plugins";

            LoadPlugins(pluginsFolder);
        }

        #endregion

    }
}
