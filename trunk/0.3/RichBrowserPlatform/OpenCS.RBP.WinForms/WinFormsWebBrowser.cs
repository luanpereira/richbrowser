using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using OpenCS.Common.Action;
using OpenCS.RBP.Actions;

namespace OpenCS.RBP.WinForms
{
    public class WinFormsWebBrowser : WebBrowser, IWebBrowser
    {
        #region IActionHandler 멤버

        public ActionResult HandleAction(IAction action)
        {
            if (action is IWebBrowserAction)
            {
                if (action is GoBackwardAction)
                {
                    this.GoBack();

                    return ActionResult.Success;
                }
                else if (action is GoForwardAction)
                {
                    this.GoForward();

                    return ActionResult.Success;
                }
                else if (action is NavigateAction)
                {
                    this.Navigate((action as NavigateAction).Url);

                    return ActionResult.Success;
                }

            }

            return ActionResult.NotHandled;
        }

        #endregion
    }
}
