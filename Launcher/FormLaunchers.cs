using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Launcher
{
    public partial class FormLaunchers : Form
    {
        public FormLaunchers()
        {
            InitializeComponent();
        }

        Process app = new Process();
        private void btnSteam_Click(object sender, EventArgs e) //Open application
        {
            ProcessStartInfo start = new ProcessStartInfo();

            start.FileName = "D:/Game Files/Steam/steam.exe";

            start.WindowStyle = ProcessWindowStyle.Hidden;//start a console window
            start.CreateNoWindow = true;

            Process proc = Process.Start(start);
        }
    }
}

