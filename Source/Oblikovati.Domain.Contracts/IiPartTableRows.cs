namespace Oblikovati.Domain.Contracts;

public interface IiPartTableRows : IList<IiPartTableRows>
{

    int Count { get; }
    IiPartTableRow Item { get; }
    IEnumerator GetEnumerator();
}
