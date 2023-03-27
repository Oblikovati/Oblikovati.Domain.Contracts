namespace Oblikovati.Domain.Contracts;

public interface ICornerRoundEdgeSet
{
    IEdgeCollection Edges { get; set; }
    ICornerRoundDefinition Parent { get; }
    object Radius { get; set; }
}
