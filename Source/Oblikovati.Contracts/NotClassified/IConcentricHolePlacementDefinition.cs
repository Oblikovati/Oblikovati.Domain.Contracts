using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.HoleFeature;

namespace Oblikovati.Contracts.NotClassified;

public interface IConcentricHolePlacementDefinition
{
    IHoleFeature Parent { get; }
    object Plane { get; }
    object ConcentricReference { get; }
}