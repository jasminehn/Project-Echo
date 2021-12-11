using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Media;

namespace ProjectEcho
{
    /**
     *
     *
     *
     *
     * Author(s): C. Segrue, I. Gnagy
     */

    
    public partial class TaskTwoUserControl : UserControl
    {
<<<<<<< Updated upstream
        public String firstVideoPath = "";
        public String secondVideoPath = "";
=======
<<<<<<< HEAD
        SettingsHandler settingsHandler = new SettingsHandler();
        private int textSizeOffset = 0; //keeps track of how much the text size has changed

=======
        public String firstVideoPath = "";
        public String secondVideoPath = "";
>>>>>>> 2a6ac0e0b334120df791de8c8e5264c14fe3d95b
>>>>>>> Stashed changes
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

        // minus rows button click
        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("CLARE:: Number of Controls: " + tableLayoutPanel1.Controls.Count);
            Console.WriteLine("CLARE:: Number of ROWSs: " + tableLayoutPanel1.RowCount);
            
            if(tableLayoutPanel1.Controls.Count > 30)
            {
                tableLayoutPanel1.Controls.RemoveAt(tableLayoutPanel1.Controls.Count - 1);
                tableLayoutPanel1.Controls.RemoveAt(tableLayoutPanel1.Controls.Count - 1);

                if((tableLayoutPanel1.Height - 25) < tableLayoutPanel1.MinimumSize.Height)
                {
                    tableLayoutPanel1.Height -= 25;
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
        }

        private async void FirstUploadButton_Click(object sender, EventArgs e)
        {
            firstVideoPath = OpenFile();
           // PlayFile(path);
        }

        private String OpenFile()
        {
            //String strPath = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.AddExtension = true;
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "Video Files(*.mp4; *.mov; *.mp3)|*.mp3; *.mp4; *.mov";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            String path = "";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (string fileName in openFileDialog.FileNames)
                {
                    path = Path.GetFullPath(fileName);
                    //await analyzeVideoAsync(path);
                }
            }
            return path;
        }

        private async Task analyzeVideoAsync(String path)
        {
            //Windows.Storage.StorageFolder storageFolder =
            //Windows.Storage.ApplicationData.Current.LocalFolder;
            //Windows.Storage.StorageFile sampleFile = await storageFolder.CreateFileAsync(path,
            //Windows.Storage.CreationCollisionOption.ReplaceExisting);

            //VideoProperties videoProperties = await sampleFile.Properties.GetVideoPropertiesAsync();
            //Console.WriteLine("CLARE:: " + videoProperties.Duration);
        }

        private void PlayFile(String path)
        {
            try
            {
                Process.Start(path);
            } catch (Exception ex)
            {

            }
            
            //clipOneFrame.URL = path;
            //clipOneFrame.Ctlcontrols.play();
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void TaskTwoUserControl_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = Properties.Settings.Default.t2notes; //load last saved notes

            //Apply saved display settings
            textSizeOffset = Properties.Settings.Default.textsize; //sets offset to saved value
            var labels = settingsHandler.getAll(this, typeof(Label));
            foreach (Control c in labels)
            {
                System.Drawing.FontFamily fon = Font.FontFamily; //Sets font family
                FontStyle sty = c.Font.Style; //Sets style (ie. bold, italic, reg)
                float adjSize = c.Font.Size + textSizeOffset;

                c.Font = new Font(fon, adjSize, sty); //Passes in family, style, new size
            }
            var checkedlistboxes = settingsHandler.getAll(this, typeof(CheckedListBox));
            foreach (Control c in checkedlistboxes)
            {
                c.BackColor = Properties.Settings.Default.bgcolor;
                c.ForeColor = Properties.Settings.Default.fcolor;
                System.Drawing.FontFamily fon = Font.FontFamily; //Sets font family
                FontStyle sty = c.Font.Style; //Sets style (ie. bold, italic, reg)
                float adjSize = c.Font.Size + textSizeOffset;

                c.Font = new Font(fon, adjSize, sty); //Passes in family, style, new size
            }

            Panel[] panels = new Panel[] { panel3, panel7};
            foreach (Control c in panels)
            {
                c.BackColor = Properties.Settings.Default.bgcolor;
                c.ForeColor = Properties.Settings.Default.fcolor;
            }
            BackColor = Properties.Settings.Default.bgmain;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //save notes as they type
            Properties.Settings.Default.t2notes = richTextBox1.Text;
            Properties.Settings.Default.Save();
        }

        private void SecondUploadButton_Click(object sender, EventArgs e)
        {
            secondVideoPath = OpenFile();
        }

        private void FirstPlayButton_Click(object sender, EventArgs e)
        {
            if(firstVideoPath != "")
            {
                PlayFile(firstVideoPath);
            }
        }

        private void SecondPlayButton_Click(object sender, EventArgs e)
        {
            if (secondVideoPath != "")
            {
                PlayFile(secondVideoPath);
            }
        }
    }
}