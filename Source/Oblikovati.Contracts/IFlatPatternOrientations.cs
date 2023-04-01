namespace Oblikovati.Contracts;

public interface IFlatPatternOrientations : IList<IFlatPatternOrientations>
{
    IFlatPatternOrientation Item { get; }

    IFlatPatternOrientation ActiveFlatPatternOrientation { get; }
}