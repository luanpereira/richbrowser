using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace JinwooMin.Logging
{
    /// <summary>
    /// TODO
    /// </summary>
    public class LogUtils
    {
        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="msg"></param>
        public static void ShowWarning(ILogger logger, string msg)
        {
            logger.Warn(msg);
            MessageBox.Show(msg, LogUtils.LogOptionString(LogOptions.WARN), MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="msg"></param>
        /// <param name="e"></param>
        public static void ShowError(ILogger logger, string msg, Exception e)
        {
            logger.Error(msg);
            logger.Debug(e.StackTrace);
        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="option"></param>
        /// <returns></returns>
        public static string LogOptionString(LogOptions option)
        {
            switch (option)
            {
                case LogOptions.DEBUG: return Properties.Resources.LABEL_DEBUG;
                case LogOptions.INFO: return Properties.Resources.LABEL_INFO;
                case LogOptions.WARN: return Properties.Resources.LABEL_WARN;
                case LogOptions.ERROR: return Properties.Resources.LABEL_ERROR;
                case LogOptions.FATAL: return Properties.Resources.LABEL_FATAL;
            }

            return "";
        }
    }
}
