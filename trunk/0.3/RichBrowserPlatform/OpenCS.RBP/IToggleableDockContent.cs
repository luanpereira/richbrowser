using System;
using System.Collections.Generic;
using System.Text;
using OpenCS.Common.Action;
using OpenCS.Common.Plugin;
using WeifenLuo.WinFormsUI.Docking;

namespace OpenCS.RBP
{
    /// <summary>
    /// Toggleable DockContent
    /// </summary>
    public interface IToggleableDockContent : IDockableContent
    {
        /// <summary>
        /// Gets or Sets IPlugin.
        /// </summary>
        IPlugin Plugin
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or Sets IRichBrowserControl.
        /// </summary>
        IRichBrowserControl RichBrowserControl
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or Sets IActionHandler.
        /// </summary>
        IActionHandler ActionHandler
        {
            get;
            set;
        }

    }
}
