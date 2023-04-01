using Oblikovati.Contracts.Application.TransientObjects.Utility;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.
    MidSurfaceFeature;

public interface IMidSurfaceFeatures : IList<IMidSurfaceFeatures>
{
    IMidSurfaceFeature _Item { get; }
    int _Count { get; }

    IMidSurfaceFeature _Add(uint simulationId, IObjectCollection Bodies);
}