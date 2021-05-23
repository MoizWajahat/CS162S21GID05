using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShowMessage;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Issuetxt.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            
            if (Usernametxt.Text == "Admin")
            {
                Form2 d = new Form2();
                d.Show();
                this.Hide();

            } else if (Usernametxt.Text == "Customer")
            {
                CustomerMenu m = new CustomerMenu();
                m.Show();
                this.Hide();

            } 
            else if (Usernametxt.Text == "")
            {
                this.Issuetxt.Show();
            }
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {
            GuestMenu M = new GuestMenu();
            M.Show();
            this.Hide();
        }
    }
}
