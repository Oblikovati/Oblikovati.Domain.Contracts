namespace Oblikovati.Domain.Contracts;

public interface IHoleTableRows : IList<IHoleTableRows>
{

    IHoleTableRow Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IHoleTableRow Add(object Hole);
}
