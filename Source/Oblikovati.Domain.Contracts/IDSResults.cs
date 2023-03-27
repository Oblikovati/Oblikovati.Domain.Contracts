namespace Oblikovati.Domain.Contracts;

public interface IDSResults : IList<IDSResults>
{

    int Count { get; }
    IDSResult Item { get; }
    IDSResult ItemByResultType { get; }
    IEnumerator GetEnumerator();
}
