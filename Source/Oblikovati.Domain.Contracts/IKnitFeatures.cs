namespace Oblikovati.Domain.Contracts;

public interface IKnitFeatures : IList<IKnitFeatures>
{

    IKnitFeature Item { get; }
    int Count { get; }
    IEnumerator GetEnumerator();
    IKnitFeature _Add(IObjectCollection Surfaces);
    IKnitFeature Add(IObjectCollection Surfaces, double MaximumTolerance, bool MaintainAsSurface);
}
