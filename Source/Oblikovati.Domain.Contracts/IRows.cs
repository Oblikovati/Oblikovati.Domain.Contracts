namespace Oblikovati.Domain.Contracts;

public interface IRows : IList<IRows>
{

    IRow Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IRow Add(int TargetIndex, bool InsertBefore, object Contents, object Height);
}
