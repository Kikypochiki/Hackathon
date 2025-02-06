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
    public partial class foodDonation : Form
    {
        public foodDonation()
        {
            InitializeComponent();
        }

        private void foodDonation_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button_esc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for your donation!");
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
