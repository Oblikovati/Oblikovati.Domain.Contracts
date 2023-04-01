using Oblikovati.Contracts.Application.TransientObjects.Utility;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    CornerRoundFeature;

public interface ICornerRoundEdgeSet
{
    IEdgeCollection Edges { get; set; }
    ICornerRoundDefinition Parent { get; }
    object Radius { get; set; }
}