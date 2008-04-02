using System;
using System.Collections.Generic;
using System.Text;
using OpenCS.Common.Plugin;

namespace OpenCS.RBP
{
    abstract public class BaseRbpPlugin : BasePlugin, IRbpPlugin
    {
        protected IRichBrowserControl m_rbc;

        #region IRbpPlugin 멤버

        public IRichBrowserControl RichBrowserControl
        {
            set { m_rbc = value; }
        }

        #endregion
    }
}
