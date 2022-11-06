using Microsoft.Win32;
using MoonLauncher;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LauncherCore
{
    class MoonLauncher
    {
       
        public static RegistryKey Settings = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\MoonLauncher", true);
        
       
        public static void SetDefault()
        {
            Settings.SetValue("ClearTemp", 1);
            Settings.SetValue("DisableServices", 1);
            Settings.SetValue("GPBEnable", 1);
            Settings.SetValue("KillNVIDIA", 1);
            Settings.SetValue("KillProcesses", 1);
            Settings.SetValue("TweakPriorities", 1);
            Settings.SetValue("ClearFNCache", 1);
        }

        public static void DownloadAndRunBatchFile(string url, string name, bool window)
        {
            WebClient wb = new WebClient();
            wb.DownloadFile($"{url}", @$"C:\Windows\Temp\{name}.bat");
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = window;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();
            string cmdCommand;
            cmdCommand = @$"C:\Windows\Temp\{name}.bat";
            cmd.StandardInput.WriteLine(cmdCommand);
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();

            File.Delete(@$"C:\Windows\Temp\{name}.bat");
        }

        public static void RunCMD(string command)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();
            string cmdCommand;
            cmdCommand = @$"{command}";
            cmd.StandardInput.WriteLine(cmdCommand);
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
        }

        public static void nsudoCall(string command)
        {
            Process wdboot = new Process();
            wdboot.StartInfo.FileName = @"C:\Windows\Temp\NSudoLG.exe";
            wdboot.StartInfo.Arguments = $"-U:T {command}";
            wdboot.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            wdboot.StartInfo.CreateNoWindow = true;
            wdboot.Start();
            wdboot.WaitForExit();
        }
    }
}
