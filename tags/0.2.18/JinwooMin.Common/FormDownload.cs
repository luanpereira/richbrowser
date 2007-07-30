using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using System.IO;

namespace JinwooMin.Common
{
    /// <summary>
    /// TODO
    /// </summary>
    public partial class FormDownload : Form
    {
        private WebClient m_webClient = new WebClient();
        private string m_url;
        private string m_file;
        private int m_restSec = 30;

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
            this.buttonCancel.Text = Properties.Resources.LABEL_CANCEL;
            #endregion

            m_url = url;
            m_file = file;

            Debug.Print("downloader initialized.");
        }

        private void FormDownload_Load(object sender, EventArgs e)
        {
            m_webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(WebClient_DownloadFileAsyncCompleted);
            m_webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(WebClient_DownloadProgressChanged);
            m_webClient.DownloadFileAsync(new Uri(m_url), m_file);

            labelMessage.Text = string.Format(Properties.Resources.MSG_CONNECTING, m_restSec);
            Debug.Print("downloading..." + m_url);
            timerSkip.Interval = 1000;
            timerSkip.Enabled = true;
        }

        private void WebClient_DownloadFileAsyncCompleted(object sender, AsyncCompletedEventArgs e)
        {
            timerSkip.Enabled = false;
            labelMessage.Text = Properties.Resources.MSG_COMPLETED;
            Debug.Print("downloaded..." + m_url);

            if (e.Error == null)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }
            m_webClient.Dispose();
            Close();
        }

        private void WebClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            timerSkip.Enabled = false;
            if (e.ProgressPercentage >= 0 && e.ProgressPercentage <= 100)
            {
                labelMessage.Text = string.Format(Properties.Resources.MSG_DOWNLOADED, Path.GetFileName(m_file), e.ProgressPercentage);
                Debug.Print("downloading...{0}%", e.ProgressPercentage.ToString());

                progressBarMain.Value = e.ProgressPercentage;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void Cancel()
        {
            timerSkip.Enabled = false;
            Debug.Print("downloading canceled.");
            m_webClient.CancelAsync();
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void timerSkip_Tick(object sender, EventArgs e)
        {
            m_restSec--;
            labelMessage.Text = string.Format(Properties.Resources.MSG_CONNECTING, m_restSec);
            if (m_restSec == 0)
            {
                Cancel();
            }
        }
    }
}