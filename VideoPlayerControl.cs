using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vlc.DotNet.Forms;

namespace ProjectEcho
{
    public partial class VideoPlayerControl : UserControl
    {
        public VlcControl videoControl1 = new VlcControl();
        public VideoPlayerControl()
        {
            String strExeFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            Console.WriteLine("CLARE:: location of app " + strExeFilePath);
            String strWorkPath = System.IO.Path.GetDirectoryName(strExeFilePath);
            Console.WriteLine("CLARE:: work path " + strWorkPath);
            string appPath = strWorkPath + @"\vlclib";
            

            try
            {
                var libDirectory = new DirectoryInfo(appPath);
                
                videoControl1.VlcLibDirectory = libDirectory;
            }
            catch (Exception e)
            {
                Console.WriteLine("Setting libdir failed. Stack Trace: " + e);
            }


            InitializeComponent();
            videoControl1.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            videoControl1.Dock = DockStyle.Fill;
            this.videoControlPanel.Controls.Add(videoControl1);
            //var libDirectory = new DirectoryInfo(appPath);

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("CLARE:: YA GOT HERE");
            //vlcControl1.Play(new Uri(@"C:\Users\JP003306\Downloads\emberslo.mp4"));
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }
    }
}
