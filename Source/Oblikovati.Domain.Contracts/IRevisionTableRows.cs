namespace Oblikovati.Domain.Contracts;

public interface IRevisionTableRows : IList<IRevisionTableRows>
{

    IRevisionTableRow Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IRevisionTableRow Add();
    IRevisionTableRow AddCustom(int TargetIndex, bool InsertBefore);
}
