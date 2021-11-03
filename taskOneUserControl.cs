using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectEcho
{
    public partial class TaskOneUserControl : UserControl
    {
        DocumentHandler dh = new DocumentHandler();
        string currentTab;

        public TaskOneUserControl()
        {
            InitializeComponent();
            currentTab = this.tabControl1.SelectedTab.Text;
            uploadInfo1.Text = "Uploaded: " + dh.displayDocuments(1, currentTab);
        }

        private void taskOnePanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            //Format Checker Boxes
            t1paCL.SetItemChecked(0, false); //Aligned
            t1paCL.SetItemChecked(1, false); //Font
            t1paCL.SetItemChecked(2, false); //Font Size
            t1paCL.SetItemChecked(3, false); //Length

            //DocumentHandler dh = new DocumentHandler();
            //string currentTab = this.tabControl1.SelectedTab.Text;

            String path = dh.uploadDocument(1, currentTab);

            //uploadInfo.Text = "well im here?";
            if (path.EndsWith(".docx") || path.EndsWith(".doc"))
            {
                //uploadInfo.Text = uploadInfo.Text + path;
                uploadInfo1.Text = "Uploaded: " + dh.displayDocuments(1, currentTab); //updates text displaying the previously uploaded files
                FormatChecker fc = new FormatChecker();
                Boolean[] b = fc.runFormatCheck(path, 4);
                label9.Text = "correct alignment  " + b[0] + "   " + "correct font  " + b[1] + "   " + "correct size  " + b[2] + "   " + "correct length" + b[3];
                if(b[0].Equals(true))
                {
                    t1paCL.SetItemChecked(0, true); //Aligned
                }

                if(b[1].Equals(true))
                {
                    t1paCL.SetItemChecked(1, true); //Font
                }

                if(b[2].Equals(true))
                {
                    t1paCL.SetItemChecked(2, true); //Font Size
                }

                if(b[3].Equals(true))
                {
                    t1paCL.SetItemChecked(3, true); //Length
                }

                //Grammar Check 
            }
            String report = GrammarAPI.ReturnReport(path);
            label23.Text = report;
        }
    }
}
