using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoonLauncher
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            RegistryKey Settings = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\MoonLauncher", true);
            object objvalue = Settings.GetValue("ShowGetStartedDialog");
            if (objvalue == null)
            {
                Settings.SetValue("ShowGetStartedDialog", 1);
                Application.Run(new GetStarted());
            }
            int value = Convert.ToInt32(objvalue);
            if (value == 0)
            {
                Application.Run(new MainForm());
            }
            else
            {
                Application.Run(new GetStarted());
            }
        }
    }
}
