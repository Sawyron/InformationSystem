namespace InformationSystem.Services
{
    public class MessageService : IMessageService
    {
        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void ShowExclamation(string exclamination)
        {
            MessageBox.Show(exclamination, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        public void ShowError(string error)
        {
            MessageBox.Show(error, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
