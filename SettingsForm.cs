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
            textsizeSelect.Value = (decimal)label1.Font.Size;
        }

        private void switchButton_Click(object sender, EventArgs e)
        {
            switchOnOff(darkModeSwitch);
            if (on)
            {
                BackColor = System.Drawing.Color.White;
                textsizeSelect.BackColor = Color.White;
                ForeColor = System.Drawing.Color.Black;
                on = true;
            }
            else
            {
                BackColor = System.Drawing.Color.Black;
                textsizeSelect.BackColor = Color.Black;
                textsizeSelect.ForeColor = Color.White;
                ForeColor = System.Drawing.Color.White;
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
            switchOnOff(blueyellowSwitch);
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
            switchOnOff(redgreenSwitch);
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
            switchOnOff(boldSwitch);
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
            //TODO: Currently only changes text size of buttons
        }

        private void textsizeSelect_SelectedItemChanged(object sender, EventArgs e)
        {
            Font = new Font("Microsoft Sans Serif", (float)textsizeSelect.Value);  
            //TODO: Currently only changes text size of buttons            

            var controls = getAll(this, typeof(Label));
            foreach (Control c in controls)
            {
                //Console.WriteLine(c.ToString()); //print name of each label (for testing)
                c.Font = new Font("Microsoft Sans Serif", (float)textsizeSelect.Value);
            }
        }

        //returns list of all labels
        public IEnumerable<Control> getAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();
            return controls.SelectMany(ctrl => getAll(ctrl, type)).Concat(controls).Where(c => c.GetType() == type);
        }

    }
}
