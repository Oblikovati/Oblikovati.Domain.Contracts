using Oblikovati.Contracts.Application.TransientObjects.Utility;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.KnitFeature;

public interface IKnitFeatures : IList<IKnitFeatures>
{
    IKnitFeature Item { get; }


    IKnitFeature _Add(IObjectCollection Surfaces);
    IKnitFeature Add(IObjectCollection Surfaces, double MaximumTolerance, bool MaintainAsSurface);
}