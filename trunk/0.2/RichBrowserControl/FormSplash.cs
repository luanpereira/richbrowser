using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using JinwooMin.Logging;
using System.Threading;

namespace JinwooMin.RichBrowserControl
{
    public partial class FormSplash : Form, ILogger
    {
        public static FormSplash ms_frmSplash = null;

        public FormSplash()
        {
            InitializeComponent();
        }

        // A static entry point to launch FormSplash.
        static public void ShowForm()
        {
            Application.DoEvents();
            ms_frmSplash = new FormSplash();
            ms_frmSplash.Show();
            //Application.Run(ms_frmSplash);
        }

        // A static method to close the FormSplash
        static public void CloseForm()
        {
            Application.DoEvents();
            Thread.Sleep(2000);
            ms_frmSplash.Close();
        }

        static public ILogger GetLogger()
        {
            return ms_frmSplash;
        }

        private static void AddItem(string msg)
        {
            Application.DoEvents();
            ms_frmSplash.Focus();
            ms_frmSplash.listBoxLog.Items.Add(msg);
            ms_frmSplash.listBoxLog.SelectedIndex = ms_frmSplash.listBoxLog.Items.Count - 1;
        }

        #region ILogger Members

        public LogOptions Options
        {
            get
            {
                return LogOptions.ALL;
            }
            set
            {
                ;
            }
        }

        public void Fatal(string msg)
        {
            AddItem(msg);
        }

        public void Error(string msg)
        {
            AddItem(msg);
        }

        public void Info(string msg)
        {
            AddItem(msg);
        }

        public void Warn(string msg)
        {
            //AddItem(msg);
        }

        public void Debug(string msg)
        {
            //AddItem(msg);
        }

        #endregion
    }
}