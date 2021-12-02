using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

namespace ProjectEcho
{


    class InterfaceHandler
    {
        public IEnumerable<Control> getAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();
            return controls.SelectMany(ctrl => getAll(ctrl, type)).Concat(controls).Where(c => c.GetType() == type);
        }

        /*
        public void toggleBoldness(bool settingOn, Control inputForm)
        {
            var labels = getAll(inputForm, typeof(Label)); //Finds all labels
            var checkLists = getAll(inputForm, typeof(CheckedListBox)); //Finds all labels

            //Checks boldness toggles
            if (settingOn) //ON
            {
                foreach (Label c in labels) //Changes every label indivdually
                {
                    FontFamily fam = c.Font.FontFamily; //Sets current font style
                    float s = c.Font.Size; //Sets current font size

                    //Passes in font style, size and changes to bold
                    c.Font = new System.Drawing.Font(fam, s, FontStyle.Bold);
                }

                foreach (CheckedListBox t in checkLists) //Changes every label indivdually
                {
                    FontFamily fam = t.Font.FontFamily; //Sets current font style
                    float s = t.Font.Size; //Sets current font size

                    //Passes in font style, size and changes to bold
                    t.Font = new System.Drawing.Font(fam, s, FontStyle.Bold);
                }

            }
            else //OFF
            {
                foreach (Label c in labels)
                {
                    FontFamily fam = c.Font.FontFamily;
                    float s = c.Font.Size;

                    c.Font = new System.Drawing.Font(fam, s, FontStyle.Regular);
                }

                foreach (CheckedListBox t in checkLists)
                {
                    FontFamily fam = t.Font.FontFamily;
                    float s = t.Font.Size;

                    t.Font = new System.Drawing.Font(fam, s, FontStyle.Bold);
                }
            }
        }
        */

        public void toggleBoldness(bool settingOn, Control inputForm)
        {


            var controls = getAll(inputForm, typeof(Label)); //Finds all labels
            var textthings = getAll(inputForm, typeof(CheckedListBox)); //Finds all labels

            //Checks boldness toggles
            if (settingOn) //ON
            {
                //inputForm.Font = new System.Drawing.Font("Century Gothic", 12, FontStyle.Bold);
                inputForm.Font = new System.Drawing.Font(inputForm.Font, FontStyle.Regular);

                foreach (Label l in controls) //Changes every label indivdually
                {
                    FontFamily fam = l.Font.FontFamily; //Sets current font style
                    float s = l.Font.Size; //Sets current font size

                    //Passes in font style, size and changes to bold
                    l.Font = new System.Drawing.Font(fam, s, FontStyle.Bold);
                }

                foreach (CheckedListBox c in textthings) //Changes every label indivdually
                {
                    FontFamily fam = c.Font.FontFamily; //Sets current font style
                    float s = c.Font.Size; //Sets current font size

                    //Passes in font style, size and changes to bold
                    c.Font = new System.Drawing.Font(fam, s, FontStyle.Bold);
                }

            }
            else //OFF
            {
                foreach (Control c in controls)
                {
                    FontFamily fam = c.Font.FontFamily;
                    float s = c.Font.Size;

                    c.Font = new System.Drawing.Font(fam, s, FontStyle.Regular);
                }
            }

        }
        public void toggleDarkMode(bool settingOn, Control inputForm)
        {
            //Checks boldness toggles
            if (settingOn) //ON
            {
                inputForm.BackColor = Color.Black;
                inputForm.ForeColor = Color.White;
                
            }
            else
            {
                inputForm.BackColor = Color.White;
                inputForm.ForeColor = Color.Black;
            }

        }

        public void adjustTextSize(int amount, Control inputForm)
        {
            var controls = getAll(inputForm, typeof(Label));
            var textthings = getAll(inputForm, typeof(CheckedListBox));

            foreach (Control c in controls)
            {
                FontFamily fam = c.Font.FontFamily;
                float s = c.Font.Size;
                float adjustTextSize = s + Properties.Settings.Default.textsize;

                c.Font = new System.Drawing.Font(fam, s);
            }

            foreach (Control t in textthings)
            {
                FontFamily fam = t.Font.FontFamily;
                float s = t.Font.Size;
                float adjustTextSize = s + Properties.Settings.Default.textsize;

                t.Font = new System.Drawing.Font(fam, s);
            }

        }
    }
}