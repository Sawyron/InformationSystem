using InformationSystem.Controllers;
using InformationSystem.Models;
using InformationSystem.Services;
using InformationSystem.Services.Factories;
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
            ConnectionPageFactory connectionPageFactory = new ConnectionPageFactory();
            RichTextBoxPageFactory textBoxFactory = new RichTextBoxPageFactory();
            List<IPageFactory<IDataController, UserControl>> pageFactories = new List<IPageFactory<IDataController, UserControl>>()
            {
                textBoxFactory
            };
            PagesFactory<IDataController, UserControl> pagesFactory = new PagesFactory<IDataController, UserControl>(pageFactories);

            MainController mainController = new MainController(form,
                new MessageService(), connectionPageFactory.CreatePage(), pagesFactory.GetPages());

            Application.Run(form);
        }
    }
}