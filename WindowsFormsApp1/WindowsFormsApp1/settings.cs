﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Program.f1.Visible = true;
            this.Close();
            //button_back.DialogResult = DialogResult.OK;
            //Application.Exit();
        }
    }
}
