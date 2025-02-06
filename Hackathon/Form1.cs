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
        private Guna.UI2.WinForms.Guna2Button activeButton;

        public Home()
        {
            InitializeComponent();
            dashboard home = new dashboard();
            guna2Panel2.Controls.Clear();
            guna2Panel2.Controls.Add(home);
            SetActiveButton(guna2Button_home);
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
            dashboard home = new dashboard();
            guna2Panel2.Controls.Clear();
            guna2Panel2.Controls.Add(home);
            SetActiveButton(guna2Button_home);
        }

        private void guna2Button_foodhub_Click(object sender, EventArgs e)
        {
            foodHub fh = new foodHub();
            guna2Panel2.Controls.Clear();
            guna2Panel2.Controls.Add(fh);
            SetActiveButton(guna2Button_foodhub);
        }

        private void guna2Button_aboutus_Click(object sender, EventArgs e)
        {
            aboutUs about = new aboutUs();
            guna2Panel2.Controls.Clear();
            guna2Panel2.Controls.Add(about);
            SetActiveButton(guna2Button_aboutus);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            donatePrompt prompt = new donatePrompt();
            prompt.Show();
        }

        private void SetActiveButton(Guna.UI2.WinForms.Guna2Button button)
        {
            if (activeButton != null)
            {
                // Reset the previous active button's color
                activeButton.FillColor = Color.FromArgb(52, 62, 25);
                activeButton.ForeColor = Color.White;
            }

            // Set the new active button's color
            activeButton = button;
            activeButton.FillColor = Color.FromArgb(255, 230, 230, 230);
            activeButton.ForeColor = Color.FromArgb(52, 62, 35);
        }
    }
}
