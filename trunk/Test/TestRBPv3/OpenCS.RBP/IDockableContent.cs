using System;
using System.Collections.Generic;
using System.Text;
using WeifenLuo.WinFormsUI.Docking;

namespace OpenCS.RBP
{
    /// <summary>
    /// 도킹가능한 컨텐트
    /// </summary>
    public interface IDockableContent
    {
        /// <summary>
        /// DockPanel에 표시한다.
        /// </summary>
        /// <param name="dockPanel">DockPanel</param>
        /// <param name="dockState">DockState</param>
        void Show(DockPanel dockPanel, DockState dockState);
    }
}
