using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
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

            uploadInfo3A1.Text = "Uploaded: " + dh.displayMultipleDocuments(3, "A", "media");
            uploadInfo3A.Text = "Uploaded: " + dh.displayMultipleDocuments(3, "A", "document");
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

        private void MediaUploadButton3A_Click(object sender, EventArgs e)
        {
            CheckVideo(3, "A", "media", uploadInfo3A1, checkedListBox1);
        }

        private async void UploadButton3A_Click(object sender, EventArgs e)
        {
            try
            {
                await CheckDocument(3, "A", "document", uploadInfo3A,
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

        public async Task CheckVideo(int taskNum, string taskPart, string documentType, Label uploadInfoLabel, CheckedListBox formatCL)
        {
            foreach (int i in formatCL.CheckedIndices)
            {
                formatCL.SetItemCheckState(i, CheckState.Unchecked);
            }


            String path = dh.uploadMultipleDocuments(taskNum, taskPart, documentType);

            uploadInfoLabel.Text = "Uploaded: " + dh.displayMultipleDocuments(taskNum, taskPart, documentType); //updates text displaying the previously uploaded files
                
            
        }

        public async Task CheckDocument(int taskNum, string taskPart, string documentType, Label uploadInfoLabel,
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
