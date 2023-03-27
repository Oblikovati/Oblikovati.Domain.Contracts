namespace Oblikovati.Domain.Contracts;

public interface IBossFeatures : IList<IBossFeatures>
{

    IBossFeature Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
}
