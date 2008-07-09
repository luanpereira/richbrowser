using System;
using System.Collections.Generic;
using System.Text;
using OpenCS.Common.Action;

namespace OpenCS.RBP.Actions
{
    public class ShowAction : IAction
    {
        private object mObject;

        public object Object
        {
            get { return mObject; }
            set { mObject = value; }
        }

        public ShowAction(object obj)
        {
            mObject = obj;
        }
    }
}
