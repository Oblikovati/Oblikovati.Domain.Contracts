namespace Oblikovati.Domain.Contracts;

public interface IFlatPatternPlates : IList<IFlatPatternPlates>
{

    int Count { get; }
    IFlatPatternPlate Item { get; }
    IEnumerator GetEnumerator();
}
