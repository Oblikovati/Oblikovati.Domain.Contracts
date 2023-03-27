namespace Oblikovati.Domain.Contracts;

public interface IUnfoldFeatures : IList<IUnfoldFeatures>
{

    IUnfoldFeature Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IUnfoldFeature Add(IFace StationaryFace, object Bends, object Sketches);
}
