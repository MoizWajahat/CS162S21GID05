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
    public partial class GuestMenu : Form
    {
        public GuestMenu()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            bunifuPages2.SetPage("Request");
        }

        private void bunifuButton7_Click(object sender, EventArgs e)
        {
            bunifuPages2.SetPage("addTrainer");
        }

        private void tabPage8_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            bunifuPages2.SetPage("Home");
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            bunifuPages2.SetPage("Store");
        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
            bunifuPages2.SetPage("addCoustomer");
        }
    }
}
