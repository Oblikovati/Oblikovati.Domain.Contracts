namespace Oblikovati.Domain.Contracts;

public interface IRadialMarkingMenus : IList<IRadialMarkingMenus>
{
    IRadialMarkingMenu Item { get; }
    int Count { get; }
    IRadialMarkingMenu Add(string Name, string InternalName, string ClientId);
    IEnumerator GetEnumerator();
}
