namespace Oblikovati.Domain.Contracts;

public interface IContentTableRows : IList<IContentTableRows>
{

    int Count { get; }
    IContentTableRow Item { get; }
    IContentTableRow Add(ref List<string> RowData, int Position);
    IEnumerator GetEnumerator();
}
