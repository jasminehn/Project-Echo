using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ProjectEcho
{
    /**
     *
     *
     *
     *
     * Author(s): J. Nelson, I. Gnagy
     */

    public partial class SettingsForm : Form
    {
        SettingsHandler settingsHandler = new SettingsHandler();

        //button colors
        private Color buttonOnColor = ColorTranslator.FromHtml("#5ac993");
        private Color buttonOffColor = SystemColors.ControlDark;
        //light mode colors
        private Color lightBG = Color.WhiteSmoke;
        private Color lightText = Color.Black;
        //dark mode colors
        private Color darkBG = ColorTranslator.FromHtml("#121113");
        private Color darkText = Color.WhiteSmoke;
        //creates vars for repeated use
        private Color backgroundColor;
        private Color backgroundMain;
        private Color fontColor;

        private int textSizeOffset = 0; //keeps track of how much the text size has changed

        MainForm mainForm;
        HelpForm helpForm;
        TaskOneUserControl taskOne;
        TaskTwoUserControl taskTwo;
        TaskThreeUserControl taskThree;

        public SettingsForm(MainForm mainFormInput, HelpForm helpFormInput, TaskOneUserControl taskOneInput, TaskTwoUserControl taskTwoInput, TaskThreeUserControl taskThreeInput)
        {
            InitializeComponent();
            mainForm = mainFormInput;
            helpForm = helpFormInput;
            taskOne = taskOneInput;
            taskTwo = taskTwoInput;
            taskThree = taskThreeInput;
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            //Apply saved display settings upon loading
            boldnessToggle.Checked = Properties.Settings.Default.boldness;
            switchButton.Checked = Properties.Settings.Default.darkmode;
            textSizeOffset = Properties.Settings.Default.textsize; //sets offset to saved value
            textsizeAdjust.Value = Properties.Settings.Default.textsize; //sets slider to saved value

            backgroundColor = Properties.Settings.Default.bgcolor;
            backgroundMain = Properties.Settings.Default.bgmain;
            fontColor = Properties.Settings.Default.fcolor;

            var controls = settingsHandler.getAll(this, typeof(Label));
            foreach(Control c in controls)
            {
                FontFamily fon = Font.FontFamily; //Sets font family
                FontStyle sty = c.Font.Style; //Sets style (ie. bold, italic, reg)
                float adjSize = c.Font.Size + textSizeOffset;
                c.Font = new Font(fon, adjSize, sty); //Passes in family, style, new size
            }
        }

        private void switchButton_Click(object sender, EventArgs e)
        {
            Color currback = this.BackColor;

            //Checks darkmode toggle
            if (switchButton.Checked) //ON
            {

                backgroundColor = ColorTranslator.FromHtml("#121113");
                backgroundMain = ColorTranslator.FromHtml("#0A070E");
                fontColor = Color.White;

                if (currback == Color.White)
                {
                    BackColor = backgroundColor;
                    ForeColor = fontColor;

                    //settings menu changes
                    BackColor = backgroundColor;
                    panel1.BackColor = backgroundColor;
                    ForeColor = fontColor;

                    //Changes color for slider
                    textsizeAdjust.BackColor = backgroundColor;
                    textsizeAdjust.ForeColor = fontColor;

                    //Changes color for button
                    applyButton.BackColor = backgroundColor;

                    //main form changes 
                    mainForm.BackColor = backgroundMain;
                    mainForm.mainMenuPanel.BackColor = backgroundColor;
                    mainForm.mainPanel.BackColor = backgroundColor;
                }
                else
                {
                    BackColor = backgroundColor;
                    panel1.BackColor = backgroundColor;
                    ForeColor = fontColor;

                    textsizeAdjust.BackColor = backgroundColor;
                    textsizeAdjust.ForeColor = fontColor;

                    applyButton.BackColor = backgroundColor;

                    mainForm.BackColor = backgroundMain;
                    mainForm.mainMenuPanel.BackColor = backgroundColor;
                    mainForm.mainPanel.BackColor = backgroundColor;
                }

            }
            else //OFF
            {
                backgroundColor = Color.White;
                backgroundMain = Color.White;
                fontColor = Color.Black;

                if (currback == ColorTranslator.FromHtml("#121113"))
                {
                    BackColor = backgroundColor;
                    ForeColor = fontColor;

                    //settings menu changes
                    BackColor = backgroundColor;
                    panel1.BackColor = backgroundColor;
                    ForeColor = fontColor;

                    //Changes color for slider
                    textsizeAdjust.BackColor = backgroundColor;
                    textsizeAdjust.ForeColor = fontColor;

                    //Changes color for button
                    applyButton.BackColor = backgroundColor;

                    //main form changes 
                    mainForm.BackColor = backgroundMain;
                    mainForm.mainMenuPanel.BackColor = backgroundColor;
                    mainForm.mainPanel.BackColor = backgroundColor;
                }
                else
                {
                    BackColor = backgroundColor;
                    panel1.BackColor = backgroundColor;
                    ForeColor = fontColor;

                    textsizeAdjust.BackColor = backgroundColor;
                    textsizeAdjust.ForeColor = fontColor;

                    applyButton.BackColor = backgroundColor;

                    mainForm.BackColor = backgroundMain;
                    mainForm.mainMenuPanel.BackColor = backgroundColor;
                    mainForm.mainPanel.BackColor = backgroundColor;
                }
            }
        }

        private void boldnessToggle_CheckedChanged(object sender, EventArgs e)
        {
            var labels = settingsHandler.getAll(mainForm, typeof(Label)); //Finds all labels in main form
            var checkLists = settingsHandler.getAll(mainForm, typeof(CheckedListBox)); //Finds all checkedlistboxes in main form

            var settingsLabels = settingsHandler.getAll(this, typeof(Label)); //Finds all labels in settings form
            labels = labels.Concat(settingsLabels); //adds settings form labels to label IEnumerable

            var helpLabels = settingsHandler.getAll(helpForm, typeof(Label)); //Finds all labels in help form
            labels = labels.Concat(helpLabels); //adds help form labels to label IEnumerable

            //Checks boldness toggles
            if (boldnessToggle.Checked) //ON
            {
                foreach(Control c in labels) //Changes every label indivdually
                {
                    FontFamily fam = c.Font.FontFamily; //Sets current font style
                    float s = c.Font.Size; //Sets current font size

                    //Passes in font style, size and changes to bold
                    c.Font = new System.Drawing.Font(fam, s, FontStyle.Bold);
                }
                foreach(CheckedListBox c in checkLists) //Changes every label indivdually
                {
                    FontFamily fam = c.Font.FontFamily; //Sets current font style
                    float s = c.Font.Size; //Sets current font size

                    //Passes in font style, size and changes to bold
                    c.Font = new System.Drawing.Font(fam, s, FontStyle.Bold);
                }
            }
            else //OFF
            {
                foreach(Control c in labels)
                {
                    FontFamily fam = c.Font.FontFamily;
                    float s = c.Font.Size;
                    c.Font = new System.Drawing.Font(fam, s, FontStyle.Regular);
                }
                foreach(CheckedListBox c in checkLists)
                {
                    FontFamily fam = c.Font.FontFamily;
                    float s = c.Font.Size;
                    c.Font = new System.Drawing.Font(fam, s, FontStyle.Regular);
                }
            }
        }

        private float prev = 0;

        private void textsizeAdjust_Scroll(object sender, EventArgs e)
        {
            var labels = settingsHandler.getAll(mainForm, typeof(Label)); //Finds all labels in main form
            var checkLists = settingsHandler.getAll(mainForm, typeof(CheckedListBox)); //Finds all checkedlistboxes in main form

            var settingsLabels = settingsHandler.getAll(this, typeof(Label)); //Finds all labels in settings form
            labels = labels.Concat(settingsLabels); //adds settings form labels to label IEnumerable

            var helpLabels = settingsHandler.getAll(helpForm, typeof(Label)); //Finds all labels in help form
            labels = labels.Concat(helpLabels); //adds help form labels to label IEnumerable

            float curr = textsizeAdjust.Value; // gets current font size

            //Checks if the slider val is getting larger or smaller
            if (prev < curr)
            {
                foreach (Control c in labels) //Changes every label indivdually
                {
                    FontFamily fon = Font.FontFamily; //Sets font family
                    FontStyle sty = c.Font.Style; //Sets style (ie. bold, italic, reg)
                    float adjSize = c.Font.Size + 1;
                    //Passes in family, style, and changes to new size
                    c.Font = new Font(fon, adjSize, sty);
                }
                foreach (CheckedListBox c in checkLists)
                {
                    FontFamily fon = Font.FontFamily;
                    FontStyle sty = c.Font.Style;
                    float adjSize = c.Font.Size + 1;
                    c.Font = new System.Drawing.Font(fon, adjSize, sty);
                }
                prev = curr; //Sets prev to current size for next interation
            }
            else
            {
                foreach (Control c in labels)
                {
                    FontFamily fon = Font.FontFamily;
                    FontStyle sty = c.Font.Style;
                    float adjSize = c.Font.Size - 1;
                    c.Font = new Font(fon, adjSize, sty);
                }
                foreach (CheckedListBox c in checkLists)
                {
                    FontFamily fon = Font.FontFamily;
                    FontStyle sty = c.Font.Style;
                    float adjSize = c.Font.Size - 1;
                    c.Font = new System.Drawing.Font(fon, adjSize, sty);
                }
                prev = curr;
            }
            textSizeOffset = textsizeAdjust.Value;
            Properties.Settings.Default.textsize = textSizeOffset;
            Properties.Settings.Default.Save();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            //Apply and save to form for reloading
            Properties.Settings.Default.boldness = boldnessToggle.Checked;
            Properties.Settings.Default.darkmode = switchButton.Checked;
            Properties.Settings.Default.textsize = textSizeOffset;
            Properties.Settings.Default.bgcolor = backgroundColor;
            Properties.Settings.Default.bgmain= backgroundMain;
            Properties.Settings.Default.Save();

            this.Close(); //close settings menu when they save te settings
        }

        private void textsizeAdjust_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}