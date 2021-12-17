using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.Drawing;
using System.Linq;

namespace ProjectEcho
{
    /**
     *
     *
     *
     * Author(s): J. Nelson, I. Gnagy
     */

    public partial class TaskThreeUserControl : UserControl
    {
        private DocumentHandler dh = new DocumentHandler();
        private FormatChecker fc = new FormatChecker();
        SettingsHandler settingsHandler = new SettingsHandler();

        int textSizeOffset = 0;

        public Boolean[] taskProgress = { false, false, false, false, false };

        public TaskThreeUserControl()
        {
            InitializeComponent();

            loadProgress();

            mediaUploadInfo3A.Text = "Uploaded: " + dh.displayMultipleDocuments(3, "A", "media");
            mediaUploadInfo3B.Text = "Uploaded: " + dh.displayMultipleDocuments(3, "B", "media");
            mediaUploadInfo3C.Text = "Uploaded: " + dh.displayMultipleDocuments(3, "C", "media");

            uploadInfo3A.Text = "Uploaded: " + dh.displayMultipleDocuments(3, "A", "document");
            uploadInfo3B.Text = "Uploaded: " + dh.displayMultipleDocuments(3, "B", "document");
            uploadInfo3C.Text = "Uploaded: " + dh.displayMultipleDocuments(3, "C", "document");
            uploadInfo3D.Text = "Uploaded: " + dh.displayDocuments(3, "D");
            uploadInfo3E.Text = "Uploaded: " + dh.displayDocuments(3, "E");
        }

        private void TaskThreeUserControl_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = Properties.Settings.Default.t3notes; //load last saved notes
            
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
            var checkedlistboxes = settingsHandler.getAll(this, typeof(CheckedListBox));
            foreach (Control c in checkedlistboxes)
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

        private async void MediaUploadButton3A_Click(object sender, EventArgs e)
        {
            try
            {
                await CheckVideo(3, "A", "media", mediaUploadInfo3A, 
                    mediaCheckList3A, mediaTextBox3A,
                    mediaProgressBar3A, mediaProgressStatus3A,
                    7, 0);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Open File Dialog closed by user. Stack Trace " + ex);
            }
        }

        private async void UploadButton3A_Click(object sender, EventArgs e)
        {
            try
            {
                await CheckMultipleDocuments(3, "A", "document", uploadInfo3A,
                    formatCheckList3A, formatTextBox3A,
                    grammarCheckList3A, grammarTextBox3A,
                    formatProgressBar3A, formatProgressStatus3A,
                    grammarProgressBar3A, grammarProgressStatus3A,
                    2);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Open File Dialog closed by user. Stack trace: " + ex);
            }
        }

