using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using JinwooMin.RichBrowserInterface;
using JinwooMin.Common;

namespace JinwooMin.RichBrowserControl
{
    public partial class FormInformation : Form
    {
        private PluginLoader m_pluginLoader;

        public PluginLoader PluginLoader
        {
            set { m_pluginLoader = value; }
        }

        public FormInformation()
        {
            InitializeComponent();

            labelProductName.Text = Application.ProductName;
            labelProductVersion.Text = "v" + VersionInfo.GetVersionOnly() + " " + VersionInfo.GetVersionStage() + VersionInfo.GetBuildNumber();

            Assembly asm = Assembly.GetAssembly(typeof(RichBrowserControl));
            string asmVersion = (asm.GetCustomAttributes(typeof(AssemblyFileVersionAttribute), false)[0] as AssemblyFileVersionAttribute).Version;
            labelPoweredBy.Text = labelPoweredBy.Text + " v" + asmVersion;
        }
    }
}