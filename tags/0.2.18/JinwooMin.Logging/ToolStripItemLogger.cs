using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace JinwooMin.Logging
{
    /// <summary>
    /// TODO
    /// </summary>
    public class ToolStripItemLogger : AbstractLogger
    {
        private ToolStripItem m_item;

        /// <summary>
        /// TODO
        /// </summary>
        public ToolStripItemLogger(ToolStripItem item)
        {
            m_item = item;
        }

        /// <summary>
        /// TODO
        /// </summary>
        protected override void Log(string prefix, string msg)
        {
            m_item.Text = msg;
            m_item.Owner.Refresh();
        }
    }
}
