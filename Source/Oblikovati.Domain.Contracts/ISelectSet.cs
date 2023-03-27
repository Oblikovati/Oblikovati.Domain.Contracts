namespace Oblikovati.Domain.Contracts;

public interface ISelectSet : IList<ISelectSet>
{
    object Item { get; }
    int Count { get; }
    void Select(object Entity);
    void Remove(object Index);
    void Clear();
    void Delete();
    IEnumerator GetEnumerator();
    void SelectMultiple(IObjectCollection Entities);
}
