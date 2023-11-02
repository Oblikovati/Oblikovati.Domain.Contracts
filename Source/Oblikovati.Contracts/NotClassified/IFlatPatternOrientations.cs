namespace Oblikovati.Contracts.NotClassified;

public interface IFlatPatternOrientations : IList<IFlatPatternOrientations>
{
    IFlatPatternOrientation Item { get; }

    IFlatPatternOrientation ActiveFlatPatternOrientation { get; }
}