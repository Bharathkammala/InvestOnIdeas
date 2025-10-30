namespace InvestOnIdeas
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new MainDashboard());
            //Application.Run(new Profile());
            //Application.Run(new Bookmarks());
            //Application.Run(new ChatWindow());
            //Application.Run(new Collaborations());
            Application.Run(new MyIdeas());
        }
    }
}