using System;
using System.Collections.Generic;
using System.Text;

namespace JinwooMin.Common
{
    public class DirtyChangedEventArgs : EventArgs
    {
        private bool m_isDirty = true;
        public bool IsDirty
        {
            get { return m_isDirty; }
            set { m_isDirty = value; }
        }

        public DirtyChangedEventArgs(bool dirty)
        {
            m_isDirty = dirty;
        }
    }

    public delegate void DirtyChangedEventHanler(object sender, DirtyChangedEventArgs e);
}
