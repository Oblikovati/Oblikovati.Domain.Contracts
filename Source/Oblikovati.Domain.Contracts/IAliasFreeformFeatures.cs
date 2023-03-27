namespace Oblikovati.Domain.Contracts;

public interface IAliasFreeformFeatures : IList<IAliasFreeformFeatures>
{

    IAliasFreeformFeature Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IAliasFreeformFeature _Add(ISurfaceBody BaseBody);
}
