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
        private IRichBrowserControl mRbc;

        /// <summary>
        /// 로거. 설정하지 않으면 <c>ConsoleLogger</c>가 기본으로 설정된다.
        /// </summary>
        private ILogger mLogger = new ConsoleLogger();

        #region ILoggable 멤버

        /// <summary>
        /// 로거를 가져오거나 설정한다.
        /// </summary>
        public ILogger Logger
        {
            get { return mLogger; }
            set { mLogger = value; }
        }

        #endregion

        #region IRbpPlugin 멤버

        /// <summary>
        /// 리치 브라우저 콘트롤을 설정한다.
        /// </summary>
        public IRichBrowserControl RichBrowserControl
        {
            get { return mRbc; }
            set { mRbc = value; }
        }

        #endregion

    }
}
