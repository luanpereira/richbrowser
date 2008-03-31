using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RBPcsEXWB;

namespace DemoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            richBrowserControl1.WebBrowserFactory = new csEXWBWebBrowserFactory();
            //richBrowserControl1.WebBrowserFactory = new DefaultWebBrowserFactory();
        }
    }
}