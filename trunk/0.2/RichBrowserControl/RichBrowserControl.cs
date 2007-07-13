using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using JinwooMin.RichBrowserInterface;
using csExWB;
using WeifenLuo.WinFormsUI;
using IfacesEnumsStructsClasses;
using JinwooMin.Logging;
using System.Runtime.InteropServices;

namespace JinwooMin.RichBrowserControl
{
    public partial class RichBrowserControl : UserControl, IPluginHost
    {
        #region Members

        private PluginLoader m_pluginLoader = null;
        private PluginLoader m_customPluginLoader = null;

        private string PLATFORM_DATA_PATH = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).ToString() + "\\RichBrowserPlatform";

        private LogManager m_logger;

        /// <summary>
        /// TODO
        /// </summary>
        public LogManager Logger
        {
            get { return m_logger; }
        }

        #region Show/Hide Toolbars

        /// <summary>
        /// TODO
        /// </summary>
        public bool ShowWebToolbar
        {
            get { return toolStripWeb.Visible; }
            set
            {
                SetVisibleWebToolbar(value);
            }
        }

        /// <summary>
        /// TODO
        /// </summary>
        public bool ShowAddressToolbar
        {
            get { return toolStripAddress.Visible; }
            set
            {
                SetVisibleAddressToolbar(value);
            }
        }

        /// <summary>
        /// TODO
        /// </summary>
        public bool ShowMenubar
        {
            get { return menuStripMain.Visible; }
            set { menuStripMain.Visible = value; }
        }

        /// <summary>
        /// TODO
        /// </summary>
        public bool ShowTabToolbar
        {
            get { return toolStripTab.Visible; }
            set
            {
                SetVisibleTabToolbar(value);
            }
        }

        #endregion

        #endregion

        #region Constructor

        /// <summary>
        /// TODO
        /// </summary>
        public RichBrowserControl()
        {
            string splashFile = Application.StartupPath + "\\splash.png";
            if (File.Exists(splashFile) == true)
            {
                Bitmap bitmap = new Bitmap(splashFile);
                FormSplash.ShowForm(bitmap);
            }
            else
            {
                FormSplash.ShowForm();
            }

            InitializeComponent();

            if (Logger == null)
            {
                m_logger = new LogManager();
            }
            Logger.AddLogger(new ConsoleLogger(), LogOptions.ALL);
            Logger.AddLogger(new TextFileLogger(PLATFORM_DATA_PATH + "\\richbrowserplatform.log"),
                LogOptions.FATAL | LogOptions.ERROR | LogOptions.WARN | LogOptions.INFO
                | ((Properties.Settings.Default.DebugLogEnabled == true) ? LogOptions.DEBUG : LogOptions.NONE));
            Logger.AddLogger(new ToolStripItemLogger(toolStripStatusLabelMessage),
                LogOptions.FATAL | LogOptions.ERROR | LogOptions.WARN | LogOptions.INFO);
            Logger.AddLogger(new MessageBoxLogger(), LogOptions.FATAL | LogOptions.ERROR);

            Logger.AddLogger(FormSplash.GetLogger(),
                LogOptions.FATAL | LogOptions.ERROR | LogOptions.WARN | LogOptions.INFO);

            Logger.Info(Properties.Resources.MSG_RBP_STARTING);

            #region Resources
            toolStripTab.Text = Properties.Resources.LABEL_TAB;
            toolStripWeb.Text = Properties.Resources.LABEL_WEB;
            toolStripAddress.Text = Properties.Resources.LABEL_ADDRESS;

            tabToolStripMenuItem.Text = Properties.Resources.MENU_TAB;
            tabToolStripMenuItem1.Text = Properties.Resources.MENU_TAB;
            webToolStripMenuItem.Text = Properties.Resources.MENU_WEB;
            webToolStripMenuItem1.Text = Properties.Resources.MENU_WEB;
            addressToolStripMenuItem.Text = Properties.Resources.MENU_ADDRESS;
            addressToolStripMenuItem1.Text = Properties.Resources.MENU_ADDRESS;

            SetVisibleTabToolbar(Properties.Settings.Default.ShowTabToolbar);
            SetVisibleWebToolbar(Properties.Settings.Default.ShowWebToolbar);
            SetVisibleAddressToolbar(Properties.Settings.Default.ShowAddressToolbar);
            #endregion
        }

