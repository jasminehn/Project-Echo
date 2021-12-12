using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
namespace ProjectEcho
{
    /**
     *
     *
     *
     * Author(s): J. Nelson, I. Gnagy
     */

    public partial class TaskThreeUserControl : UserControl
    {
        private DocumentHandler dh = new DocumentHandler();
        private FormatChecker fc = new FormatChecker();

        private Label l1;
        private Label l2;
        private Label l3;
        private Label l4;
        private Label l5;
        private Label l6;
        private Label l7;

        int textSizeOffset = 0;
        SettingsHandler settingsHandler = new SettingsHandler();

        public TaskThreeUserControl()
        {
            InitializeComponent();
        }

        private void TaskThreeUserControl_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = Properties.Settings.Default.t3notes; //load last saved notes

            //Apply saved display settings
            textSizeOffset = Properties.Settings.Default.textsize; //sets offset to saved value
            var labels = settingsHandler.getAll(this, typeof(Label));
            foreach (Control c in labels)
            {
                System.Drawing.FontFamily fon = Font.FontFamily; //Sets font family
                FontStyle sty = c.Font.Style; //Sets style (ie. bold, italic, reg)
                float adjSize = c.Font.Size + textSizeOffset;

                c.Font = new Font(fon, adjSize, sty); //Passes in family, style, new size
            }
            var checkedlistboxes = settingsHandler.getAll(this, typeof(CheckedListBox));
            foreach (Control c in checkedlistboxes)
            {
                System.Drawing.FontFamily fon = Font.FontFamily; //Sets font family
                FontStyle sty = c.Font.Style; //Sets style (ie. bold, italic, reg)
                float adjSize = c.Font.Size + textSizeOffset;

                c.Font = new Font(fon, adjSize, sty); //Passes in family, style, new size
            }
            var tabs = settingsHandler.getAll(this, typeof(TabPage));
            foreach (Control c in tabs)
            {
                c.BackColor = Properties.Settings.Default.bgcolor;
                c.ForeColor = Properties.Settings.Default.fcolor;
            }
            Panel[] panels = new Panel[] { panel1, panel4, panel17, panel6, panel38, panel51, panel35, panel19, panel23, panel9 };
            foreach (Control c in panels)
            {
                c.BackColor = Properties.Settings.Default.bgcolor;
                c.ForeColor = Properties.Settings.Default.fcolor;
            }
        }

        private void UploadButton3A1_Click(object sender, EventArgs e)
        {

        }

        private void UploadButton3A2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //save notes as they type
            Properties.Settings.Default.t3notes = richTextBox1.Text;
            Properties.Settings.Default.Save();
        }

    }
}
