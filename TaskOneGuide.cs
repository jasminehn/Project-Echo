using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vlc.DotNet.Forms;

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
                button3.Text = "Play";
            }
            else if(button3.Text == "Play")
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
            textBox1.Text = @"C:\Users\JP003306\Downloads\emberslo.mp4";
        }
    }
}
