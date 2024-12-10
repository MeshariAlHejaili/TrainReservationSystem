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

        private void btnAddReservation_Click(object sender, EventArgs e)
        {
            addReservationForm addReservationForm = new addReservationForm();
            addReservationForm.ShowDialog();    
            this.Show();
        }

        private void btnCancelReservation_Click(object sender, EventArgs e)
        {
            cancelReservationForm cancelReservationForm = new cancelReservationForm();
            cancelReservationForm.ShowDialog(); 
            this.Show();
        }

        private void buttonbtnAssignStaff3_Click(object sender, EventArgs e)
        {
            assignStaffForm assignStaffForm = new assignStaffForm();   
            assignStaffForm.ShowDialog();
            this.Show();
        }

        private void passengerTrainDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
