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

        private Label l1;
        private Label l2;
        private Label l3;
        private Label l4;
        private Label l5;
        private Label l6;
        private Label l7;

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
        }

        private async void UploadButton1A_Click(object sender, EventArgs e)
        {
            try
            {
                l1 = leftMarginLabel1A; l2 = rightMarginLabel1A; l3 = topMarginLabel1A; l4 = bottomMarginLabel1A; l5 = fontTypeLabel1A; l6 = fontSizeLabel1A; l7 = docLengthLabel1A;
                await CheckDocument(1, "A", uploadInfo1A, formatCheckList1A, grammarCheckList1A, grammarErrors1A, contentCheckList1A, missingWordList1A, 4);
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
                l1 = leftMarginLabel1B; l2 = rightMarginLabel1B; l3 = topMarginLabel1B; l4 = bottomMarginLabel1B; l5 = fontTypeLabel1B; l6 = fontSizeLabel1B; l7 = docLengthLabel1B;
                await CheckDocument(1, "B", uploadInfo1B, formatCheckList1B, grammarCheckList1B, grammarErrors1B, contentCheckList1B, missingWordList1B, 0);
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
                l1 = leftMarginLabel1C; l2 = rightMarginLabel1C; l3 = topMarginLabel1C; l4 = bottomMarginLabel1C; l5 = fontTypeLabel1C; l6 = fontSizeLabel1C; l7 = docLengthLabel1C;
                await CheckDocument(1, "C", uploadInfo1C, formatCheckList1C, grammarCheckList1C, grammarErrors1C, contentCheckList1C, missingWordList1C, 0);
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
                l1 = leftMarginLabel1D; l2 = rightMarginLabel1D; l3 = topMarginLabel1D; l4 = bottomMarginLabel1D; l5 = fontTypeLabel1D; l6 = fontSizeLabel1D; l7 = docLengthLabel1D;
                await CheckDocument(1, "D", uploadInfo1D, formatCheckList1D, grammarCheckList1D, grammarErrors1D, contentCheckList1D, missingWordList1D, 0);
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
                l1 = leftMarginLabel1E; l2 = rightMarginLabel1E; l3 = topMarginLabel1E; l4 = bottomMarginLabel1E; l5 = fontTypeLabel1E; l6 = fontSizeLabel1E; l7 = docLengthLabel1E;
                await CheckDocument(1, "E", uploadInfo1E, formatCheckList1E, grammarCheckList1E, grammarErrors1E, contentCheckList1E, missingWordList1E, 9);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Open File Dialog closed by user. Stack trace: " + ex);
            }
        }

        /* This method programatically executed the uploading and checking of a document. 
         * Because each task part has unique controls, this is necessary to avoid repeated code.
        */
        public async Task CheckDocument(int taskNum, string taskPart, Label uploadInfoLabel, CheckedListBox formatCL, CheckedListBox grammarCL, TextBox grammarErrorsTextBox, CheckedListBox contentCL, ListBox missingWordsListBox, int pageCount)
        {
            //formatCL.ClearSelected(); //clears all format checker boxes
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
                formatProgressBar.Value = report.PercentComplete;
                formatProgressBar.Update();
            };
            var gprogress = new Progress<ProgressInformation>();
            gprogress.ProgressChanged += (o, report) =>
            {
                grammarProgressBar.Value = report.PercentComplete;
                grammarProgressBar.Update();
            };
            var cprogress = new Progress<ProgressInformation>();
            cprogress.ProgressChanged += (o, report) =>
            {
                contentProgressBar.Value = report.PercentComplete;
                contentProgressBar.Update();
            };

            String path = dh.uploadDocument(taskNum, taskPart);

            //uploadInfo.Text = "well im here?";
            if(path.EndsWith(".docx") || path.EndsWith(".doc"))
            {
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

                l1.Text = fc.leftMarginFB;
                l2.Text = fc.rightMarginFB;
                l3.Text = fc.topMarginFB;
                l4.Text = fc.bottomMarginFB;

                l5.Text = fc.fontTypeFB;
                l6.Text = fc.fontSizeFB;
                l7.Text = fc.pageNumFB;
                label18.Text = "FINISHED";
            }

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
            label19.Text = "FINISHED";

            await processData(clist, cprogress);//PROGRESS BAR
            missingWordsListBox.DataSource = GrammarAPI.glossaryWordList;
            if(missingWordsListBox.Items.Count == 0)
            {
                contentCL.SetItemChecked(0, true);
            }
            label21.Text = "FINISHED";




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