namespace Oblikovati.Domain.Contracts;

public interface ISnapFitFeatures : IList<ISnapFitFeatures>
{

    ISnapFitFeature Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
}
