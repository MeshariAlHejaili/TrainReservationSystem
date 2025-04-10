﻿using System;
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
    public partial class paymentForm : Form
    {
        public int ScheduleID { get; set; }
        public string TrainName { get; set; }
        public string DepartureStation { get; set; }
        public string ArrivalStation { get; set; }
        public DateTime TravelDate { get; set; }
        public passengerDashboard passengerDashboard;
        public Admin admin;

        public paymentForm()
        {
            InitializeComponent();
            passengerDashboard = new passengerDashboard();
            emailFiled.Hide();
            label6.Hide();
            passengerDetailsBtn.Hide();
        }
        public paymentForm(int scheduleID)
        {
            InitializeComponent();
            admin = new Admin();
            this.ScheduleID = scheduleID;

            // Automatically fetch and display necessary details
            TravelDate = GetTravelDate(scheduleID);
            TrainName = GetTrainName(scheduleID);
            DepartureStation = GetStationName(scheduleID, true);
            ArrivalStation = GetStationName(scheduleID, false);

            // Optionally pre-load seat selection
            int trainID = GetTrainID(scheduleID);
            if (trainID > 0)
            {
                LoadAvailableSeats(new ComboBox(), trainID); // Replace `new ComboBox()` with your actual ComboBox for admin use
            }
        }


        private int GetTrainID(int scheduleID)
        {
            string query = "SELECT TrainID FROM trainschedule WHERE ScheduleID = @ScheduleID";

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ScheduleID", scheduleID);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        return Convert.ToInt32(result); // Return TrainID if found
                    }
                    else
                    {
                        throw new Exception("TrainID not found for the given ScheduleID.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error retrieving TrainID: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1; // Return an invalid value in case of error
                }
            }
        }

        private void LoadAvailableSeats(ComboBox comboBox, int trainID)
        {
            string query = @"
        SELECT SeatNumber 
        FROM seats 
        WHERE TrainID = @TrainID 
        AND SeatNumber NOT IN (
            SELECT s.SeatNumber 
            FROM reservation r
            JOIN seats s ON r.SeatNumber = s.SeatNumber
            WHERE r.ScheduleID = @ScheduleID
        )";

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    // Pass TrainID and ScheduleID as parameters
                    cmd.Parameters.AddWithValue("@TrainID", trainID);
                    cmd.Parameters.AddWithValue("@ScheduleID", ScheduleID);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    comboBox.Items.Clear(); // Clear any existing items

                    while (reader.Read())
                    {
                        comboBox.Items.Add(reader.GetString("SeatNumber"));
                    }

                    if (comboBox.Items.Count == 0)
                    {
                        MessageBox.Show("No available seats for the selected schedule.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading seats: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int ticketCount = (int)numericUpDown1.Value;

            // Clear previous fields
            flowLayoutPanel1.Controls.Clear();

            // Retrieve TrainID using ScheduleID
            int trainID = GetTrainID(ScheduleID);
            if (trainID == -1) return; // Exit if TrainID retrieval failed

            // Dynamically add fields for each passenger
            for (int i = 1; i <= ticketCount; i++)
            {
                // Create and configure controls for passenger name
                Label lblName = new Label
                {
                    Text = $"Passenger {i} Name:",
                    AutoSize = true
                };
                TextBox txtName = new TextBox
                {
                    Name = $"txtPassengerName{i}",
                    Width = 450
                };

                // Create and configure controls for passenger age
                Label lblAge = new Label
                {
                    Text = $"Passenger {i} Age:",
                    AutoSize = true
                };
                TextBox txtAge = new TextBox
                {
                    Name = $"txtPassengerAge{i}",
                    Width = 100
                };

                // Create and configure controls for seat selection
                Label lblSeat = new Label
                {
                    Text = $"Passenger {i} Seat:",
                    AutoSize = true
                };
                ComboBox cmbSeat = new ComboBox
                {
                    Name = $"cmbPassengerSeat{i}",
                    Width = 200,
                    DropDownStyle = ComboBoxStyle.DropDownList
                };

                // Load available seats into the ComboBox
                LoadAvailableSeats(cmbSeat, trainID);

                // Add controls to the panel
                flowLayoutPanel1.Controls.Add(lblName);
                flowLayoutPanel1.Controls.Add(txtName);
                flowLayoutPanel1.Controls.Add(lblAge);
                flowLayoutPanel1.Controls.Add(txtAge);
                flowLayoutPanel1.Controls.Add(lblSeat);
                flowLayoutPanel1.Controls.Add(cmbSeat);
            }
            CalculatePrice();
        }
        private void InsertReservation(string passengerName, string passengerAge, string seatNumber, int trainID)
        {
            string query = @"
        INSERT INTO reservation (IDDocument, ReservationDate, TravelDate, TrainName, SeatNumber, Status, ScheduleID)
        VALUES (@IDDocument, @ReservationDate, @TravelDate, @TrainName, @SeatNumber, 'Confirmed', @ScheduleID)";

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@IDDocument", Session.LoggedInPassengerIDDocument);
                    cmd.Parameters.AddWithValue("@ReservationDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@TravelDate", TravelDate); // From PaymentForm property
                    cmd.Parameters.AddWithValue("@TrainName", TrainName); // From PaymentForm property
                    cmd.Parameters.AddWithValue("@SeatNumber", seatNumber);
                    cmd.Parameters.AddWithValue("@ScheduleID", ScheduleID); // From PaymentForm property

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error inserting reservation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (admin != null)
                admin.Show();
            else
            {
                passengerDashboard.Show();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            this.Hide();
            loginPage.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Ensure all fields are filled
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                // Validate all TextBox fields
                if (control is TextBox textBox && string.IsNullOrWhiteSpace(textBox.Text))
                {
                    MessageBox.Show("Please fill out all passenger information fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate all ComboBox fields for seat selection
                if (control is ComboBox comboBox && comboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a seat for each passenger.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Proceed with booking logic
            try
            {
                int trainID = GetTrainID(ScheduleID); // Dynamically fetch TrainID based on ScheduleID
                if (trainID == -1)
                {
                    MessageBox.Show("Unable to retrieve TrainID. Booking aborted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                for (int i = 1; i <= numericUpDown1.Value; i++)
                {
                    // Gather data for each passenger
                    string passengerName = flowLayoutPanel1.Controls[$"txtPassengerName{i}"].Text;
                    string passengerAge = flowLayoutPanel1.Controls[$"txtPassengerAge{i}"].Text;
                    string seatNumber = (flowLayoutPanel1.Controls[$"cmbPassengerSeat{i}"] as ComboBox).SelectedItem.ToString();

                    // Insert reservation for each passenger
                    InsertReservation(passengerName, passengerAge, seatNumber, trainID);
                }

                MessageBox.Show("All reservations successfully made!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                if (admin != null)
                    admin.Show();
                else
                {
                    passengerDashboard.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during booking: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CalculatePrice()
        {
            int ticketCount = (int)numericUpDown1.Value; // Get the number of tickets from the numeric up-down control
            decimal pricePerTicket = 50m; // Fixed price per ticket
            decimal vatRate = 0.15m; // VAT rate (15%)

            // Calculate subprice, VAT, and total
            decimal subprice = ticketCount * pricePerTicket;
            decimal vat = subprice * vatRate;
            decimal totalPrice = subprice + vat;

            // Update the labels
            lblSubPrice.Text = $"Subtotal: ${subprice:F2}";
            lblVAT.Text = $"VAT (15%): ${vat:F2}";
            lblTotalPrice.Text = $"Total: ${totalPrice:F2}";
        }

        /************************* Admin methods *********************************/
        private DateTime GetTravelDate(int scheduleID)
        {
            string query = "SELECT Date FROM trainschedule WHERE ScheduleID = @ScheduleID";

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ScheduleID", scheduleID);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        return Convert.ToDateTime(result);
                    }
                    else
                    {
                        throw new Exception("Travel date not found for the given ScheduleID.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error retrieving travel date: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return DateTime.MinValue; // Return default value in case of error
                }
            }
        }
        private string GetTrainName(int scheduleID)
        {
            string query = @"
        SELECT t.Name_EN 
        FROM trainschedule ts 
        JOIN train t ON ts.TrainID = t.TrainID 
        WHERE ts.ScheduleID = @ScheduleID";

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ScheduleID", scheduleID);

                    object result = cmd.ExecuteScalar();
                    return result?.ToString() ?? "Unknown Train";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error retrieving train name: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return "Unknown Train";
                }
            }
        }
        private string GetStationName(int scheduleID, bool isDeparture)
        {
            string query = @"
        SELECT s.StationName 
        FROM trainschedule ts 
        JOIN station s ON ts." + (isDeparture ? "From_StationID" : "To_StationID") + @" = s.StationID 
        WHERE ts.ScheduleID = @ScheduleID";

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ScheduleID", scheduleID);

                    object result = cmd.ExecuteScalar();
                    return result?.ToString() ?? "Unknown Station";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error retrieving station name: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return "Unknown Station";
                }
            }
        }

        private void passengerDetailsBtn_Click(object sender, EventArgs e)
        {
            string email = emailFiled.Text;
            string passengerID = getIDDocument(email);
            if (passengerID != null)
            {
                // Store the IDDocument in the session
                Session.LoggedInPassengerIDDocument = passengerID;
                MessageBox.Show("Email entered correctly.", "successfull", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Invalid email.", "Passenger information Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public string getIDDocument(string email) {

            string query = "SELECT IDDocument FROM passenger WHERE Email = @Email";

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);

                conn.Open();
                object result = cmd.ExecuteScalar();
                return result != null ? result.ToString() : null; // Return IDDocument or null if not found
            }
        }
        
    }
}

