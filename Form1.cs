using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectEcho
{
    public partial class MainForm : Form
    {
        private Panel currentPanel = new Panel();
        public Panel[] contextPanels = new Panel[4];
        public MainForm()
        {
            InitializeComponent();
            contextPanels[0] = (mainMenuPanel);
            contextPanels[1] = (taskOnePanel);
            //contextPanels[2] = (taskTwoPanel);
            //contextPanels[3] = (taskThreePanel);

            currentPanel = contextPanels[0];
            setPanelActive(0);
            string[] taskOneArray = { "Context for learning information", "Plans for Learning segment", "Instructional Materials", "Assessments", "Planning Commentary" };
            taskOneList.Items.AddRange(taskOneArray);
            string[] taskTwoArray = { "Video Clips", "Commentary" };
            taskTwoList.Items.AddRange(taskTwoArray);
            string[] taskThreeArray = { "Video Conference", "Notes", "Feedback", "Commentary" };
            taskThreeList.Items.AddRange(taskThreeArray);
            string[] reviewArray = { "Task 1", "Task 2", "Task 3" };
            reviewList.Items.AddRange(reviewArray);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void titlePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void taskTwoList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
           
        }

        private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm sf = new SettingsForm();

            if(sf.ShowDialog() == DialogResult.OK)
            {
                Console.Write("Settings opened");
            }
        }

        private void task1Button_Click(object sender, EventArgs e)
        {
            setPanelActive(1);
        }

        private void taskTwoButton_Click(object sender, EventArgs e)
        {
            setPanelActive(2);
        }

        private void taskThreeButton_Click(object sender, EventArgs e)
        {
            setPanelActive(3);
        }

        private void returnToMenuButton_Click(object sender, EventArgs e)
        {
            setPanelActive(0);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            int i = Array.IndexOf(contextPanels, currentPanel);
            setPanelActive(i - 1);
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            int i = Array.IndexOf(contextPanels, currentPanel);
            setPanelActive(i + 1);
        }

        private void setPanelActive(int i)
        {
            currentPanel.Enabled = false;
            currentPanel.Visible = false;
            currentPanel = contextPanels[i];
            currentPanel.Enabled = true;
            currentPanel.Visible = true;

            if(i.Equals(0))
            {
                titleLabel.Text = "MAIN MENU";
                returnToMenuButton.Visible = false;
                returnToMenuButton.Enabled = false;
                backButton.Visible = false;
                backButton.Enabled = false;
            } else
            {
                returnToMenuButton.Visible = true;
                returnToMenuButton.Enabled = true;
                backButton.Visible = true;
                backButton.Enabled = true;
                if(i.Equals(1))
                {
                    titleLabel.Text = "TASK ONE";
                } else if(i.Equals(2))
                {
                    forwardButton.Visible = true;
                    forwardButton.Enabled = true;
                    titleLabel.Text = "TASK TWO";
                } else if(i.Equals(3))
                {
                    titleLabel.Text = "TASK THREE";
                    forwardButton.Visible = false;
                    forwardButton.Enabled = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.AddExtension = true;
            openFileDialog.Multiselect = true;
            //openFileDialog.Filter = "PDF files (*.pdf)|*.pdf";

            if(openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach(string fileName in openFileDialog.FileNames)
                {
                    //Process.Start(fileName);
                }
            }
        }
    }
}
