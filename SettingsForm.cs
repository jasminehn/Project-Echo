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
    public partial class SettingsForm : Form
    {
        bool on = true;

        //button colors
        Color buttonOnColor = ColorTranslator.FromHtml("#5ac993");
        Color buttonOffColor = SystemColors.ControlDark;

        //light mode colors
        Color lightBG = Color.WhiteSmoke;
        Color lightText = Color.Black;

        //dark mode colors
        Color darkBG = ColorTranslator.FromHtml("#121113");
        Color darkText = Color.WhiteSmoke;
        

        private void switchOnOff(SwitchButton button)
        {
            if (on)
            {
                //button.Text = "ON";
                //switchButton1.Checked = true;
                //button.BackColor = Color.LimeGreen;

                //button.BackColor = buttonOnColor;
                on = false;
            }
            else
            {
                //button.Text = "OFF";
                //switchButton1.Checked = false;
                //button.BackColor = Color.DarkGray;

                //button.BackColor = buttonOffColor;
                on = true;
            }
        }

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            /*darkModeSwitch.Text = "OFF";
            invertedSwitch.Text = "OFF";
            grayscaleSwitch.Text = "OFF";
            blueyellowSwitch.Text = "OFF";
            redgreenSwitch.Text = "OFF";
            boldSwitch.Text = "OFF";*/
            textsizeSelect.Value = (decimal)label1.Font.Size;
        }

        private void switchButton_Click(object sender, EventArgs e)
        {
            //switchOnOff(darkModeSwitch);
            if (on)
            {
                /*
                BackColor = System.Drawing.Color.White;
                textsizeSelect.BackColor = Color.White;
                textsizeSelect.ForeColor = Color.Black;
                ForeColor = System.Drawing.Color.Black;
                */
                BackColor = lightBG;
                panel1.BackColor = lightBG;
                ForeColor = Color.Black; //changes all text color
                textsizeSelect.BackColor = Color.White;
                textsizeSelect.ForeColor = Color.Black;

                on = true;
            }
            else //DARK MODE ON
            {
                /*
                BackColor = System.Drawing.Color.Black;
                textsizeSelect.BackColor = Color.Black;
                textsizeSelect.ForeColor = Color.White;
                ForeColor = System.Drawing.Color.White;
                */
                BackColor = darkBG;
                panel1.BackColor = darkBG;
                ForeColor = Color.White; //changes all text color
                textsizeSelect.BackColor = Color.Black;
                textsizeSelect.ForeColor = Color.White;
                
                on = false;
            }
        }

        private void invertedSwitch_Click(object sender, EventArgs e)
        {
            //switchOnOff(invertedSwitch);
            if (on)
            {
                //normal
                on = true;
            }
            else
            {
                //inverted
                on = false;
            }
        }

        private void grayscaleSwitch_Click(object sender, EventArgs e)
        {
            //switchOnOff(grayscaleSwitch);
            if (on)
            {
                //normal
                on = true;
            }
            else
            {
                //greyscale
                on = false;
            }
        }

        private void blueyellowSwitch_Click(object sender, EventArgs e)
        {
            //switchOnOff(blueyellowSwitch);
            if (on)
            {
                //normal
                on = true;
            }
            else
            {
                //filter
                on = false;
            }
        }

        private void redgreenSwitch_Click(object sender, EventArgs e)
        {
            //switchOnOff(redgreenSwitch);
            if (on)
            {
                //normal
                on = true;
            }
            else
            {
                //filter
                on = false;
            }
        }
        
        private void boldSwitch_Click(object sender, EventArgs e)
        {

        }

        private void textsizeSelect_SelectedItemChanged(object sender, EventArgs e)
        {
            Font = new Font("Century Gothic", (float)textsizeSelect.Value);  
            //TODO: Currently only changes text size of buttons            

            var controls = getAll(this, typeof(Label));
            foreach (Control c in controls)
            {
                //Console.WriteLine(c.ToString()); //print name of each label (for testing)
                c.Font = new Font("Century Gothic", (float)textsizeSelect.Value);
            }
        }

        //returns list of all labels
        public IEnumerable<Control> getAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();
            return controls.SelectMany(ctrl => getAll(ctrl, type)).Concat(controls).Where(c => c.GetType() == type);
        }


        //NEW CODE WITH TOGGLES

        private void switchButton1_CheckedChanged(object sender, EventArgs e)
        {
            switchOnOff(darkModeToggle);
            if (on)
            {
                /*
                BackColor = System.Drawing.Color.White;
                textsizeSelect.BackColor = Color.White;
                textsizeSelect.ForeColor = Color.Black;
                ForeColor = System.Drawing.Color.Black;
                */
                BackColor = lightBG;
                panel1.BackColor = lightBG;
                ForeColor = Color.Black; //changes all text color
                textsizeSelect.BackColor = Color.White;
                textsizeSelect.ForeColor = Color.Black;

                on = true;
            }
            else //DARK MODE ON
            {
                /*
                BackColor = System.Drawing.Color.Black;
                textsizeSelect.BackColor = Color.Black;
                textsizeSelect.ForeColor = Color.White;
                ForeColor = System.Drawing.Color.White;
                */
                BackColor = darkBG;
                panel1.BackColor = darkBG;
                ForeColor = Color.White; //changes all text color
                textsizeSelect.BackColor = Color.Black;
                textsizeSelect.ForeColor = Color.White;

                on = false;
            }
        }

        private void boldnessToggle_CheckedChanged(object sender, EventArgs e)
        {
            switchOnOff(boldnessToggle);
            var controls = getAll(this, typeof(Label));
            if (on)
            {
                Font = new System.Drawing.Font(Font, FontStyle.Regular);
                foreach (Control c in controls)
                {
                    c.Font = new System.Drawing.Font(Font, FontStyle.Regular);
                }
                on = true;
            }
            else
            {
                Font = new System.Drawing.Font(Font, FontStyle.Bold);
                foreach (Control c in controls)
                {
                    c.Font = new System.Drawing.Font(Font, FontStyle.Bold);
                }
                on = false;
            }
        }

        private void grayscaleToggle_CheckedChanged(object sender, EventArgs e)
        {
            switchOnOff(grayscaleToggle);
            if (on)
            {
                //normal
                on = true;
            }
            else
            {
                //greyscale
                on = false;
            }
        }

        private void invertedToggle_CheckedChanged(object sender, EventArgs e)
        {
            switchOnOff(invertedToggle);
            if (on)
            {
                //normal
                on = true;
            }
            else
            {
                //inverted
                on = false;
            }
        }

        private void redgreenToggle_CheckedChanged(object sender, EventArgs e)
        {
            switchOnOff(redgreenToggle);
            if (on)
            {
                //normal
                on = true;
            }
            else
            {
                //filter
                on = false;
            }
        }

        private void blueyellowToggle_CheckedChanged(object sender, EventArgs e)
        {
            switchOnOff(blueyellowToggle);
            if (on)
            {
                //normal
                on = true;
            }
            else
            {
                //filter
                on = false;
            }
        }

        private void textsizeSelect_ValueChanged(object sender, EventArgs e)
        {
            Font = new Font("Century Gothic", (float)textsizeSelect.Value);
            //TODO: Currently only changes text size of buttons            

            var controls = getAll(this, typeof(Label));
            foreach (Control c in controls)
            {
                //Console.WriteLine(c.ToString()); //print name of each label (for testing)
                c.Font = new Font("Century Gothic", (float)textsizeSelect.Value);
            }
        }
    }
}
