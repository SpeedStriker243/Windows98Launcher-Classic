using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Windows98Launcher
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            if (!Directory.Exists("qemu-98"))
            {
                MessageBox.Show("The directory 'qemu-98' does not exist. Program must close.", "Fatal error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Environment.Exit(0);
            }
            if (File.Exists("windows98.iso") == false)
            {
                MessageBox.Show("The Windows 98 ISO file was not found. Please add a Windows 98 ISO file next to this program and name it 'windows98.iso'.", "ISO file not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                button2.Enabled = false;
            }
            if (File.Exists("winboot.img") == false)
            {
                MessageBox.Show("The Windows 98 boot floppy image was not found. Please add a Windows 98 boot floppy disk file next to this program and name it 'winboot.img'.", "Boot floppy image not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                button2.Enabled = false;
            }
            if (!File.Exists("win98.qcow2"))
            {
                DialogResult createHardDisk = MessageBox.Show("No virtual hard drive found for Windows 98. Create one?", "No hard drive found", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (createHardDisk == DialogResult.Yes)
                {
                    Process.Start("qemu-98/qemu-img.exe", "create -f qcow2 .\\win98.qcow2 512M");
                }
                if (createHardDisk == DialogResult.No)
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.qemu.org/");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process win98 = new Process();
            win98.StartInfo.UseShellExecute = false;
            win98.StartInfo.RedirectStandardOutput = true;
            win98.StartInfo.FileName = "qemu-98\\qemu-system-i386.exe";
            win98.StartInfo.Arguments = "-serial stdio -drive file=win98.qcow2,media=disk -full-screen";
            win98.StartInfo.CreateNoWindow = true;
            win98.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process win98s = new Process();
            win98s.StartInfo.UseShellExecute = false;
            win98s.StartInfo.RedirectStandardOutput = true;
            win98s.StartInfo.FileName = "qemu-98\\qemu-system-i386.exe";
            win98s.StartInfo.Arguments = "-serial stdio -drive file=win98.qcow2,media=disk -fda winboot.img -cdrom windows98.iso -boot d -full-screen";
            win98s.StartInfo.CreateNoWindow = true;
            win98s.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var options = new BootOptions();
            options.Show();
        }
    }
}
