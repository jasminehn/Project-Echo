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
        private Boolean playState = false;
        public VideoPlayerControl()
        {
            InitializeComponent();
            textBox1.Text = "C:\\Users\\365ye\\OneDrive\\Desktop\\wow.mp4";
            vlcControl1.SetMedia(new Uri(textBox1.Text));
            //vlcControl1.Play(new Uri(textBox1.Text));
        }

        private void selectVideo_Click(object sender, EventArgs e)
        {
            vlcControl1.Play(new Uri(textBox1.Text));
        }

        private void playPauseButton_Click(object sender, EventArgs e)
        {
            if(playState == false)
            {
                vlcControl1.Play();
                //button3.Text = "Play";
                playState = true;
            }
            else if(playState == true)
            {
                vlcControl1.Pause();
                //button3.Text = "Pause";
                playState = false;
            }
        }
    }
}
