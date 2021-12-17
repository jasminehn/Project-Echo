using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Reflection;
using System.Diagnostics;

/**
 *  To the next owners --
 *  Welcome to the Education Capstone Checker Application. This application is designed to improve the scores 
 *  of John Carroll students submitting to the Ohio Board of Education. Along with documentation that we have
 *  written, I would like to give you all a bit of a background in the technology you may be using while 
 *  updating/upgrading this project.
 *  
 *  We have used a number of existing libraries, with their own documentation guides. 
 *  
 *  
 *  Authors: C. Segrue, J. Nelson, E. MacDonald, I. Gnagy
 */
namespace ProjectEcho
{
    /** Each task is built with something called a 'User Control'. If you take a look at the Designer, you can get 
     *  a better sense of what's going on below. (Hint: Right click anywhere on the code and at the top of the 
     *  Options Menu you'll see 'View Designer'.) 
     *  
     *  A User Control is basically anything that you drag onto the WYSIWYG editor for the user to view/interact with.
     *  A button, an image, a label -- all of these are User Controls. You can build your own User Controls, which is 
     *  exactly what we did.
     *  
     *  Authors: C. Segrue, J. Nelson
     */
    public partial class MainForm : Form
    {
        public UserControl[] taskControls = new UserControl[4]; // Creating an array to store every task for navigation purposes
        private UserControl currentControl = new UserControl(); // Every time the user switches pages, this value gets set to
        private static string ProgramPath = AppDomain.CurrentDomain.BaseDirectory; //get direct path to the program                                                        // one of the existing pages in the UserControl array.                                                     
        public static TaskOneUserControl t1 = new TaskOneUserControl();  // purposely empty         

        public HelpForm hf = new HelpForm(); // Globally available
        int saveHelpResource = 0; // The HelpForm has never been opened, so set to zero.
        public String path;
        public static int pdfIndex = 3;
        public static String pdfPage = "Task One";

        private SettingsHandler settingsHandler = new SettingsHandler();
        private int textSizeOffset = 0; //keeps track of how much the text size has changed



