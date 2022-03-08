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

            ConnectionView connectionView = new ConnectionView();
            ConnectionController connectionController = new ConnectionController(
                new OdbcConnectionString(string.Empty, "postgres", string.Empty),
                connectionView,
                new MessageService());

            RichTextBoxView textBoxView = new RichTextBoxView();
            RichTextBoxController richTextBoxController = new RichTextBoxController(new TitleService(), textBoxView);

            MainForm form = new MainForm(connectionView, textBoxView);
            MainController mainController = new MainController(form, new MessageService(), connectionController, richTextBoxController);
            Application.Run(form);
        }
    }
}