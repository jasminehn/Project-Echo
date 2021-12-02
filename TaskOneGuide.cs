using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//using Vlc.DotNet.Forms;

namespace ProjectEcho
{
    public partial class TaskOneGuide : Form
    {

        public TaskOneGuide()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            vlcControl1.Play(new Uri(textBox1.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(button3.Text == "Pause")
            {
                vlcControl1.Pause();
                button3.Text = "Start";
            }
            else if(button3.Text == "Start")
            {
                vlcControl1.Pause();
                button3.Text = "Pause";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            vlcControl1.Stop();
        }

        private void TaskOneGuide_Load(object sender, EventArgs e)
        {
            /*
            vlcControl1.BeginInit();
            //vlcControl1.VlcLibDirectory = new DirectoryInfo(_exeFolder + @"\libvlc\win-x86"); //Make sure your dir is correct
            vlcControl1.VlcLibDirectory = new DirectoryInfo("C: \\Users\\365ye\\OneDrive\\Documents\\GitHub\\Project - Echo\\libvlc\\");
            vlcControl1.VlcMediaplayerOptions = new[] { "-vv" }; //not sure what this does
            vlcControl1.EndInit();
            //YourControlContainer.Controls.Add(vlcControl1); //Add the control to your container
            */
            textBox1.Text = "C:\\Users\\365ye\\OneDrive\\Desktop\\wow.mp4";
        }
    }
}
