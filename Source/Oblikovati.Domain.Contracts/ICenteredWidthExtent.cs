namespace Oblikovati.Domain.Contracts;

public interface ICenteredWidthExtent
{

    IPartFeature Parent { get; }
    IEdge Edge { get; }
    IParameter Width { get; }
}
