using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MoonLauncher
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            object objvalue = LauncherCore.MoonLauncher.Settings.GetValue("OpenedBefore");
            if (objvalue == null)
            {
                label1.Text = "Welcome to Moon Launcher!";
                LauncherCore.MoonLauncher.Settings.SetValue("OpenedBefore", 1, RegistryValueKind.DWord);
            }
            int OpenedBeforeValue = Convert.ToInt32(objvalue);
            if (OpenedBeforeValue == 0)
            {
                label1.Text = "Welcome to Moon Launcher!";
                LauncherCore.MoonLauncher.Settings.SetValue("OpenedBefore", 1, RegistryValueKind.DWord);
            }
            else
            {
                label1.Text = "Welcome Back!";
                
            }
            OpenChildForm(new Tabs.HomeTab());
            button1.Enabled = false;
        }

        private Form activeForm;

        public void OpenChildForm(Form childForm)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(childForm);
            MainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Tabs.HomeTab());
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Tabs.SettingsTab());
            button2.Enabled = false;
        }
    }
}
