namespace Oblikovati.Domain.Contracts;

public interface IColumns : IList<IColumns>
{

    IColumn Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IColumn Add(string Title, int TargetIndex, bool InsertBefore, object Width);
}
