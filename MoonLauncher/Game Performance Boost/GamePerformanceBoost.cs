using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoonLauncher.Game_Performance_Boost
{
    public partial class GamePerformanceBoost : Form
    {
        public GamePerformanceBoost()
        {
            InitializeComponent();
            InitializeGPB();
        }

        private void GamePerformanceBoost_Load(object sender, EventArgs e)
        {
            
        }

        private async void InitializeGPB()
        {
            await Task.Delay(250);
            label5.Text = "Cleaning Temps...";
            GPB.GPBDLL.ClearTemp(GPB.GPBDLL.ClearTempValue);
            progressBar1.Value = 20;
            label5.Text = "Cleaning Fortnite Cache...";
            GPB.GPBDLL.ClearFNCache(GPB.GPBDLL.ClearFNCacheValue);
            progressBar1.Value = 30;
            label5.Text = "Killing Necessary Processes...";
            GPB.GPBDLL.KillProcesses(GPB.GPBDLL.KillProcessesValue);
            progressBar1.Value = 40;
            label5.Text = "Disabling NVIDIA Processes";
            GPB.GPBDLL.KillNVServices(GPB.GPBDLL.KillNvidiaValue);
            progressBar1.Value = 60;
            label5.Text = "Opening Game...";
            GPB.GPBDLL.OpenGame(GPB.GPBDLL.EpicGamesDirectory, GPB.GPBDLL.FortniteGameDirectory);
            progressBar1.Value = 60;
            await Task.Delay(60000);
            label5.Text = "Tweaking Priorities...";
            GPB.GPBDLL.TweakPriorities(GPB.GPBDLL.TweakProritiesValue);
            progressBar1.Value = 80;
            label5.Text = "Disabling Services...";
            GPB.GPBDLL.DisableServices(GPB.GPBDLL.DisableServicesValue);
            progressBar1.Value = 100;
            label5.Text = "All Done.";
            await Task.Delay(2000);
            Application.Exit();
        }


    }
}
