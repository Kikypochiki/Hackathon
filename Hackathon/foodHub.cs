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
    public partial class foodHub : UserControl
    {
        public foodHub()
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


        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}


