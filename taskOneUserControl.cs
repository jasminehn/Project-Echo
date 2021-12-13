using System;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Media;

namespace ProjectEcho
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

            //load saved checkboxes
            if (!string.IsNullOrEmpty(Properties.Settings.Default.checkerprogress))
            {
                Properties.Settings.Default.checkerprogress.Split(',')
                    .ToList()
                    .ForEach(item =>
                    {
                        var index = this.formatCheckList1A.Items.IndexOf(item);
                        this.formatCheckList1A.SetItemChecked(index, true);
                    });
            }
            
        }

        private void TaskOneUserControl_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = Properties.Settings.Default.t1notes; //load last saved notes

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
                    grammarCheckList1A, grammarErrors1A, 
                    contentCheckList1A, missingWordList1A,
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
                    grammarCheckList1B, grammarErrors1B, 
                    contentCheckList1B, missingWordList1B,
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
                    grammarCheckList1C, grammarErrors1C, 
                    contentCheckList1C, missingWordList1C,
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
                    grammarCheckList1D, grammarErrors1D, 
                    contentCheckList1D, missingWordList1D,
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
                    grammarCheckList1E, grammarErrors1E, 
                    contentCheckList1E, missingWordList1E,
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

            if(path.EndsWith(".docx") || path.EndsWith(".doc"))
            {
                //Execute format analysis
                await processData(flist, fprogress); //PROGRESS BAR
                
                uploadInfoLabel.Text = "Uploaded: " + dh.displayDocuments(taskNum, taskPart); //updates text displaying the previously uploaded files
                Boolean[] itemsChecked = fc.runFormatCheck(path, pageCount);

                for(int i = 0; i < formatCL.Items.Count; i++)
                {
                    if(itemsChecked[i].Equals(true))
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

            if(GrammarAPI.spellingErrorCount == 0)
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
            if(missingWordsListBox.Items.Count == 0)
            {
                contentCL.SetItemChecked(0, true);
            }
            contentPS.Text = "FINISHED";





            //save progress of checkbox
            var indices = this.formatCheckList1A.CheckedItems.Cast<string>().ToArray();

            Properties.Settings.Default.checkerprogress = string.Join(",", indices);
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