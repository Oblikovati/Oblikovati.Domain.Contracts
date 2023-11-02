namespace Oblikovati.Contracts.NotClassified;

public interface IFlatPatternPlates : IList<IFlatPatternPlates>
{
    IFlatPatternPlate Item { get; }
}