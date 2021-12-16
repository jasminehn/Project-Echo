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

        //var allLabels = getAll(this, typeof(Label)); //Finds all labels

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
            taskControls[0] = t1; // purposely empty
            taskControls[1] = taskOne; // taskOne is created in the Designer
            taskControls[2] = taskTwo; // taskTwo is created in the Designer
            taskControls[3] = taskThree;  // Will be changed once Task Three is built.

            currentControl = taskControls[0]; 
            taskOne.Visible = false;
            taskTwo.Visible = false;
            taskThree.Visible = false;
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

            //Apply saved darkmode settings
            var everything = settingsHandler.getAllControls(this);

            foreach (Control c in everything)
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

        // On-click events for the buttons on the MainForm
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
            headerPanel.Dock = DockStyle.Top;
            currentControl.Visible = false; // Set the current control to invisible
            currentControl.Dock = DockStyle.None;
            currentControl = taskControls[i]; // reset the global currentControl variable to the new position in the array
            currentControl.Dock = DockStyle.Fill;
            currentControl.Visible = true; // set this new control visible

            if (i.Equals(0)) // First position is the Main Menu
            {
                titleLabel.Text = "MAIN MENU";
                currentControl.Dock = DockStyle.None;
                mainMenuPanel.Dock = DockStyle.Fill;
                mainMenuPanel.Visible = true;  // Same sort of operation as the controls above, but we need to do it for the panel which
                                               // is not a control
                returnToMenuButton.Visible = false;
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
         */

        // Creates the HelpForm after user clicks the Help tool menu item
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pdfIndex = 0;
            LaunchHelpForm();
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit(); // Exits out of the whole application
        }

        // Not working
        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            toolTip1.SetToolTip(menuStrip1, "View the edTPA Submission Rubric");
        }

        

        private void t1videoLaunchButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://youtu.be/IsNq-4qV1ZY");
        }

        private void t2videoLaunchButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://youtu.be/AwW2rk4-aNA");
        }

        private void t3videoLaunchButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://youtu.be/HSD9YrP_4pc");
        }

        private void taskOneDocuButton_Click(object sender, EventArgs e)
        {
            MainForm.pdfIndex = 1;
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

        private void recentFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Opens the UserUploads folder stored on the user's machine
            string executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string useruploadsPath = Path.Combine(executableLocation, "UserUploads");
            Process.Start(useruploadsPath);
        }

        private void clearLocalFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //delete everything in useruploads (FIX LATER)
            /*
            string executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string xslLocation = Path.Combine(executableLocation, "UserUploads");

            System.IO.DirectoryInfo useruploads = new DirectoryInfo(xslLocation);

            
            foreach (DirectoryInfo dir in useruploads.GetDirectories())
            {
                dir.Delete(true);
            }
            */
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm sf = new SettingsForm(this, hf, taskOne, taskTwo, taskThree); //pass in the main form and the helpform to the settings form

            if (sf.ShowDialog() == DialogResult.OK)
            {
                Console.Write("Settings opened");
            }
        }
    }
}
