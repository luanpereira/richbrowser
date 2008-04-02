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
using OpenCS.Common.Plugin;

namespace OpenCS.RBP.Controls
{
    public partial class RichBrowserControl : UserControl, IPluginHost
    {
        private List<IPlugin> m_plugins = new List<IPlugin>();

        public RichBrowserControl()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string appPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string pluginsFolder = appPath + @"\Plugins";

            LoadPlugins(pluginsFolder);
        }

        #region IPluginHost 멤버

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
                                    plugin.Init();

                                    m_plugins.Add(plugin);
                                }

                            }
                        }
                    }
                }
            }
        }

        public List<IPlugin> Plugins
        {
            get { return m_plugins; }
        }

        #endregion
    }
}
