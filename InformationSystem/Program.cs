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

            PageFactory pageFactory = new PageFactory();
            MainForm form = new MainForm();
            List<UserControlPage<IDataController>> pages = new List<UserControlPage<IDataController>>();
            pages.Add(pageFactory.GetRichBoxPage());
            MainController mainController = new MainController(form,
                new MessageService(), pageFactory.GetConnectionPage(), pages);

            Application.Run(form);
        }
    }
}