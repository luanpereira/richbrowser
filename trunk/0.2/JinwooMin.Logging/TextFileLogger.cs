using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace JinwooMin.Logging
{
    public class TextFileLogger : AbstractLogger
    {
        private string m_filename;

        public TextFileLogger(string filename)
        {
            m_filename = filename;
        }

        protected override void Log(string prefix, string msg)
        {
            StreamWriter writer = File.AppendText(m_filename);
            writer.WriteLine("[" + prefix + "] " + msg);
            writer.Close();
        }
    }
}
