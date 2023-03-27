namespace Oblikovati.Domain.Contracts;

public interface IRefoldFeatures : IList<IRefoldFeatures>
{

    IRefoldFeature Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IRefoldFeature Add(IFace StationaryFace, object Bends, object Sketches);
}
