using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace TrainReservationSystem
{
    public partial class passengerReser : Form
    {
        public passengerReser()
        {
            InitializeComponent();
        }

        private void LoadReservations()
        {
            string query = @"
        SELECT 
            r.ReservationID AS 'Reservation ID', 
            ts.Date AS 'Travel Date', 
            r.FlightNumber AS 'Train Name', 
            s1.StationName AS 'Departure Station', 
            s2.StationName AS 'Arrival Station', 
            r.SeatNumber AS 'Seat Number', 
            r.Status AS 'Status'
        FROM reservation r
        JOIN trainschedule ts ON r.ScheduleID = ts.ScheduleID
        JOIN station s1 ON ts.From_StationID = s1.StationID
        JOIN station s2 ON ts.To_StationID = s2.StationID
        WHERE r.IDDocument = @IDDocument";

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    conn.Open();

                    // Prepare the SQL command
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@IDDocument", Session.LoggedInPassengerIDDocument);

                    // Execute the query and fill the DataTable
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind the results to the DataGridView
                    dataGridViewReservations.DataSource = dataTable;

                    // Customize the DataGridView appearance
                    dataGridViewReservations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridViewReservations.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    dataGridViewReservations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dataGridViewReservations.MultiSelect = false;

                    // Check if no reservations exist
                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("No reservations found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading reservations: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
            LoadReservations();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
