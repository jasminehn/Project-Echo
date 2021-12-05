using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectEcho
{
    public partial class VideoPlayerControl : UserControl
    {
        public VideoPlayerControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("CLARE:: YA GOT HERE");
            vlcControl1.Play(new Uri(@"C:\Users\JP003306\Downloads\emberslo.mp4"));
        }
    }
}
