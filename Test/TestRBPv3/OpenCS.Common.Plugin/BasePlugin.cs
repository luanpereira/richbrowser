﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OpenCS.Common.Plugin
{
    /// <summary>
    /// 기본 구현 플러그인
    /// </summary>
    abstract public class BasePlugin : IPlugin
    {
        /// <summary>
        /// 플러그인 호스트
        /// </summary>
        protected IPluginHost m_host;

        /// <summary>
        /// 생성자
        /// </summary>
        public BasePlugin()
        {
        }

        #region IPlugin 멤버

        /// <summary>
        /// 플러그인 호스트를 설정한다.
        /// </summary>
        public IPluginHost PluginHost
        {
            set { m_host = value; }
        }

        /// <summary>
        /// 제목을 가져온다.
        /// </summary>
        abstract public string Title
        {
            get;
        }

        /// <summary>
        /// 버전을 가져온다.
        /// </summary>
        abstract public Version Version
        {
            get;
        }

        /// <summary>
        /// 플러그인을 초기화한다.
        /// </summary>
        abstract public void Init();

        /// <summary>
        /// 플러그인을 해제한다.
        /// </summary>
        abstract public void Deinit();

        #endregion
    }
}
