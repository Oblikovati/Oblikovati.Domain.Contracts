namespace Oblikovati.Domain.Contracts;

public interface ITrimFeatures : IList<ITrimFeatures>
{

    ITrimFeature Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
}
