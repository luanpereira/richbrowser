using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace JinwooMin.Logging
{
    public class MessageBoxLogger : AbstractLogger
    {
        protected override void Log(string prefix, string msg)
        {
            if (prefix == LOG_PREFIX_FATAL)
            {
                MessageBox.Show(msg, Properties.Resources.LABEL_FATAL, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (prefix == LOG_PREFIX_ERROR)
            {
                MessageBox.Show(msg, Properties.Resources.LABEL_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (prefix == LOG_PREFIX_WARN)
            {
                MessageBox.Show(msg, Properties.Resources.LABEL_WARN, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (prefix == LOG_PREFIX_INFO)
            {
                MessageBox.Show(msg, Properties.Resources.LABEL_INFO, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
