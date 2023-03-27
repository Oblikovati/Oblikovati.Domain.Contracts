namespace Oblikovati.Domain.Contracts;

public interface ICornerRoundDefinition
{

    int EdgeSetCount { get; }
    ICornerRoundEdgeSet EdgeSetItem { get; }
    ICornerRoundFeature Parent { get; }
    ICornerRoundEdgeSet AddEdgeSet(IEdgeCollection CornerEdges, object Radius);
    void RemoveEdgeSet(int Index);
    ICornerRoundDefinition Copy();
}