        public MainForm()
        {
            InitializeComponent();
            Rectangle resolution = Screen.PrimaryScreen.Bounds;
            Console.WriteLine("CLARE:: SCREEN SIZE " + resolution.ToString());
            mainMenuPanel.Dock = DockStyle.Fill;

            mainMenuPanel.AutoSize = true;
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.AutoSize = true;


            /* While all of the tasks are made with User Controls, the Main Menu is built with a normal panel. 
             * We would've made it with a User Control, but we switched to User Controls later in the game and 
             * switching the Main Menu would have forced us to mess with our Save State code.
             * So the first value in the array is purposely empty, because it's a sort of placeholder for the Main Menu.
             */
            taskControls[0] = t1; // purposely empty, holding spot for the main menu panel
            taskControls[1] = taskOne; // taskOne is created in the Designer
            taskControls[2] = taskTwo; // taskTwo is created in the Designer
            taskControls[3] = taskThree;  // Will be changed once Task Three is built.

            currentControl = taskControls[0]; // setting the current control on start, which should always be the main menu
            taskOne.Visible = false; // Setting all of the other controls invisible in case we mess it up in the designer
            taskTwo.Visible = false;
            taskThree.Visible = false;
            setControlActive(0); // Call to the set Control active method, which handles most to all UI changes


            // Maintains progress for the first task and allows users to see that progress on the main menu
            string[] taskOneArray = { "Context for learning information", "Plans for Learning segment", "Instructional Materials", "Assessments", "Planning Commentary" };
            taskOneList.Items.AddRange(taskOneArray);
            taskOne.updateTaskProgress(); // Checks to see if there is any pre-existing progress on start
            checkProgress(taskOne.taskProgress, taskOneList);

            // Maintains progress for the second task and allows users to see that progress on the main menu
            string[] taskTwoArray = { "Video Clips", "Commentary" };
            taskTwoList.Items.AddRange(taskTwoArray);
            taskTwo.updateTaskProgress(); // Checks to see if there is any pre-existing progress on start
            checkProgress(taskTwo.taskProgress, taskTwoList);

            // Maintains progress for the third task and allows users to see that progress on the main menu
            string[] taskThreeArray = { "Video Conference", "Notes", "Feedback", "Commentary", "Evaluation Criteria" };
            taskThreeList.Items.AddRange(taskThreeArray);
            taskThree.updateTaskProgress(); // Checks to see if there is any pre-existing progress on start
            checkProgress(taskThree.taskProgress, taskThreeList);

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

         /*
            Apply saved display settings
            Author: @J. Nelson
            */
        private void MainForm_Load(object sender, EventArgs e)
        {
            //Apply saved display settings
            textSizeOffset = Properties.Settings.Default.textsize; //sets offset to saved value
            var labels = settingsHandler.getAll(this, typeof(Label));
            foreach (Control c in labels)
            {
                System.Drawing.FontFamily fon = c.Font.FontFamily; //Sets font family
                FontStyle sty = c.Font.Style; //Sets style (ie. bold, italic, reg)
                float adjSize = c.Font.Size + textSizeOffset;

                c.Font = new Font(fon, adjSize, sty); //Passes in family, style, new size
            }

            
            /*
            Apply saved darkmode settings
            Author: @J. Nelson
            */
            var allControls = settingsHandler.getAllControls(this);
            foreach (Control c in allControls)
            {
                if ((c.Tag != null) && (c.Tag.ToString() == "panelBW"))
                {
                    c.BackColor = Properties.Settings.Default.bgcolor;
                }

                if ((c.Tag != null) && (c.Tag.ToString() == "analysisDM"))
                {
                    c.BackColor = Properties.Settings.Default.abcolor;
                }

                if ((c.Tag != null) && (c.Tag.ToString() == "feedbackDM"))
                {
                    c.BackColor = Properties.Settings.Default.fbcolor;
                }

                if ((c.Tag != null) && (c.Tag.ToString() == "checklistDM"))
                {
                    c.BackColor = Properties.Settings.Default.abcolor;
                    c.ForeColor = Properties.Settings.Default.fcolor;
                }

                if ((c.Tag != null) && (c.Tag.ToString() == "labelBW"))
                {
                    c.ForeColor = Properties.Settings.Default.fcolor;
                }

                if ((c.Tag != null) && (c.Tag.ToString() == "tabPageBW"))
                {
                    c.BackColor = Properties.Settings.Default.bgcolor;
                }
            }
        }

        /*
        On-click events for the buttons on the MainForm
        Author: @C. Segrue
        */ 
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

        /**
        The setControlActive method requires an int to be passed in, representing the position in the array the control to 
        be set active is in. This method takes the currently set control, hides it from view, and then makes the new
        control visible. In addition, it hides/shows UI elements, such as the Return to Main Menu button, based on the control
        that is active.

        Author: @C. Segrue

        */
        public void setControlActive(int i)
        {
            //Checking progress on all of the tasks
            checkProgress(taskOne.taskProgress, taskOneList); 
            checkProgress(taskTwo.taskProgress, taskTwoList);
            checkProgress(taskThree.taskProgress, taskThreeList);

            /*
            On the designer, none of the elements are properly docked. We want all of the controls/main menu to be DockStyle.Fill 
            once they are set active, but only one element can be in this position. Everytime this method is called, the currentControl's
            DockStyle is removed so the new control can take it's place.
            */

            headerPanel.Dock = DockStyle.Top; //Verifying that the header stays at the top. Probably redundant.
            currentControl.Visible = false; // Set the current control to invisible
            currentControl.Dock = DockStyle.None; //Removing the DockStyle so the new element can take it's place
            currentControl = taskControls[i]; // reset the global currentControl variable to the new position in the array
            currentControl.Dock = DockStyle.Fill; //Resizes and sets the new control to the correct bounds within the form.
            currentControl.Visible = true; // set this new control visible

            if (i.Equals(0)) // First position is the Main Menu
            {
                titleLabel.Text = "MAIN MENU"; // Setting the title label 
                currentControl.Dock = DockStyle.None; //This only needs to be done here because the first element in that array isn't being used,
                                                      // it's just holding the place for the MainMenu. As a result, we still need to set
                                                      // the DockStyle on the Main Menu Panel to fill
                mainMenuPanel.Dock = DockStyle.Fill;
                mainMenuPanel.Visible = true;  // Same sort of operation as the controls above, but we need to do it for the panel which
                                               // is not a control
                returnToMenuButton.Visible = false; // Setting UI buttons inactive as you can't return to the MM while on the MM
                forwardButton.Visible = true;
                backButton.Visible = false; // Nothing to go back to, set this invisible so we can't use it

            }
            else
            {
                mainMenuPanel.Visible = false;
                mainMenuPanel.Dock = DockStyle.None;
                returnToMenuButton.Visible = true;
                backButton.Visible = true;

                if (i.Equals(1))
                {
                    titleLabel.Text = "TASK ONE";
                    forwardButton.Visible = true; // All of these guarentee that if they aren't visible/invisible
                                                  // when they need to be, they will get changed.
                }
                else if (i.Equals(2))
                {
                    titleLabel.Text = "TASK TWO";
                    forwardButton.Visible = true;
                }
                else if (i.Equals(3))
                {
                    titleLabel.Text = "TASK THREE";
                    forwardButton.Visible = false;
                }
            }

        }

        /* The Tool Strip is the list of items displated along the top of the application.
         * 
         * At the moment, we have three items displayed.
         *      - File
         *      - Settings
         *      - Help
         * 
         * Settings and Help have their own Designers and code, so please navigate there
         * if you would like to see what those are doing.
         *
         * Author: @C. Segrue
         *
         */

        /* Creates the HelpForm after user clicks the Help tool menu item
        Author: @C.Segrue
        */
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pdfIndex = 0; // Since this is the generic Help Button, we load the first PDF
            LaunchHelpForm();
        }

