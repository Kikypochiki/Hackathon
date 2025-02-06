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

        private void donatePrompt_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button_esc_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            payment payments = new payment();
            payments.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            foodDonation food = new foodDonation();
            food.Show();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
