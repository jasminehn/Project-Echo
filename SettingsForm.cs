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

        private void switchOnOff(Button button)
        {
            if (on)
            {
                button.Text = "ON";
                button.BackColor = Color.LimeGreen;
                on = false;
            }
            else
            {
                button.Text = "OFF";
                button.BackColor = Color.DarkGray;
                on = true;
            }
        }

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            darkModeSwitch.Text = "OFF";
            invertedSwitch.Text = "OFF";
            grayscaleSwitch.Text = "OFF";
            blueyellowSwitch.Text = "OFF";
            redgreenSwitch.Text = "OFF";
            boldSwitch.Text = "OFF";
            textsizeSlider.Value = (int)label1.Font.Size;
        }

        private void switchButton_Click(object sender, EventArgs e)
        {
            switchOnOff(darkModeSwitch);
            if (on)
            {
                BackColor = System.Drawing.Color.White;
                textsizeSlider.BackColor = Color.White;
                label4.ForeColor = System.Drawing.Color.Black;
                on = true;
            }
            else
            {
                BackColor = System.Drawing.Color.Black;
                textsizeSlider.BackColor = Color.Black;
                label4.ForeColor = System.Drawing.Color.White;
                on = false;
            }
        }

        private void invertedSwitch_Click(object sender, EventArgs e)
        {
            switchOnOff(invertedSwitch);
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
            switchOnOff(grayscaleSwitch);
        }

        private void blueyellowSwitch_Click(object sender, EventArgs e)
        {
            switchOnOff(blueyellowSwitch);
        }

        private void redgreenSwitch_Click(object sender, EventArgs e)
        {
            switchOnOff(redgreenSwitch);
        }

        private void textsizeSlider_Scroll(object sender, EventArgs e)
        {
            
            label1.Font = new Font(label1.Font.FontFamily, textsizeSlider.Value);
            
        }

        private void boldSwitch_Click(object sender, EventArgs e)
        {
            switchOnOff(boldSwitch);
            if (on)
            {
                //So far this only changes the font of the buttons
                Font = new System.Drawing.Font(Font, FontStyle.Regular);
                on = true;
            }
            else
            {
                //So far this only changes the font of the buttons
                Font = new System.Drawing.Font(Font, FontStyle.Bold);
                on = false;
            }
        }
    }
}
