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
    public partial class dashboard : UserControl
    {
        public dashboard()
        {
            InitializeComponent();
            dashboard_Load();
           setText();

        }

        public void dashboard_Load()
        {
            Database db = new Database();
            List<Info> infos = db.fetchData();
            foreach (Info info in infos)
            {
                label4.Text = "₱" + info.moneyRaised.ToString();
                label8.Text = info.mealsProvided.ToString();
                label9.Text = info.familiesHelped.ToString();
            }
        }

        private void setText()
        {
            Database db = new Database();
            List<Info> infos = db.fetchData();
            family.Text = infos[0].familiesHelped.ToString();
            meal.Text = infos[0].mealsProvided.ToString();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button_donatenow_Click(object sender, EventArgs e)
        {
            donatePrompt prompt = new donatePrompt();
            prompt.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton8_Click(object sender, EventArgs e)
        {

        }
    }
}
