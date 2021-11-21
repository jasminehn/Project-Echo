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
            tableLayoutPanel1.RowCount += 1;
            tableLayoutPanel1.Height += 39;

            TableLayoutRowStyleCollection styles = this.tableLayoutPanel1.RowStyles;

            foreach(RowStyle style in styles)
            {
                style.SizeType = SizeType.Absolute;
                //style.Height = 39;
            }

            //tableLayoutPanel1.RowStyles(Size)
            //tableLayoutPanel1.RowStyles.Add
            //tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(SizeType.Absolute, 20))
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(tableLayoutPanel1.RowCount != 1)
            {
                tableLayoutPanel1.RowCount -= 1;
                tableLayoutPanel1.Height -= 39;

                TableLayoutRowStyleCollection styles =
                this.tableLayoutPanel1.RowStyles;

                foreach(RowStyle style in styles)
                {
                    style.SizeType = SizeType.Percent;
                    style.Height = 100 / tableLayoutPanel1.RowCount;
                }
                //tableLayoutPanel1.Size();
            }
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }
    }
}
