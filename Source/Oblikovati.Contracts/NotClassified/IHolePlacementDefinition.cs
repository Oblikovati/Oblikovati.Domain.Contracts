using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.HoleFeature;

namespace Oblikovati.Contracts.NotClassified;

public interface IHolePlacementDefinition
{
    IHoleFeature Parent { get; }
}