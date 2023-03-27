namespace Oblikovati.Domain.Contracts;

public interface IOffsetWidthExtent
{

    IPartFeature Parent { get; }
    IEdge Edge { get; }
    IParameter OffsetDistanceOne { get; }
    IParameter OffsetDistanceTwo { get; }
    object OffsetEntityOne { get; }
    object OffsetEntityTwo { get; }
}
