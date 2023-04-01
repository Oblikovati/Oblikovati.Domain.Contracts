namespace Oblikovati.Contracts;

public interface IHoleTableRow : IList<IHoleTableRow>
{
    IHoleTable Parent { get; }
    IHoleTableCell Item { get; }

    double Height { get; set; }
    IHoleTag HoleTag { get; }
    object ReferencedHole { get; }

    void Delete();
}