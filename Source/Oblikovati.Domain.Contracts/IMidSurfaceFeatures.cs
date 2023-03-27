namespace Oblikovati.Domain.Contracts;

public interface IMidSurfaceFeatures : IList<IMidSurfaceFeatures>
{

    IMidSurfaceFeature _Item { get; }
    int _Count { get; }
    IEnumerator GetEnumerator();
    IMidSurfaceFeature _Add(uint simulationId, IObjectCollection Bodies);
}
