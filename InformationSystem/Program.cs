using InformationSystem.Controllers;
using InformationSystem.Models;
using InformationSystem.Services;
using InformationSystem.Views;

namespace InformationSystem
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
            MainForm form = new MainForm();
            MessageService messageService = new MessageService();
            OdbcConnectionString connection = new OdbcConnectionString(string.Empty, "postgres", string.Empty);
            ConnectionController controller = new ConnectionController(connection, form, messageService);
            Application.Run(form);
        }
    }
}