        #endregion

        #region IPluginHost Members

        /// <summary>
        /// TODO
        /// </summary>
        public cEXWB ActiveWebBrowser
        {
            get
            {
                if (dockPanelMain.ActiveDocument as WebBrowserDockContent != null)
                {
                    return (dockPanelMain.ActiveDocument as WebBrowserDockContent).WebBrowser;
                }
                return null;
            }
        }

        /// <summary>
        /// TODO
        /// </summary>
        public ToolStripContainer ToolStripContainer
        {
            get { return toolStripContainerMain; }
        }

        /// <summary>
        /// TODO
        /// </summary>
        public MenuStrip MenuStrip
        {
            get { return menuStripMain; }
        }

        /// <summary>
        /// TODO
        /// </summary>
        public DockPanel DockPanel
        {
            get { return dockPanelMain; }
        }

        /// <summary>
        /// TODO
        /// </summary>
        public ContainerControl ContainerControl
        {
            get { return this; }
        }

        /// <summary>
        /// TODO
        /// </summary>
        public void NewWebBrowser()
        {
            MakeNewWebBrowser();
        }

        private WebBrowserDockContent FoundWebDC()
        {
            if (dockPanelMain.ActiveDocument is WebBrowserDockContent)
            {
                return dockPanelMain.ActiveDocument as WebBrowserDockContent;
            }

            // found webbrowser
            WebBrowserDockContent webDC = null;
            foreach (DockContent dc in dockPanelMain.Contents)
            {
                if (dc is WebBrowserDockContent)
                {
                    webDC = dc as WebBrowserDockContent;
                    webDC.Show();
                    break;
                }
            }

            if (webDC == null)
            {
                webDC = MakeNewWebBrowser();
                dockPanelMain.Refresh();
            }

            return webDC;
        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public cEXWB Navigate(string url)
        {
            // found webbrowser
            WebBrowserDockContent webDC = FoundWebDC();
            webDC.WebBrowser.Navigate(url);

            return webDC.WebBrowser;
        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="url"></param>
        /// <param name="postData"></param>
        /// <returns></returns>
        public cEXWB Navigate(string url, byte[] postData)
        {
            WebBrowserDockContent webDC = FoundWebDC();
            webDC.WebBrowser.Navigate(url, postData);

            return webDC.WebBrowser;
        }

        private ToolStripMenuItem FindMenuItem(string text)
        {
            ToolStripItem[] items = menuStripMain.Items.Find(text, false);
            if (items.Length > 0)
            {
                return items[0] as ToolStripMenuItem;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// TODO
        /// </summary>
        public ToolStripMenuItem GetTopMenuItem(TopMenuItem topMenuItem)
        {
            ToolStripMenuItem menuItem = null;

            switch (topMenuItem)
            {
                case TopMenuItem.File:
                    menuItem = FindMenuItem(fileToolStripMenuItem.Name);
                    break;

                case TopMenuItem.View:
                    menuItem = FindMenuItem(viewToolStripMenuItem.Name);
                    break;

                case TopMenuItem.Tools:
                    menuItem = FindMenuItem(toolsToolStripMenuItem.Name);
                    break;

                case TopMenuItem.Help:
                    menuItem = FindMenuItem(helpToolStripMenuItem.Name);
                    break;
            }

            return menuItem;
        }

        /// <summary>
        /// TODO
        /// </summary>
        public void AddMenuItem(ToolStripMenuItem menuItem)
        {
            // view menu 다음에 추가한다.
            menuStripMain.Items.Insert(2, menuItem);
        }

        #endregion

        #region Control init/deinit

        private void RichBrowserControl_Load(object sender, EventArgs e)
        {
            #region event handler

            ParentForm.FormClosing += new FormClosingEventHandler(parentForm_FormClosing);

            toolStripButtonNew.Click += new EventHandler(toolStripButtonNew_Click);
            toolStripButtonBack.Click += new EventHandler(toolStripButtonBack_Click);
            toolStripButtonForward.Click += new EventHandler(toolStripButtonForward_Click);
            toolStripButtonStop.Click += new EventHandler(toolStripButtonStop_Click);
            toolStripButtonRefresh.Click += new EventHandler(toolStripButtonRefresh_Click);
            toolStripButtonHome.Click += new EventHandler(toolStripButtonHome_Click);
            toolStripButtonGo.Click += new EventHandler(toolStripButtonGo_Click);

            toolStripLabelAddress.Click += new EventHandler(toolStripLabelAddress_Click);

            toolStripTextBoxAddress.KeyUp += new KeyEventHandler(toolStripTextBoxAddress_KeyUp);
            toolStripTextBoxAddress.KeyDown += new KeyEventHandler(toolStripTextBoxAddress_KeyDown);

            dockPanelMain.ActiveDocumentChanged += new EventHandler(dockPanelMain_ActiveDocumentChanged);

            #endregion


            dockPanelMain.Dock = DockStyle.Fill;
            dockPanelMain.DocumentStyle = DocumentStyles.DockingWindow;

            toolStripProgressBarMain.Visible = false;

            SetToolbar();

            // base plugins
            m_pluginLoader = new PluginLoader(m_logger, PLATFORM_DATA_PATH, this, Application.StartupPath + "\\Plugins", "*Plugin.dll");
            m_pluginLoader.Load();

            // custom plugins
            //if (Properties.Settings.Default.CustomPluginsPath != "NULL")
            {
                m_customPluginLoader = new PluginLoader(m_logger, PLATFORM_DATA_PATH, this, Application.StartupPath + "\\CustomPlugins", "*Plugin.dll");
                m_customPluginLoader.Load();
            }
            Properties.Settings.Default.Save();

            Logger.Info(Properties.Resources.MSG_RBP_STARTED);

            m_logger.RemoveLogger(FormSplash.GetLogger());
            FormSplash.CloseForm();
        }

        private void parentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Logger.Info(Properties.Resources.MSG_RBP_FINISHING);

            // deinit plugins
            if (m_pluginLoader.Unload() == PluginResult.Cancel)
            {
                e.Cancel = true;
                Logger.Info(Properties.Resources.MSG_RBP_FINISHING_CANCELED);
                return;
            }

            // custom plugins
            if (Properties.Settings.Default.CustomPluginsPath != "NULL")
            {
                if (m_customPluginLoader.Unload() == PluginResult.Cancel)
                {
                    e.Cancel = true;
                    Logger.Info(Properties.Resources.MSG_RBP_FINISHING_CANCELED);
                    return;
                }
            }

            while (dockPanelMain.Contents.Count > 0)
            {
                (dockPanelMain.Contents[0] as DockContent).Close();
            }

            Logger.Info(Properties.Resources.MSG_RBP_FINISHED);
        }

        #endregion

        #region WebBrowser features

        /// <summary>
        /// TODO
        /// </summary>
        public void GoAddress()
        {
            GoAddress(toolStripTextBoxAddress.Text);
        }

        /// <summary>
        /// TODO
        /// </summary>
        public void GoAddress(string url)
        {
            WebBrowserDockContent webDC = dockPanelMain.ActiveDocument as WebBrowserDockContent;
            if (webDC == null)
            {
                webDC = MakeNewWebBrowser();
            }
            webDC.WebBrowser.Navigate(url);
        }

        private WebBrowserDockContent MakeNewWebBrowser()
        {
            WebBrowserDockContent webDC = new WebBrowserDockContent();
            webDC.WebBrowser.CommandStateChange += new CommandStateChangeEventHandler(webBrowser_CommandStateChange);
            webDC.WebBrowser.BeforeNavigate2 += new BeforeNavigate2EventHandler(webBrowser_BeforeNavigate2);
            //webDC.WebBrowser.NavigateComplete2 += new NavigateComplete2EventHandler(webBrowser_NavigateComplete2);
            webDC.WebBrowser.DocumentComplete += new DocumentCompleteEventHandler(webBrowser_DocumentComplete);
            webDC.WebBrowser.ProgressChange += new ProgressChangeEventHandler(webBrowser_ProgressChange);
            webDC.WebBrowser.StatusTextChange += new StatusTextChangeEventHandler(webBrowser_StatusTextChange);
            webDC.Show(dockPanelMain, DockState.Document);

            return webDC;
        }

        private void GoBack()
        {
            if (ActiveWebBrowser != null)
            {
                ActiveWebBrowser.GoBack();
            }
        }

        private void GoForward()
        {
            if (ActiveWebBrowser != null)
            {
                ActiveWebBrowser.GoForward();
            }
        }

        private void StopLoading()
        {
            if (ActiveWebBrowser != null)
            {
                ActiveWebBrowser.Stop();
            }
        }

        private void Reload()
        {
            if (ActiveWebBrowser != null)
            {
                ActiveWebBrowser.Refresh();
            }
        }

        private void GoHome()
        {
            if (ActiveWebBrowser != null)
            {
                ActiveWebBrowser.GoHome();
            }
        }

        #region WebBrowser event handling

        private void webBrowser_BeforeNavigate2(object sender, BeforeNavigate2EventArgs e)
        {
            Logger.Debug("webBrowser_BeforeNavigate2.");
            toolStripProgressBarMain.Visible = true;
        }

        private void webBrowser_DocumentComplete(object sender, DocumentCompleteEventArgs e)
        {
            //
            Logger.Debug("documentcompleted. e=" + e.url);
            toolStripTextBoxAddress.Text = e.url;
        }

        private void webBrowser_NavigateComplete2(object sender, NavigateComplete2EventArgs e)
        {
            Logger.Debug("location=" + e.url);
            toolStripProgressBarMain.Visible = false;
        }

        private void webBrowser_ProgressChange(object sender, ProgressChangeEventArgs e)
        {
            Logger.Debug("progresschange=" + e.progress);
            if (e.progress >= 0 && e.progress <= 100)
            {
                toolStripProgressBarMain.Value = e.progress;
            }
            //toolStripProgressBarMain.Visible = (e.progress == 100) ? false : true;
        }

        private void webBrowser_StatusTextChange(object sender, StatusTextChangeEventArgs e)
        {
            Logger.Debug("webBrowser_StatusTextChange=" + e.text);
            toolStripStatusLabelMessage.Text = e.text;
        }

        private void webBrowser_CommandStateChange(object sender, CommandStateChangeEventArgs e)
        {
            Logger.Debug("command=" + e.command.ToString());
            if (dockPanelMain.ActiveDocument is WebBrowserDockContent)
            {
                switch (e.command)
                {
                    case CommandStateChangeConstants.CSC_NAVIGATEBACK:
                        toolStripButtonBack.Enabled = e.enable;
                        break;

                    case CommandStateChangeConstants.CSC_NAVIGATEFORWARD:
                        toolStripButtonForward.Enabled = e.enable;
                        break;
                }
            }
        }

        #endregion

        #endregion

        #region Toolbar event handling

        private void toolStripTextBoxAddress_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void toolStripTextBoxAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // no beep
                // ref: http://www.vbforums.com/showthread.php?t=394442
                e.SuppressKeyPress = true;

                GoAddress();
            }
        }

        private void toolStripButtonGo_Click(object sender, EventArgs e)
        {
            GoAddress();
        }

        private void toolStripLabelAddress_Click(object sender, EventArgs e)
        {
            toolStripTextBoxAddress.Focus();
        }

        private void toolStripButtonBack_Click(object sender, EventArgs e)
        {
            GoBack();
        }

        private void toolStripButtonForward_Click(object sender, EventArgs e)
        {
            GoForward();
        }

        private void toolStripButtonStop_Click(object sender, EventArgs e)
        {
            StopLoading();
        }

        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void toolStripButtonHome_Click(object sender, EventArgs e)
        {
            GoHome();
        }

        private void toolStripButtonNew_Click(object sender, EventArgs e)
        {
            MakeNewWebBrowser();
        }

        private void toolStripButtonCloseTab_Click(object sender, EventArgs e)
        {
            CloseTab();
        }

        #endregion

        #region Toolbar setting

        private void SetToolbar()
        {
            if (ActiveWebBrowser != null)
            {
                toolStripButtonBack.Enabled = ActiveWebBrowser.CanGoBack;
                toolStripButtonForward.Enabled = ActiveWebBrowser.CanGoForward;
                toolStripButtonStop.Enabled = true;// ActiveWebBrowser.Busy;
                toolStripButtonRefresh.Enabled = true;
                toolStripButtonHome.Enabled = true;
            }
            else
            {
                toolStripButtonBack.Enabled = false;
                toolStripButtonForward.Enabled = false;
                toolStripButtonStop.Enabled = false;
                toolStripButtonRefresh.Enabled = false;
                toolStripButtonHome.Enabled = false;
            }
        }

        #endregion

        #region DockPanel event handling

        private void dockPanelMain_ActiveDocumentChanged(object sender, EventArgs e)
        {
            SetToolbar();
        }

        #endregion

        #region Menu event handling

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParentForm.Close();
        }

