
namespace InformationSystem.Models
{
    public interface IPage<C, V>
    {
        C Controller { get; }
        V View { get; }
        string Name { get; }
    }
}