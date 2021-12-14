using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

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
        public String firstVideoPath = "";
        public String secondVideoPath = "";

        private DocumentHandler dh = new DocumentHandler();
        private FormatChecker fc = new FormatChecker();

        int textSizeOffset = 0;
        SettingsHandler settingsHandler = new SettingsHandler();

        public TaskTwoUserControl()
        {
            InitializeComponent();
        }

        private void TaskTwoUserControl_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = Properties.Settings.Default.t2notes; //load last saved notes

            /*
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
            Panel[] panels = new Panel[] { panel3, panel7 };
            foreach (Control c in panels)
            {
                c.BackColor = Properties.Settings.Default.bgcolor;
                c.ForeColor = Properties.Settings.Default.fcolor;
            }
            */
        }

        private void AddRowButton_Click(object sender, EventArgs e)
        {
            Control[] controls = new Control[2];
            controls[0] = new TextBox { Text = "", Height = 25, Width = 672, Anchor = AnchorStyles.Left, AutoSize = true };
            controls[1] = new CheckBox { Anchor = AnchorStyles.Left, AutoSize = true };
            tableLayoutPanel1.Controls.AddRange(controls);

            if ((tableLayoutPanel1.Height + 25) < tableLayoutPanel1.MaximumSize.Height)
            {
                tableLayoutPanel1.Height += 25;
            }

            TableLayoutRowStyleCollection styles = tableLayoutPanel1.RowStyles;
            foreach (RowStyle style in styles)
            {
                if (style.SizeType != SizeType.Absolute)
                {
                    style.SizeType = SizeType.Absolute;
                }
            }

            foreach (RowStyle sizes in styles)
            {
                sizes.Height = 25;
            }
        }

        // minus rows button click
        private void RemoveRowButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("CLARE:: Number of Controls: " + tableLayoutPanel1.Controls.Count);
            Console.WriteLine("CLARE:: Number of ROWSs: " + tableLayoutPanel1.RowCount);

            if (tableLayoutPanel1.Controls.Count > 30)
            {
                tableLayoutPanel1.Controls.RemoveAt(tableLayoutPanel1.Controls.Count - 1);
                tableLayoutPanel1.Controls.RemoveAt(tableLayoutPanel1.Controls.Count - 1);

                if ((tableLayoutPanel1.Height - 25) < tableLayoutPanel1.MinimumSize.Height)
                {
                    tableLayoutPanel1.Height -= 25;
                }

                TableLayoutRowStyleCollection styles = tableLayoutPanel1.RowStyles;
                foreach (RowStyle style in styles)
                {
                    if (style.SizeType != SizeType.Absolute)
                    {
                        style.SizeType = SizeType.Absolute;
                    }
                }

                foreach (RowStyle sizes in styles)
                {
                    sizes.Height = 25;
                }
            }
        }

        private void FirstUploadButton_Click(object sender, EventArgs e)
        {
            firstVideoPath = OpenFile();

            //CheckVideo(2, "A", "media", ) //finish later
        }

        private String OpenFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                CheckFileExists = true,
                AddExtension = true,
                Multiselect = false,
                Filter = "Video Files(*.mp4; *.mov; *.mp3)|*.mp3; *.mp4; *.mov",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            };

            String path = "";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (string fileName in openFileDialog.FileNames)
                {
                    path = Path.GetFullPath(fileName);
                    AnalyzeVideoAsync(path);


                    //MOVE THIS LATER
                    string separatedFileName = Path.GetFileName(fileName); //gets only the file name + extension
                    uploadInfo2c1.Text = "Uploaded: \n" + separatedFileName;

                    List<string> mlist = new List<string>();
                    for (int i = 0; i < 100; i++)
                    {
                        mlist.Add(i.ToString());
                    }
                    var mprogress = new Progress<ProgressInformation>();
                    mprogress.ProgressChanged += (o, report) =>
                    {
                        progressBar4.Value = report.PercentComplete;
                        progressBar4.Update();
                    };
                    processData(mlist, mprogress);

                    t1paCL.SetItemChecked(1, true);
                    //MOVE THIS LATER (END)
                }
            }
            return path;
        }

        private async Task AnalyzeVideoAsync(String path)
        {
            //Windows.Storage.StorageFolder storageFolder =
            //Windows.Storage.ApplicationData.Current.LocalFolder;
            //Windows.Storage.StorageFile sampleFile = await storageFolder.CreateFileAsync(path,
            //Windows.Storage.CreationCollisionOption.ReplaceExisting);

            //VideoProperties videoProperties = await sampleFile.Properties.GetVideoPropertiesAsync();
            //Console.WriteLine("CLARE:: " + videoProperties.Duration);
        }

        //FINISH LATER
        public async Task CheckVideo(int taskNum, string taskPart, string documentType, Label uploadInfoLabel,
            CheckedListBox mediaCL, TextBox mediaTB,
            ProgressBar mediaPB, Label mediaPS,
            int mediaLength)
        {
            //Clears all checkedListBoxes
            foreach (int i in mediaCL.CheckedIndices)
            {
                mediaCL.SetItemCheckState(i, CheckState.Unchecked);
            }

            //progress bar
            List<string> mlist = new List<string>();
            for (int i = 0; i < 100; i++)
            {
                mlist.Add(i.ToString());
            }
            var mprogress = new Progress<ProgressInformation>();
            mprogress.ProgressChanged += (o, report) =>
            {
                mediaPB.Value = report.PercentComplete;
                mediaPB.Update();
            };

            String path = dh.uploadMultipleDocuments(taskNum, taskPart, documentType); //Upload the file
            uploadInfoLabel.Text = "Uploaded: " + dh.displayMultipleDocuments(taskNum, taskPart, documentType); //updates text displaying the previously uploaded files

            await processData(mlist, mprogress); //Start the progress bar


            Boolean[] itemsChecked = fc.runMediaFormatCheck(path, 0);

            mediaTB.Text = fc.mediaSizeFB
                + "\r\n\r\n" + fc.mediaLengthFB;

            mediaPS.Text = "FINISHED";
        }

        private void PlayFile(String path)
        {
            try
            {
                Process.Start(path);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            //clipOneFrame.URL = path;
            //clipOneFrame.Ctlcontrols.play();
        }

        private Task processData(List<string> list, IProgress<ProgressInformation> progress)
        {
            int index = 1;
            int totalProcess = list.Count;
            var progressInfo = new ProgressInformation();
            return Task.Run(() =>
            {
                for (int i = 0; i < totalProcess; i++)
                {
                    progressInfo.PercentComplete = index++ * 100 / totalProcess;
                    progress.Report(progressInfo);
                    System.Threading.Thread.Sleep(10); //used to simulate length of operation
                }
            });
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
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
            if (firstVideoPath != "")
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