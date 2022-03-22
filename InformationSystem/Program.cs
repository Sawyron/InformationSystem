using InformationSystem.Connection;
using InformationSystem.Controllers;
using InformationSystem.Infrastructure;
using InformationSystem.Main;
using InformationSystem.Services;
using InformationSystem.Services.Factories;
using InformationSystem.StringView;

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
            ConnectionPageFactory connectionPageFactory = new ConnectionPageFactory();
            PageLoader<IDataController, UserControl> pageLoader = new PageLoader<IDataController, UserControl>();

            MainController mainController = new MainController(form,
                new MessageService(), connectionPageFactory.CreatePage(), pageLoader.GetPages());

            Application.Run(form);
        }
    }
}