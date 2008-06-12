using System;
using System.Collections.Generic;
using System.Text;

namespace OpenCS.RBP
{
    /// <summary>
    /// 새창을 띄운다는 이벤트 인자
    /// </summary>
    public class NewWindowEventArgs : EventArgs
    {
        private string mUrl;

        /// <summary>
        /// 웹 주소를 가져오거나 설정한다.
        /// </summary>
        public string Url
        {
            get { return mUrl; }
            set { mUrl = value; }
        }

        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="url">웹 주소</param>
        public NewWindowEventArgs(string url)
        {
            mUrl = url;
        }
    }
}
