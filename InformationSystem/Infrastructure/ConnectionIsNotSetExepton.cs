namespace InformationSystem.Services
{
    public class ConnectionIsNotSetExepton : Exception
    {
        public ConnectionIsNotSetExepton() : base("Data base connection is not set")
        {
        }

        public ConnectionIsNotSetExepton(string? message) : base(message)
        {
        }

        public ConnectionIsNotSetExepton(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
