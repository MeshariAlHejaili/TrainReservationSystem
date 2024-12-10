namespace TrainReservationSystem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                DatabaseHelper.InitializeConnection();
                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.

                ApplicationConfiguration.Initialize();
                Application.Run(new LoginPage());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to start the application: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Ensure the connection is closed when the application exits
                DatabaseHelper.CloseConnection();
            }
        }
    }
}