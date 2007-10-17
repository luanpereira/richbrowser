using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RichBrowserPlatform;
using RBPDefaultWebBrowser;
using RBPcsExWB;

namespace DemoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //richBrowserControl1.WebBrowserFactory = new csExWBWebBrowserFactory();
            richBrowserControl1.WebBrowserFactory = new DefaultWebBrowserFactory();
        }
    }
}