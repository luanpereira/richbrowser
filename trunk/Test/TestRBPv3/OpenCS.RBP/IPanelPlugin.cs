using System;
using System.Collections.Generic;
using System.Text;
using OpenCS.Common.Plugin;

namespace OpenCS.RBP
{
    /// <summary>
    /// 패널형태의 플러그인
    /// </summary>
    public interface IPanelPlugin : IPlugin
    {
        /// <summary>
        /// 패널을 표시한다.
        /// </summary>
        void Show();
    }
}
