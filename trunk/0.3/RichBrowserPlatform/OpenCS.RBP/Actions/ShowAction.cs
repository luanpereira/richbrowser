using System;
using System.Collections.Generic;
using System.Text;
using OpenCS.Common.Action;

namespace OpenCS.RBP.Actions
{
    /// <summary>
    /// 객체를 표시하라는 액션
    /// </summary>
    public class ShowAction : IAction
    {
        private object mShowingObject;

        /// <summary>
        /// 표시할 객체를 가져오거나 설정한다.
        /// </summary>
        public object ShowingObject
        {
            get { return mShowingObject; }
            set { mShowingObject = value; }
        }

        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="showingObject">표시할 객체</param>
        public ShowAction(object showingObject)
        {
            mShowingObject = showingObject;
        }
    }
}
