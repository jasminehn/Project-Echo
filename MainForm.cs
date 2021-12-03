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
        /**
         *  To the next owners --
         *  Welcome to the Education Capstone Checker Application. This application is designed to improve the scores 
         *  of John Carroll students submitting to the Ohio Board of Education. Along with documentation that we have
         *  written, I would like to give you all a bit of a background in the technology you may be using while 
         *  updating/upgrading this project.
         *  
         *  We have used a number of existing libraries, with their own documentation guides.  
         */

        /** Each task is built with something called a 'User Control'. If you take a look at the Designer, you can get 
         *  a better sense of what's going on below. (Hint: Right click anywhere on the code and at the top of the 
         *  Options Menu you'll see 'View Designer'.) 
         *  
         *  A User Control is basically anything that you drag onto the WYSIWYG editor for the user to view/interact with.
         *  A button, an image, a label -- all of these are User Controls. You can build your own User Controls, which is 
         *  exactly what we did.
         */

        // Creating an array to store every task for navigation purposes
        public UserControl[] taskControls = new UserControl[4];
        // Every time the user switches pages, this value gets set to one of the existing pages in the UserControl array.
        private UserControl currentControl = new UserControl();                                                      
        public static TaskOneUserControl t1 = new TaskOneUserControl();  // purposely empty         
        public HelpForm hf = new HelpForm();
        int saveHelpResource = 0;

        public String path;

        private InterfaceHandler ih = new InterfaceHandler(); //Creates new instance of InterfaceHandler

        /**
         * 
         * 
         */
        public MainForm()
        {
            InitializeComponent();
            
            /* While all of the tasks are made with User Controls, the Main Menu is built with a normal panel. We would've made it with a User Control,
             * but we switched to User Controls later in the game and switching the Main Menu would have forced us to mess with our Save State code.
             * So the first value in the array is purposely empty, because it's a sort of placeholder for the Main Menu.
             */
            taskControls[0] = t1; // purposely empty
            taskControls[1] = taskOne; // taskOne is created in the Designer
            taskControls[2] = taskTwoUserControl1; // taskTwo is created in the Designer
            taskControls[3] = taskOne;  // Will be changed once Task Three is built.

            currentControl = taskControls[0]; // When the 
            taskOne.Visible = false;
            setControlActive(0);
            string[] taskOneArray = { "Context for learning information", "Plans for Learning segment", "Instructional Materials", "Assessments", "Planning Commentary" };
            taskOneList.Items.AddRange(taskOneArray);
            string[] taskTwoArray = { "Video Clips", "Commentary" };
            taskTwoList.Items.AddRange(taskTwoArray);
            string[] taskThreeArray = { "Video Conference", "Notes", "Feedback", "Commentary" };
            taskThreeList.Items.AddRange(taskThreeArray);
            //string[] reviewArray = { "Task 1", "Task 2", "Task 3" };
            //reviewList.Items.AddRange(reviewArray);

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

        private void MainForm_Load(object sender, EventArgs e)
        {
            ih.adjustTextSize(Properties.Settings.Default.textsize, taskOne);
            ih.adjustTextSize(Properties.Settings.Default.textsize, taskTwoUserControl1);
            ih.adjustTextSize(Properties.Settings.Default.textsize, mainMenuPanel);
            ih.adjustTextSize(Properties.Settings.Default.textsize, mainPanel);
            ih.adjustTextSize(Properties.Settings.Default.textsize, panel1);

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

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Creates the form that displays
            saveHelpResource++;
            if(saveHelpResource == 0)
            {
                if(hf.ShowDialog() == DialogResult.OK)
                {
                    Console.Write("Help opened");
                }
            }
            else
            {
                hf.Show();
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm sf = new SettingsForm();

            if(sf.ShowDialog() == DialogResult.OK)
            {
                Console.Write("Settings opened");
            }
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            toolTip1.SetToolTip(menuStrip1, "View the edTPA Submission Rubric");
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
