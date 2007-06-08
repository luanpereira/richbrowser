using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace JinwooMin.Logging
{
    public class ToolStripItemLogger : AbstractLogger
    {
        private ToolStripItem m_item;

        public ToolStripItemLogger(ToolStripItem item)
        {
            m_item = item;
        }

        protected override void Log(string prefix, string msg)
        {
            m_item.Text = msg;
            m_item.Owner.Refresh();
        }
    }
}
