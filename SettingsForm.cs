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
        int textSizeOffset = 0; //keeps track of how much the text size has changed

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            //Applies user settings upon loading
            textSizeOffset = Properties.Settings.Default.textsize; //sets offset to saved value
            //Console.WriteLine("offset:"+textSizeOffset); //print offsetat start for texting
            //Console.WriteLine(Properties.Settings.Default.textsize);
            textsizeAdjust.Value = Properties.Settings.Default.textsize; //sets slider to saved value

            //changes text size to current saved value
            var controls = getAll(this, typeof(Label));
            foreach (Control c in controls)
            {
                FontFamily fon = Font.FontFamily; //Sets font family 
                FontStyle sty = c.Font.Style; //Sets style (ie. bold, italic, reg)
                float adjSize = c.Font.Size + textSizeOffset;

                c.Font = new Font(fon, adjSize, sty); //Passes in family, style, new size
            }
            
        }

       public IEnumerable<Control> getAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();
            return controls.SelectMany(ctrl => getAll(ctrl, type)).Concat(controls).Where(c => c.GetType() == type);
        }

        float prev = 0;

        private void textsizeAdjust_Scroll(object sender, EventArgs e)
        {
            
            var controls = getAll(this, typeof(Label)); //Finds all labels
            
            float curr = textsizeAdjust.Value; // gets current font size

            //Checks if the slider val is getting larger or smaller
            if (prev < curr)
            {
                foreach (Control c in controls) //Changes every label indivdually
                {
                    FontFamily fon = Font.FontFamily; //Sets font family 
                    FontStyle sty = c.Font.Style; //Sets style (ie. bold, italic, reg)
                    float adjSize = c.Font.Size + 1;

                    //Passes in family, style, and changes to new size
                    c.Font = new Font(fon, adjSize, sty);
                }
                //textSizeOffset = textSizeOffset + 1; //increases offset
                prev = curr; //Sets prev to current size for next interation
            }
            else
            {
                //If the slider is set back down to 0, it subtracts 1 instead of 0
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
                        float adjSize = c.Font.Size - 1;

                        c.Font = new Font(fon, adjSize, sty);
                    }
                }
                prev = curr;
            }
            textSizeOffset = textsizeAdjust.Value;

        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            string warning = "Settings will be saved and appliaction will restart. Are you sure you would like to continue?";

            if (MessageBox.Show(warning, "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Properties.Settings.Default.textsize = textSizeOffset;
                Properties.Settings.Default.Save();

                Environment.Exit(0);
            }
            else
            {
                this.Close();
            }

            
        }

        private void textsizeAdjust_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void SettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //MainForm.ActiveForm MainForm_Load
        }
    }
}
