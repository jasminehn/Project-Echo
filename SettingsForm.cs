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
            on = switchButton.Checked; //sets on to current toggle bool
            if (on)
            {                
                BackColor = darkBG;
                panel1.BackColor = darkBG;
                ForeColor = Color.White; //changes all text color
                textsizeSelect.BackColor = Color.Black;
                textsizeSelect.ForeColor = Color.White;
                
                on = true;
            }
            else //DARK MODE ON
            {
                BackColor = lightBG;
                panel1.BackColor = lightBG;
                ForeColor = Color.Black; //changes all text color
                textsizeSelect.BackColor = Color.White;
                textsizeSelect.ForeColor = Color.Black;

                on = false;
            }
        }
       public IEnumerable<Control> getAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();
            return controls.SelectMany(ctrl => getAll(ctrl, type)).Concat(controls).Where(c => c.GetType() == type);
        }

        private void boldnessToggle_CheckedChanged(object sender, EventArgs e)
        {
            on = boldnessToggle.Checked; //sets on to current toggle bool
            var controls = getAll(this, typeof(Label));
            if (on)
            {
                Font = new System.Drawing.Font(Font, FontStyle.Bold);
                foreach (Control c in controls)
                {
                    c.Font = new System.Drawing.Font(Font, FontStyle.Bold);
                }
                on = false;
            }
            else
            {
                Font = new System.Drawing.Font(Font, FontStyle.Regular);
                foreach (Control c in controls)
                {
                    c.Font = new System.Drawing.Font(Font, FontStyle.Regular);
                }
                on = true;
            }
        }

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
        }

        private void textsizeSelect_ValueChanged(object sender, EventArgs e)
        {
            //TODO: increase text size individually, not set all to one

            var controls = getAll(this, typeof(Label));
            //Font = new Font("Century Gothic", 12);
            
            foreach (Control c in controls)
            {
                float ogSize = Font.Size;
                float adjFontSize = (float)textsizeSelect.Value + Font.Size;
                c.Font = new Font("Century Gothic", adjFontSize);

                /*if (boldnessToggle.Checked)
                {
                    
                    c.Font = new Font("Century Gothic", adjFontSize, FontStyle.Bold);
                }
                else
                {
                    c.Font = new Font("Century Gothic", adjFontSize, FontStyle.Regular);
                }*/
            }
        }
    }
}
