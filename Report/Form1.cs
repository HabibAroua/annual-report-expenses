﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Report
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btClick_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
