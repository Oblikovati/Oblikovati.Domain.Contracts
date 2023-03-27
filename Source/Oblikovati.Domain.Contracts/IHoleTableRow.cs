namespace Oblikovati.Domain.Contracts;

public interface IHoleTableRow : IList<IHoleTableRow>
{

    IHoleTable Parent { get; }
    IHoleTableCell Item { get; }
    int Count { get; }
    double Height { get; set; }
    IHoleTag HoleTag { get; }
    object ReferencedHole { get; }
    IEnumerator GetEnumerator();
    void Delete();
}
