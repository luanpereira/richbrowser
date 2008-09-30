using System;
using System.Collections.Generic;
using System.Text;

namespace OpenCS.RBP
{
    public class WebBrowserStatusTextChangedEventArgs : EventArgs
    {
        private string mStatusText;

        public string StatusText
        {
            get { return mStatusText; }
            set { mStatusText = value; }
        }

        public WebBrowserStatusTextChangedEventArgs(string statusText)
        {
            mStatusText = statusText;
        }
    }
}
