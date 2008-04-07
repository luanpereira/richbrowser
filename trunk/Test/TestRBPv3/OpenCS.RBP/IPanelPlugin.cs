using System;
using System.Collections.Generic;
using System.Text;
using OpenCS.Common.Plugin;
using WeifenLuo.WinFormsUI.Docking;
using OpenCS.Common.Logging;

namespace OpenCS.RBP
{
    /// <summary>
    /// 패널형태의 플러그인
    /// </summary>
    public interface IPanelPlugin : IPlugin, ILoggable
    {
        /// <summary>
        /// 패널을 표시한다.
        /// </summary>
        /// <param name="dockPanel">DockPanel</param>
        /// <param name="dockState">표시할 방법</param>
        void Show(DockPanel dockPanel, DockState dockState);
    }
}
