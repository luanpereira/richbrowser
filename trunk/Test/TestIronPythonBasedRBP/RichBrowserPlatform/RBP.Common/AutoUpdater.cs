using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Windows.Forms;
using System.IO;
using System.ComponentModel;
using System.Diagnostics;
//using RBP.Logging;

namespace RBP.Common
{
    /// <summary>
    /// TODO
    /// </summary>
    public class AutoUpdater
    {
        private string m_setupFile;
        private Form m_mainForm;
        private string m_updateUrl;
        private string m_updateDir;
        private object m_progressBar;

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="mainForm"></param>
        /// <param name="updateUrl"></param>
        /// <param name="updateDir"></param>
        /// <param name="progressBar"></param>
        public AutoUpdater(Form mainForm, string updateUrl, string updateDir, object progressBar)
        {
            m_mainForm = mainForm;
            m_updateUrl = updateUrl;
            m_updateDir = updateDir;
            m_progressBar = progressBar;
        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="mainForm"></param>
        /// <param name="updateUrl"></param>
        /// <param name="updateDir"></param>
        public AutoUpdater(Form mainForm, string updateUrl, string updateDir)
        {
            m_mainForm = mainForm;
            m_updateUrl = updateUrl;
            m_updateDir = updateDir;
        }

        /// <summary>
        /// TODO
        /// </summary>
        public bool HasNewVersion()
        {
            WebClient web = new WebClient();
            try
            {

                string downStr = web.DownloadString(m_updateUrl + "/autoupdate.txt");

                string destVerStr = downStr.Split('|')[0];
                Debug.Print("dest version=" + destVerStr);
                Version destVer = new Version(destVerStr);

                string srcVerStr = Application.ProductVersion;
                Debug.Print("src version=" + srcVerStr);
                Version srcVer = new Version(srcVerStr);

                // dest >  src: 1
                // dest == src: 0
                // dest <  src: -1
                //MessageBox.Show(destVer.CompareTo(srcVer).ToString());
                if (destVer.CompareTo(srcVer) > 0)
                {
                    if (MessageBox.Show(
                        string.Format("New version ({0} {1}) here.", Application.ProductName, VersionInfo.GetVersionFrom(destVerStr)),
                        "Question",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        m_setupFile = downStr.Split('|')[1];

                        Directory.CreateDirectory(m_updateDir);
                        FormDownload dlg = new FormDownload(m_updateUrl + "/" + m_setupFile, m_updateDir + "\\" + m_setupFile);
                        if (dlg.ShowDialog() == DialogResult.OK)
                        {
                            Process process = new Process();
                            process.StartInfo.FileName = m_updateDir + "\\" + m_setupFile;
                            process.Start();
                            return true;
                        }
                    }
                }
            }
            catch (WebException e)
            {
                Debug.Print(e.Message);
                Debug.Print(e.StackTrace);
            }

            return false;
        }
    }
}
