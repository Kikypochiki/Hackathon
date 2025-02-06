using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackathon
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            dashboard home = new dashboard();
            guna2Panel2.Controls.Clear();
            guna2Panel2.Controls.Add(home);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button_home_Click(object sender, EventArgs e)
        {
            dashboard home= new dashboard();
            guna2Panel2.Controls.Clear();
            guna2Panel2.Controls.Add(home);
        }

        private void guna2Button_foodhub_Click(object sender, EventArgs e)
        {
            foodHub fh = new foodHub();
            guna2Panel2.Controls.Clear();
            guna2Panel2.Controls.Add(fh);
        }

        private void guna2Button_aboutus_Click(object sender, EventArgs e)
        {

        }
    }
}
