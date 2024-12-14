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
        private int selectedScheduleId = 0; // To store selected ScheduleID
        private bool isViewingAssignedStaff = false;
        public Admin()
        {
            InitializeComponent();
            LoadTrainSchedules();
            passengerTrainDataGrid.CellClick += passengerTrainDataGrid_CellClick;
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

                DataTable trainScheduleTable = new DataTable();
                adapter.Fill(trainScheduleTable);

                passengerTrainDataGrid.DataSource = trainScheduleTable; // Bind train schedules to the grid
            }
        }

        private void passengerTrainDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the selected ScheduleID
                selectedScheduleId = Convert.ToInt32(passengerTrainDataGrid.Rows[e.RowIndex].Cells["ScheduleID"].Value);
            }
        }

        private void btnAssignStaff_Click(object sender, EventArgs e)
        {
            if (selectedScheduleId > 0) // Ensure a train schedule is selected
            {
                // Pass the selected ScheduleID to the AssignStaff form
                AssignStaffForm assignStaffForm = new AssignStaffForm(selectedScheduleId);
                assignStaffForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a train schedule before assigning staff.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnViewAssignedStaff_Click(object sender, EventArgs e)
        {
            // Check if a valid ScheduleID is selected
            if (selectedScheduleId > 0)
            {
                if (isViewingAssignedStaff)
                {
                    // If currently viewing assigned staff, switch back to the train schedule view
                    LoadTrainSchedules();
                    isViewingAssignedStaff = false; // Set flag to show train schedules next

                    // Show the "Assign Staff" button since we're back to the train schedule view
                    btnAssignStaff.Visible = true;
                }
                else
                {
                    // If currently not viewing assigned staff, show the assigned staff for the selected ScheduleID
                    string query = @"
                SELECT 
                    ss.StaffScheduleID, 
                    s.Name AS StaffName, 
                    ss.Role, 
                    ss.TravelDate
                FROM 
                    staffschedule ss
                JOIN 
                    staff s ON ss.StaffID = s.StaffID
                WHERE 
                    ss.ScheduleID = @ScheduleID;";

                    // Execute the query with the selected ScheduleID
                    using (MySqlConnection conn = DatabaseHelper.GetConnection())
                    {
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@ScheduleID", selectedScheduleId);
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                        DataTable assignedStaffTable = new DataTable();
                        adapter.Fill(assignedStaffTable);

                        // If there are no assigned staff for the selected ScheduleID, show a message
                        if (assignedStaffTable.Rows.Count == 0)
                        {
                            MessageBox.Show("No staff assigned to this schedule.", "No Assigned Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        // Bind the result to the grid, displaying only staff assigned to the selected schedule
                        passengerTrainDataGrid.DataSource = assignedStaffTable;
                    }

                    // Set the flag to indicate that the user is viewing assigned staff now
                    isViewingAssignedStaff = true;

                    // Hide the "Assign Staff" button since we're now viewing the assigned staff schedule
                    btnAssignStaff.Visible = false;
                }
            }
            else
            {
                // If no schedule is selected, show a message
                MessageBox.Show("Please select a train schedule to view assigned staff.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Event handler for double-click on a cell in the grid
        private void passengerTrainDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the clicked row is valid (i.e., not the header row)
            if (e.RowIndex >= 0)
            {
                // Get the ScheduleID from the selected row (make sure the column name matches your data)
                var scheduleIdCellValue = passengerTrainDataGrid.Rows[e.RowIndex].Cells["ScheduleID"].Value;

                // Check if ScheduleID is valid (not null or DBNull)
                if (scheduleIdCellValue != null && scheduleIdCellValue != DBNull.Value)
                {
                    try
                    {
                        // Try to convert the ScheduleID to an integer
                        int scheduleId = Convert.ToInt32(scheduleIdCellValue);

                        // Open the train details form and pass the ScheduleID as a parameter
                        trainDetailsForm detailsForm = new trainDetailsForm(scheduleId);
                        detailsForm.Show(); // Show the details form
                        this.Hide(); // Optionally hide the current form (Admin form) to switch to the details form
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error opening train details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Show an error message if ScheduleID is invalid
                    MessageBox.Show("Selected row does not contain a valid Schedule ID.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        // Button click event handler
        private void btnReservation_Click(object sender, EventArgs e)
        {
            // Ensure a valid row is selected
            if (passengerTrainDataGrid.SelectedRows.Count > 0)
            {
                // Get the ScheduleID from the selected row (ensure it matches the correct column name)
                var scheduleIdCellValue = passengerTrainDataGrid.SelectedRows[0].Cells["ScheduleID"].Value;

                // Check if ScheduleID is valid (not null or DBNull)
                if (scheduleIdCellValue != null && scheduleIdCellValue != DBNull.Value)
                {
                    try
                    {
                        // Try to convert the ScheduleID to an integer
                        int scheduleId = Convert.ToInt32(scheduleIdCellValue);

                        // Open the train details form and pass the ScheduleID as a parameter
                        trainDetailsForm detailsForm = new trainDetailsForm(scheduleId);
                        detailsForm.Show(); // Show the details form
                        this.Hide(); // Optionally hide the current form (Admin form) to switch to the details form
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error opening train details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Show an error message if ScheduleID is invalid
                    MessageBox.Show("Selected row does not contain a valid Schedule ID.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                // If no row is selected, show a message
                MessageBox.Show("Please select a train schedule to view its details.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGenerateReports_Click(object sender, EventArgs e)
        {
            if (passengerTrainDataGrid.SelectedRows.Count > 0)
            {
                // Get the selected ScheduleID from the DataGridView
                var scheduleIdCellValue = passengerTrainDataGrid.SelectedRows[0].Cells["ScheduleID"].Value;

                if (scheduleIdCellValue != null && scheduleIdCellValue != DBNull.Value)
                {
                    try
                    {
                        int selectedScheduleId = Convert.ToInt32(scheduleIdCellValue);

                        // Open ReportsForm and pass the ScheduleID
                        ReportsForm reportsForm = new ReportsForm(selectedScheduleId);
                        reportsForm.GenerateReports();  // This will load and display the reports
                        reportsForm.ShowDialog(); // Show the form as a modal
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error generating reports: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a valid train schedule first.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please select a train schedule to generate reports.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            this.Hide();
            loginPage.Show();
        }

        private void passengerMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dtpTravelDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string selectedDate = dtpSearchDate.Value.ToString("yyyy-MM-dd"); // Get the date in 'yyyy-MM-dd' format

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
            ts.Date = @SelectedDate;";

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@SelectedDate", selectedDate);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable searchResults = new DataTable();
                    adapter.Fill(searchResults);

                    // Bind results to the DataGridView
                    passengerTrainDataGrid.DataSource = searchResults;

                    if (searchResults.Rows.Count == 0)
                    {
                        MessageBox.Show("No results found for the selected date.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void showAllBtn_Click(object sender, EventArgs e)
        {
            LoadTrainSchedules();
        }
    }
}
