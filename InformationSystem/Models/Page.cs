using InformationSystem.Controllers;

namespace InformationSystem.Models
{
    public class Page<C, V> : IPage<C, V>
    {
        public Page(V view, C controller, string name)
        {
            View = view;
            Name = name;
            Controller = controller;
        }
        public V View { get; }
        public string Name { get; }
        public C Controller { get; }
    }
}
