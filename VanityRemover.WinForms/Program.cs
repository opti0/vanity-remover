using Geeky.VanityRemover.Core;
using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace Geeky.VanityRemover
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            // Get initial directory
            var initialDirectory = args.Length > 0
                ? args[0]
                : "";

            // Create cleaner
            var cleaner = new Cleaner();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("pl-PL");
            Thread.CurrentThread.CurrentCulture = new CultureInfo("pl-PL");

            // Start application
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main(initialDirectory, cleaner));
        }
    }
}