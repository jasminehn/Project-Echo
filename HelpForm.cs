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
using CefSharp.WinForms;
using CefSharp;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

namespace ProjectEcho
{
    public partial class HelpForm : Form
    {        
        static string ProgramPath = AppDomain.CurrentDomain.BaseDirectory; //get direct path to the program        
        string FileName1 = string.Format("{0}PDF\\Requirements.pdf", System.IO.Path.GetFullPath(System.IO.Path.Combine(ProgramPath, @"..\..\"))); //jump back relative to the .exe-Path to the Requirements document path
        string url;
        //static ChromiumWebBrowser = new ChromiumWebBrowser();

        private int focusFlag = 0;


        public HelpForm()
        {
            InitializeComponent();
        }
        ChromiumWebBrowser chrome;

        private void HelpForm_Load(object sender, EventArgs e)
        {
            url = FileName1;
            comboBox2.Visible = false;
            CefSettings settings = new CefSettings();
            Cef.Initialize(settings);
            chrome = new ChromiumWebBrowser(url);
            this.ChromiumBrowser.Controls.Add(chrome);
            chrome.AddressChanged += Chrome_AddressChanged;
        }

        private void Chrome_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                url = e.Address;
            }));
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            /**          
            //manual browser refresh; this is needed in order to actually change the page (this method must be async)
            //webBrowser1.AllowNavigation = true; //i dont think this line is needed but i'm leaving it here for now just in case
            // webBrowser1.Hide(); //hide browser while navigating to new page
            //webBrowser1.Navigate("about:blank");
            await Task.Delay(10);

            //change page depending on selection
            if (comboBox1.SelectedItem.Equals("Task 1") && (comboBox2.SelectedItem.Equals("Part A") || comboBox2.SelectedItem.Equals("Part B") || comboBox2.SelectedItem.Equals("Part C")))
            {
                //webBrowser1.Navigate(new Uri(FileName1 + "#page=1"));
                //webBrowser1.Navigate(FileName1 + "#page=1");
                //webBrowser1.Show();
                url = FileName1 + "#page=1";
                chrome.Load(url);
            }
            else if (comboBox1.SelectedItem.Equals("Task 1") && (comboBox2.SelectedItem.Equals("Part D") || comboBox2.SelectedItem.Equals("Part E")))
            {
                // webBrowser1.Navigate(new Uri(FileName1 + "#page=2"));
                //webBrowser1.Show();
                url = FileName1 + "#page=2";
                chrome.Load(url);
            }
            else if (comboBox1.SelectedItem.Equals("Task 2") && (comboBox2.SelectedItem.Equals("Part A") || comboBox2.SelectedItem.Equals("Part B")))
            {
                //webBrowser1.Navigate(new Uri(FileName1 + "#page=3"));
                //webBrowser1.Show();
                url = FileName1 + "#page=3";
                chrome.Load(url);
                chrome.Refresh();
            }
            else if (comboBox1.SelectedItem.Equals("Task 3") && comboBox2.SelectedItem.Equals("Part A"))
            {
                //webBrowser1.Navigate(new Uri(FileName1 + "#page=4"));
                //webBrowser1.Show();
                url = FileName1 + "#page=4";
                chrome.Load(url);
            }
            else if (comboBox1.SelectedItem.Equals("Task 3") && comboBox2.SelectedItem.Equals("Part B"))
            {
                //webBrowser1.Navigate(new Uri(FileName1 + "#page=5"));
                //webBrowser1.Show();
                url = FileName1 + "#page=5";
                chrome.Load(url);
            }
            else if (comboBox1.SelectedItem.Equals("Task 3") && comboBox2.SelectedItem.Equals("Part C"))
            {
                webBrowser1.Navigate(new Uri(FileName1 + "#page=6"));
                webBrowser1.Show();
                webBrowser1.Show();
                url = FileName1 + "#page=6";
                chrome.Load(url);
            }
            else if (comboBox1.SelectedItem.Equals("Task 3") && (comboBox2.SelectedItem.Equals("Part D") || comboBox2.SelectedItem.Equals("Part E")))
            {
                webBrowser1.Navigate(new Uri(FileName1 + "#page=7"));
                webBrowser1.Show();
                webBrowser1.Show();
                url = FileName1 + "#page=7";
                chrome.Load(url);
            }
            //webBrowser1.Navigate("www.google.com");

            //webBrowser1.Show(); //display browser after navigating to new page
            //Console.WriteLine(webBrowser1.Url.AbsoluteUri); //print current page (for testing)
            */
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //manual browser refresh; this is needed in order to actually change the page (this method must be async)
            //webBrowser1.AllowNavigation = true; //i dont think this line is needed but i'm leaving it here for now just in case
            // webBrowser1.Hide(); //hide browser while navigating to new page
            //webBrowser1.Navigate("about:blank");
            await Task.Delay(10);

