using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectEcho
{
    public partial class TaskOneUserControl : UserControl
    {
        DocumentHandler dh = new DocumentHandler();
        FormatChecker fc = new FormatChecker();
        public static bool complete = false;

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
                await checkDocument(1, "A", t1paCL, uploadInfo1);
            } catch (Exception ex)
            {
                Console.WriteLine("Open File Dialog closed by user. Stack trace: " + ex);
            }
        }

        private void uploadButton1B_Click(object sender, EventArgs e)
        {
            checkDocument(1, "B", formatCheckList1B, uploadInfo1B);            
        }

        private void uploadButton1C_Click(object sender, EventArgs e)
        {
            checkDocument(1, "C", formatCheckList1C, uploadInfo1C);
        }

        private void uploadButton1D_Click(object sender, EventArgs e)
        {
            checkDocument(1, "D", formatCheckList1D, uploadInfo1D);
        }

        private void uploadButton1E_Click(object sender, EventArgs e)
        {
            checkDocument(1, "E", formatCheckList1E, uploadInfo1E);
        }

        /// <summary>
        /// This method programatically executed the uploading and checking of a document. Because each task part 
        /// has unique names for certain labels, this is necessary to avoid repeated code.
        /// </summary>
        /// <param name="taskNum">The task number, which in this class will always be "1"</param>
        /// <param name="taskPart">The task part (i.e. "A", "B", etc.)</param>
        /// <param name="formatCL">The formt checkedListBox being used by the current task</param>
        /// <param name="uploadInfoLabel">The label containing the names of the uploaded documents</param>
        public async Task checkDocument(int taskNum, string taskPart, CheckedListBox formatCL, Label uploadInfoLabel) //, Label reportLabel)
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
            }



            await GrammarAPI.plswork(path);


            string report = GrammarAPI.idk;

            //Console.WriteLine(report);
            grammarBox.Text = report;
        }

    }
}
