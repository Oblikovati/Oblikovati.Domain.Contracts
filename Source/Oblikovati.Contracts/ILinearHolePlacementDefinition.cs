using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.HoleFeature;
using Oblikovati.Contracts.Parameters;

namespace Oblikovati.Contracts;

public interface ILinearHolePlacementDefinition
{
    IHoleFeature Parent { get; }
    object Plane { get; }
    object ReferenceEntityOne { get; }
    IParameter DistanceOne { get; }
    bool DirectionOneReversed { get; set; }
    object ReferenceEntityTwo { get; }
    IParameter DistanceTwo { get; }
    bool DirectionTwoReversed { get; set; }
}