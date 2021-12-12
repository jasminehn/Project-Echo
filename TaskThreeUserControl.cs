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
            uploadInfo3A2.Text = "Uploaded: " + dh.displayMultipleDocuments(3, "A", "document");
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

        private void UploadButton3A1_Click(object sender, EventArgs e)
        {
            CheckVideo(3, "A", "media", uploadInfo3A1, checkedListBox1);
        }

        private void UploadButton3A2_Click(object sender, EventArgs e)
        {
            CheckDocument(3, "A", "document", uploadInfo3A2, checkedListBox5,  checkedListBox3, grammarErrors3A, 2);
        }

        public void CheckVideo(int taskNum, string taskPart, string documentType, Label uploadInfoLabel, CheckedListBox formatCL)
        {
            foreach (int i in formatCL.CheckedIndices)
            {
                formatCL.SetItemCheckState(i, CheckState.Unchecked);
            }


            String path = dh.uploadMultipleDocuments(taskNum, taskPart, documentType);

            uploadInfoLabel.Text = "Uploaded: " + dh.displayMultipleDocuments(taskNum, taskPart, documentType); //updates text displaying the previously uploaded files
                
            
        }

        public void CheckDocument(int taskNum, string taskPart, string documentType, Label uploadInfoLabel, CheckedListBox formatCL, CheckedListBox grammarCL, TextBox grammarErrorsTextBox,  int pageCount)
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
            


            String path = dh.uploadMultipleDocuments(taskNum, taskPart, documentType);

            //uploadInfo.Text = "well im here?";
            if (path.EndsWith(".docx") || path.EndsWith(".doc"))
            {


                uploadInfoLabel.Text = "Uploaded: " + dh.displayDocuments(taskNum, taskPart); //updates text displaying the previously uploaded files
                Boolean[] itemsChecked = fc.runFormatCheck(path, pageCount);

                for (int i = 0; i < formatCL.Items.Count; i++)
                {
                    if (itemsChecked[i].Equals(true))
                    {
                        formatCL.SetItemChecked(i, true);
                    }
                }


                label18.Text = "FINISHED";
            }


            //await GrammarAPI.returnReport(path); //execute API call

            //string grammarReport = GrammarAPI.reportOutput;

            //grammarErrorsTextBox.Text = grammarReport;

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
            label19.Text = "FINISHED";

            

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //save notes as they type
            Properties.Settings.Default.t3notes = richTextBox1.Text;
            Properties.Settings.Default.Save();
        }

    }
}
