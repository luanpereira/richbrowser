using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using JinwooMin.Logging;
using System.Threading;
using JinwooMin.Common;
using System.IO;
using System.Reflection;

namespace JinwooMin.RichBrowserControl
{
    public partial class FormSplash : Form, ILogger
    {
        /// <summary>
        /// TODO
        /// </summary>
        public static FormSplash ms_frmSplash = null;

        private bool m_isAbout;

        /// <summary>
        /// TODO
        /// </summary>
        public bool IsAbout
        {
            get { return m_isAbout; }
            set { m_isAbout = value; }
        }

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
        static public void ShowForm(Image image)
        {
            Application.DoEvents();
            ms_frmSplash = new FormSplash();
            ms_frmSplash.TopMost = true;
            ms_frmSplash.pictureBoxMain.Image = image;
            ms_frmSplash.Width = image.Width;
            ms_frmSplash.Height = image.Height + ms_frmSplash.progressBarMain.Height;
            ms_frmSplash.Show();
            //Application.Run(ms_frmSplash);
        }

        /// <summary>
        /// A static entry point to launch FormSplash.
        /// </summary>
        static public void ShowForm()
        {
            Application.DoEvents();
            ms_frmSplash = new FormSplash();
            ms_frmSplash.TopMost = true;
            ms_frmSplash.Show();
            //Application.Run(ms_frmSplash);
        }

        /// <summary>
        /// A static entry point to launch FormSplash.
        /// </summary>
        static public void ShowWithSplashImage(bool isAbout)
        {
            Application.DoEvents();
            ms_frmSplash = new FormSplash();
            ms_frmSplash.TopMost = true;
            ms_frmSplash.IsAbout = isAbout;
            string splashFile = Application.StartupPath + "\\splash.png";
            if (File.Exists(splashFile) == true)
            {
                ms_frmSplash.pictureBoxMain.Image = new Bitmap(splashFile);
            }
            ms_frmSplash.Width = ms_frmSplash.pictureBoxMain.Image.Width;
            if (isAbout == true)
            {
                ms_frmSplash.Height = ms_frmSplash.pictureBoxMain.Image.Height;
                ms_frmSplash.progressBarMain.Visible = false;
                Assembly asm = Assembly.GetAssembly(typeof(RichBrowserControl));
                string asmVersion = (asm.GetCustomAttributes(typeof(AssemblyFileVersionAttribute), false)[0] as AssemblyFileVersionAttribute).Version;
                FormSplash.AddItem("Powered by RichBrowserPlatform v" + asmVersion);
                ms_frmSplash.ShowDialog();
            }
            else
            {
                ms_frmSplash.Height = ms_frmSplash.pictureBoxMain.Image.Height + ms_frmSplash.progressBarMain.Height;
                ms_frmSplash.Show();
            }
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

            ms_frmSplash.labelTitle.Text = Application.ProductName + " " + VersionInfo.GetVersion(); 
            ms_frmSplash.labelMessage.Text = msg;
            ms_frmSplash.pictureBoxMain.Refresh();
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

        private void pictureBoxMain_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString(
                ms_frmSplash.labelTitle.Text,
                ms_frmSplash.labelTitle.Font, Brushes.Black,
                ms_frmSplash.labelTitle.Left,
                ms_frmSplash.labelTitle.Top);
            e.Graphics.DrawString(
                ms_frmSplash.labelMessage.Text,
                ms_frmSplash.labelMessage.Font, Brushes.Black,
                ms_frmSplash.labelMessage.Left,
                ms_frmSplash.labelMessage.Top);
        }

        private void pictureBoxMain_Click(object sender, EventArgs e)
        {
            if (m_isAbout == true)
            {
                Close();
            }
        }

        private void FormSplash_KeyDown(object sender, KeyEventArgs e)
        {
            if (m_isAbout == true)
            {
                if (e.KeyCode == Keys.Escape)
                {
                    Close();
                }
            }
        }
    }
}