namespace Oblikovati.Domain.Contracts;

public interface IFlatBendResults : IList<IFlatBendResults>
{

    IFlatBendResult Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
}
