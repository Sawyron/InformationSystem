namespace InformationSystem.Services
{
    public class MessageService : IMessageService
    {
        private MessageService() { }

        private static readonly Lazy<MessageService> _instance = new Lazy<MessageService>(() => new MessageService());

        public static MessageService Instance => _instance.Value;
        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void ShowExclamation(string exclamination)
        {
            MessageBox.Show(exclamination, "Exclamination", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        public void ShowError(string error)
        {
            MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
