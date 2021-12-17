using CefSharp;
using CefSharp.WinForms;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectEcho
{
    /**
     * The HelpForm was made to help lead students to the best pre-existing edTPA documentation
     * to assist them in their submission. Using a Chromium Browser, we display locally stored
     * .pdf files and direct them to the correct page of the document using combo boxes.
     *
     * There is definitely room to add more documentation here, but for now, we are using
     * only one edTPA document.
     *
     * Authors: J. Nelson, C. Segrue
     */

    public partial class HelpForm : Form
    {
        private readonly static string ProgramPath = AppDomain.CurrentDomain.BaseDirectory; //get direct path to the program
        private readonly string FileName1 = string.Format("{0}PDF\\Requirements.pdf", System.IO.Path.GetFullPath(System.IO.Path.Combine(ProgramPath, @"..\..\"))); //jump back relative to the .exe-Path to the Requirements document path
        private readonly string FileName2 = string.Format("{0}PDF\\MakingGoodChoices.pdf", System.IO.Path.GetFullPath(System.IO.Path.Combine(ProgramPath, @"..\..\")));
        private string url;
        //static ChromiumWebBrowser = new ChromiumWebBrowser();

        private int focusFlag = 0;

        SettingsHandler settingsHandler = new SettingsHandler();
        private int textSizeOffset = 0; //keeps track of how much the text size has changed     

        public HelpForm()
        {
            InitializeComponent();
        }

        private ChromiumWebBrowser chrome;

        private void HelpForm_Load(object sender, EventArgs e)
        {
            //Apply saved display settings
            textSizeOffset = Properties.Settings.Default.textsize; //sets offset to saved value
            var controls = settingsHandler.getAll(this, typeof(Label));
            foreach (Control c in controls)
            {
                FontFamily fon = Font.FontFamily; //Sets font family
                FontStyle sty = c.Font.Style; //Sets style (ie. bold, italic, reg)
                float adjSize = c.Font.Size + textSizeOffset;
                c.Font = new Font(fon, adjSize, sty); //Passes in family, style, new size
            }


            if (MainForm.pdfIndex == 0)
            {
                url = FileName1;

                Console.WriteLine("CLARE:: entered if 1" + MainForm.pdfIndex);
            }
            else if (MainForm.pdfIndex == 1)
            {
                url = FileName2;
                Console.WriteLine("CLARE:: entered else if 2" + url);
            }

            urlBox.Text = url;
            partComboBox.Enabled = false;
            CefSettings helpBrowser = new CefSettings();
            Cef.Initialize(helpBrowser);
            Cef.EnableHighDPISupport(); // One some computers, mostly laptops, the Browser will jutt out to the
                                        // right and a little down. This line
                                        // has fixed our issue as far as we can tell.
            chrome = new ChromiumWebBrowser(url); // Currently we only have one file that we are displaying to users.
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
                partComboBox.Enabled = true;
            }
            else
            {
                partComboBox.Enabled = false;
            }

            string[] task1 = { "Part A", "Part B", "Part C", "Part D", "Part E" };
            string[] task2 = { "Part A", "Part B" };
            string[] task3 = { "Part A", "Part B", "Part C", "Part D", "Part E" };
            if (comboBox1.SelectedItem.Equals("Task 1"))
            {
                partComboBox.Text = " "; //set current task part to blank so the user will choose one when they switch tasks
                partComboBox.Items.Clear();
                partComboBox.Items.AddRange(task1);
            }
            else if (comboBox1.SelectedItem.Equals("Task 2"))
            {
                partComboBox.Text = " ";
                partComboBox.Items.Clear();
                partComboBox.Items.AddRange(task2);
            }
            else
            {
                partComboBox.Text = " ";
                partComboBox.Items.Clear();
                partComboBox.Items.AddRange(task3);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Does nothing
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await Task.Delay(10); // Do we still need a delay?

            if (pdfComboBox.SelectedIndex == 0)
            {
                //change page depending on selection
                if (comboBox1.SelectedItem.Equals("Task 1") && (partComboBox.SelectedItem.Equals("Part A") || partComboBox.SelectedItem.Equals("Part B") || partComboBox.SelectedItem.Equals("Part C")))
                {
                    url = FileName1 + "#page=1";
                    urlBox.Text = url;
                    chrome.Reload();
                }
                else if (comboBox1.SelectedItem.Equals("Task 1") && (partComboBox.SelectedItem.Equals("Part D") || partComboBox.SelectedItem.Equals("Part E")))
                {
                    url = FileName1 + "#page=2";
                    urlBox.Text = url;
                    chrome.Reload();
                }
                else if (comboBox1.SelectedItem.Equals("Task 2") && (partComboBox.SelectedItem.Equals("Part A") || partComboBox.SelectedItem.Equals("Part B")))
                {
                    url = FileName1 + "#page=3";
                    urlBox.Text = url;
                    chrome.Reload();
                }
                else if (comboBox1.SelectedItem.Equals("Task 3") && partComboBox.SelectedItem.Equals("Part A"))
                {
                    url = FileName1 + "#page=4";
                    urlBox.Text = url;
                    chrome.Reload();
                }
                else if (comboBox1.SelectedItem.Equals("Task 3") && partComboBox.SelectedItem.Equals("Part B"))
                {
                    url = FileName1 + "#page=5";
                    urlBox.Text = url;
                    chrome.Reload();
                }
                else if (comboBox1.SelectedItem.Equals("Task 3") && partComboBox.SelectedItem.Equals("Part C"))
                {
                    url = FileName1 + "#page=6";
                    urlBox.Text = url;
                    chrome.Reload();
                }
                else if (comboBox1.SelectedItem.Equals("Task 3") && (partComboBox.SelectedItem.Equals("Part D") || partComboBox.SelectedItem.Equals("Part E")))
                {
                    url = FileName1 + "#page=7";
                    urlBox.Text = url;
                    chrome.Reload();
                }

            }
            else if (pdfComboBox.SelectedIndex == 1)
            {
                //change page depending on selection
                if (comboBox1.SelectedItem.Equals("Task 1"))
                {
                    url = FileName2 + "#page=9";
                    //urlBox.Text = url;

                }
                else if (comboBox1.SelectedItem.Equals("Task 2"))
                {
                    url = FileName2 + "#page=18";
                    //urlBox.Text = url;

                }
                else if (comboBox1.SelectedItem.Equals("Task 3"))
                {
                    url = FileName2 + "#page=27";
                    //urlBox.Text = url;
                    //chrome.Reload();
                }
                urlBox.Text = url;
                chrome.Reload();

            }
            //chrome.Load(url);
        }

        private void HelpForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
            else
            {
                // Normally we would do the following line of code, but since we
                // want the user to be able to open the HelpForm more than once
                // per run, we do nothin.

                // Cef.Shutdown();
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

        private void pdfComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pdfComboBox.SelectedIndex == 0)
            {
                partComboBox.Enabled = true;
                url = FileName1;
            }
            else if (pdfComboBox.SelectedIndex == 1)
            {
                partComboBox.Enabled = false;
                url = FileName2;
            }
            urlBox.Text = url;
            chrome.Reload();
        }

        private void HelpForm_VisibleChanged(object sender, EventArgs e)
        {
            //if()

        }
    }
}