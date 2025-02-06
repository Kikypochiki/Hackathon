using Guna.UI2.HtmlRenderer.Adapters;
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
            showMap();
        }

        private async void showMap()
        {
            StringBuilder address = new StringBuilder();
            address.Append("https://www.google.com/maps/place/Baybay+City,+Leyte");

            await webView21.EnsureCoreWebView2Async();
            webView21.Source = new Uri(address.ToString());
        }

        private void foodDonation_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button_esc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button_CONFIRM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for your donation!");
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
