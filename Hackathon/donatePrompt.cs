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
    public partial class donatePrompt : Form
    {
        public donatePrompt()
        {
            InitializeComponent();
        }

        private void guna2Button_esc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button_food_Click(object sender, EventArgs e)
        {
            foodDonation food = new foodDonation();
            food.Show();
        }

        private void guna2Button_money_Click(object sender, EventArgs e)
        {
            payment payments = new payment();
            payments.Show(); 
        }
    }
}
