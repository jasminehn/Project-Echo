using System;
using System.Windows.Forms;

namespace ProjectEcho
{
    public partial class VideoPlayerControl : UserControl
    {
        public VideoPlayerControl()
        {
            //This will give us the full name path of the executable file:
            //i.e. C:\Program Files\MyApplication\MyApplication.exe
            string strExeFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            //This will strip just the working path name:
            //C:\Program Files\MyApplication
            string strWorkPath = System.IO.Path.GetDirectoryName(strExeFilePath);
            string appPath = strWorkPath + @"\Project-Echo\vlclib";
            vlcControl1.VlcLibDirectory.MoveTo(appPath);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("CLARE:: YA GOT HERE");
            vlcControl1.Play(new Uri(@"C:\Users\JP003306\Downloads\emberslo.mp4"));
        }
    }
}
