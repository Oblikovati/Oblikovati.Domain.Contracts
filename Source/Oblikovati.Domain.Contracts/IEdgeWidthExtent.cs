namespace Oblikovati.Domain.Contracts;

public interface IEdgeWidthExtent
{

    IPartFeature Parent { get; }
    IEdge Edge { get; }
}
