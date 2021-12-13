using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

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

        int textSizeOffset = 0;
        SettingsHandler settingsHandler = new SettingsHandler();

        public TaskThreeUserControl()
        {
            InitializeComponent();

            mediaUploadInfo3A.Text = "Uploaded: " + dh.displayMultipleDocuments(3, "A", "media");

            uploadInfo3A.Text = "Uploaded: " + dh.displayMultipleDocuments(3, "A", "document");
            uploadInfo3B.Text = "Uploaded: " + dh.displayMultipleDocuments(3, "B", "document");
            uploadInfo3C.Text = "Uploaded: " + dh.displayMultipleDocuments(3, "C", "document");
            uploadInfo3D.Text = "Uploaded: " + dh.displayDocuments(3, "D");
            uploadInfo3E.Text = "Uploaded: " + dh.displayDocuments(3, "E");
        }

        private void TaskThreeUserControl_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = Properties.Settings.Default.t3notes; //load last saved notes

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
            Panel[] panels = new Panel[] { panel1, panel4, panel17, panel6, panel38, panel51, panel35, panel19, panel23, panel9 };
            foreach (Control c in panels)
            {
                c.BackColor = Properties.Settings.Default.bgcolor;
                c.ForeColor = Properties.Settings.Default.fcolor;
            }
            */
        }

        private async void MediaUploadButton3A_Click(object sender, EventArgs e)
        {
            try
            {
                await CheckVideo(3, "A", "media", mediaUploadInfo3A, 
                    mediaCheckList3A, mediaTextBox3A,
                    mediaProgressBar3A, mediaProgressStatus3A,
                    0);
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
                await CheckMipltipleDocuments(3, "A", "document", uploadInfo3A,
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

        private async void UploadButton3B_Click(object sender, EventArgs e)
        {
            try
            {
                await CheckMipltipleDocuments(3, "B", "document", uploadInfo3B,
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

        private async void UploadButton3C_Click(object sender, EventArgs e)
        {
            try
            {
                await CheckMipltipleDocuments(3, "C", "document", uploadInfo3C,
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

        public async Task CheckMipltipleDocuments(int taskNum, string taskPart, string documentType, Label uploadInfoLabel,
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


    }
}
