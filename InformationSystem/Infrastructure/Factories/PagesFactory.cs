using InformationSystem.Models;

namespace InformationSystem.Services.Factories
{
    public class PagesFactory<C, V> : IPagesFactory<C, V>
    {
        private List<IPageFactory<C, V>> _pagesFactories = new List<IPageFactory<C, V>>();
        public PagesFactory(IEnumerable<IPageFactory<C, V>> pages)
        {
            _pagesFactories.AddRange(pages);
        }
        public IEnumerable<IPage<C, V>> GetPages()
        {
            List<IPage<C, V>> pages = new List<IPage<C, V>>();
            foreach (var factory in _pagesFactories)
            {
                pages.Add(factory.CreatePage());
            }
            return pages;
        }
    }
}
