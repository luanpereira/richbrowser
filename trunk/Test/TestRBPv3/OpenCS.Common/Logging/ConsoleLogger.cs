﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace OpenCS.Common.Logging
{
    /// <summary>
    /// 콘솔로 메시지를 남기는 로거
    /// </summary>
    public class ConsoleLogger : ILogger
    {
        #region ILogger 멤버

        /// <summary>
        /// 심각한 오류 메시지를 남긴다.
        /// </summary>
        /// <param name="message">메시지</param>
        public void Fatal(string message)
        {
            System.Diagnostics.Debug.Fail("[FATAL] " + message);
        }

        /// <summary>
        /// 오류 메시지를 남긴다.
        /// </summary>
        /// <param name="message">메시지</param>
        public void Error(string message)
        {
            System.Diagnostics.Debug.Fail("[ERROR] " + message);
        }

        /// <summary>
        /// 경고 메시지를 남긴다.
        /// </summary>
        /// <param name="message">메시지</param>
        public void Warn(string message)
        {
            System.Diagnostics.Debug.Print("[WARN ] " + message);
        }

        /// <summary>
        /// 정보 메시지를 남긴다.
        /// </summary>
        /// <param name="message">메시지</param>
        public void Info(string message)
        {
            System.Diagnostics.Debug.Print("[INFO ] " + message);
        }

        /// <summary>
        /// 디버깅 메시지를 남긴다.
        /// </summary>
        /// <param name="message">메시지</param>
        public void Debug(string message)
        {
            System.Diagnostics.Debug.Print("[DEBUG] " + message);
        }

        #endregion
    }
}
