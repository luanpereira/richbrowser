using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using OpenCS.Common.Logging;

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
        /// 태그와 태그사이의 문자열을 구한다.
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="content"></param>
        /// <param name="startTag"></param>
        /// <param name="endTag"></param>
        /// <param name="removeTags"></param>
        /// <param name="trim"></param>
        /// <returns></returns>
        public string GrabString(ILogger logger, string content, string startTag, string endTag, bool removeTags, bool trim)
        {
            string result = "";
            try
            {
                int startIdx = content.IndexOf(startTag);
                int startLen = startTag.Length;
                int endIdx = content.IndexOf(endTag, startIdx);
                int len = content.Length;
                result = content.Substring(startIdx + startLen, endIdx - startIdx - startLen);
                if (removeTags == true)
                {
                    result = StripTags(result);
                }

                if (trim == true)
                {
                    result = result.Trim(new char[] { '\t', ' ', '\r', '\n' });
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }

            return result;
        }

    }
}
