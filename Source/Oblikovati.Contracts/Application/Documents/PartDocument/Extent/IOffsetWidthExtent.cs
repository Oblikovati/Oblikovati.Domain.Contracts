using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.PartFeature;
using Oblikovati.Contracts.NotClassified;
using Oblikovati.Contracts.Parameters;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.Extent;

public interface IOffsetWidthExtent
{
    IPartFeature Parent { get; }
    IEdge Edge { get; }
    IParameter OffsetDistanceOne { get; }
    IParameter OffsetDistanceTwo { get; }
    object OffsetEntityOne { get; }
    object OffsetEntityTwo { get; }
}