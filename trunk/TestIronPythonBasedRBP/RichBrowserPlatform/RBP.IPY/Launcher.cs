#define useProcess
//#define usePythonEngine

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace RBP.IPY
{
    public class Launcher
    {
        static string IPYW_PATH = "ipy\\ipyw.exe";

        public static void Start(string[] args)
        {
            string exeFile = Path.GetFileNameWithoutExtension(Application.ExecutablePath);
            string iniFile = exeFile + ".ini";

            if (args.Length == 1)
            {
                string arg = args[0];
                if (arg == "/?" || arg == "/h" || arg == "/help")
                {
                    ShowHelp();
                }
                else
                {
                    Launch(args[0]);
                }
            }
            else if (args.Length == 0)
            {
                if (File.Exists(iniFile) == true)
                {
                    StreamReader sr = new StreamReader(iniFile);
                    string filename = sr.ReadLine();
                    sr.Close();
                    if (File.Exists(filename) == true)
                    {
                        Launch(filename);
                    }
                    else
                    {
                        ShowError(filename + " not found.");
                    }
                }
                else
                {
                    ShowError(iniFile + " not found.");
                }
            }
            else
            {
                ShowHelp();
            }
        }

        private static void Launch(string py)
        {
            if (File.Exists(IPYW_PATH) == true)
            {

#if useProcess
                #region launch using Process

                Process p = new Process();
                p.StartInfo.FileName = IPYW_PATH;
                p.StartInfo.Arguments = py;
                p.Start();
                //p.WaitForExit();
                
                #endregion
#endif

#if usePythonEngine

                #region launch using PythonEngine (but not faster)

                // ref: http://www.voidspace.org.uk/ironpython/embedding.shtml
                PythonEngine engine = new PythonEngine();
                engine.AddToPath(Path.GetDirectoryName(Application.ExecutablePath));
                //engine.Sys.argv = List.Make(args);

                EngineModule engineModule = engine.CreateModule("__main__", new Dictionary<string, object>(), true);
                engine.DefaultModule = engineModule;

                string path = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), py);
                engine.ExecuteFile(path);

                #endregion
#endif

            }
            else
            {
                ShowError("Can't found '" + IPYW_PATH + "'");
            }
        }

        private static void ShowHelp()
        {
            MessageBox.Show("IronPython Launcher v0.1 by mio \r\n\r\n Usage: IPYLauncher <python file> or make IPYLauncher.ini");
        }

        private static void ShowError(string msg)
        {
            MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
