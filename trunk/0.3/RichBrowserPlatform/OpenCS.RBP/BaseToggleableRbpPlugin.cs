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
    /// <summary>
    /// 토글 가능한 패널 플러그인 기본 구현
    /// </summary>
    abstract public class BaseToggleableRbpPlugin : BaseRbpPlugin
    {
        private DockContent mDc;
        private ToolStripButton mButton;
        private ToolStripMenuItem mMenuItem;

        /// <summary>
        /// 도킹 패널을 가져오거나 설정한다.
        /// </summary>
        public DockContent DockContent
        {
            get { return mDc; }
            set { mDc = value; }
        }

        /// <summary>
        /// 버튼을 가져오거나 설정한다.
        /// </summary>
        public ToolStripButton Button
        {
            get { return mButton; }
            set { mButton = value; }
        }

        /// <summary>
        /// 메뉴아이템을 가져오거나 설정한다.
        /// </summary>
        public ToolStripMenuItem MenuItem
        {
            get { return mMenuItem; }
            set { mMenuItem = value; }
        }

        /// <summary>
        /// 토글 관련 리소스를 설정한다.
        /// IPlugin.Init() 내에서 DockContent를 초기화한 후 호출한다.
        /// </summary>
        protected void InitToggleableResources()
        {
            mDc.HideOnClose = true;

            mButton = new ToolStripButton(Title);
            mMenuItem = new ToolStripMenuItem(Title);
            RichBrowserControl.AddToolBarButton(mButton, new ShowAction(mDc));
            RichBrowserControl.AddMenuItem(mMenuItem, new ShowAction(mDc));
        }

        /// <summary>
        /// 토글 관련 리소스를 설정한다.
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
        /// 토글 관련 리소스를 해제한다.
        /// IPlugin.Deinit() 내에서 DockContent.Close()하기전에 호출한다.
        /// </summary>
        protected void DeinitToggleableResources()
        {
            RichBrowserControl.RemoveToolBarButton(mButton);
            RichBrowserControl.RemoveMenuItem(mMenuItem);
        }

        /// <summary>
        /// <c>ShowAction</c>을 처리한다.
        /// </summary>
        /// <param name="action">액션</param>
        /// <returns>성공하면 <c>ActionResult.Success</c></returns>
        protected ActionResult HandleShowAction(IAction action)
        {
            if (action is ShowAction)
            {
                DockContent dc = (action as ShowAction).ShowingObject as DockContent;
                if (dc != null && dc == mDc)
                {
                    ShowDockContent();

                    return ActionResult.Success;
                }
            }

            return ActionResult.NotHandled;
        }

        /// <summary>
        /// 도킹 패널을 표시한다.
        /// </summary>
        abstract protected void ShowDockContent();
    }
}
