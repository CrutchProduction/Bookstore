using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Bookstore
{
    internal static class Program
    {
        public static bool yes = false;
        private static Store store;
        private static TitleForm titleform;

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
            while (true) {
                titleform = new TitleForm();
                Application.Run(titleform);
                if (yes)
                {
                    store = new Store();
                    Thread newThread = new Thread(gameThread);
                    newThread.Start();
                    Application.Run(store);
                    store.stopGame();
                    newThread.Join();
                }

                if (!yes)
                {
                    break;
                }
                yes = false;
            }
        }

        static void gameThread()
        {
            store.startGame(titleform.GetCurDifficulty());
        }
    }
}