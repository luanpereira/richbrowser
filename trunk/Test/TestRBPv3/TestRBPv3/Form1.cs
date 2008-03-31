using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OpenCS.Plugin;
using System.IO;
using System.Reflection;
using System.Diagnostics;

namespace TestRBPv3
{
    public partial class Form1 : Form, IPluginHost
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string appPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string pluginsFolder = appPath + @"\Plugins";

            foreach (string pluginFolder in Directory.GetDirectories(pluginsFolder))
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
                            if (ifType != null)
                            {
                                Debug.Print(ifType.ToString());
                                object obj = asm.CreateInstance(type.FullName);
                                if (obj != null)
                                {
                                    IPlugin plugin = obj as IPlugin;
                                    plugin.PluginHost = this;
                                    plugin.Init();
                                }

                            }
                        }
                    }
                }
            }
        }
    }
}