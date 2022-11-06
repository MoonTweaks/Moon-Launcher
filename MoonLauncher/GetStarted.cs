using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MoonLauncher
{
    public partial class GetStarted : Form
    {
        Thread th;
        public GetStarted()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fdb = new FolderBrowserDialog();
            
            if (fdb.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = fdb.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fdb = new FolderBrowserDialog();

            if (fdb.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = fdb.SelectedPath;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey Settings = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\MoonLauncher", true);
                Settings.SetValue("EpicGamesDirectory", textBox1.Text, RegistryValueKind.String);
                Settings.SetValue("FortniteGamePath", textBox2.Text, RegistryValueKind.String);
                Settings.SetValue("ShowGetStartedDialog", 0, RegistryValueKind.DWord);
                LauncherCore.MoonLauncher.SetDefault();
                this.Close();
                th = new Thread(openmainform);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void openmainform()
        {
            Application.Run(new MainForm());
        }

        private void GetStarted_Load(object sender, EventArgs e)
        {

        }
    }
}
