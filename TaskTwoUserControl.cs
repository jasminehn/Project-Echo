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
    public partial class TaskTwoUserControl : UserControl
    {
        public TaskTwoUserControl()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            //tableLayoutPanel1.RowCount += 1;
            Control[] controls = new Control[2];
            controls[0] = new TextBox { Text = "", Height = 26, Width = 672, Anchor = AnchorStyles.Left, AutoSize = true };
            controls[1] = new CheckBox { Anchor = AnchorStyles.Left, AutoSize = true };
            tableLayoutPanel1.Controls.AddRange(controls);
            //tableLayoutPanel1.Controls.AddRange
            //if((tableLayoutPanel1.Height + 39) < tableLayoutPanel1.MaximumSize.Height)
            tableLayoutPanel1.Height += 39;
            /* TableLayoutRowStyleCollection styles = tableLayoutPanel1.RowStyles;
             foreach(RowStyle style in styles)
             {
                 if(style.SizeType != SizeType.Absolute)
                 {
                     style.SizeType = SizeType.Absolute;
                 }
             }

             foreach(RowStyle sizes in styles)
             {  
                 sizes.Height = 39;
             }*/
            //tableLayoutPanel1.RowStyles(Size)
            //tableLayoutPanel1.RowStyles.Add
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(tableLayoutPanel1.RowCount != 2)
            {
                this.tableLayoutPanel1.RowStyles.RemoveAt(tableLayoutPanel1.RowCount - 1);
                tableLayoutPanel1.RowCount -= 1;
                tableLayoutPanel1.Height -= 39;

                TableLayoutRowStyleCollection styles =
                this.tableLayoutPanel1.RowStyles;

                foreach(RowStyle style in styles)
                {
                    style.SizeType = SizeType.Percent;
                    style.Height = 100 / tableLayoutPanel1.RowCount;
                }
            }
        }
    }
}
