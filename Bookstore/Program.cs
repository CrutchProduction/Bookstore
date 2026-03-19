using System.Security.Cryptography.X509Certificates;

namespace Bookstore
{
    internal static class Program
    {
        public static bool yes = false;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            
            //сначала запускается титульный экран
            Application.Run(new TitleForm());
            if (yes) Application.Run(new Store());
        }
    }
}