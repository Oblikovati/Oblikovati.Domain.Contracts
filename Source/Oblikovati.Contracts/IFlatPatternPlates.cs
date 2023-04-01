namespace Oblikovati.Contracts;

public interface IFlatPatternPlates : IList<IFlatPatternPlates>
{
    IFlatPatternPlate Item { get; }
}