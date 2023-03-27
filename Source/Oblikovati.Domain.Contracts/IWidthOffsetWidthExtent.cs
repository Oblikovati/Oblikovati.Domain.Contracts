namespace Oblikovati.Domain.Contracts;

public interface IWidthOffsetWidthExtent
{

    IPartFeature Parent { get; }
    IEdge Edge { get; }
    IParameter Width { get; }
    IParameter OffsetDistance { get; }
    object OffsetEntity { get; }
    bool PositiveDirection { get; }
}
