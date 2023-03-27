namespace Oblikovati.Domain.Contracts;

public interface IDirectEditOperations : IList<IDirectEditOperations>
{

    IDirectEditOperation Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
}
