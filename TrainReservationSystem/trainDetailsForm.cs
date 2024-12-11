using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace TrainReservationSystem
{
    public partial class trainDetailsForm : Form
    {
        private int scheduleId;
        public trainDetailsForm(int scheduleId)
        {
            InitializeComponent();
            this.scheduleId = scheduleId;
            LoadTrainReservations();
            InitializeDataGridView();
        }



        private void LoadTrainReservations()
        {
            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string query = @"
                SELECT 
                    r.ReservationID,
                    p.PassengerName AS PassengerName,
                    r.SeatNumber,
                    r.ReservationDate,
                    r.TravelDate,
                    r.FlightNumber,
                    r.Status,
                    ts.ScheduleID
                FROM 
                    reservation r
                JOIN 
                    passenger p ON r.IDDocument = p.IDDocument
                JOIN 
                    trainschedule ts ON r.ScheduleID = ts.ScheduleID
                WHERE 
                    ts.ScheduleID = @ScheduleID;";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ScheduleID", scheduleId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        reservationsDataGrid.DataSource = dataTable;
                        InitializeDataGridView(); // Only call this after data is loaded
                    }
                    else
                    {
                        MessageBox.Show("No reservations found for this schedule.");
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void InitializeDataGridView()
        {
            // Ensure the grid has data before modifying columns
            if (reservationsDataGrid.Rows.Count > 0)
            {
                // Set columns to be editable or read-only
                reservationsDataGrid.Columns["ReservationID"].ReadOnly = true;
                reservationsDataGrid.Columns["PassengerName"].ReadOnly = true;
                reservationsDataGrid.Columns["SeatNumber"].ReadOnly = false; // Editable
                reservationsDataGrid.Columns["Status"].ReadOnly = false; // Editable
                reservationsDataGrid.Columns["ReservationDate"].ReadOnly = false; // Editable
                reservationsDataGrid.Columns["TravelDate"].ReadOnly = false; // Editable
                reservationsDataGrid.Columns["FlightNumber"].ReadOnly = false; // Editable
            }
        }

        // Declare controls for the UI


        private void passengerTrainDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddReservation_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelReservation_Click(object sender, EventArgs e)
        {
            if (reservationsDataGrid.SelectedRows.Count > 0)
            {
                int reservationId = Convert.ToInt32(reservationsDataGrid.SelectedRows[0].Cells["ReservationID"].Value);

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel this reservation?", "Confirm Cancellation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        using (MySqlConnection conn = DatabaseHelper.GetConnection())
                        {
                            conn.Open();

                            string query = "DELETE FROM reservation WHERE ReservationID = @ReservationID";
                            MySqlCommand cmd = new MySqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@ReservationID", reservationId);

                            int result = cmd.ExecuteNonQuery();
                            if (result > 0)
                            {
                                MessageBox.Show("Reservation canceled successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Remove the selected row from the DataGridView
                                reservationsDataGrid.Rows.RemoveAt(reservationsDataGrid.SelectedRows[0].Index);
                            }
                            else
                            {
                                MessageBox.Show("Failed to cancel the reservation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a reservation to cancel.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void trainDetailsForm_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdateReservation_Click(object sender, EventArgs e)
        {
            try
            {
                if (reservationsDataGrid.SelectedRows.Count > 0)
                {
                    // Get the selected reservation's ID
                    int reservationId = Convert.ToInt32(reservationsDataGrid.SelectedRows[0].Cells["ReservationID"].Value);

                    // Retrieve the new values from the DataGridView
                    string seatNumber = reservationsDataGrid.SelectedRows[0].Cells["SeatNumber"].Value.ToString();
                    string status = reservationsDataGrid.SelectedRows[0].Cells["Status"].Value.ToString();
                    DateTime reservationDate = Convert.ToDateTime(reservationsDataGrid.SelectedRows[0].Cells["ReservationDate"].Value);
                    DateTime travelDate = Convert.ToDateTime(reservationsDataGrid.SelectedRows[0].Cells["TravelDate"].Value);
                    string flightNumber = reservationsDataGrid.SelectedRows[0].Cells["FlightNumber"].Value.ToString();

                    // Update the reservation in the database
                    using (MySqlConnection conn = DatabaseHelper.GetConnection())
                    {
                        string query = @"
                    UPDATE reservation
                    SET 
                        SeatNumber = @SeatNumber,
                        Status = @Status,
                        ReservationDate = @ReservationDate,
                        TravelDate = @TravelDate,
                        FlightNumber = @FlightNumber
                    WHERE 
                        ReservationID = @ReservationID";

                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@SeatNumber", seatNumber);
                        cmd.Parameters.AddWithValue("@Status", status);
                        cmd.Parameters.AddWithValue("@ReservationDate", reservationDate);
                        cmd.Parameters.AddWithValue("@TravelDate", travelDate);
                        cmd.Parameters.AddWithValue("@FlightNumber", flightNumber);
                        cmd.Parameters.AddWithValue("@ReservationID", reservationId);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Reservation updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to update the reservation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a reservation to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
