using System;
using System.Collections.Generic;
using System.Text;

namespace OpenCS.RBP.Actions
{
    /// <summary>
    /// 웹 주소(URL)를 이동하는 액션
    /// </summary>
    public class NavigateAction : IWebBrowserAction
    {
        private string m_url;

        /// <summary>
        /// 웹 주소를 가져오거나 설정한다.
        /// </summary>
        public string Url
        {
            get { return m_url; }
            set { m_url = value; }
        }

        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="url">웹 주소</param>
        public NavigateAction(string url)
        {
            m_url = url;
        }
    }
}
