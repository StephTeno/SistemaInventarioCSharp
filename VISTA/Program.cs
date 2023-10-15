using CustomMessageBox;
using Microsoft.Extensions.Configuration;
using System.Diagnostics;

namespace Vista
{
    internal static class Program
    {
        public static IConfiguration? Configuration;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Process[] process = Process.GetProcessesByName("Vista");

            if (process.Length == 1)
            {
                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.
                ApplicationConfiguration.Initialize();
                Application.Run(new frmAppLogin());
            }
            else 
            {
                RJMessageBox.Show("El programa ya se encuentra abierto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }
    }
}