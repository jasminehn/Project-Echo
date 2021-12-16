using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ProjectEcho
{
    class SettingsHandler
    {
        //Returns an IEnumerable of all controls of a specified type from a given panel
        public IEnumerable<Control> getAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();
            return controls.SelectMany(ctrl => getAll(ctrl, type)).Concat(controls).Where(c => c.GetType() == type);
        }

        //Returns an IEnumerable of all controls from a given panel
        public IEnumerable<Control> getAllControls(Control container)
        {
            List<Control> controlList = new List<Control>();
            foreach (Control c in container.Controls)
            {
                controlList.AddRange(getAllControls(c));
                controlList.Add(c);
            }
            return controlList;
        }

    }
}
