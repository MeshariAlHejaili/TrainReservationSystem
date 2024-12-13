using MySqlConnector;

namespace TrainReservationSystem
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        //private void loginBtn_Click(object sender, EventArgs e)
        //{
        //    string email = emailFiled.Text;
        //    string password = passwordFiled.Text;

        //    // Check if the user is a staff member
        //    if (IsStaff(email, password))
        //    {
        //        // If the user is a staff, open the Admin form
        //        Admin adminForm = new Admin();
        //        adminForm.Show();
        //        this.Hide(); // Hide the current login form
        //    }
        //    // If the user is not a staff, check if they are a passenger
        //    else if (IsPassenger(email, password))
        //    {
        //        // If the user is a passenger, open the PassengerDashboard form
        //        passengerDashboard passengerDashboardForm = new passengerDashboard();
        //        passengerDashboardForm.Show();
        //        this.Hide(); // Hide the current login form
        //    }
        //    else
        //    {
        //        // Show error message if no match is found
        //        MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string email = emailFiled.Text;
            string password = passwordFiled.Text;

            // Check if the user is a passenger
            string passengerID = IsPassenger(email, password);
            if (passengerID != null)
            {
                // Store the IDDocument in the session
                Session.LoggedInPassengerIDDocument = passengerID;

                // Open PassengerDashboard
                passengerDashboard dashboard = new passengerDashboard();
                dashboard.Show();
                this.Hide();
            }
            else if (IsStaff(email, password)) // Assuming you have an IsStaff method
            {
                // Open Admin form if it's a staff member
                Admin adminForm = new Admin();
                adminForm.Show();
                this.Hide();
            }
            else
            {
                // Show an error message if login fails
                MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LoginPage_Load(object sender, EventArgs e)
        {
            emailLabel.Parent = loginPageImage;
            emailLabel.BackColor = Color.Transparent;
            passwordLabel.Parent = loginPageImage;
            passwordLabel.BackColor = Color.Transparent;
            loginPageLabel.Parent = loginPageImage;
            loginPageLabel.BackColor = Color.Transparent;
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }

        private bool IsStaff(string email, string password)
        {
            string query = "SELECT COUNT(*) FROM staff WHERE Email = @Email AND Password = @Password";

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);

                conn.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        // Method to check if the email and password belong to a passenger
        //private bool IsPassenger(string email, string password)
        //{
        //    string query = "SELECT COUNT(*) FROM passenger WHERE Email = @Email AND Password = @Password";

        //    using (MySqlConnection conn = DatabaseHelper.GetConnection())
        //    {
        //        MySqlCommand cmd = new MySqlCommand(query, conn);
        //        cmd.Parameters.AddWithValue("@Email", email);
        //        cmd.Parameters.AddWithValue("@Password", password);

        //        conn.Open();
        //        int count = Convert.ToInt32(cmd.ExecuteScalar());
        //        return count > 0;
        //    }
        //}

        private string IsPassenger(string email, string password)
        {
            string query = "SELECT IDDocument FROM passenger WHERE Email = @Email AND Password = @Password";

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);

                conn.Open();
                object result = cmd.ExecuteScalar();
                return result != null ? result.ToString() : null; // Return IDDocument or null if not found
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            passengerDashboard passengerDashboard = new passengerDashboard();
            this.Hide();
            passengerDashboard.Show();
        }
    }
}
