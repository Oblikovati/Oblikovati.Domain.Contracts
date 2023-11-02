using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.HoleFeature;

namespace Oblikovati.Contracts.NotClassified;

public interface IPointHolePlacementDefinition
{
    IHoleFeature Parent { get; }
    object Point { get; }
    object Direction { get; }
}