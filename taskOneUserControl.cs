﻿using System;
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
    public partial class taskOneUserControl : UserControl
    {
        public taskOneUserControl()
        {
            InitializeComponent();
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            String path = FileHandler.OpenFile();


            
        }
    }
}
