namespace Oblikovati.Domain.Contracts;

public interface IPartsListRows : IList<IPartsListRows>
{

    IPartsListRow Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IPartsListRow Add(int TargetIndex, bool InsertBefore);
}
