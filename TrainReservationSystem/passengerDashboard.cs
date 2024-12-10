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
    }
}
