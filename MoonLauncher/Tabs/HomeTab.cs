using LauncherCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MoonLauncher.Tabs
{
    public partial class HomeTab : Form
    {
        Thread th;
        public HomeTab()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void HomeTab_Load(object sender, EventArgs e)
        {
            object EpicGamesDir = LauncherCore.MoonLauncher.Settings.GetValue("EpicGamesDirectory");
            object FortniteGameDir = LauncherCore.MoonLauncher.Settings.GetValue("FortniteGamePath");
            textBox1.Text = EpicGamesDir.ToString();
            textBox2.Text = FortniteGameDir.ToString();
               
        }

        private void button3_Click(object sender, EventArgs e)
        {
            object GPBObject = LauncherCore.MoonLauncher.Settings.GetValue("GPBEnable");
            int GPBEnable = Convert.ToInt32(GPBObject);
            if (GPBEnable == 1)
            {
                Application.Exit();
                th = new Thread(GamePerformanceBoost);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else
            {
                string EpicGamesDir = LauncherCore.MoonLauncher.Settings.GetValue("EpicGamesDirectory").ToString();
                string FortniteGameDir = LauncherCore.MoonLauncher.Settings.GetValue("FortniteGamePath").ToString();
                GPB.GPBDLL.OpenGame(EpicGamesDir, FortniteGameDir);
            }
        }

        private void GamePerformanceBoost()
        {
            Application.Run(new Game_Performance_Boost.GamePerformanceBoost());
        }
    }
}
