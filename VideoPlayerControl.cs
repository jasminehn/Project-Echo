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
        private String path = @"C:\Users\ceseg\Videos\wow.mp4";
        public VideoPlayerControl()
        {
            InitializeComponent();
            
            vlcControl1.SetMedia(new Uri(path));
            long duration = vlcControl1.Time;
            Console.WriteLine("CLARE:: " + duration);
        }

        private void playPauseButton_Click(object sender, EventArgs e)
        {
            if(playState == false)
            {
                playPauseButton.Image = ProjectEcho.Properties.Resources.pauseButtonImage;
                vlcControl1.Play();
                playState = true;
                //long duration = vlcControl1.Time;
                //long duration = vlcControl1.GetMedia.Duration.Milliseconds;
                //Console.WriteLine("CLARE:: " + duration);
            }
            else if(playState == true)
            {
                playPauseButton.Image = ProjectEcho.Properties.Resources.playButtonImage;
                vlcControl1.Pause();
                playState = false;
            }
        }

        private void volumeBar_ValueChanged(object sender, decimal value)
        {
            vlcControl1.Audio.Volume = (int) value * 10;
        }
    }
}
