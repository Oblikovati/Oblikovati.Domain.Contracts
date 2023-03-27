namespace Oblikovati.Domain.Contracts;

public interface IHighlightSets : IList<IHighlightSets>
{
    IHighlightSet Item { get; }
    int Count { get; }
    IHighlightSet Add();
    IEnumerator GetEnumerator();
}
