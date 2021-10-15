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
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HelpForm_Load(object sender, EventArgs e)
        {
            comboBox2.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        //Once task box is clicked
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                comboBox2.Visible = true;
            }
            else
            {
                comboBox2.Visible = false;
            }

            string[] task1 = { "Part A", "Part B", "Part C", "Part D", "Part E" };
            string[] task2 = { "Part A", "Part B"};
            string[] task3 = { "Part A", "Part B", "Part C" };
            if (comboBox1.SelectedItem.Equals("Task 1"))
            {
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(task1);
            }
            else if (comboBox1.SelectedItem.Equals("Task 2"))
            {
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(task2);
            }
            else
            {
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(task3);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
