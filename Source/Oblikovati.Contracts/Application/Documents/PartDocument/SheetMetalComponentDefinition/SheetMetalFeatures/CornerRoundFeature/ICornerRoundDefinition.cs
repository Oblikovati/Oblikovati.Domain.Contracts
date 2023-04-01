using Oblikovati.Contracts.Application.TransientObjects.Utility;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    CornerRoundFeature;

public interface ICornerRoundDefinition
{
    int EdgeSetCount { get; }
    ICornerRoundEdgeSet EdgeSetItem { get; }
    ICornerRoundFeature Parent { get; }
    ICornerRoundEdgeSet AddEdgeSet(IEdgeCollection CornerEdges, object Radius);
    void RemoveEdgeSet(int Index);
    ICornerRoundDefinition Copy();
}