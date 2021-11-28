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
    public partial class MainForm : Form
    {
        private UserControl currentControl = new UserControl();
        static TaskOneUserControl t1 = new TaskOneUserControl();
        static TaskTwoUserControl t2 = new TaskTwoUserControl();
        public UserControl[] taskControls = new UserControl[4];
        public HelpForm hf = new HelpForm();
        int saveHelpResource = 0;



        public String path;
        public MainForm()
        {
            InitializeComponent();
            //MainForm.CenterToScreen();
            taskControls[0] = t1;
            taskControls[1] = taskOne;
            taskControls[2] = taskTwo;
            taskControls[3] = t1;
            currentControl = taskControls[0];
            taskOne.Visible = false;
            setControlActive(0);
            string[] taskOneArray = { "Context for learning information", "Plans for Learning segment", "Instructional Materials", "Assessments", "Planning Commentary" };
            taskOneList.Items.AddRange(taskOneArray);
            string[] taskTwoArray = { "Video Clips", "Commentary" };
            taskTwoList.Items.AddRange(taskTwoArray);
            string[] taskThreeArray = { "Video Conference", "Notes", "Feedback", "Commentary" };
            taskThreeList.Items.AddRange(taskThreeArray);
            string[] reviewArray = { "Task 1", "Task 2", "Task 3" };
            reviewList.Items.AddRange(reviewArray);

            //create user uploads folder
            string userUploadsPath = Environment.CurrentDirectory + "\\UserUploads";
            try
            {
                //if the directory doesn't exist, create it
                if (!Directory.Exists(userUploadsPath))
                {
                    Directory.CreateDirectory(userUploadsPath);
                }
            }
            catch (Exception)
            {
                //fail silently
            }
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
            setControlActive(1);
        }

        private void taskTwoButton_Click(object sender, EventArgs e)
        {
            setControlActive(2);
        }

        private void taskThreeButton_Click(object sender, EventArgs e)
        {
            setControlActive(3);
        }

        private void returnToMenuButton_Click(object sender, EventArgs e)
        {
            setControlActive(0);
        }

        private void backButton_Click(object sender, EventArgs e)
        {

            int i = Array.IndexOf(taskControls, currentControl);
            setControlActive(i - 1);
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            int i = Array.IndexOf(taskControls, currentControl);
            setControlActive(i + 1);
        }

        public void setControlActive(int i)
        {
             
             currentControl.Visible = false;
             currentControl = taskControls[i];
             currentControl.Visible = true;
     
            if(i.Equals(0))
            {
                titleLabel.Text = "MAIN MENU";
                mainMenuPanel.Visible = true;  
                returnToMenuButton.Visible = false;
                backButton.Visible = false;
                
            } else
            {
                mainMenuPanel.Visible = false;
                returnToMenuButton.Visible = true;
                backButton.Visible = true;
               
                if (i.Equals(1))
                {
                    titleLabel.Text = "TASK ONE";
                    forwardButton.Visible = true;
                } else if(i.Equals(2))
                {
                    titleLabel.Text = "TASK TWO";
                    forwardButton.Visible = true;
                }
                else if(i.Equals(3))
                {
                    titleLabel.Text = "TASK THREE";
                    forwardButton.Visible = false;
                }
            }
            
        }        

        //Executes when the help button is clicked
        private void helpButton_Click(object sender, EventArgs e)
        {
            //Creates the form that displays
            saveHelpResource++;
            if(saveHelpResource == 0)
            {
                if (hf.ShowDialog() == DialogResult.OK)
                {
                    Console.Write("Help opened");
                }
            } else
            {
                hf.Show();
            }
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
