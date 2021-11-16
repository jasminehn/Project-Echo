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

        //button colors
        Color buttonOnColor = ColorTranslator.FromHtml("#5ac993");
        Color buttonOffColor = SystemColors.ControlDark;

        //light mode colors
        Color lightBG = Color.WhiteSmoke;
        Color lightText = Color.Black;

        //dark mode colors
        Color darkBG = ColorTranslator.FromHtml("#121113");
        Color darkText = Color.WhiteSmoke;
        
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
            //textsizeSelect.Value = (decimal)textsizeLabel.Font.Size;
        }

        private void switchButton_Click(object sender, EventArgs e)
        {
            if (switchButton.Checked)
            {                
                BackColor = darkBG;
                panel1.BackColor = darkBG;
                ForeColor = Color.White; //changes all text color
                //Changes color for slider
                textsizeAdjust.BackColor = Color.Black;
                textsizeAdjust.ForeColor = Color.White;
                //Changes color for button
                applyButton.BackColor = Color.Black;
            }
            else //DARK MODE ON
            {
                BackColor = lightBG;
                panel1.BackColor = lightBG;
                ForeColor = Color.Black; //changes all text color
                //Changes color for slider
                textsizeAdjust.BackColor = Color.White;
                textsizeAdjust.ForeColor = Color.Black;
                //Changes color for button
                applyButton.BackColor = Color.White;
            }
        }
       public IEnumerable<Control> getAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();
            return controls.SelectMany(ctrl => getAll(ctrl, type)).Concat(controls).Where(c => c.GetType() == type);
        }

        private void boldnessToggle_CheckedChanged(object sender, EventArgs e)
        {
            var controls = getAll(this, typeof(Label));
            if (boldnessToggle.Checked)
            {
                Font = new System.Drawing.Font(Font, FontStyle.Bold);
                foreach (Control c in controls)
                {
                    FontFamily fam = c.Font.FontFamily;
                    float s = c.Font.Size;
                    c.Font = new System.Drawing.Font(fam, s, FontStyle.Bold);
                }
            }
            else
            {
                Font = new System.Drawing.Font(Font, FontStyle.Regular);
                foreach (Control c in controls)
                {
                    FontFamily fam = c.Font.FontFamily;
                    float s = c.Font.Size;
                    c.Font = new System.Drawing.Font(fam, s, FontStyle.Regular);
                }
            }
        }
        /*
        private void grayscaleToggle_CheckedChanged(object sender, EventArgs e)
        {
            on = grayscaleToggle.Checked; //sets on to current toggle bool
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
            on = invertedToggle.Checked; //sets on to current toggle bool
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
            on = blueyellowToggle.Checked; //sets on to current toggle bool
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
            on = blueyellowToggle.Checked; //sets on to current toggle bool
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
        } */
        float prev = 0;

        private void textsizeAdjust_Scroll(object sender, EventArgs e)
        {
            var controls = getAll(this, typeof(Label));
            
            float curr = textsizeAdjust.Value; // gets current font size

            //Checks if the slider val is getting larger or smaller
            if (prev < curr)
            {
                foreach (Control c in controls)
                {
                    FontFamily fon = Font.FontFamily; //Sets font family 
                    FontStyle sty = c.Font.Style; //Sets style (ie. bold, italic, reg)
                    float adjSize = c.Font.Size + curr;
                    c.Font = new Font(fon, adjSize, sty); //Passes in family, style, new size
                }
                prev = curr; //Sets prev to current size for next interation
            }
            else
            {
                //If the slider is set back down to 0, it subs 0. This subs 1 as it should
                if(curr == 0)
                {
                    foreach (Control c in controls)
                    {
                        FontFamily fon = Font.FontFamily;
                        FontStyle sty = c.Font.Style;
                        float adjSize = c.Font.Size - 1;

                        c.Font = new Font(fon, adjSize, sty);
                    }
                }
                else
                {
                    foreach (Control c in controls)
                    {
                        FontFamily fon = Font.FontFamily;
                        FontStyle sty = c.Font.Style;
                        float adjSize = c.Font.Size - curr;

                        c.Font = new Font(fon, adjSize, sty);
                    }
                }
                
                prev = curr;
            }
            
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            //TODO: Apply and save to form for reloading
        }
    }
}
