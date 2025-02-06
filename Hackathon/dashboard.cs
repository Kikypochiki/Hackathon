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
        private Timer updateTimer;
        private Database db;
        private List<Info> infos;

        public dashboard()
        {
            InitializeComponent();
            db = new Database();
            infos = db.fetchData();
            dashboard_Load();
            setText();
            InitializeTimer();
        }

        public void dashboard_Load()
        {
            UpdateLabels();
        }

        private void setText()
        {
            family.Text = infos[0].familiesHelped.ToString();
            meal.Text = infos[0].mealsProvided.ToString();
        }

        private void InitializeTimer()
        {
            updateTimer = new Timer();
            updateTimer.Interval = 5000; // Set the interval to 5 seconds
            updateTimer.Tick += new EventHandler(UpdateInfo);
            updateTimer.Start();
        }

        private void UpdateInfo(object sender, EventArgs e)
        {
            // Increment the values
            infos[0].moneyRaised += 100; // Increment moneyRaised by 100
            infos[0].mealsProvided += 10; // Increment mealsProvided by 10
            infos[0].familiesHelped += 5; // Increment familiesHelped by 5

            // Update the labels
            UpdateLabels();
        }

        private void UpdateLabels()
        {
            label4.Text = "₱" + infos[0].moneyRaised.ToString();
            label8.Text = infos[0].mealsProvided.ToString();
            label9.Text = infos[0].familiesHelped.ToString();
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

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

