using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using OpenCS.Common.Action;
using OpenCS.RBP.Actions;

namespace OpenCS.RBP
{
    abstract public class BaseToggleableRbpPlugin : BaseRbpPlugin
    {
        private DockContent mDc;
        private ToolStripButton mButton;
        private ToolStripMenuItem mMenuItem;

        public DockContent DockContent
        {
            get { return mDc; }
            set { mDc = value; }
        }

        public ToolStripButton Button
        {
            get { return mButton; }
            set { mButton = value; }
        }

        public ToolStripMenuItem MenuItem
        {
            get { return mMenuItem; }
            set { mMenuItem = value; }
        }

        protected void InitToggleableResources()
        {
            mDc.HideOnClose = true;

            mButton = new ToolStripButton(Title);
            mMenuItem = new ToolStripMenuItem(Title);
            RichBrowserControl.AddToolBarButton(mButton, new ShowAction(mDc));
            RichBrowserControl.AddMenuItem(mMenuItem, new ShowAction(mDc));
        }

        /// <summary>
        /// IPlugin.Init() 내에서 DockContent를 초기화한 후 호출한다.
        /// </summary>
        protected void InitToggleableResources(Image image)
        {
            mDc.HideOnClose = true;

            mButton = new ToolStripButton(Title, image);
            mMenuItem = new ToolStripMenuItem(Title, image);
            RichBrowserControl.AddToolBarButton(mButton, new ShowAction(mDc));
            RichBrowserControl.AddMenuItem(mMenuItem, new ShowAction(mDc));
        }

        /// <summary>
        /// IPlugin.Deinit() 내에서 DockContent.Close()하기전에 호출한다.
        /// </summary>
        protected void DeinitToggleableResources()
        {
            RichBrowserControl.RemoveToolBarButton(mButton);
            RichBrowserControl.RemoveMenuItem(mMenuItem);
        }

        protected ActionResult HandleShowAction(IAction action)
        {
            if (action is ShowAction)
            {
                DockContent dc = (action as ShowAction).Object as DockContent;
                if (dc != null)
                {
                    ShowDockContent();

                    return ActionResult.Success;
                }
            }

            return ActionResult.NotHandled;
        }

        abstract protected void ShowDockContent();
    }
}
