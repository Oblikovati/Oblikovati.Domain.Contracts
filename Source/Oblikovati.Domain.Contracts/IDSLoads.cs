namespace Oblikovati.Domain.Contracts;

public interface IDSLoads : IList<IDSLoads>
{

    int Count { get; }
    IDSLoad Item { get; }
    IEnumerator GetEnumerator();
}
