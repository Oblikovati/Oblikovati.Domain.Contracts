namespace Oblikovati.Domain.Contracts;

public interface ICommandBarList : IList<ICommandBarList>
{
    ICommandBar Item { get; }
    int Count { get; }
    bool InheritAll { get; set; }
    void _Add(object CommandBar);
    void Add(ICommandBar CommandBar);
    void Remove(int Index);
    IEnumerator GetEnumerator();
}
