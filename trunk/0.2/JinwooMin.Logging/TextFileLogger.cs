using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace JinwooMin.Logging
{
    /// <summary>
    /// TODO
    /// </summary>
    public class TextFileLogger : AbstractLogger
    {
        private string m_filename;

        /// <summary>
        /// TODO
        /// </summary>
        public TextFileLogger(string filename)
        {
            m_filename = filename;
        }

        /// <summary>
        /// TODO
        /// </summary>
        protected override void Log(string prefix, string msg)
        {
            StreamWriter writer = File.AppendText(m_filename);
            writer.WriteLine("[" + prefix + "] " + msg);
            writer.Close();
        }
    }
}
