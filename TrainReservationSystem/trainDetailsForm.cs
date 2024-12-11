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
                r.ReservationDate
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

                    // Debugging - Print the number of rows returned
                    Console.WriteLine("Number of rows: " + dataTable.Rows.Count);

                    if (dataTable.Rows.Count > 0)
                    {
                        reservationsDataGrid.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("No reservations found for this schedule.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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

        }

        private void trainDetailsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
