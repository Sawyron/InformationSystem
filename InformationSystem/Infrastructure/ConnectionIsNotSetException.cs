namespace InformationSystem.Services
{
    public class ConnectionIsNotSetException : Exception
    {
        public ConnectionIsNotSetException() : base("Data base connection is not set")
        {
        }

        public ConnectionIsNotSetException(string? message) : base(message)
        {
        }

        public ConnectionIsNotSetException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
