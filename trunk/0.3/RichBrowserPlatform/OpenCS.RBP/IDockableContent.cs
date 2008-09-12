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
        /// Gets or Sets HideOnClose.
        /// </summary>
        bool HideOnClose
        {
            get;
            set;
        }

        /// <summary>
        /// DockPanel에 표시한다.
        /// </summary>
        /// <param name="dockPanel">DockPanel</param>
        /// <param name="dockState">DockState</param>
        void Show(DockPanel dockPanel, DockState dockState);

        /// <summary>
        /// Close this DockContent.
        /// </summary>
        void Close();

    }
}
