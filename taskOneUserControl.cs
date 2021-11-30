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
        DocumentHandler dh = new DocumentHandler();
        FormatChecker fc = new FormatChecker();
        public static bool complete = false;

        Label l1;
        Label l2;
        Label l3;
        Label l4;
        Label l5;
        Label l6;
        Label l7;

        //string currentTab; //not needed right now but might be used in the future

        public TaskOneUserControl()
        {
            InitializeComponent();
            //currentTab = this.tabControl1.SelectedTab.Text; //not needed right now but might be used in the future

            //Displays the currently uploaded documents for each task part
            uploadInfo1.Text = "Uploaded: " + dh.displayDocuments(1, "A");
            uploadInfo1B.Text = "Uploaded: " + dh.displayDocuments(1, "B");
            uploadInfo1C.Text = "Uploaded: " + dh.displayDocuments(1, "C");
            uploadInfo1D.Text = "Uploaded: " + dh.displayDocuments(1, "D");
            uploadInfo1E.Text = "Uploaded: " + dh.displayDocuments(1, "E");
        }

        private async void uploadButton_Click(object sender, EventArgs e)
        {
            try
            {
                l1 = label74; l2 = label77; l3 = label76; l4 = label75; l5 = label63; l6 = label72; l7 = label73;
                await checkDocument(1, "A", t1paCL, uploadInfo1, grammarBox, missingWordList1A);
            } 
            catch (Exception ex)
            {
                Console.WriteLine("Open File Dialog closed by user. Stack trace: " + ex);
            }
        }

        private async void uploadButton1B_Click(object sender, EventArgs e)
        {
            try
            {
                l1 = label29; l2 = label3; l3 = label25; l4 = label26; l5 = label31; l6 = label30; l7 = label27;
                await checkDocument(1, "B", formatCheckList1B, uploadInfo1B, grammarErrors1B, missingWordList1B);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Open File Dialog closed by user. Stack trace: " + ex);
            }
        }


        private async void uploadButton1C_Click(object sender, EventArgs e)
        {
            try
            {
                await checkDocument(1, "C", formatCheckList1C, uploadInfo1C, grammarErrors1C, missingWordList1C);
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
                await checkDocument(1, "D", formatCheckList1D, uploadInfo1D, grammarErrors1D, missingWordList1D);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Open File Dialog closed by user. Stack trace: " + ex);
            }
        }

        private async void uploadButton1E_Click(object sender, EventArgs e)
        {
            try
            {
                await checkDocument(1, "E", formatCheckList1E, uploadInfo1E, grammarErrors1E, missingWordList1E);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Open File Dialog closed by user. Stack trace: " + ex);
            }
        }


        /// <summary>
        /// This method programatically executed the uploading and checking of a document. Because each task part 
        /// has unique names for certain labels, this is necessary to avoid repeated code.
        /// </summary>
        /// <param name="taskNum">The task number, which in this class will always be "1"</param>
        /// <param name="taskPart">The task part (i.e. "A", "B", etc.)</param>
        /// <param name="formatCL">The formt checkedListBox being used by the current task</param>
        /// <param name="uploadInfoLabel">The label containing the names of the uploaded documents</param>
        public async Task checkDocument(int taskNum, string taskPart, CheckedListBox formatCL, Label uploadInfoLabel, TextBox grammarErrorsTextBox, ListBox missingWordsListBox) //, Label reportLabel)
        {
            formatCL.ClearSelected(); //clears all format checker boxes            
            String path = dh.uploadDocument(taskNum, taskPart);

            //uploadInfo.Text = "well im here?";
            if (path.EndsWith(".docx") || path.EndsWith(".doc"))
            {
                uploadInfoLabel.Text = "Uploaded: " + dh.displayDocuments(taskNum, taskPart); //updates text displaying the previously uploaded files
                //FormatChecker fc = new FormatChecker(); //moved to line 17 to avoid an RPC server error (happens when it attempts to open Word while it's already running)
                Boolean[] itemsChecked = fc.runFormatCheck(path, 4);

                for(int i=0; i<itemsChecked.Length; i++)
                {
                    if (itemsChecked[i].Equals(true))
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



            await GrammarAPI.returnReport(path);


            string report = GrammarAPI.idk;

            //this stuff below will be changed to task-specific variables

            //Console.WriteLine(report);
            grammarBox.Text = report;

            missingWordList1A.DataSource = GrammarAPI.dogs;



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
