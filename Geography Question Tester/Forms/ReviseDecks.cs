﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geography_Question_Tester.Forms
{
    public partial class ReviseDecks : Form
    {
        public ReviseDecks()
        {
            InitializeComponent();
            this.loggedinbtn.Text = MainMenu.CurrentStudent.Fname;
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            LoginMenu.BackStack.Pop().Show();
            this.Hide();
        }
    }
}
