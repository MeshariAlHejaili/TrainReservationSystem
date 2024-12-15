using System;
using System.Data;
using System.Windows.Forms;
using MySqlConnector;

namespace TrainReservationSystem
{
    public partial class ReportsForm : Form
    {
        private int scheduleId;

        public ReportsForm(int selectedScheduleId)
        {
            InitializeComponent();
            scheduleId = selectedScheduleId;
        }

        public void GenerateReports()
        {
            // Clear any existing data in the grids
            dataGridViewActiveTrains.DataSource = null;
            dataGridViewStations.DataSource = null;
            dataGridViewLoadFactor.DataSource = null;

            // Call individual methods to generate each report
            GenerateActiveTrainsReport();
            GenerateListStationsReport();
            GenerateLoadFactorReport();
        }

        private void GenerateActiveTrainsReport()
        {
            string query = @"
            SELECT 
                ts.ScheduleID, 
                t.Name_EN AS TrainName,
                ts.Date, 
                ts.DepartureTime, 
                ts.ArrivalTime, 
                ts.Distance
            FROM 
                trainschedule ts
            JOIN 
                train t ON ts.TrainID = t.TrainID
            WHERE 
                ts.Date = CURDATE()";

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ScheduleID", scheduleId);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable activeTrainsTable = new DataTable();
                adapter.Fill(activeTrainsTable);

                if (activeTrainsTable.Rows.Count > 0)
                {
                    dataGridViewActiveTrains.DataSource = activeTrainsTable;
                    lblActiveTrainsTitle.Visible = true;
                    groupBoxActiveTrains.Visible = true;
                }
                else
                {
                    lblActiveTrainsTitle.Visible = true;
                    groupBoxActiveTrains.Visible = false;
                    MessageBox.Show("No active trains are on their way today.");
                }
            }
        }

        private void GenerateListStationsReport()
        {
            // Query to fetch TrainID, Departure Station, and Arrival Station for all train schedules
            string query = @"
    SELECT 
        ts.TrainID, 
        t.Name_EN AS TrainName,
        s1.StationName AS DepartureStation, 
        s2.StationName AS ArrivalStation
    FROM 
        trainschedule ts
    JOIN 
        train t ON ts.TrainID = t.TrainID
    JOIN 
        station s1 ON ts.From_StationID = s1.StationID
    JOIN 
        station s2 ON ts.To_StationID = s2.StationID;";

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable stationsTable = new DataTable();
                    adapter.Fill(stationsTable);

                    if (stationsTable.Rows.Count > 0)
                    {
                        // Display the fetched data in dataGridViewStations
                        dataGridViewStations.DataSource = stationsTable;

                        // Set visibility and UI elements for the station report
                        lblStationsTitle.Visible = true;
                        groupBoxStations.Visible = true;
                    }
                    else
                    {
                        lblStationsTitle.Visible = false;
                        groupBoxStations.Visible = false;
                        MessageBox.Show("No train schedules found in the database.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while fetching train schedules: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void GenerateLoadFactorReport()
        {
            string query = @"
            SELECT 
                COUNT(*) AS OccupiedSeats
            FROM 
                reservation r
            WHERE 
                r.ScheduleID = @ScheduleID;";

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ScheduleID", scheduleId);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable reservationTable = new DataTable();
                adapter.Fill(reservationTable);

                int occupiedSeats = reservationTable.Rows.Count > 0 ? Convert.ToInt32(reservationTable.Rows[0]["OccupiedSeats"]) : 0;
                int totalSeats = 25; // Assuming total seats are fixed at 25

                // Calculate the load factor
                double loadFactor = (occupiedSeats / (double)totalSeats) * 100;

                DataTable loadFactorTable = new DataTable();
                loadFactorTable.Columns.Add("Occupied Seats");
                loadFactorTable.Columns.Add("Total Seats");
                loadFactorTable.Columns.Add("Load Factor (%)");

                loadFactorTable.Rows.Add(occupiedSeats, totalSeats, loadFactor);

                dataGridViewLoadFactor.DataSource = loadFactorTable;
                lblLoadFactorTitle.Visible = true;
                groupBoxLoadFactor.Visible = true;
            }
        }

        private void groupBoxActiveTrains_Enter(object sender, EventArgs e)
        {

        }

        private void Logout_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            this.Hide();
            loginPage.Show();
        }

        private void Dashbord_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            this.Hide();
            admin.Show();
        }
    }
}
