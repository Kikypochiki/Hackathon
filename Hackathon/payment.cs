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
    public partial class payment : Form
    {
        public payment()
        {
            InitializeComponent();
        }

        private void guna2TextBox_holdername_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button_esc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for your donation!");
            this.Close();
        }
    }
}
