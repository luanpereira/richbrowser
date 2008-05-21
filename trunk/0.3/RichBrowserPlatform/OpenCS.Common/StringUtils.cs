using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace OpenCS.Common
{
    /// <summary>
    /// 문자열 관련 유틸 클래스.
    /// </summary>
    public class StringUtils
    {
        /// <summary>
        /// HTML 태그를 없앤다. 참고 주소: http://www.developerfusion.co.uk/show/3901/
        /// 
        /// </summary>
        /// <param name="src">원본 문자열</param>
        /// <returns>변환된 문자열</returns>
        public static string StripTags(string src)
        {
            Regex re = new Regex("<[^>]*>");
            return re.Replace(src, "");
        }

        /// <summary>
        /// 태그와 태그사이의 문자열을 구한다. 태그를 찾지 못하면 원본 문자열과 동일한 문자열을 반환한다.
        /// </summary>
        /// <param name="src">원본 문자열</param>
        /// <param name="startTag">시작 태그</param>
        /// <param name="endTag">종료 태그</param>
        /// <returns>사이의 문자열</returns>
        public static string GrabString(string src, string startTag, string endTag)
        {
            string result = src;

            int startIdx = src.IndexOf(startTag);
            if (startIdx > -1)
            {
                int startLen = startTag.Length;
                int endIdx = src.IndexOf(endTag, startIdx);
                if (endIdx > -1)
                {
                    int len = src.Length;
                    result = src.Substring(startIdx + startLen, endIdx - startIdx - startLen);
                }
            }

            return result;
        }
    }
}
