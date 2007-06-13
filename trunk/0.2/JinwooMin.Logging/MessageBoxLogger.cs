using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace JinwooMin.Logging
{
    /// <summary>
    /// TODO
    /// </summary>
    public class MessageBoxLogger : AbstractLogger
    {
        /// <summary>
        /// TODO
        /// </summary>
        protected override void Log(string prefix, string msg)
        {
            if (prefix == LOG_PREFIX_FATAL)
            {
                MessageBox.Show(msg, LogUtils.LogOptionString(LogOptions.FATAL), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (prefix == LOG_PREFIX_ERROR)
            {
                MessageBox.Show(msg, LogUtils.LogOptionString(LogOptions.ERROR), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (prefix == LOG_PREFIX_WARN)
            {
                MessageBox.Show(msg, LogUtils.LogOptionString(LogOptions.WARN), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (prefix == LOG_PREFIX_INFO)
            {
                MessageBox.Show(msg, LogUtils.LogOptionString(LogOptions.INFO), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
