namespace Oblikovati.Domain.Contracts;

public interface IDisabledCommandList : IList<IDisabledCommandList>
{
    int Count { get; }
    IControlDefinition Item { get; }
    IEnumerator GetEnumerator();
    void Add(IControlDefinition Command);
    void Remove(int Index);
}
