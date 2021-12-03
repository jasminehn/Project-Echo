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