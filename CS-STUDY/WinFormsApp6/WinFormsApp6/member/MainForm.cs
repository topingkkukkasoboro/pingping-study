﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp6.member
{

    public partial class MainForm : Form
    {
        public MainForm(String id, String password)
        {
            InitializeComponent();

            label1.Text = id;
            label2.Text = password;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl11.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userControl11.BringToFront();
        }
    }
}
