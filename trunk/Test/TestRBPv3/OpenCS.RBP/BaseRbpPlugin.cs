using System;
using System.Collections.Generic;
using System.Text;
using OpenCS.Common.Plugin;
using OpenCS.Common.Logging;

namespace OpenCS.RBP
{
    /// <summary>
    /// 기본 구현한 리치 브라우저 플랫폼 플러그인
    /// </summary>
    abstract public class BaseRbpPlugin : BasePlugin, IRbpPlugin
    {
        /// <summary>
        /// 리치 브라우저 콘트롤
        /// </summary>
        protected IRichBrowserControl m_rbc;

        /// <summary>
        /// 로거
        /// </summary>
        protected ILogger m_logger = new ConsoleLogger();

        #region ILoggable 멤버

        /// <summary>
        /// 로거를 가져오거나 설정한다.
        /// </summary>
        public ILogger Logger
        {
            set { m_logger = value; }
        }

        #endregion

        #region IRbpPlugin 멤버

        /// <summary>
        /// 리치 브라우저 콘트롤을 설정한다.
        /// </summary>
        public IRichBrowserControl RichBrowserControl
        {
            set { m_rbc = value; }
        }

        #endregion

    }
}
