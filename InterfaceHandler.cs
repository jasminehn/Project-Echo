using System;
using System.Collections.Generic;
using System.Linq;
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

        public void toggleBoldness(bool settingOn, Form inputForm)
        {


            var controls = getAll(inputForm, typeof(Label)); //Finds all labels
            var textthings = getAll(inputForm, typeof(CheckedListBox)); //Finds all labels

            //Checks boldness toggles
            if (settingOn) //ON
            {
                //inputForm.Font = new System.Drawing.Font("Century Gothic", 12, FontStyle.Bold);
                inputForm.Font = new System.Drawing.Font(inputForm.Font, FontStyle.Regular);

                foreach (Control c in controls) //Changes every label indivdually
                {
                    FontFamily fam = c.Font.FontFamily; //Sets current font style
                    float s = c.Font.Size; //Sets current font size

                    //Passes in font style, size and changes to bold
                    c.Font = new System.Drawing.Font(fam, s, FontStyle.Bold);
                }

                foreach (Control t in textthings) //Changes every label indivdually
                {
                    FontFamily fam = t.Font.FontFamily; //Sets current font style
                    float s = t.Font.Size; //Sets current font size

                    //Passes in font style, size and changes to bold
                    t.Font = new System.Drawing.Font(fam, s, FontStyle.Bold);
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
    }
}
