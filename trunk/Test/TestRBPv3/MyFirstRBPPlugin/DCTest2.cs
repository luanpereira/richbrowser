using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using OpenCS.RBP;
using OpenCS.Common.Action;

namespace MyFirstRBPPlugin
{
    public partial class DCTest2 : DockContent, IActionHandler
    {
        private DockPanel m_dp;

        public DockPanel HostDockPanel
        {
            get { return m_dp; }
            set
            {
                m_dp = value;
                m_dp.ContentAdded += new EventHandler<DockContentEventArgs>(m_dp_ContentAdded);
                m_dp.ContentRemoved += new EventHandler<DockContentEventArgs>(m_dp_ContentRemoved);
            }
        }

        WBItem GetItem(IWebBrowser wb)
        {
            WBItem foundItem = null;
            foreach (WBItem item in listBox1.Items)
            {
                if (item.Wb == wb)
                {
                    foundItem = item;
                }
            }

            return foundItem;
        }

        void m_dp_ContentRemoved(object sender, DockContentEventArgs e)
        {
            if (e.Content is IWebBrowserDockContent)
            {
                IWebBrowser wb = (e.Content as IWebBrowserDockContent).WebBrowser;
                wb.Navigated -= wb_Navigated;
                WBItem foundItem = GetItem(wb);
                if (foundItem != null)
                {
                    listBox1.Items.Remove(foundItem);
                }
            }
        }

        void m_dp_ContentAdded(object sender, DockContentEventArgs e)
        {
            if (e.Content is IWebBrowserDockContent)
            {
                IWebBrowser wb = (e.Content as IWebBrowserDockContent).WebBrowser;
                wb.Navigated += new WebBrowserNavigatedEventHandler(wb_Navigated);
                WBItem item = new WBItem();
                item.Wb = wb;
                item.Url = "new wb";
                listBox1.Items.Add(item);
            }
        }

        void wb_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            WBItem foundItem = GetItem(sender as IWebBrowser); ;
            if (foundItem != null)
            {
                foundItem.Url = e.Url.ToString();
                listBox1.Invalidate();
            }
        }

        public DCTest2()
        {
            InitializeComponent();
        }

        #region IActionHandler 멤버

        public ActionResult HandleAction(IAction action)
        {
            if (action is PropertyAction<string>)
            {
                toolStripTextBox1.Text = (action as PropertyAction<string>).Property;
                return ActionResult.Success;
            }

            return ActionResult.NotHandled;
        }

        #endregion
    }

    internal class WBItem
    {
        private IWebBrowser m_wb;
        private string m_url;

        public IWebBrowser Wb
        {
            get { return m_wb; }
            set { m_wb = value; }
        }

        public string Url
        {
            get { return m_url; }
            set { m_url = value; }
        }

        public override string ToString()
        {
            return m_url;
        }
    }
}