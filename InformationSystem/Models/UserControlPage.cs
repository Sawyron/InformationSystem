using InformationSystem.Controllers;

namespace InformationSystem.Models
{
    public class UserControlPage<C> : IPage<C, UserControl>
    {
        public UserControlPage(UserControl view, C controller, string name)
        {
            View = view;
            Name = name;
            Controller = controller;
        }
        public UserControl View { get; }
        public string Name { get; }
        public C Controller { get; }
    }
}
