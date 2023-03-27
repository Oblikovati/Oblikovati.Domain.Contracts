namespace Oblikovati.Domain.Contracts;

public interface IGrillFeatures : IList<IGrillFeatures>
{

    IGrillFeature Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
}
