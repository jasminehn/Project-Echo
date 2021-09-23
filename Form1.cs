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
        public MainForm()
        {
            InitializeComponent();
            Panel[] contextPanels = {mainMenuPanel, taskOnePanel, taskTwoPanel, taskThreePanel};
            
            currentPanel = contextPanels[1];
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
            buildOnePanel();
        }

        private void taskTwoButton_Click(object sender, EventArgs e)
        {
            buildTwoPanel();
        }

        private void taskThreeButton_Click(object sender, EventArgs e)
        {
            buildThreePanel();
        }

        private void returnToMenuButton_Click(object sender, EventArgs e)
        {
            buildMainPanel();
        }

        private void backButton_Click(object sender, EventArgs e)
        {

        }

        private void setPanelActive(Panel p)
        {
             
        }

        private void buildMainPanel()
        {
            returnToMenuButton.Visible = false;
            currentPanel.Enabled = false;
            currentPanel.Visible = false;
            mainMenuPanel.Enabled = true;
            mainMenuPanel.Visible = true;

            titleLabel.Text = "MAIN MENU";
        }

        private void buildOnePanel()
        {
            returnToMenuButton.Visible = true;
            mainMenuPanel.Enabled = false;
            mainMenuPanel.Visible = false;

            taskOnePanel.Visible = true;
            taskOnePanel.Enabled = true;
            currentPanel = taskOnePanel;

            titleLabel.Text = "TASK ONE";
        }

        private void buildTwoPanel()
        {
            returnToMenuButton.Visible = true;
            mainMenuPanel.Enabled = false;
            mainMenuPanel.Visible = false;

            taskTwoPanel.Visible = true;
            taskTwoPanel.Enabled = true;
            currentPanel = taskTwoPanel;

            titleLabel.Text = "TASK TWO";
        }

        private void buildThreePanel()
        {
            returnToMenuButton.Visible = true;
            mainMenuPanel.Enabled = false;
            mainMenuPanel.Visible = false;

            taskThreePanel.Visible = true;
            taskThreePanel.Enabled = true;
            currentPanel = taskThreePanel;

            titleLabel.Text = "TASK THREE";
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
