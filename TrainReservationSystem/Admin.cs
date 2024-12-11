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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            LoadTrainSchedules();
            passengerTrainDataGrid.CellDoubleClick += passengerTrainDataGrid_CellDoubleClick;
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

        private void passengerTrainDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure a valid row is selected
            if (e.RowIndex >= 0)
            {
                var scheduleIdCellValue = passengerTrainDataGrid.Rows[e.RowIndex].Cells["ScheduleID"].Value;

                // Check if the ScheduleID is valid (not null or DBNull)
                if (scheduleIdCellValue != null && scheduleIdCellValue != DBNull.Value)
                {
                    try
                    {
                        // Try to convert the ScheduleID to an integer
                        int scheduleId = Convert.ToInt32(scheduleIdCellValue);

                        // Check if a valid reservation exists for this ScheduleID
                        if (scheduleId > 0) // Assuming valid ScheduleID is > 0
                        {
                            // Open the train details form with the corresponding schedule ID
                            trainDetailsForm detailsForm = new trainDetailsForm(scheduleId);
                            detailsForm.Show();
                        }
                        else
                        {
                            // Only show message once
                            if (!isMessageShown) // Ensure the message is shown once
                            {
                                isMessageShown = true;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        // Only show message once
                        if (!isMessageShown) // Ensure the message is shown once
                        {
                            isMessageShown = true;
                        }
                    }
                }
                else
                {
                    // In case ScheduleID is null or invalid, show a message
                    if (!isMessageShown) // Ensure the message is shown once
                    {
                        MessageBox.Show("Selected row does not contain a valid Schedule ID.");
                        isMessageShown = true;
                    }
                }
            }
            else
            {
                // Message for invalid row selection
                if (!isMessageShown) // Ensure the message is shown once
                {
                    MessageBox.Show("Please select a valid reservation row.");
                    isMessageShown = true;
                }
            }
        }

        // Flag to ensure the message is only shown once
        private bool isMessageShown = false;




        private void passengerTrainDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
