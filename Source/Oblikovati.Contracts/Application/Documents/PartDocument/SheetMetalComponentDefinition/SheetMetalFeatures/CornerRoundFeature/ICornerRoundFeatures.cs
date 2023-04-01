using Oblikovati.Contracts.Application.TransientObjects.Utility;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    CornerRoundFeature;

public interface ICornerRoundFeatures : IList<ICornerRoundFeatures>
{
    ICornerRoundFeature Item { get; }


    ICornerRoundFeature Add(ICornerRoundDefinition CornerRoundDefinition);
    ICornerRoundDefinition CreateCornerRoundDefinition(IEdgeCollection CornerEdges, object Radius);
}