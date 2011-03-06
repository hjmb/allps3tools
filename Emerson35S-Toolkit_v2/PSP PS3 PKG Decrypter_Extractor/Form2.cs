using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PKG_Manager
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.EnableRaisingEvents = false;
            proc.StartInfo.FileName = "http://www.ps3-hacks.com/file/293";
            proc.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.EnableRaisingEvents = false;
            proc.StartInfo.FileName = "http://www.nextgenupdate.com/forums/playstation-3-exploits-hacks/326625-puff-puff-pass-post-share-your-custom-ps3-boot-logos-sound.html";
            proc.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.EnableRaisingEvents = false;
            proc.StartInfo.FileName = "http://www.ps3-hacks.com/2011/02/21/ps3-coldboot-installer-3-56-version-spoofer-released/";
            proc.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.EnableRaisingEvents = false;
            proc.StartInfo.FileName = "http://www.ps3-hacks.com/file/276";
            proc.Start();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("How to install? \nEnable write access to dev_flash by using asbestos, \nupload Coldboot.raf to /dev_rwflash/vsh/resources." 
                + "\nRename and upload whatever ac3 file too if you wish to change the start-up sound — or simply use this Coldboot Installer." 
                + "\n Whatever you see fit.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.EnableRaisingEvents = false;
            proc.StartInfo.FileName = "http://www.nextgenupdate.com/forums/playstation-3-exploits-hacks/324060-release-custom-ps3-boot-logo-creator.html";
            proc.Start();
        }
    }
}
