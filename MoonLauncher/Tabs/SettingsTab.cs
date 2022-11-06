using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MoonLauncher.Tabs
{
    public partial class SettingsTab : Form
    {
        public SettingsTab()
        {
            InitializeComponent();
            object EpicGamesLauncherPath = LauncherCore.MoonLauncher.Settings.GetValue("EpicGamesDirectory");
            object FortnitePath = LauncherCore.MoonLauncher.Settings.GetValue("FortniteGamePath");
            textBox1.Text = EpicGamesLauncherPath.ToString();
            textBox2.Text = FortnitePath.ToString();
            object GPBEnable = LauncherCore.MoonLauncher.Settings.GetValue("GPBEnable");
            if (GPBEnable == null)
            {
                checkBox1.Checked = false;
            }
            int GPBEnableValue = Convert.ToInt32(GPBEnable);
            if (GPBEnableValue == 0)
            {
                checkBox1.Checked = false;
                checkBox7.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
                checkBox6.Enabled = false;
                checkBox8.Enabled = false;
                checkBox2.Enabled = false;

            }
            else
            {
                checkBox1.Checked = true;
                checkBox7.Enabled = true;
                checkBox3.Enabled = true;
                checkBox4.Enabled = true;
                checkBox6.Enabled = true;
                checkBox8.Enabled = true;
                checkBox2.Enabled = true;
            }
            object clearTemp = LauncherCore.MoonLauncher.Settings.GetValue("ClearTemp");
            object disableServices = LauncherCore.MoonLauncher.Settings.GetValue("DisableServices");
            object killNVIDIA = LauncherCore.MoonLauncher.Settings.GetValue("KillNVIDIA");
            object killProcesses = LauncherCore.MoonLauncher.Settings.GetValue("KillProcesses");
            object TweakPriorities = LauncherCore.MoonLauncher.Settings.GetValue("TweakPriorities");
            object clearCache = LauncherCore.MoonLauncher.Settings.GetValue("ClearFNCache");

            int clearTempValue = Convert.ToInt32(clearTemp);
            int disableServicesValue = Convert.ToInt32(disableServices);
            int killProcessesValue = Convert.ToInt32(killProcesses);
            int TweakPrioritiesValue = Convert.ToInt32(TweakPriorities);
            int killNVIDIAValue = Convert.ToInt32(killNVIDIA);
            int clearCacheValue = Convert.ToInt32(clearCache);

            if (clearTempValue == 0)
            {
                checkBox7.Checked = false;
            }
            else
            {
                checkBox7.Checked = true;
            }
            if (disableServicesValue == 0)
            {
                checkBox3.Checked = false;
            }
            else
            {
                checkBox3.Checked = true;
            }
            if (killNVIDIAValue == 0)
            {
                checkBox6.Checked = false;
            }
            else
            {
                checkBox6.Checked = true;
            }
            if (killProcessesValue == 0)
            {
                checkBox4.Checked = false;
            }
            else
            {
                checkBox4.Checked = true;
            }
            if (clearCacheValue == 0)
            {
                checkBox8.Checked = false;
            }
            else
            {
                checkBox8.Checked = true;
            }
            if (TweakPrioritiesValue == 0)
            {
                checkBox2.Checked = false;
            }
            else
            {
                checkBox2.Checked = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fdb = new FolderBrowserDialog();

            if (fdb.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = fdb.SelectedPath;
                LauncherCore.MoonLauncher.Settings.SetValue("EpicGamesDirectory", textBox1.Text, RegistryValueKind.String);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            FolderBrowserDialog fdb = new FolderBrowserDialog();

            if (fdb.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = fdb.SelectedPath;
                LauncherCore.MoonLauncher.Settings.SetValue("FortniteGamePath", textBox2.Text, RegistryValueKind.String);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                LauncherCore.MoonLauncher.Settings.SetValue("GPBEnable", 1, RegistryValueKind.DWord);
                checkBox7.Enabled = true;
                checkBox3.Enabled = true;
                checkBox4.Enabled = true;
                checkBox6.Enabled = true;
                checkBox8.Enabled = true;
                checkBox2.Enabled = true;
            }
            else
            {
                LauncherCore.MoonLauncher.Settings.SetValue("GPBEnable", 0, RegistryValueKind.DWord);
                checkBox7.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
                checkBox6.Enabled = false;
                checkBox8.Enabled = false;
                checkBox2.Enabled = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LauncherCore.MoonLauncher.Settings.SetValue("EpicGamesDirectory", textBox1.Text, RegistryValueKind.String);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            LauncherCore.MoonLauncher.Settings.SetValue("FortniteGamePath", textBox2.Text, RegistryValueKind.String);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                LauncherCore.MoonLauncher.Settings.SetValue("DisableServices", 1);
            }
            else
            {
                LauncherCore.MoonLauncher.Settings.SetValue("DisableServices", 0);
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                LauncherCore.MoonLauncher.Settings.SetValue("ClearTemp", 1);
            }
            else
            {
                LauncherCore.MoonLauncher.Settings.SetValue("ClearTemp", 0);
            }
            
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                LauncherCore.MoonLauncher.Settings.SetValue("KillProcesses", 1);
            }
            else
            {
                LauncherCore.MoonLauncher.Settings.SetValue("KillProcesses", 0);
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                LauncherCore.MoonLauncher.Settings.SetValue("KillNVIDIA", 1);
            }
            else
            {
                LauncherCore.MoonLauncher.Settings.SetValue("KillNVIDIA", 0);
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                LauncherCore.MoonLauncher.Settings.SetValue("ClearFNCache", 1);
            }
            else
            {
                LauncherCore.MoonLauncher.Settings.SetValue("ClearFNCache", 0);
            }
        }

        private void SettingsTab_Load(object sender, EventArgs e)
        {
            checkBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                LauncherCore.MoonLauncher.Settings.SetValue("TweakPriorities", 1);
            }
            else
            {
                LauncherCore.MoonLauncher.Settings.SetValue("TweakPriorities", 0);
            }
        }
    }
}
