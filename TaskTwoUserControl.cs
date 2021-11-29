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
using Windows.Storage;


namespace ProjectEcho
{

    public partial class TaskTwoUserControl : UserControl
    {

        public TaskTwoUserControl()
        {
            InitializeComponent();
            //this.clipOneFrame.uiMode = "mini";
            //this.clipOneFrame.Enabled = true;
            
            //clipOneFrame.openPlayer(@"C:\Users\ceseg\Desktop\testClip.mp4");
            //this.clipOneFrame.URL= @"C:\Users\ceseg\Desktop\testClip.mp4";
            //this.clipOneFrame.openPlayer(@"C:\Users\ceseg\Desktop\testClip.mp4");
            //this.clipTwoFrame.uiMode = "mini";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /**
             *  KNOWN BUG:
             *  ADDING CONTROLS CAUSES THE LAST ROW'S HEIGHT TO SLOWLY GET LARGER AND LARGER
             *  
             */
            Control[] controls = new Control[2];
            controls[0] = new TextBox { Text = "", Height = 25, Width = 672, Anchor = AnchorStyles.Left, AutoSize = true };
            controls[1] = new CheckBox { Anchor = AnchorStyles.Left, AutoSize = true };
            tableLayoutPanel1.Controls.AddRange(controls);

            if((tableLayoutPanel1.Height + 25) < tableLayoutPanel1.MaximumSize.Height)
            {
                tableLayoutPanel1.Height += 25;
            }


           TableLayoutRowStyleCollection styles = tableLayoutPanel1.RowStyles;
           foreach(RowStyle style in styles)
            {
                if(style.SizeType != SizeType.Absolute)
                {
                    style.SizeType = SizeType.Absolute;
                }
            }

            foreach(RowStyle sizes in styles)
            {
                sizes.Height = 25;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(tableLayoutPanel1.RowCount != 2)
            {
                this.tableLayoutPanel1.RowStyles.RemoveAt(tableLayoutPanel1.RowCount - 1);
                this.tableLayoutPanel1.Controls.RemoveAt(tableLayoutPanel1.RowCount - 1);
                tableLayoutPanel1.RowCount -= 1;
                tableLayoutPanel1.Height -= 39;

                TableLayoutRowStyleCollection styles = this.tableLayoutPanel1.RowStyles;

                foreach(RowStyle style in styles)
                {
                    style.SizeType = SizeType.Percent;
                    style.Height = 100 / tableLayoutPanel1.RowCount;
                }
            }
        }

            private async void uploadButton_Click(object sender, EventArgs e)
            {
        
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.CheckFileExists = true;
                openFileDialog.AddExtension = true;
                openFileDialog.Multiselect = false;
                openFileDialog.Filter = "Video Files(*.mp4; *.mov; *.mp3)|*.mp3; *.mp4; *.mov";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                String path = "";

                if(openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    foreach(string fileName in openFileDialog.FileNames)
                    {
                        path = Path.GetFullPath(fileName);
                        await analyzeVideoAsync(path);
                    }
                }
                PlayFile(path);
            }

            private async Task analyzeVideoAsync(String path)
            {
                Windows.Storage.StorageFolder storageFolder =
                Windows.Storage.ApplicationData.Current.LocalFolder;
                Windows.Storage.StorageFile sampleFile = await storageFolder.CreateFileAsync(path,
                Windows.Storage.CreationCollisionOption.ReplaceExisting);

       
                //VideoProperties videoProperties = await sampleFile.Properties.GetVideoPropertiesAsync();
                //Console.WriteLine("CLARE:: " + videoProperties.Duration);
   
            }

        private void PlayFile(String path)
        {
            //clipOneFrame.URL = path;
            //clipOneFrame.Ctlcontrols.play();
        }

 
        private void t1paCL_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void permissionSlipTab_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //clipOneFrame.Ctlcontrols.play();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void taskOnePanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }

