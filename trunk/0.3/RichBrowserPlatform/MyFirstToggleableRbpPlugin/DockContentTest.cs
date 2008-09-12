using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using OpenCS.RBP;
using OpenCS.Common.Plugin;
using OpenCS.Common.Action;

namespace MyFirstToggleableRbpPlugin
{
    public partial class DockContentTest : DockContent, IToggleableDockContent
    {
        public DockContentTest()
        {
            InitializeComponent();
        }

        #region IToggleableDockContent 멤버

        public IPlugin Plugin
        {
            get
            {
                throw new Exception("The method or operation is not implemented.");
            }
            set
            {
                ;
            }
        }

        public IRichBrowserControl RichBrowserControl
        {
            get
            {
                throw new Exception("The method or operation is not implemented.");
            }
            set
            {
                ;
            }
        }

        public IActionHandler ActionHandler
        {
            get
            {
                throw new Exception("The method or operation is not implemented.");
            }
            set
            {
                ;
            }
        }

        #endregion
    }
}