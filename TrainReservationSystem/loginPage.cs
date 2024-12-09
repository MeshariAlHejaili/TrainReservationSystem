namespace TrainReservationSystem
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            passengerDashboard passengerDashboard = new passengerDashboard();
            passengerDashboard.Show();
        }
    }
}
