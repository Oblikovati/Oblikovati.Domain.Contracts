namespace Oblikovati.Domain.Contracts;

public interface IiPartTableColumns : IList<IiPartTableColumns>
{

    int Count { get; }
    IiPartTableColumn Item { get; }
    IEnumerator GetEnumerator();
}
