using System;
using System.Collections.Generic;
using System.Text;
using OpenCS.Common.Plugin;
using OpenCS.Common.Logging;

namespace OpenCS.RBP
{
    /// <summary>
    /// 리지 브라우저 플랫폼용 플러그인
    /// </summary>
    public interface IRbpPlugin : IPlugin, ILoggable
    {
        /// <summary>
        /// 리치 브라우저 콘트롤을 설정한다.
        /// </summary>
        IRichBrowserControl RichBrowserControl
        {
            set;
        }
    }
}
