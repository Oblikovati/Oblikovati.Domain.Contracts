namespace Oblikovati.Domain.Contracts;

public interface IDirectEditFeatures : IList<IDirectEditFeatures>
{

    IDirectEditFeature Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
}
