using InformationSystem.Models;

namespace InformationSystem.StringView
{
    public interface IStringView
    {
        void ShowTitles(IEnumerable<Title> titles);
        event EventHandler? OnSelect;
    }
}
