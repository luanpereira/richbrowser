using System;
using System.Collections.Generic;
using System.Text;

namespace JinwooMin.Common
{
    /// <summary>
    /// TODO
    /// </summary>
    public class DirtyChangedEventArgs : EventArgs
    {
        private bool m_isDirty = true;

        /// <summary>
        /// TODO
        /// </summary>
        public bool IsDirty
        {
            get { return m_isDirty; }
            set { m_isDirty = value; }
        }

        /// <summary>
        /// TODO
        /// </summary>
        public DirtyChangedEventArgs(bool dirty)
        {
            m_isDirty = dirty;
        }
    }

    /// <summary>
    /// TODO
    /// </summary>
    public delegate void DirtyChangedEventHanler(object sender, DirtyChangedEventArgs e);
}
