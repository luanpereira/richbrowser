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
        /// <summary>
        /// TODO
        /// </summary>
        public static FormSplash ms_frmSplash = null;

        /// <summary>
        /// TODO
        /// </summary>
        public FormSplash()
        {
            InitializeComponent();

            // resources
            this.Text = Properties.Resources.LABEL_LOADING;
        }

        
        /// <summary>
        /// A static entry point to launch FormSplash.
        /// </summary>
        static public void ShowForm()
        {
            Application.DoEvents();
            ms_frmSplash = new FormSplash();
            ms_frmSplash.Show();
            //Application.Run(ms_frmSplash);
        }

        /// <summary>
        /// A static method to close the FormSplash
        /// </summary>
        static public void CloseForm()
        {
            Application.DoEvents();
            Thread.Sleep(2000);
            ms_frmSplash.Close();
        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// TODO
        /// </summary>
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

        /// <summary>
        /// TODO
        /// </summary>
        public void Fatal(string msg)
        {
            AddItem(msg);
        }

        /// <summary>
        /// TODO
        /// </summary>
        public void Error(string msg)
        {
            AddItem(msg);
        }

        /// <summary>
        /// TODO
        /// </summary>
        public void Info(string msg)
        {
            AddItem(msg);
        }

        /// <summary>
        /// TODO
        /// </summary>
        public void Warn(string msg)
        {
            //AddItem(msg);
        }

        /// <summary>
        /// TODO
        /// </summary>
        public void Debug(string msg)
        {
            //AddItem(msg);
        }

        #endregion
    }
}