using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainReservationSystem
{
    public partial class paymentForm : Form
    {
        public paymentForm()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int ticketCount = (int)numericUpDown1.Value;

            // Clear previous fields
            flowLayoutPanel1.Controls.Clear();

            // Dynamically add fields for each passenger
            for (int i = 1; i <= ticketCount; i++)
            {
                // Create and configure controls
                Label lblName = new Label
                {
                    Text = $"Passenger {i} Name:",
                    AutoSize = true
                };
                TextBox txtName = new TextBox
                {
                    Name = $"txtPassengerName{i}",
                    Width = 450
                };

                Label lblAge = new Label
                {
                    Text = $"Passenger {i} Age:",
                    AutoSize = true
                };
                TextBox txtAge = new TextBox
                {
                    Name = $"txtPassengerAge{i}",
                    Width = 100
                };

                // Add controls to the panel
                flowLayoutPanel1.Controls.Add(lblName);
                flowLayoutPanel1.Controls.Add(txtName);
                flowLayoutPanel1.Controls.Add(lblAge);
                flowLayoutPanel1.Controls.Add(txtAge);
            }
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            passengerDashboard passengerDashboard = new passengerDashboard();
            this.Hide();
            passengerDashboard.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            this.Hide();
            loginPage.Show();
        }
    }
}
