using System;
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
    public partial class TMenu : Form
    {
        public TMenu()
        {
            InitializeComponent();
        }

        private void TMenu_Load(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            bunifuPages2.SetPage("Home");
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            bunifuPages2.SetPage("Request");
        }
    }
}
