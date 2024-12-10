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

        private void LoginPage_Load(object sender, EventArgs e)
        {
            usernameLabel.Parent = loginPageImage;
            usernameLabel.BackColor = Color.Transparent;
            passwordLabel.Parent = loginPageImage;
            passwordLabel.BackColor = Color.Transparent;
            loginPageLabel.Parent = loginPageImage;
            loginPageLabel.BackColor = Color.Transparent;
        }
    }
}
