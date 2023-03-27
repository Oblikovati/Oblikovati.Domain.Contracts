namespace Oblikovati.Domain.Contracts;

public interface IFreeformFeatures : IList<IFreeformFeatures>
{

    IFreeformFeature Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
}
