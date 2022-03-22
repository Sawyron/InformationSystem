using InformationSystem.Models;
using InformationSystem.Services.Factories;

namespace InformationSystem.Infrastructure
{
    public class PageLoader<C, V> : IPagesFactory<C, V>
    {
        public IEnumerable<IPage<C, V>> GetPages()
        {
            Type pageFactoryType = typeof(IPageFactory<C, V>);
            List<IPageFactory<C, V>> pageFactories = new List<IPageFactory<C, V>>();
            AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => pageFactoryType.IsAssignableFrom(p))
                .ToList().ForEach(t =>
                {
                    IPageFactory<C, V>? pageFactory = (IPageFactory<C, V>?)Activator.CreateInstance(t);
                    if (pageFactory != null)
                    {
                        pageFactories.Add(pageFactory);
                    }

                });
            List<IPage<C, V>> pages = new List<IPage<C, V>>();
            foreach (IPageFactory<C, V> factory in pageFactories)
            {
                pages.Add(factory.CreatePage());
            }
            return pages;
        }
    }
}
