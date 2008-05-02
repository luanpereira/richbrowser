using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Diagnostics;
using OpenCS.RBP.WinForms;

namespace TestRBPv3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            richBrowserControl1.WebBrowserDockContentFactory = new WinFormsWebBrowserDockContentFactory();

            this.Load+=new EventHandler(Form1_Load);
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
        }

        void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            richBrowserControl1.UnloadPlugins();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richBrowserControl1.LoadPlugins();
        }
    }
}