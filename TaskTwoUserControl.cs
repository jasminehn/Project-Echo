﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectEcho
{
    /**
     *
     *
     *
     *
     * Author(s): C. Segrue, I. Gnagy, J. Nelson
     */

    public partial class TaskTwoUserControl : UserControl
    {
        public String firstVideoPath = "";
        public String secondVideoPath = "";

        private DocumentHandler dh = new DocumentHandler();
        private FormatChecker fc = new FormatChecker();
        SettingsHandler settingsHandler = new SettingsHandler();

        int textSizeOffset = 0;

        public Boolean[] taskProgress = { false, false };

        public TaskTwoUserControl()
        {
            InitializeComponent();

            loadProgress();

            mediaUploadInfo2A.Text = "Uploaded: " + dh.displayMultipleDocuments(3, "A", "video");
            uploadInfo2c2.Text = "Uploaded: " + dh.displayMultipleDocuments(3, "A", "video");
        }

        private void TaskTwoUserControl_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = Properties.Settings.Default.t2notes; //load last saved notes

            //Apply saved display settings
            textSizeOffset = Properties.Settings.Default.textsize; //sets offset to saved value
            var labels = settingsHandler.getAll(this, typeof(Label));
            foreach (Control c in labels)
            {
                System.Drawing.FontFamily fon = c.Font.FontFamily; //Sets font family
                FontStyle sty = c.Font.Style; //Sets style (ie. bold, italic, reg)
                float adjSize = c.Font.Size + textSizeOffset;

                c.Font = new Font(fon, adjSize, sty); //Passes in family, style, new size
            }

            //Apply saved darkmode settings
            var everything = settingsHandler.getAllControls(this);

            foreach (Control c in everything)
            {
                if ((c.Tag != null) && (c.Tag.ToString() == "panelBW"))
                {
                    c.BackColor = Properties.Settings.Default.bgcolor;
                }

                if ((c.Tag != null) && (c.Tag.ToString() == "analysisDM"))
                {
                    c.BackColor = Properties.Settings.Default.abcolor;
                }

                if ((c.Tag != null) && (c.Tag.ToString() == "feedbackDM"))
                {
                    c.BackColor = Properties.Settings.Default.fbcolor;
                }

                if ((c.Tag != null) && (c.Tag.ToString() == "checklistDM"))
                {
                    c.BackColor = Properties.Settings.Default.abcolor;
                    c.ForeColor = Properties.Settings.Default.fcolor;
                }

                if ((c.Tag != null) && (c.Tag.ToString() == "labelBW"))
                {
                    c.ForeColor = Properties.Settings.Default.fcolor;
                }

                if ((c.Tag != null) && (c.Tag.ToString() == "tabPageBW"))
                {
                    c.BackColor = Properties.Settings.Default.bgcolor;
                }
            }
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

        private async void FirstUploadButton_Click(object sender, EventArgs e)
        {
            try
            {
                await CheckVideo(2, "A", "video", mediaUploadInfo2A,
                    mediaCheckList2A, mediaTextBox2A,
                    mediaProgressBar2A, mediaProgressStatus2A,
                    11, 3, "firstVideoPath");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Open File Dialog closed by user. Stack Trace " + ex);
            }
        }

        public async Task CheckVideo(int taskNum, string taskPart, string documentType, Label uploadInfoLabel,
            CheckedListBox mediaCL, TextBox mediaTB,
            ProgressBar mediaPB, Label mediaPS,
            int maxLength, int minLength, String videoPath)
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

            Boolean[] itemsChecked = fc.runMediaFormatCheck(path, 500.0, maxLength, minLength);

            for (int i = 0; i < mediaCL.Items.Count; i++)
            {
                if (itemsChecked[i].Equals(true))
                {
                    mediaCL.SetItemChecked(i, true);
                }
            }

            mediaTB.Text = fc.mediaSizeFB
                + "\r\n\r\n" + fc.mediaLengthFB;

            mediaPS.Text = "FINISHED";

            if (videoPath == "firstVideoPath")
            {
                firstVideoPath = path;
            }
            else if (videoPath == "secondVideoPath")
            {
                secondVideoPath = path;
            }

            saveProgress();

            updateTaskProgress();
        }

        public void updateTaskProgress()
        {
            CheckedListBox[] progressPartA = { mediaCheckList2A };
            Boolean partAComplete = evaluateProgress(progressPartA);

            CheckedListBox[] progressPartB = { checkedListBox1 };
            Boolean partBComplete = evaluateProgress(progressPartB);

            taskProgress.SetValue(partAComplete, 0);
            taskProgress.SetValue(partBComplete, 1);
        }

        public Boolean evaluateProgress(CheckedListBox[] checkedListBoxes)
        {
            //check if all checkboxes are complete, if so return true
            Boolean isComplete = true;
            foreach (CheckedListBox cb in checkedListBoxes)
            {
                if (cb.CheckedItems.Count != cb.Items.Count)
                {
                    isComplete = false;
                    break;
                }
            }
            return isComplete;
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

        private async void SecondUploadButton_Click(object sender, EventArgs e)
        {
            //secondVideoPath = OpenFile();

            try
            {
                await CheckVideo(2, "A", "video", uploadInfo2c2,
                    checkedListBox1, textBox15,
                    progressBar1, label4,
                    11, 3, "secondVideoPath");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Open File Dialog closed by user. Stack Trace " + ex);
            }
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

        private void loadProgress()
        {
            /*  PART A  */
            //load saved checkboxes
            if (!string.IsNullOrEmpty(Properties.Settings.Default.mcl2a))
            {
                Properties.Settings.Default.mcl2a.Split(',').ToList().ForEach(item =>
                {
                    var index = mediaCheckList2A.Items.IndexOf(item);
                    mediaCheckList2A.SetItemChecked(index, true);
                });
            }
            //load saved feedback
            mediaTextBox2A.Text = Properties.Settings.Default.mtb2a;
        }

        private void saveProgress()
        {
            /*  TASK 2 PART A   */
            //save progress of all checkListBoxes task 2 part A
            var mcl2a = this.mediaCheckList2A.CheckedItems.Cast<string>().ToArray();
            Properties.Settings.Default.mcl2a = string.Join(",", mcl2a);
            //save progress of all feedback task 1 part A
            string mtb2a = mediaTextBox2A.Text;
            Properties.Settings.Default.mtb2a = mtb2a;

            Properties.Settings.Default.Save();
        }
    }
}