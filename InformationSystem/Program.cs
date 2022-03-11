using InformationSystem.Connection;
using InformationSystem.Controllers;
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
            List<IPageFactory<IDataController, UserControl>> pageFactories = new List<IPageFactory<IDataController, UserControl>>()
            {
                new StringViewPageFactory(),
                new SQLFunctionPageFactory()
            };
            PagesFactory<IDataController, UserControl> pagesFactory = new PagesFactory<IDataController, UserControl>(pageFactories);

            MainController mainController = new MainController(form,
                new MessageService(), connectionPageFactory.CreatePage(), pagesFactory.GetPages());

            Application.Run(form);
        }
    }
}