        //Author: @C.Segrue
        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit(); // Exits out of the whole application
        }

        //Author: @J. Nelson
        private void recentFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open the UserUploads folder stored on the user's machine
            string executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string useruploadsPath = Path.Combine(executableLocation, "UserUploads");
            Process.Start(useruploadsPath);
        }
        
        
        //Author: @J. Nelson
        private void clearLocalFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Delete everything in useruploads
            string executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string useruploadsPath = Path.Combine(executableLocation, "UserUploads");
            System.IO.DirectoryInfo useruploads = new DirectoryInfo(useruploadsPath);
            foreach (DirectoryInfo dir in useruploads.GetDirectories())
            {
                dir.Delete(true);
            }
            System.Windows.Forms.MessageBox.Show("Local files have been cleared. Your UserUploads folder is now empty.");
        }

        //Author: @C.Segrue
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm sf = new SettingsForm(this, hf, taskOne, taskTwo, taskThree); //pass in the main form and the helpform to the settings form
            if (sf.ShowDialog() == DialogResult.OK)
            {
                Console.Write("Settings opened");
            }
        }

        // Not working
        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            toolTip1.SetToolTip(menuStrip1, "View the edTPA Submission Rubric");
        }

        
        /*
        The following Video Launch methods link to unlisted YouTube videos, owned by Dr. DiLisi. These videos
        are instructional guides for how to submit/gather material for each area.

        Author: @C.Segrue
        */
        private void t1videoLaunchButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://youtu.be/IsNq-4qV1ZY"); //Launches the link to the first YouTube video in the user's default browser
        }

        private void t2videoLaunchButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://youtu.be/AwW2rk4-aNA"); //Launches the link to the second YouTube video in the user's default browser
        }

        private void t3videoLaunchButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://youtu.be/HSD9YrP_4pc"); //Launches the link to the third YouTube video in the user's default browser
        }

        /*
        

        */
        private void taskOneDocuButton_Click(object sender, EventArgs e)
        {
            // Setting the currently desired
            pdfIndex = 1;
            pdfPage = "#page=9";
            helpToolStripMenuItem_Click(sender, e);
        }

        private void taskTwoDocuButton_Click(object sender, EventArgs e)
        {
            pdfIndex = 1;
            pdfPage = "#page=18";
            LaunchHelpForm();
        }

        private void taskThreeDocuButton_Click(object sender, EventArgs e)
        {
            pdfIndex = 1;
            pdfPage = "#page=27";
            LaunchHelpForm();
        }

        //Author: @C.Segrue
        private void LaunchHelpForm()
        {

            /* We use a Chromium Browser in the Help Form. For more details, see the HelpForm.cs file.
             * One of the limitations of this Browser is that it can only be instantiated once
             * The reason we have this saveHelpResource variable is to be sure that we only try to build
             * the Chromium Browser once.
             */
            saveHelpResource++;
            if (saveHelpResource == 0)
            {
                if (hf.ShowDialog() == DialogResult.OK)
                {
                    Console.Write("Help opened"); //Debug
                }
            }
            else
            {
                hf.Show(); // In the HelpForm, you can see that the Form is
                           // never really destroyed until the whole Application is
                           // shut down.
            }
        }

        //Author: @J.Nelson
        public void checkProgress(Boolean[] taskProgress, CheckedListBox taskChecklist)
        {
            //Clears all checkedListBoxes
            foreach (int i in taskChecklist.CheckedIndices)
            {
                taskChecklist.SetItemCheckState(i, CheckState.Unchecked);
            }

            for (int i = 0; i < taskChecklist.Items.Count; i++)
            {
                if (taskProgress[i].Equals(true))
                {
                    taskChecklist.SetItemChecked(i, true);
                }
            }
        }
    }
}