        private async void MediaUploadButton3B_Click(object sender, EventArgs e)
        {
            try
            {
                await CheckVideo(3, "B", "media", mediaUploadInfo3B,
                    mediaCheckList3B, mediaTextBox3B,
                    mediaProgressBar3B, mediaProgressStatus3B,
                    5, 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Open File Dialog closed by user. Stack Trace " + ex);
            }
        }

        private async void UploadButton3B_Click(object sender, EventArgs e)
        {
            try
            {
                await CheckMultipleDocuments(3, "B", "document", uploadInfo3B,
                    formatCheckList3B, formatTextBox3B,
                    grammarCheckList3B, grammarTextBox3B,
                    formatProgressBar3B, formatProgressStatus3B,
                    grammarProgressBar3B, grammarProgressStatus3B,
                    2);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Open File Dialog closed by user. Stack trace: " + ex);
            }
        }

        private async void MediaUploadButton3C_Click(object sender, EventArgs e)
        {
            try
            {
                await CheckVideo(3, "C", "media", mediaUploadInfo3C,
                    mediaCheckList3C, mediaTextBox3C,
                    mediaProgressBar3C, mediaProgressStatus3C,
                    10, 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Open File Dialog closed by user. Stack Trace " + ex);
            }
        }

        private async void UploadButton3C_Click(object sender, EventArgs e)
        {
            try
            {
                await CheckMultipleDocuments(3, "C", "document", uploadInfo3C,
                    formatCheckList3C, formatTextBox3C,
                    grammarCheckList3C, grammarTextBox3C,
                    formatProgressBar3C, formatProgressStatus3C,
                    grammarProgressBar3C, grammarProgressStatus3C,
                    2);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Open File Dialog closed by user. Stack trace: " + ex);
            }
        }

        private async void UploadButton3D_Click(object sender, EventArgs e)
        {
            try
            {
                await CheckDocument(3, "D", uploadInfo3D,
                    formatCheckList3D, formatTextBox3D,
                    grammarCheckList3D, grammarTextBox3D,
                    contentCheckList3D, contentListBox3D,
                    formatProgressBar3D, formatProgressStatus3D,
                    grammarProgressBar3D, grammarProgressStatus3D,
                    contentProgressBar3D, contentProgressStatus3D,
                    0);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Open File Dialog closed by user. Stack trace: " + ex);
            }
        }

        private async void UploadButton3E_Click(object sender, EventArgs e)
        {
            try
            {
                await CheckDocument(3, "E", uploadInfo3E,
                    formatCheckList3E, formatTextBox3E,
                    grammarCheckList3E, grammarTextBox3E,
                    contentCheckList3E, contentListBox3E,
                    formatProgressBar3E, formatProgressStatus3E,
                    grammarProgressBar3E, grammarProgressStatus3E,
                    contentProgressBar3E, contentProgressStatus3E,
                    0);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Open File Dialog closed by user. Stack trace: " + ex);
            }
        }

        public async Task CheckVideo(int taskNum, string taskPart, string documentType, Label uploadInfoLabel,
            CheckedListBox mediaCL, TextBox mediaTB,
            ProgressBar mediaPB, Label mediaPS,
            int maxLength, int minLength)
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

            mediaTB.Text = "\r\n\r\n" + fc.mediaSizeFB
               + "\r\n\r\n\r\n\r\n" + fc.mediaLengthFB;

            mediaPS.Text = "FINISHED";
        }

        public async Task CheckMultipleDocuments(int taskNum, string taskPart, string documentType, Label uploadInfoLabel,
            CheckedListBox formatCL, TextBox formatTextBox,
            CheckedListBox grammarCL, TextBox grammarErrorsTextBox,
            ProgressBar formatPB, Label formatPS,
            ProgressBar grammarPB, Label grammarPS,
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

            //progress bar stuff
            List<string> flist = new List<string>();
            List<string> glist = new List<string>();
            for (int i = 0; i < 100; i++)
            {
                flist.Add(i.ToString());
                glist.Add(i.ToString());
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

            String path = dh.uploadMultipleDocuments(taskNum, taskPart, documentType);

            if (path.EndsWith(".docx") || path.EndsWith(".doc"))
            {
                //Execute format analysis
                await processData(flist, fprogress); //PROGRESS BAR

                uploadInfoLabel.Text = "Uploaded: " + dh.displayMultipleDocuments(taskNum, taskPart, documentType); //updates text displaying the previously uploaded files
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

            saveProgress();

            updateTaskProgress();
        }

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

            updateTaskProgress();
        }

        public void updateTaskProgress()
        {
            CheckedListBox[] progressPartA = { mediaCheckList3A, formatCheckList3A, grammarCheckList3A };
            Boolean partAComplete = evaluateProgress(progressPartA);

            CheckedListBox[] progressPartB = { mediaCheckList3B, formatCheckList3B, grammarCheckList3B };
            Boolean partBComplete = evaluateProgress(progressPartB);

            CheckedListBox[] progressPartC = { mediaCheckList3C, formatCheckList3C, grammarCheckList3C };
            Boolean partCComplete = evaluateProgress(progressPartC);

            CheckedListBox[] progressPartD = { formatCheckList3D, grammarCheckList3D, contentCheckList3D };
            Boolean partDComplete = evaluateProgress(progressPartD);

            CheckedListBox[] progressPartE = { formatCheckList3E, grammarCheckList3E, contentCheckList3E };
            Boolean partEComplete = evaluateProgress(progressPartE);

            taskProgress.SetValue(partAComplete, 0);
            taskProgress.SetValue(partBComplete, 1);
            taskProgress.SetValue(partCComplete, 2);
            taskProgress.SetValue(partDComplete, 3);
            taskProgress.SetValue(partEComplete, 4);
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

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //save notes as they type
            Properties.Settings.Default.t3notes = richTextBox1.Text;
            Properties.Settings.Default.Save();
        }

        private void loadProgress()
        {
            /*  PART A  */
            //load saved checkboxes
            if (!string.IsNullOrEmpty(Properties.Settings.Default.mcl3a))
            {
                Properties.Settings.Default.mcl3a.Split(',').ToList().ForEach(item =>
                {
                    var index = mediaCheckList3A.Items.IndexOf(item);
                    mediaCheckList3A.SetItemChecked(index, true);
                });
            }
            if (!string.IsNullOrEmpty(Properties.Settings.Default.fcl3a))
            {
                Properties.Settings.Default.fcl3a.Split(',').ToList().ForEach(item =>
                {
                    var index = formatCheckList3A.Items.IndexOf(item);
                    formatCheckList3A.SetItemChecked(index, true);
                });
            }
            if (!string.IsNullOrEmpty(Properties.Settings.Default.gcl3a))
            {
                Properties.Settings.Default.gcl3a.Split(',').ToList().ForEach(item =>
                {
                    var index = grammarCheckList3A.Items.IndexOf(item);
                    grammarCheckList3A.SetItemChecked(index, true);
                });
            }
            //load saved feedback
            mediaTextBox3A.Text = Properties.Settings.Default.mtb3a;
            formatTextBox3A.Text = Properties.Settings.Default.ftb3a;
            grammarTextBox3A.Text = Properties.Settings.Default.gtb3a;


            /*  PART B  */
            //load saved checkboxes
            if (!string.IsNullOrEmpty(Properties.Settings.Default.mcl3b))
            {
                Properties.Settings.Default.mcl3b.Split(',').ToList().ForEach(item =>
                {
                    var index = mediaCheckList3B.Items.IndexOf(item);
                    mediaCheckList3B.SetItemChecked(index, true);
                });
            }
            if (!string.IsNullOrEmpty(Properties.Settings.Default.fcl3b))
            {
                Properties.Settings.Default.fcl3b.Split(',').ToList().ForEach(item =>
                {
                    var index = formatCheckList3B.Items.IndexOf(item);
                    formatCheckList3B.SetItemChecked(index, true);
                });
            }
            if (!string.IsNullOrEmpty(Properties.Settings.Default.gcl3b))
            {
                Properties.Settings.Default.gcl3b.Split(',').ToList().ForEach(item =>
                {
                    var index = grammarCheckList3B.Items.IndexOf(item);
                    grammarCheckList3B.SetItemChecked(index, true);
                });
            }
            //load saved feedback
            mediaTextBox3B.Text = Properties.Settings.Default.mtb3b;
            formatTextBox3B.Text = Properties.Settings.Default.ftb3b;
            grammarTextBox3B.Text = Properties.Settings.Default.gtb3b;


            /*  PART C  */
            //load saved checkboxes
            if (!string.IsNullOrEmpty(Properties.Settings.Default.mcl3c))
            {
                Properties.Settings.Default.mcl3c.Split(',').ToList().ForEach(item =>
                {
                    var index = mediaCheckList3C.Items.IndexOf(item);
                    mediaCheckList3C.SetItemChecked(index, true);
                });
            }
            if (!string.IsNullOrEmpty(Properties.Settings.Default.fcl3c))
            {
                Properties.Settings.Default.fcl3c.Split(',').ToList().ForEach(item =>
                {
                    var index = formatCheckList3C.Items.IndexOf(item);
                    formatCheckList3C.SetItemChecked(index, true);
                });
            }
            if (!string.IsNullOrEmpty(Properties.Settings.Default.gcl3c))
            {
                Properties.Settings.Default.gcl3c.Split(',').ToList().ForEach(item =>
                {
                    var index = grammarCheckList3C.Items.IndexOf(item);
                    grammarCheckList3C.SetItemChecked(index, true);
                });
            }
            //load saved feedback
            mediaTextBox3C.Text = Properties.Settings.Default.mtb3c;
            formatTextBox3C.Text = Properties.Settings.Default.ftb3c;
            grammarTextBox3C.Text = Properties.Settings.Default.gtb3c;


            /*  PART D  */
            //load saved checkboxes
            if (!string.IsNullOrEmpty(Properties.Settings.Default.fcl3d))
            {
                Properties.Settings.Default.fcl3d.Split(',').ToList().ForEach(item =>
                {
                    var index = formatCheckList3D.Items.IndexOf(item);
                    formatCheckList3D.SetItemChecked(index, true);
                });
            }
            if (!string.IsNullOrEmpty(Properties.Settings.Default.gcl3d))
            {
                Properties.Settings.Default.gcl3d.Split(',').ToList().ForEach(item =>
                {
                    var index = grammarCheckList3D.Items.IndexOf(item);
                    grammarCheckList3D.SetItemChecked(index, true);
                });
            }
            if (!string.IsNullOrEmpty(Properties.Settings.Default.ccl3d))
            {
                Properties.Settings.Default.ccl3d.Split(',').ToList().ForEach(item =>
                {
                    var index = contentCheckList3D.Items.IndexOf(item);
                    contentCheckList3D.SetItemChecked(index, true);
                });
            }
            //load saved feedback
            formatTextBox3D.Text = Properties.Settings.Default.ftb3d;
            grammarTextBox3D.Text = Properties.Settings.Default.gtb3d;
            if (!string.IsNullOrEmpty(Properties.Settings.Default.clb3d))
            {
                Properties.Settings.Default.clb3d.Split(',').ToList().ForEach(item => { contentCheckList3D.Items.Add(item); });
            }


            /*  PART E  */
            //load saved checkboxes
            if (!string.IsNullOrEmpty(Properties.Settings.Default.fcl3e))
            {
                Properties.Settings.Default.fcl3e.Split(',').ToList().ForEach(item =>
                {
                    var index = formatCheckList3E.Items.IndexOf(item);
                    formatCheckList3E.SetItemChecked(index, true);
                });
            }
            if (!string.IsNullOrEmpty(Properties.Settings.Default.gcl3e))
            {
                Properties.Settings.Default.gcl3e.Split(',').ToList().ForEach(item =>
                {
                    var index = grammarCheckList3E.Items.IndexOf(item);
                    grammarCheckList3E.SetItemChecked(index, true);
                });
            }
            if (!string.IsNullOrEmpty(Properties.Settings.Default.ccl3e))
            {
                Properties.Settings.Default.ccl3e.Split(',').ToList().ForEach(item =>
                {
                    var index = contentCheckList3E.Items.IndexOf(item);
                    contentCheckList3E.SetItemChecked(index, true);
                });
            }
            //load saved feedback
            formatTextBox3E.Text = Properties.Settings.Default.ftb3e;
            grammarTextBox3E.Text = Properties.Settings.Default.gtb3e;
            if (!string.IsNullOrEmpty(Properties.Settings.Default.clb3e))
            {
                Properties.Settings.Default.clb3e.Split(',').ToList().ForEach(item => { contentListBox3E.Items.Add(item); });
            }
        }

        private void saveProgress()
        {
            /*  TASK 3 PART A   */
            //save progress of all checkListBoxes task 3 part A
            var mcl3a = this.mediaCheckList3A.CheckedItems.Cast<string>().ToArray();
            Properties.Settings.Default.mcl3a = string.Join(",", mcl3a);
            var fcl3a = this.formatCheckList3A.CheckedItems.Cast<string>().ToArray();
            Properties.Settings.Default.fcl3a = string.Join(",", fcl3a);
            var gcl3a = this.grammarCheckList3A.CheckedItems.Cast<string>().ToArray();
            Properties.Settings.Default.gcl3a = string.Join(",", gcl3a);
            //save progress of all feedback task 3 part A
            string mtb3a = mediaTextBox3A.Text;
            Properties.Settings.Default.mtb3a = mtb3a;
            string ftb3a = formatTextBox3A.Text;
            Properties.Settings.Default.ftb3a = ftb3a;
            string gtb3a = grammarTextBox3A.Text;
            Properties.Settings.Default.gtb3a = gtb3a;


            /*  TASK 3 PART B   */
            //save progress of all checkListBoxes task 3 part B
            var mcl3b = this.mediaCheckList3B.CheckedItems.Cast<string>().ToArray();
            Properties.Settings.Default.mcl3b = string.Join(",", mcl3b);
            var fcl3b = this.formatCheckList3B.CheckedItems.Cast<string>().ToArray();
            Properties.Settings.Default.fcl3b = string.Join(",", fcl3b);
            var gcl3b = this.grammarCheckList3B.CheckedItems.Cast<string>().ToArray();
            Properties.Settings.Default.gcl3b = string.Join(",", gcl3b);
            //save progress of all feedback task 3 part B
            string mtb3b = mediaTextBox3B.Text;
            Properties.Settings.Default.mtb3b = mtb3b;
            string ftb3b = formatTextBox3B.Text;
            Properties.Settings.Default.ftb3b = ftb3b;
            string gtb3b = grammarTextBox3B.Text;
            Properties.Settings.Default.gtb3b = gtb3b;


            /*  TASK 3 PART C   */
            //save progress of all checkListBoxes task 3 part B
            var mcl3c = this.mediaCheckList3C.CheckedItems.Cast<string>().ToArray();
            Properties.Settings.Default.mcl3c = string.Join(",", mcl3c);
            var fcl3c = this.formatCheckList3C.CheckedItems.Cast<string>().ToArray();
            Properties.Settings.Default.fcl3c = string.Join(",", fcl3c);
            var gcl3c = this.grammarCheckList3C.CheckedItems.Cast<string>().ToArray();
            Properties.Settings.Default.gcl3c = string.Join(",", gcl3c);
            //save progress of all feedback task 3 part B
            string mtb3c = mediaTextBox3C.Text;
            Properties.Settings.Default.mtb3c = mtb3c;
            string ftb3c = formatTextBox3C.Text;
            Properties.Settings.Default.ftb3c = ftb3c;
            string gtb3c = grammarTextBox3C.Text;
            Properties.Settings.Default.gtb3c = gtb3c;


            /*  TASK 3 PART D   */
            //save progress of all checkListBoxes task 3 part B
            var fcl3d = this.formatCheckList3D.CheckedItems.Cast<string>().ToArray();
            Properties.Settings.Default.fcl3d = string.Join(",", fcl3d);
            var gcl3d = this.grammarCheckList3D.CheckedItems.Cast<string>().ToArray();
            Properties.Settings.Default.gcl3d = string.Join(",", gcl3d);
            var ccl3d = this.contentCheckList3D.CheckedItems.Cast<string>().ToArray();
            Properties.Settings.Default.ccl3d = string.Join(",", ccl3d);
            //save progress of all feedback task 3 part B
            string ftb3d = formatTextBox3D.Text;
            Properties.Settings.Default.ftb3d = ftb3d;
            string gtb3d = grammarTextBox3D.Text;
            Properties.Settings.Default.gtb3d = gtb3d;
            var clb3d = this.contentListBox3D.Items.Cast<string>().ToArray();
            Properties.Settings.Default.clb3d = string.Join(",", clb3d);


            /*  TASK 3 PART E   */
            //save progress of all checkListBoxes task 3 part B
            var fcl3e = this.formatCheckList3E.CheckedItems.Cast<string>().ToArray();
            Properties.Settings.Default.fcl3e = string.Join(",", fcl3e);
            var gcl3e = this.grammarCheckList3E.CheckedItems.Cast<string>().ToArray();
            Properties.Settings.Default.gcl3e = string.Join(",", gcl3e);
            var ccl3e = this.contentCheckList3E.CheckedItems.Cast<string>().ToArray();
            Properties.Settings.Default.ccl3e = string.Join(",", ccl3e);
            //save progress of all feedback task 3 part B
            string ftb3e = formatTextBox3E.Text;
            Properties.Settings.Default.ftb3e = ftb3e;
            string gtb3e = grammarTextBox3E.Text;
            Properties.Settings.Default.gtb3e = gtb3e;
            var clb3e = this.contentListBox3E.Items.Cast<string>().ToArray();
            Properties.Settings.Default.clb3e = string.Join(",", clb3e);

            Properties.Settings.Default.Save();
        }

    }
}
