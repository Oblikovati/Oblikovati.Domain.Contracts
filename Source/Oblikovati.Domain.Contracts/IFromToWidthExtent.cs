namespace Oblikovati.Domain.Contracts;

public interface IFromToWidthExtent
{

    IPartFeature Parent { get; }
    IEdge Edge { get; }
    object FromEntity { get; }
    object ToEntity { get; }
}
