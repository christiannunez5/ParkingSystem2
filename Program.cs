namespace ParkingSystemGUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            List <ParkingSystem> parkedCars = new List<ParkingSystem>();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Dashboard());

            Dashboard d = new Dashboard();

            AddCarForm car = new AddCarForm();
        }
    }
}