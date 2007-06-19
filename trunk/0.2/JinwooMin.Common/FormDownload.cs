using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace JinwooMin.Common
{
    /// <summary>
    /// TODO
    /// </summary>
    public partial class FormDownload : Form
    {
        private string m_url;
        private string m_file;

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="url"></param>
        /// <param name="file"></param>
        public FormDownload(string url, string file)
        {
            InitializeComponent();

            #region Resources
            this.Text = Properties.Resources.LABEL_DOWNLOADING;
            #endregion

            m_url = url;
            m_file = file;
        }

        private void FormDownload_Load(object sender, EventArgs e)
        {
            WebClient web = new WebClient();

            web.DownloadFileCompleted += new AsyncCompletedEventHandler(WebClient_DownloadFileAsyncCompleted);
            web.DownloadProgressChanged += new DownloadProgressChangedEventHandler(WebClient_DownloadProgressChanged);
            web.DownloadFileAsync(new Uri(m_url), m_file);
        }

        private void WebClient_DownloadFileAsyncCompleted(object sender, AsyncCompletedEventArgs e)
        {
            Close();
        }

        private void WebClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage >= 0 && e.ProgressPercentage <= 100)
            {
                progressBarMain.Value = e.ProgressPercentage;
            }
        }
    }
}