            if(comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
            {
                urlBox.Text = "idk why we here but we are";
                // do nothing
            } else
            {
                //change page depending on selection
                if(comboBox1.SelectedItem.Equals("Task 1") && (comboBox2.SelectedItem.Equals("Part A") || comboBox2.SelectedItem.Equals("Part B") || comboBox2.SelectedItem.Equals("Part C")))
                {
                    url = FileName1 + "#page=1";
                    urlBox.Text = url;
                    chrome.Reload();
                    
                }
                else if(comboBox1.SelectedItem.Equals("Task 1") && (comboBox2.SelectedItem.Equals("Part D") || comboBox2.SelectedItem.Equals("Part E")))
                {
                    url = FileName1 + "#page=2";
                    urlBox.Text = url;
                    chrome.Reload();
                }
                else if(comboBox1.SelectedItem.Equals("Task 2") && (comboBox2.SelectedItem.Equals("Part A") || comboBox2.SelectedItem.Equals("Part B")))
                {
                    url = FileName1 + "#page=3";
                    urlBox.Text = url;
                    chrome.Reload();
                }
                else if(comboBox1.SelectedItem.Equals("Task 3") && comboBox2.SelectedItem.Equals("Part A"))
                {
                    url = FileName1 + "#page=4";
                    urlBox.Text = url;
                    chrome.Reload();
                }
                else if(comboBox1.SelectedItem.Equals("Task 3") && comboBox2.SelectedItem.Equals("Part B"))
                {
                    url = FileName1 + "#page=5";
                    urlBox.Text = url;
                    chrome.Reload();
                }
                else if(comboBox1.SelectedItem.Equals("Task 3") && comboBox2.SelectedItem.Equals("Part C"))
                {
                    url = FileName1 + "#page=6";
                    urlBox.Text = url;
                    chrome.Reload();
                }
                else if(comboBox1.SelectedItem.Equals("Task 3") && (comboBox2.SelectedItem.Equals("Part D") || comboBox2.SelectedItem.Equals("Part E")))
                {
                    url = FileName1 + "#page=7";
                    urlBox.Text = url;
                    chrome.Reload();
                }

                chrome.Load(url);
                //webBrowser1.Navigate("www.google.com");

                //webBrowser1.Show(); //display browser after navigating to new page
                //Console.WriteLine(webBrowser1.Url.AbsoluteUri); //print current page (for testing)
            }


        }

        private void HelpForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            } else
            {
                //Cef.Shutdown();
            }
        }               

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBox1.Text.Length <= 0)
            {
                //this will clear all search result
                chrome.StopFinding(true);
            }
            else
            {
                chrome.Find(0, textBox1.Text, true, false, false);
            }
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            chrome.Find(1, textBox1.Text, false, false, true);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            chrome.Find(1, textBox1.Text, true, false, true);
        }

        private void HelpForm_MouseEnter(object sender, EventArgs e)
        {
            if (focusFlag < 1)
            {
                this.Focus();
                ++focusFlag;
            }
        }
    }
}
