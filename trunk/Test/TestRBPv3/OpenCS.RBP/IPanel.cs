using System;
using System.Collections.Generic;
using System.Text;
using OpenCS.Common.Plugin;

namespace OpenCS.RBP
{
    public interface IPanelPlugin : IPlugin
    {
        void Show();
    }
}
