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
    public partial class passengerReser : Form
    {
        public passengerReser()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            this.Hide();
            loginPage.Show();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            passengerDashboard passengerDashboard = new passengerDashboard();
            this.Hide();
            passengerDashboard.Show();
        }

        private void showReserBtn_Click(object sender, EventArgs e)
        {
            paymentForm paymentForm = new paymentForm();
            this.Hide();
            paymentForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
