using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows98Launcher
{

    public partial class BootOptions : Form
    {
        public BootOptions()
        {
            InitializeComponent();
        }

        static class BootOptionVars
        {
            public static bool FloppyDisk;
            public static bool CD;
            public static string FloppyName;
            public static string CDName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            floppydiskimage.ShowDialog();

            if (floppydiskimage.SafeFileName != "")
            {
                label1.Text = floppydiskimage.SafeFileName;
                BootOptionVars.FloppyDisk = true;
                BootOptionVars.FloppyName = floppydiskimage.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cdimage.ShowDialog();

            if (cdimage.SafeFileName != "")
            {
                label2.Text = cdimage.SafeFileName;
                BootOptionVars.CD = true;
                BootOptionVars.CDName = cdimage.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string BootArgs = "";
            if (BootOptionVars.CD & BootOptionVars.FloppyDisk)
            {
                BootArgs = "-serial stdio -drive file=win98.qcow2,media=disk -cdrom " + BootOptionVars.CDName + " -fda " + BootOptionVars.FloppyName + " -full-screen";
            }
            else if (BootOptionVars.CD)
            {
                BootArgs = "-serial stdio -drive file=win98.qcow2,media=disk -cdrom " + BootOptionVars.CDName + " -full-screen";
            }
            else if (BootOptionVars.FloppyDisk)
            {
                BootArgs = "-serial stdio -drive file=win98.qcow2,media=disk -fda " + BootOptionVars.FloppyName + " -full-screen";
            }
            else
            {
                MessageBox.Show("Please select a floppy disk and/or CD image.", "No floppy or CD", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            Process win98 = new Process();
            win98.StartInfo.UseShellExecute = false;
            win98.StartInfo.RedirectStandardOutput = true;
            win98.StartInfo.FileName = "qemu-98\\qemu-system-i386.exe";
            win98.StartInfo.Arguments = BootArgs;
            win98.StartInfo.CreateNoWindow = true;
            win98.Start();
        }
    }
}
