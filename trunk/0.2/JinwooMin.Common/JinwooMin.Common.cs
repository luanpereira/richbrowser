using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Deployment.Application;
using JinwooMin.Logging;
using System.Diagnostics;

namespace JinwooMin.Common
{
    public enum VersionStage { Stable = 0, Alpha = 1, Beta = 2, RC = 3, Patch = 4 };

    public class VersionInfo
    {
        public static string GetBuildNumber()
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

        public static string GetVersionOnly()
        {
            Version appVersion = new Version(Application.ProductVersion);
            return appVersion.Major.ToString() + "."
                + appVersion.Minor.ToString();
        }

        public static string GetVersionStage()
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

        public static string GetVersion()
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
    }

    public class ProcessUtils
    {

        // ref: http://www.pcreview.co.uk/forums/thread-1393522.php
        static public bool IsThisLaunched()
        {
            Process[] ps = Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName);
            Console.WriteLine(ps.ToString());
            if (ps.Length > 1)
            {
                MessageBox.Show(
                    string.Format(Properties.Resources.MSG_ALREADY_RUNNING, Application.ProductName),
                    Properties.Resources.LABEL_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            return false;
        }
    }

}
