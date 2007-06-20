using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Deployment.Application;
using JinwooMin.Logging;
using System.Diagnostics;

namespace JinwooMin.Common
{
    /// <summary>
    /// TODO
    /// </summary>
    public enum VersionStage {
        /// <summary>
        /// TODO
        /// </summary>
        Alpha = 1,

        /// <summary>
        /// TODO
        /// </summary>
        Beta = 2,

        /// <summary>
        /// TODO
        /// </summary>
        RC = 3,

        /// <summary>
        /// TODO
        /// </summary>
        Patch = 4,

        /// <summary>
        /// TODO
        /// </summary>
        Stable = 5,
    };

    /// <summary>
    /// TODO
    /// </summary>
    public class VersionInfo
    {
        /// <summary>
        /// TODO
        /// </summary>
        public static string GetPublishBuildNumber()
        {
            string buildNumber = "";

            try
            {
                System.Deployment.Application.ApplicationDeployment deploy = System.Deployment.Application.ApplicationDeployment.CurrentDeployment;
                buildNumber = "(" + Properties.Resources.LABEL_BUILD + "#" + deploy.CurrentVersion.Revision.ToString() + ")";
            }
            catch (InvalidDeploymentException ide)
            {
                Console.WriteLine("getversion: " + ide.Message);
                buildNumber = "";
            }

            return buildNumber;
        }

        /// <summary>
        /// TODO
        /// </summary>
        public static string GetBuildNumber()
        {
            return GetBuildNumberFrom(Application.ProductVersion);
        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="versionStr"></param>
        /// <returns></returns>
        public static string GetBuildNumberFrom(string versionStr)
        {
            return GetBuildNumberFrom(new Version(versionStr));
        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="version"></param>
        /// <returns></returns>
        public static string GetBuildNumberFrom(Version version)
        {
            return "(" + Properties.Resources.LABEL_BUILD + "#" + version.Revision.ToString() + ")";
        }

        /// <summary>
        /// TODO
        /// </summary>
        public static string GetVersionOnly()
        {
            return GetVersionOnlyFrom(Application.ProductVersion);
        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="versionStr"></param>
        /// <returns></returns>
        public static string GetVersionOnlyFrom(string versionStr)
        {
            return GetVersionFrom(new Version(versionStr));
        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="version"></param>
        /// <returns></returns>
        public static string GetVersionOnlyFrom(Version version)
        {
            return version.Major.ToString() + "."
                + version.Minor.ToString();
        }

        /// <summary>
        /// TODO
        /// </summary>
        /// 
        public static string GetVersionStage()
        {
            return GetVersionStageFrom(Application.ProductVersion);
        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="versionStr"></param>
        /// <returns></returns>
        public static string GetVersionStageFrom(string versionStr)
        {
            return GetVersionStageFrom(new Version(versionStr));
        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="version"></param>
        /// <returns></returns>
        public static string GetVersionStageFrom(Version version)
        {
            string stageStr = "";
            VersionStage stage = (VersionStage)version.Build;
            switch (stage)
            {
                case VersionStage.Stable:
                    break;

                case VersionStage.Alpha:
                    stageStr = Properties.Resources.LABEL_ALPHA;
                    break;

                case VersionStage.Beta:
                    stageStr = Properties.Resources.LABEL_BETA;
                    break;

                case VersionStage.RC:
                    stageStr = Properties.Resources.LABEL_RC;
                    break;

                case VersionStage.Patch:
                    stageStr = Properties.Resources.LABEL_PATCH;
                    break;
            }

            return stageStr;
        }

        /// <summary>
        /// TODO
        /// </summary>
        public static string GetPublishVersionStage()
        {
            Version appVersion = new Version(Application.ProductVersion);
            string stageStr = "";
            VersionStage stage = (VersionStage)appVersion.Build;
            switch (stage)
            {
                case VersionStage.Stable:
                    break;

                case VersionStage.Alpha:
                    stageStr = Properties.Resources.LABEL_ALPHA;
                    break;

                case VersionStage.Beta:
                    stageStr = Properties.Resources.LABEL_BETA;
                    break;

                case VersionStage.RC:
                    stageStr = Properties.Resources.LABEL_RC;
                    break;

                case VersionStage.Patch:
                    stageStr = Properties.Resources.LABEL_PATCH;
                    break;
            }

            return stageStr + appVersion.Revision.ToString();
        }

        /// <summary>
        /// TODO
        /// </summary>
        public static string GetPublishVersion()
        {
            Version appVersion = new Version(Application.ProductVersion);
            VersionStage stage = (VersionStage)appVersion.Build;

            string appFullVersion = GetVersionOnly();
            if (stage != VersionStage.Stable)
            {
                appFullVersion = appFullVersion + " " + GetVersionStage();
            }

            if (stage != VersionStage.Stable)
            {
                appFullVersion = appFullVersion + " " + GetBuildNumber();
            }

            return appFullVersion;
        }

        /// <summary>
        /// TODO
        /// </summary>
        public static string GetVersion()
        {
            return GetVersionFrom(Application.ProductVersion);
        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="versionStr"></param>
        /// <returns></returns>
        public static string GetVersionFrom(string versionStr)
        {
            return GetVersionFrom(new Version(versionStr));
        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="version"></param>
        /// <returns></returns>
        public static string GetVersionFrom(Version version)
        {
            VersionStage stage = (VersionStage)version.Build;

            string appFullVersion = GetVersionOnlyFrom(version);
            if (GetVersionStageFrom(version) != "")
            {
                appFullVersion = appFullVersion + " " + GetVersionStageFrom(version) + " " + GetBuildNumberFrom(version);
            }
            else
            {
                appFullVersion = appFullVersion + " " + GetBuildNumberFrom(version);
            }

            return appFullVersion;
        }

    }

    /// <summary>
    /// TODO
    /// </summary>
    public class ProcessUtils
    {

        /// <summary>
        /// TODO
        /// ref: http://www.pcreview.co.uk/forums/thread-1393522.php
        /// </summary>
        static public bool IsThisLaunched()
        {
            Process[] ps = Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName);
            Console.WriteLine(ps.ToString());
            if (ps.Length > 1)
            {
                MessageBox.Show(
                    string.Format(Properties.Resources.MSG_ALREADY_RUNNING, Application.ProductName),
                    LogUtils.LogOptionString(LogOptions.ERROR), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            return false;
        }
    }

}
