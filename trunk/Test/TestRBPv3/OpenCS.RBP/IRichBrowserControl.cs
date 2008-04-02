using System;
using System.Collections.Generic;
using System.Text;
using OpenCS.Common.Plugin;
using WeifenLuo.WinFormsUI.Docking;

namespace OpenCS.RBP
{
    /// <summary>
    /// 리치 브라우저 콘트롤
    /// </summary>
    public interface IRichBrowserControl : IPluginHost
    {
        /// <summary>
        /// DockPanel을 가져온다.
        /// </summary>
        DockPanel DockPanel
        {
            get;
        }
    }
}
