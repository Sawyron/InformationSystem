namespace InformationSystem.Services
{
    public interface IMessageService
    {
        public void ShowMessage(string message);
        public void ShowExclamation(string exclamation);
        public void ShowError(string error);
    }
}
