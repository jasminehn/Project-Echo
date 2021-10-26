using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProjectEcho
{
    public partial class HelpForm : Form
    {        
        static string ProgramPath = AppDomain.CurrentDomain.BaseDirectory; //get direct path to the program        
        string FileName1 = string.Format("{0}PDF\\Requirements.pdf", Path.GetFullPath(Path.Combine(ProgramPath, @"..\..\"))); //jump back relative to the .exe-Path to the Requirements document path

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
            string[] task3 = { "Part A", "Part B", "Part C", "Part D", "Part E" };
            if (comboBox1.SelectedItem.Equals("Task 1"))
            {
                comboBox2.Text = " "; //set current task part to blank so the user will choose one when they switch tasks
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(task1);
            }
            else if (comboBox1.SelectedItem.Equals("Task 2"))
            {
                comboBox2.Text = " ";
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(task2);
            }
            else
            {
                comboBox2.Text = " ";
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(task3);
            }
            
        }

        private async void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //manual browser refresh; this is needed in order to actually change the page (this method must be async)
            //webBrowser1.AllowNavigation = true; //i dont think this line is needed but i'm leaving it here for now just in case
            webBrowser1.Hide(); //hide browser while navigating to new page
            webBrowser1.Navigate("about:blank");
            await Task.Delay(10);

            //change page depending on selection
            if (comboBox1.SelectedItem.Equals("Task 1") && (comboBox2.SelectedItem.Equals("Part A") || comboBox2.SelectedItem.Equals("Part B") || comboBox2.SelectedItem.Equals("Part C")))
            {
                webBrowser1.Navigate(new Uri(FileName1 + "#page=1"));
            }
            else if (comboBox1.SelectedItem.Equals("Task 1") && (comboBox2.SelectedItem.Equals("Part D") || comboBox2.SelectedItem.Equals("Part E")))
            {
                webBrowser1.Navigate(new Uri(FileName1 + "#page=2"));
            }
            else if (comboBox1.SelectedItem.Equals("Task 2") && (comboBox2.SelectedItem.Equals("Part A") || comboBox2.SelectedItem.Equals("Part B")))
            {
                webBrowser1.Navigate(new Uri(FileName1 + "#page=3"));
            }
            else if (comboBox1.SelectedItem.Equals("Task 3") && comboBox2.SelectedItem.Equals("Part A"))
            {
                webBrowser1.Navigate(new Uri(FileName1 + "#page=4"));
            }
            else if (comboBox1.SelectedItem.Equals("Task 3") && comboBox2.SelectedItem.Equals("Part B"))
            {
                webBrowser1.Navigate(new Uri(FileName1 + "#page=5"));
            }
            else if (comboBox1.SelectedItem.Equals("Task 3") && comboBox2.SelectedItem.Equals("Part C"))
            {
                webBrowser1.Navigate(new Uri(FileName1 + "#page=6"));
            }
            else if (comboBox1.SelectedItem.Equals("Task 3") && (comboBox2.SelectedItem.Equals("Part D") || comboBox2.SelectedItem.Equals("Part E")))
            {
                webBrowser1.Navigate(new Uri(FileName1 + "#page=7"));
            }

            webBrowser1.Show(); //display browser after navigating to new page
            //Console.WriteLine(webBrowser1.Url.AbsoluteUri); //print current page (for testing)
        }

        
    }
}
