namespace Oblikovati.Domain.Contracts;

public interface IFlatPatternOrientations : IList<IFlatPatternOrientations>
{

    IFlatPatternOrientation Item { get; }
    int Count { get; }
    IFlatPatternOrientation ActiveFlatPatternOrientation { get; }
    IEnumerator GetEnumerator();
}
