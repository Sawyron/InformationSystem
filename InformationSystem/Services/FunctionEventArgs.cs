namespace InformationSystem.Services
{
    public class FunctionEventArgs : EventArgs
    {
        public FunctionEventArgs(string name)
        {
            Name = name;
        }
        public string Name { get; private set; }
    }
}
