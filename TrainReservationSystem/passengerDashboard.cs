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
    public partial class passengerDashboard : Form
    {
        public passengerDashboard()
        {
            InitializeComponent();
            LoadTrainSchedules();
            LoadStations();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            this.Hide();
            loginPage.Show();
        }

        private void myResToolStripMenuItem_Click(object sender, EventArgs e)
        {
            passengerReser passengerReser = new passengerReser();
            this.Hide();
            passengerReser.Show();
        }

        private void LoadTrainSchedules()
        {
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = @"
            SELECT 
                ts.ScheduleID,
                t.Name_EN AS TrainName,
                s1.StationName AS DepartureStation,
                s2.StationName AS ArrivalStation,
                ts.Date,
                ts.DepartureTime,
                ts.ArrivalTime,
                ts.Distance
            FROM 
                trainschedule ts
            JOIN 
                train t ON ts.TrainID = t.TrainID
            JOIN 
                station s1 ON ts.From_StationID = s1.StationID
            JOIN 
                station s2 ON ts.To_StationID = s2.StationID;";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                passengerTrainDataGrid.DataSource = dataTable;
            }
        }

        private void LoadStations()
        {
            string query = "SELECT StationName FROM station";

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    List<string> stations = new List<string>();

                    while (reader.Read())
                    {
                        stations.Add(reader.GetString("StationName"));
                    }

                    // Bind station names to the ComboBoxes
                    cmbDepartureStation.DataSource = new List<string>(stations);
                    cmbDestinationStation.DataSource = new List<string>(stations);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading stations: {ex.Message}");
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string departureStation = cmbDepartureStation.SelectedItem.ToString();
            string destinationStation = cmbDestinationStation.SelectedItem.ToString();
            DateTime travelDate = dtpTravelDate.Value.Date;

            // Query to fetch train schedules based on search criteria
            string query = @"
        SELECT 
            ts.ScheduleID,
            t.Name_EN AS TrainName,
            s1.StationName AS DepartureStation,
            s2.StationName AS ArrivalStation,
            ts.Date,
            ts.DepartureTime,
            ts.ArrivalTime,
            ts.Distance
        FROM 
            trainschedule ts
        JOIN 
            train t ON ts.TrainID = t.TrainID
        JOIN 
            station s1 ON ts.From_StationID = s1.StationID
        JOIN 
            station s2 ON ts.To_StationID = s2.StationID
        WHERE 
            s1.StationName = @DepartureStation AND 
            s2.StationName = @DestinationStation AND 
            ts.Date = @TravelDate;";

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@DepartureStation", departureStation);
                    cmd.Parameters.AddWithValue("@DestinationStation", destinationStation);
                    cmd.Parameters.AddWithValue("@TravelDate", travelDate);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind the filtered data to the DataGridView
                    passengerTrainDataGrid.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error executing search: {ex.Message}");
                }
            }
        }

        private void passengerTrainDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure a valid row is double-clicked
            {
                // Retrieve train schedule details from the selected row
                int scheduleID = Convert.ToInt32(passengerTrainDataGrid.Rows[e.RowIndex].Cells["ScheduleID"].Value);
                string trainName = passengerTrainDataGrid.Rows[e.RowIndex].Cells["TrainName"].Value.ToString();
                string departureStation = passengerTrainDataGrid.Rows[e.RowIndex].Cells["DepartureStation"].Value.ToString();
                string arrivalStation = passengerTrainDataGrid.Rows[e.RowIndex].Cells["ArrivalStation"].Value.ToString();
                DateTime travelDate = Convert.ToDateTime(passengerTrainDataGrid.Rows[e.RowIndex].Cells["Date"].Value);

                //Open the Payment Form and pass the schedule details
                paymentForm paymentForm = new paymentForm
                {
                    ScheduleID = scheduleID,
                    TrainName = trainName,
                    DepartureStation = departureStation,
                    ArrivalStation = arrivalStation,
                    TravelDate = travelDate
                };

                // Show the PaymentForm
                paymentForm.Show();
                this.Hide();
            }
        }

        private void showAllBtn_Click(object sender, EventArgs e)
        {
            LoadTrainSchedules();
        }
    }
}
