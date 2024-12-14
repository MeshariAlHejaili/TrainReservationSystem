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
    public partial class AssignStaffForm : Form
    {
        private int scheduleId; 

        public AssignStaffForm(int scheduleId)
        {
            InitializeComponent();
            this.scheduleId = scheduleId;
            LoadAvailableStaff(); // Load staff when the form opens
        }

        private void LoadAvailableStaff()
        {
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = @"
                SELECT 
                    StaffID, 
                    Name, 
                    Role, 
                    Email 
                FROM 
                    staff 
                WHERE 
                    Role != 'Admin';";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                DataTable staffTable = new DataTable();
                adapter.Fill(staffTable);

                staffDataGrid.DataSource = staffTable; // Bind staff data to the grid
            }
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (staffDataGrid.SelectedRows.Count > 0)
            {
                // Get the selected StaffID
                int selectedStaffId = Convert.ToInt32(staffDataGrid.SelectedRows[0].Cells["StaffID"].Value);

                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string query = @"
                    INSERT INTO staffschedule (ScheduleID, StaffID, Role, TravelDate)
                    VALUES (@ScheduleID, @StaffID, @Role, @TravelDate);";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ScheduleID", scheduleId);
                    cmd.Parameters.AddWithValue("@StaffID", selectedStaffId);
                    cmd.Parameters.AddWithValue("@Role", staffDataGrid.SelectedRows[0].Cells["Role"].Value);
                    cmd.Parameters.AddWithValue("@TravelDate", DateTime.Now); // Example: Add current date as travel date

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Staff assigned successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error assigning staff: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a staff member to assign.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAssignStaff_Click(object sender, EventArgs e)
        {
            if (staffDataGrid.SelectedRows.Count > 0)
            {
                // Get the selected StaffID and Role
                int staffId = Convert.ToInt32(staffDataGrid.SelectedRows[0].Cells["StaffID"].Value);
                string role = staffDataGrid.SelectedRows[0].Cells["Role"].Value.ToString();
                DateTime travelDate = DateTime.Now; // Example travel date

                // Insert into staffschedule table
                string query = @"
            INSERT INTO staffschedule (ScheduleID, StaffID, Role, TravelDate)
            VALUES (@ScheduleID, @StaffID, @Role, @TravelDate)";

                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ScheduleID", scheduleId);
                    cmd.Parameters.AddWithValue("@StaffID", staffId);
                    cmd.Parameters.AddWithValue("@Role", role);
                    cmd.Parameters.AddWithValue("@TravelDate", travelDate);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff successfully assigned!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a staff member to assign.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
