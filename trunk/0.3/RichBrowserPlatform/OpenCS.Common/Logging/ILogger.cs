using System;
using System.Collections.Generic;
using System.Text;

namespace OpenCS.Common.Logging
{
    /// <summary>
    /// 로거
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// 심각한 오류 메시지를 남긴다.
        /// </summary>
        /// <param name="message">메시지</param>
        void Fatal(string message);

        /// <summary>
        /// 오류 메시지를 남긴다.
        /// </summary>
        /// <param name="message">메시지</param>
        void Error(string message);

        /// <summary>
        /// 경고 메시지를 남긴다.
        /// </summary>
        /// <param name="message">메시지</param>
        void Warn(string message);

        /// <summary>
        /// 정보 메시지를 남긴다.
        /// </summary>
        /// <param name="message">메시지</param>
        void Info(string message);

        /// <summary>
        /// 디버깅 메시지를 남긴다.
        /// </summary>
        /// <param name="message">메시지</param>
        void Debug(string message);
    }
}
