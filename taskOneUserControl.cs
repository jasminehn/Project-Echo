using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationCapstoneChecker
{
    /**
     *
     *
     *
     * Author(s): C. Segrue, J. Nelson, I. Gnagy
     */

    public partial class TaskOneUserControl : UserControl
    {
        private DocumentHandler dh = new DocumentHandler();
        private FormatChecker fc = new FormatChecker();
        public static bool complete = false;

        int textSizeOffset = 0;
        SettingsHandler settingsHandler = new SettingsHandler();

        public TaskOneUserControl()
        {
            InitializeComponent();

            //Displays the currently uploaded documents for each task part
            uploadInfo1A.Text = "Uploaded: " + dh.displayDocuments(1, "A");
            uploadInfo1B.Text = "Uploaded: " + dh.displayDocuments(1, "B");
            uploadInfo1C.Text = "Uploaded: " + dh.displayDocuments(1, "C");
            uploadInfo1D.Text = "Uploaded: " + dh.displayDocuments(1, "D");
            uploadInfo1E.Text = "Uploaded: " + dh.displayDocuments(1, "E");
        }

        private void TaskOneUserControl_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = Properties.Settings.Default.t1notes; //load last saved notes


            //load saved checkboxes
            if (!string.IsNullOrEmpty(Properties.Settings.Default.fcl1a))
            {
                Properties.Settings.Default.fcl1a.Split(',').ToList().ForEach(item =>
                {
                    var index = formatCheckList1A.Items.IndexOf(item);
                    formatCheckList1A.SetItemChecked(index, true);
                });
            }
            if (!string.IsNullOrEmpty(Properties.Settings.Default.gcl1a))
            {
                Properties.Settings.Default.gcl1a.Split(',').ToList().ForEach(item =>
                {
                    var index = grammarCheckList1A.Items.IndexOf(item);
                    grammarCheckList1A.SetItemChecked(index, true);
                });
            }
            if (!string.IsNullOrEmpty(Properties.Settings.Default.ccl1a))
            {
                Properties.Settings.Default.ccl1a.Split(',').ToList().ForEach(item =>
                {
                    var index = contentCheckList1A.Items.IndexOf(item);
                    contentCheckList1A.SetItemChecked(index, true);
                });
            }
            //load saved feedback
            formatTextBox1A.Text = Properties.Settings.Default.ftb1a;
            grammarTextBox1A.Text = Properties.Settings.Default.gtb1a;
            if (!string.IsNullOrEmpty(Properties.Settings.Default.clb1a))
            {
                Properties.Settings.Default.clb1a.Split(',').ToList().ForEach(item => { contentListBox1A.Items.Add(item); });
            }


            /*  PART B  */
            //load saved checkboxes
            if (!string.IsNullOrEmpty(Properties.Settings.Default.fcl1b))
            {
                Properties.Settings.Default.fcl1b.Split(',').ToList().ForEach(item =>
                {
                    var index = formatCheckList1B.Items.IndexOf(item);
                    formatCheckList1B.SetItemChecked(index, true);
                });
            }
            if (!string.IsNullOrEmpty(Properties.Settings.Default.gcl1b))
            {
                Properties.Settings.Default.gcl1b.Split(',').ToList().ForEach(item =>
                {
                    var index = grammarCheckList1B.Items.IndexOf(item);
                    grammarCheckList1B.SetItemChecked(index, true);
                });
            }
            if (!string.IsNullOrEmpty(Properties.Settings.Default.ccl1b))
            {
                Properties.Settings.Default.ccl1b.Split(',').ToList().ForEach(item =>
                {
                    var index = contentCheckList1B.Items.IndexOf(item);
                    contentCheckList1B.SetItemChecked(index, true);
                });
            }
            //load saved feedback
            formatTextBox1B.Text = Properties.Settings.Default.ftb1b;
            grammarTextBox1B.Text = Properties.Settings.Default.gtb1b;
            if (!string.IsNullOrEmpty(Properties.Settings.Default.fcl1a))
            {
                Properties.Settings.Default.clb1b.Split(',').ToList().ForEach(item => { contentListBox1B.Items.Add(item); });
            }


            /*  PART C  */
            //load saved checkboxes
            if (!string.IsNullOrEmpty(Properties.Settings.Default.fcl1c))
            {
                Properties.Settings.Default.fcl1c.Split(',').ToList().ForEach(item =>
                {
                    var index = formatCheckList1C.Items.IndexOf(item);
                    formatCheckList1C.SetItemChecked(index, true);
                });
            }
            if (!string.IsNullOrEmpty(Properties.Settings.Default.gcl1c))
            {
                Properties.Settings.Default.gcl1c.Split(',').ToList().ForEach(item =>
                {
                    var index = grammarCheckList1C.Items.IndexOf(item);
                    grammarCheckList1C.SetItemChecked(index, true);
                });
            }
            if (!string.IsNullOrEmpty(Properties.Settings.Default.ccl1c))
            {
                Properties.Settings.Default.ccl1c.Split(',').ToList().ForEach(item =>
                {
                    var index = contentCheckList1C.Items.IndexOf(item);
                    contentCheckList1C.SetItemChecked(index, true);
                });
            }
            //load saved feedback
            formatTextBox1C.Text = Properties.Settings.Default.ftb1c;
            grammarTextBox1C.Text = Properties.Settings.Default.gtb1c;
            if (!string.IsNullOrEmpty(Properties.Settings.Default.clb1c))
            {
                Properties.Settings.Default.clb1c.Split(',').ToList().ForEach(item => { contentListBox1C.Items.Add(item); });
            }


            /*  PART D  */
            //load saved checkboxes
            if (!string.IsNullOrEmpty(Properties.Settings.Default.fcl1d))
            {
                Properties.Settings.Default.fcl1d.Split(',').ToList().ForEach(item =>
                {
                    var index = formatCheckList1D.Items.IndexOf(item);
                    formatCheckList1D.SetItemChecked(index, true);
                });
            }
            if (!string.IsNullOrEmpty(Properties.Settings.Default.gcl1d))
            {
                Properties.Settings.Default.gcl1d.Split(',').ToList().ForEach(item =>
                {
                    var index = grammarCheckList1D.Items.IndexOf(item);
                    grammarCheckList1D.SetItemChecked(index, true);
                });
            }
            if (!string.IsNullOrEmpty(Properties.Settings.Default.ccl1d))
            {
                Properties.Settings.Default.ccl1d.Split(',').ToList().ForEach(item =>
                {
                    var index = contentCheckList1D.Items.IndexOf(item);
                    contentCheckList1D.SetItemChecked(index, true);
                });
            }
            //load saved feedback
            formatTextBox1D.Text = Properties.Settings.Default.ftb1d;
            grammarTextBox1D.Text = Properties.Settings.Default.gtb1d;
            if (!string.IsNullOrEmpty(Properties.Settings.Default.clb1d))
            {
                Properties.Settings.Default.clb1d.Split(',').ToList().ForEach(item => { contentListBox1D.Items.Add(item); });
            }


            /*  PART E  */
            //load saved checkboxes
            if (!string.IsNullOrEmpty(Properties.Settings.Default.fcl1e))
            {
                Properties.Settings.Default.fcl1e.Split(',').ToList().ForEach(item =>
                {
                    var index = formatCheckList1E.Items.IndexOf(item);
                    formatCheckList1E.SetItemChecked(index, true);
                });
            }
            if (!string.IsNullOrEmpty(Properties.Settings.Default.gcl1e))
            {
                Properties.Settings.Default.gcl1e.Split(',').ToList().ForEach(item =>
                {
                    var index = grammarCheckList1E.Items.IndexOf(item);
                    grammarCheckList1E.SetItemChecked(index, true);
                });
            }
            if (!string.IsNullOrEmpty(Properties.Settings.Default.ccl1e))
            {
                Properties.Settings.Default.ccl1e.Split(',').ToList().ForEach(item =>
                {
                    var index = contentCheckList1E.Items.IndexOf(item);
                    contentCheckList1E.SetItemChecked(index, true);
                });
            }
            //load saved feedback
            formatTextBox1E.Text = Properties.Settings.Default.ftb1e;
            grammarTextBox1E.Text = Properties.Settings.Default.gtb1e;
            if (!string.IsNullOrEmpty(Properties.Settings.Default.clb1e))
            {
                Properties.Settings.Default.clb1e.Split(',').ToList().ForEach(item => { contentListBox1E.Items.Add(item); });
            }


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
            var tabs = settingsHandler.getAll(this, typeof(TabPage));
            foreach (Control c in tabs)
            {
                c.BackColor = Properties.Settings.Default.bgcolor;
                c.ForeColor = Properties.Settings.Default.fcolor;
            }
            Panel[] panels = new Panel[] { panel7, panel3, panel4, panel5, panel6};
            foreach (Control c in panels)
            {
                c.BackColor = Properties.Settings.Default.bgcolor;
                c.ForeColor = Properties.Settings.Default.fcolor;
            }
            */
        }

        private async void UploadButton1A_Click(object sender, EventArgs e)
        {
            try
            {
                await CheckDocument(1, "A", uploadInfo1A,
                    formatCheckList1A, formatTextBox1A,
                    grammarCheckList1A, grammarTextBox1A,
                    contentCheckList1A, contentListBox1A,
                    formatProgressBar1A, formatProgressStatus1A,
                    grammarProgressBar1A, grammarProgressStatus1A,
                    contentProgressBar1A, contentProgressStatus1A,
                    4);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Open File Dialog closed by user. Stack trace: " + ex);
            }
        }

        private async void UploadButton1B_Click(object sender, EventArgs e)
        {
            try
            {
                await CheckDocument(1, "B", uploadInfo1B,
                    formatCheckList1B, formatTextBox1B,
                    grammarCheckList1B, grammarTextBox1B,
                    contentCheckList1B, contentListBox1B,
                    formatProgressBar1B, formatProgressStatus1B,
                    grammarProgressBar1B, grammarProgressStatus1B,
                    contentProgressBar1B, contentProgressStatus1B,
                    0);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Open File Dialog closed by user. Stack trace: " + ex);
            }
        }

        private async void UploadButton1C_Click(object sender, EventArgs e)
        {
            try
            {
                await CheckDocument(1, "C", uploadInfo1C,
                    formatCheckList1C, formatTextBox1C,
                    grammarCheckList1C, grammarTextBox1C,
                    contentCheckList1C, contentListBox1C,
                    formatProgressBar1C, formatProgressStatus1C,
                    grammarProgressBar1C, grammarProgressStatus1C,
                    contentProgressBar1C, contentProgressStatus1C,
                    0);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Open File Dialog closed by user. Stack trace: " + ex);
            }
        }

        private async void uploadButton1D_Click(object sender, EventArgs e)
        {
            try
            {
                await CheckDocument(1, "D", uploadInfo1D,
                    formatCheckList1D, formatTextBox1D,
                    grammarCheckList1D, grammarTextBox1D,
                    contentCheckList1D, contentListBox1D,
                    formatProgressBar1D, formatProgressStatus1D,
                    grammarProgressBar1D, grammarProgressStatus1D,
                    contentProgressBar1D, contentProgressStatus1D,
                    0);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Open File Dialog closed by user. Stack trace: " + ex);
            }
        }

        private async void UploadButton1E_Click(object sender, EventArgs e)
        {
            try
            {
                await CheckDocument(1, "E", uploadInfo1E,
                    formatCheckList1E, formatTextBox1E,
                    grammarCheckList1E, grammarTextBox1E,
                    contentCheckList1E, contentListBox1E,
                    formatProgressBar1E, formatProgressStatus1E,
                    grammarProgressBar1E, grammarProgressStatus1E,
                    contentProgressBar1E, contentProgressStatus1E,
                    9);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Open File Dialog closed by user. Stack trace: " + ex);
            }
        }

        /* This method programatically executed the uploading and checking of a document. 
         * Because each task part has unique controls, this is necessary to avoid repeated code.
        */
        public async Task CheckDocument(int taskNum, string taskPart, Label uploadInfoLabel,
            CheckedListBox formatCL, TextBox formatTextBox,
            CheckedListBox grammarCL, TextBox grammarErrorsTextBox,
            CheckedListBox contentCL, ListBox missingWordsListBox,
            ProgressBar formatPB, Label formatPS,
            ProgressBar grammarPB, Label grammarPS,
            ProgressBar contentPB, Label contentPS,
            int pageCount)
        {
            //Clears all checkedListBoxes
            foreach (int i in formatCL.CheckedIndices)
            {
                formatCL.SetItemCheckState(i, CheckState.Unchecked);
            }
            foreach (int i in grammarCL.CheckedIndices)
            {
                grammarCL.SetItemCheckState(i, CheckState.Unchecked);
            }
            foreach (int i in contentCL.CheckedIndices)
            {
                contentCL.SetItemCheckState(i, CheckState.Unchecked);
            }

            //progress bar stuff
            List<string> flist = new List<string>();
            List<string> glist = new List<string>();
            List<string> clist = new List<string>();
            for (int i = 0; i < 100; i++)
            {
                flist.Add(i.ToString());
                glist.Add(i.ToString());
                clist.Add(i.ToString());
            }
            var fprogress = new Progress<ProgressInformation>();
            fprogress.ProgressChanged += (o, report) =>
            {
                formatPB.Value = report.PercentComplete;
                formatPB.Update();
            };
            var gprogress = new Progress<ProgressInformation>();
            gprogress.ProgressChanged += (o, report) =>
            {
                grammarPB.Value = report.PercentComplete;
                grammarPB.Update();
            };
            var cprogress = new Progress<ProgressInformation>();
            cprogress.ProgressChanged += (o, report) =>
            {
                contentPB.Value = report.PercentComplete;
                contentPB.Update();
            };

            String path = dh.uploadDocument(taskNum, taskPart);

            if (path.EndsWith(".docx") || path.EndsWith(".doc"))
            {
                //Execute format analysis
                await processData(flist, fprogress); //PROGRESS BAR

                uploadInfoLabel.Text = "Uploaded: " + dh.displayDocuments(taskNum, taskPart); //updates text displaying the previously uploaded files
                Boolean[] itemsChecked = fc.runFormatCheck(path, pageCount);

                for (int i = 0; i < formatCL.Items.Count; i++)
                {
                    if (itemsChecked[i].Equals(true))
                    {
                        formatCL.SetItemChecked(i, true);
                    }
                }

                formatTextBox.Text = fc.leftMarginFB
                    + "\r\n\r\n" + fc.rightMarginFB
                    + "\r\n\r\n" + fc.topMarginFB
                    + "\r\n\r\n" + fc.bottomMarginFB
                    + "\r\n\r\n" + fc.fontTypeFB
                    + "\r\n\r\n" + fc.fontSizeFB
                    + "\r\n\r\n" + fc.pageNumFB;

                formatPS.Text = "FINISHED";
            }

            //Execute grammar analysis
            await processData(glist, gprogress);//PROGRES SBAR

            await GrammarAPI.returnReport(path); //execute API call

            string grammarReport = GrammarAPI.reportOutput;

            grammarErrorsTextBox.Text = grammarReport;

            if (GrammarAPI.spellingErrorCount == 0)
            {
                grammarCL.SetItemChecked(0, true);
            }
            if (GrammarAPI.grammarErrorCount == 0)
            {
                grammarCL.SetItemChecked(1, true);
            }
            if (GrammarAPI.styleErrorCount == 0)
            {
                grammarCL.SetItemChecked(2, true);
            }
            grammarPS.Text = "FINISHED";

            // Execute content analysis
            await processData(clist, cprogress);//PROGRESS BAR
            missingWordsListBox.DataSource = GrammarAPI.glossaryWordList;
            if (missingWordsListBox.Items.Count == 0)
            {
                contentCL.SetItemChecked(0, true);
            }
            contentPS.Text = "FINISHED";

            saveProgress();
        }

        private void saveProgress()
        {
            //save progress of all checkListBoxes task 1 part A
            var fcl1a = this.formatCheckList1A.CheckedItems.Cast<string>().ToArray();
            Properties.Settings.Default.fcl1a = string.Join(",", fcl1a);
            var gcl1a = this.grammarCheckList1A.CheckedItems.Cast<string>().ToArray();
            Properties.Settings.Default.gcl1a = string.Join(",", gcl1a);
            var ccl1a = this.contentCheckList1A.CheckedItems.Cast<string>().ToArray();
            Properties.Settings.Default.ccl1a = string.Join(",", ccl1a);
            //save progress of all feedback task 1 part A
            string ftb1a = formatTextBox1A.Text;
            Properties.Settings.Default.ftb1a = ftb1a;
            string gtb1a = grammarTextBox1A.Text;
            Properties.Settings.Default.gtb1a = gtb1a;
            var clb1a = this.contentListBox1A.Items.Cast<string>().ToArray();
            Properties.Settings.Default.clb1a = string.Join(",", clb1a);


            /*  TASK 1 PART B   */
            //save progress of all checkListBoxes task 1 part B
            var fcl1b = this.formatCheckList1B.CheckedItems.Cast<string>().ToArray();
            Properties.Settings.Default.fcl1b = string.Join(",", fcl1b);
            var gcl1b = this.grammarCheckList1B.CheckedItems.Cast<string>().ToArray();
            Properties.Settings.Default.gcl1b = string.Join(",", gcl1b);
            var ccl1b = this.contentCheckList1B.CheckedItems.Cast<string>().ToArray();
            Properties.Settings.Default.ccl1b = string.Join(",", ccl1b);
            //save progress of all feedback task 1 part B
            string ftb1b = formatTextBox1B.Text;
            Properties.Settings.Default.ftb1b = ftb1b;
            string gtb1b = grammarTextBox1B.Text;
            Properties.Settings.Default.gtb1b = gtb1b;
            var clb1b = this.contentListBox1B.Items.Cast<string>().ToArray();
            Properties.Settings.Default.clb1b = string.Join(",", clb1b);


            /*  TASK 1 PART C   */
            //save progress of all checkListBoxes task 1 part B
            var fcl1c = this.formatCheckList1C.CheckedItems.Cast<string>().ToArray();
            Properties.Settings.Default.fcl1c = string.Join(",", fcl1c);
            var gcl1c = this.grammarCheckList1C.CheckedItems.Cast<string>().ToArray();
            Properties.Settings.Default.gcl1c = string.Join(",", gcl1c);
            var ccl1c = this.contentCheckList1C.CheckedItems.Cast<string>().ToArray();
            Properties.Settings.Default.ccl1c = string.Join(",", ccl1c);
            //save progress of all feedback task 1 part B
            string ftb1c = formatTextBox1C.Text;
            Properties.Settings.Default.ftb1c = ftb1c;
            string gtb1c = grammarTextBox1C.Text;
            Properties.Settings.Default.gtb1c = gtb1c;
            var clb1c = this.contentListBox1C.Items.Cast<string>().ToArray();
            Properties.Settings.Default.clb1c = string.Join(",", clb1c);


            /*  TASK 1 PART D   */
            //save progress of all checkListBoxes task 1 part B
            var fcl1d = this.formatCheckList1D.CheckedItems.Cast<string>().ToArray();
            Properties.Settings.Default.fcl1d = string.Join(",", fcl1d);
            var gcl1d = this.grammarCheckList1D.CheckedItems.Cast<string>().ToArray();
            Properties.Settings.Default.gcl1d = string.Join(",", gcl1d);
            var ccl1d = this.contentCheckList1D.CheckedItems.Cast<string>().ToArray();
            Properties.Settings.Default.ccl1d = string.Join(",", ccl1d);
            //save progress of all feedback task 1 part B
            string ftb1d = formatTextBox1D.Text;
            Properties.Settings.Default.ftb1d = ftb1d;
            string gtb1d = grammarTextBox1D.Text;
            Properties.Settings.Default.gtb1d = gtb1d;
            var clb1d = this.contentListBox1D.Items.Cast<string>().ToArray();
            Properties.Settings.Default.clb1d = string.Join(",", clb1d);


            /*  TASK 1 PART E   */
            //save progress of all checkListBoxes task 1 part B
            var fcl1e = this.formatCheckList1E.CheckedItems.Cast<string>().ToArray();
            Properties.Settings.Default.fcl1e = string.Join(",", fcl1e);
            var gcl1e = this.grammarCheckList1E.CheckedItems.Cast<string>().ToArray();
            Properties.Settings.Default.gcl1e = string.Join(",", gcl1e);
            var ccl1e = this.contentCheckList1E.CheckedItems.Cast<string>().ToArray();
            Properties.Settings.Default.ccl1e = string.Join(",", ccl1e);
            //save progress of all feedback task 1 part B
            string ftb1e = formatTextBox1E.Text;
            Properties.Settings.Default.ftb1e = ftb1e;
            string gtb1e = grammarTextBox1E.Text;
            Properties.Settings.Default.gtb1e = gtb1e;
            var clb1e = this.contentListBox1E.Items.Cast<string>().ToArray();
            Properties.Settings.Default.clb1e = string.Join(",", clb1e);

            Properties.Settings.Default.Save();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //save notes as they type
            Properties.Settings.Default.t1notes = richTextBox1.Text;
            Properties.Settings.Default.Save();
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

        private void TaskOneUserControl_Leave(object sender, EventArgs e)
        {

        }
    }
}