namespace Oblikovati.Domain.Contracts;

public interface ICommandBarBaseCollection : IList<ICommandBarBaseCollection>
{
    ICommandBarBase Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    ICommandBarBase Add(string DisplayName, object InternalName);
}
