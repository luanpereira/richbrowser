using System;
using System.Collections.Generic;
using System.Text;

namespace OpenCS.RBP.Actions
{
    public class NavigateAction : IWebBrowserAction
    {
        private string m_url;

        public string Url
        {
            get { return m_url; }
            set { m_url = value; }
        }

        public NavigateAction(string url)
        {
            m_url = url;
        }
    }
}