        private void nextTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dockPanelMain.Documents.Length; i++)
            {
                IDockContent dc = dockPanelMain.Documents[i];
                if (dc.DockHandler.IsActivated == true)
                {
                    // found next document
                    int j = 0;
                    if (i < dockPanelMain.Documents.Length - 1)
                    {
                        j = i + 1;
                    }
                    dockPanelMain.Documents[j].DockHandler.Show();
                    break;
                }
            }
        }

        private void previousTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = dockPanelMain.Documents.Length - 1; i >= 0; i--)
            {
                IDockContent dc = dockPanelMain.Documents[i];
                if (dc.DockHandler.IsActivated == true)
                {
                    // found prev document
                    int j = dockPanelMain.Documents.Length - 1;
                    if (i > 0)
                    {
                        j = i - 1;
                    }
                    dockPanelMain.Documents[j].DockHandler.Show();
                    break;
                }
            }
        }

        private void closeTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseTab();
        }

        private void CloseTab()
        {
            if (dockPanelMain.ActiveDocument != null)
            {
                dockPanelMain.ActiveDocument.DockHandler.Close();

                // 남은 document가 있다면 focus를 준다.
                if (dockPanelMain.ActiveDocument != null)
                {
                    dockPanelMain.ActiveDocument.DockHandler.Form.Focus();
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInformation dlg = new FormInformation();
            dlg.ShowDialog();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO
        }
        #endregion

        private void SetVisibleTabToolbar(bool visible)
        {
            tabToolStripMenuItem.Checked = visible;
            tabToolStripMenuItem1.Checked = visible;
            toolStripTab.Visible = visible;

            Properties.Settings.Default.ShowTabToolbar = visible;
            Properties.Settings.Default.Save();
        }

        private void SetVisibleWebToolbar(bool visible)
        {
            webToolStripMenuItem.Checked = visible;
            webToolStripMenuItem1.Checked = visible;
            toolStripWeb.Visible = visible;

            Properties.Settings.Default.ShowWebToolbar = visible;
            Properties.Settings.Default.Save();
        }

        private void SetVisibleAddressToolbar(bool visible)
        {
            addressToolStripMenuItem.Checked = visible;
            addressToolStripMenuItem1.Checked = visible;
            toolStripAddress.Visible = visible;

            Properties.Settings.Default.ShowAddressToolbar = visible;
            Properties.Settings.Default.Save();
        }

        private void tabToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem)
            {
                SetVisibleTabToolbar((sender as ToolStripMenuItem).Checked);
            }
        }

        private void webToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem)
            {
                SetVisibleWebToolbar((sender as ToolStripMenuItem).Checked);
            }
        }

        private void addressToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem)
            {
                SetVisibleAddressToolbar((sender as ToolStripMenuItem).Checked);
            }
        }

    }
}