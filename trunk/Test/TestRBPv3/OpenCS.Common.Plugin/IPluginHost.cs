using System;
using System.Collections.Generic;
using System.Text;

namespace OpenCS.Common.Plugin
{
    /// <summary>
    /// 플러그인 호스트
    /// 플러그인들 관리하는 주체.
    /// </summary>
    public interface IPluginHost 
    {
        /// <summary>
        /// 플러그인 목록을 가져온다.
        /// </summary>
        List<IPlugin> Plugins
        {
            get;
        }

        /// <summary>
        /// 플러그인들을 로딩한다.
        /// </summary>
        /// <param name="baseFolder">플러그인들이 위치한 기본 폴더</param>
        void LoadPlugins(string baseFolder);
    }
}
