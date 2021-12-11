using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectEcho
{
    /**
     *
     *
     *
     * Author(s): C. Segrue, J. Nelson
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

        //string currentTab; //not needed right now but might be used in the future

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

        /// <summary>
        /// This method programatically executed the uploading and checking of a
        /// document. Because each task part has unique names for certain
        /// labels, this is necessary to avoid repeated code.
        /// </summary>
        /// <param name="taskNum">
        /// The task number, which in this class will always be "1"
        /// </param>
        /// <param name="taskPart">The task part (i.e. "A", "B", etc.)</param>
        /// <param name="formatCL">
        /// The formt checkedListBox being used by the current task
        /// </param>
        /// <param name="uploadInfoLabel">
        /// The label containing the names of the uploaded documents
        /// </param>
        public async Task CheckDocument(int taskNum, string taskPart, Label uploadInfoLabel, CheckedListBox formatCL, CheckedListBox grammarCL, TextBox grammarErrorsTextBox, CheckedListBox contentCL, ListBox missingWordsListBox, int pageCount)
        {
            formatCL.ClearSelected(); //clears all format checker boxes
            grammarCL.ClearSelected(); //clears all grammar checker boxes

            String path = dh.uploadDocument(taskNum, taskPart);

            //uploadInfo.Text = "well im here?";
            if(path.EndsWith(".docx") || path.EndsWith(".doc"))
            {
                uploadInfoLabel.Text = "Uploaded: " + dh.displayDocuments(taskNum, taskPart); //updates text displaying the previously uploaded files
                //FormatChecker fc = new FormatChecker(); //moved to line 17 to avoid an RPC server error (happens when it attempts to open Word while it's already running)
                Boolean[] itemsChecked = fc.runFormatCheck(path, pageCount);

                for(int i = 0; i < formatCL.Items.Count; i++)
                {
                    if(itemsChecked[i].Equals(true))
                    {
                        formatCL.SetItemChecked(i, true);
                    }
                }

                //this stuff below will be changed to task-specific variables
                l1.Text = fc.leftMarginFB;
                l2.Text = fc.rightMarginFB;
                l3.Text = fc.topMarginFB;
                l4.Text = fc.bottomMarginFB;

                l5.Text = fc.fontTypeFB;
                l6.Text = fc.fontSizeFB;
                l7.Text = fc.pageNumFB;
            }

            await GrammarAPI.returnReport(path); //execute API call

            string report = GrammarAPI.reportOutput;

            grammarErrorsTextBox.Text = report;

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

            missingWordsListBox.DataSource = GrammarAPI.glossaryWordList;
            if(missingWordsListBox.Items.Count == 0)
            {
                contentCL.SetItemChecked(0, true);
            }
        }

        private void TaskOneUserControl_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = Properties.Settings.Default.t1notes; //load last saved notes 
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //save notes as they type
            Properties.Settings.Default.t1notes = richTextBox1.Text;
            Properties.Settings.Default.Save();
        }

        
    }
}