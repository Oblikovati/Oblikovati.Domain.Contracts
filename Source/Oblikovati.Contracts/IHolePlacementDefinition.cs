using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.HoleFeature;

namespace Oblikovati.Contracts;

public interface IHolePlacementDefinition
{
    IHoleFeature Parent { get; }
}