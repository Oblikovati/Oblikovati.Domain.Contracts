using Oblikovati.Contracts.Application.TransientObjects.Utility;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    CornerFeature;

public interface ICornerFeatures : IList<ICornerFeatures>
{
    ICornerFeature Item { get; }


    ICornerFeature Add(ICornerDefinition CornerDefinition);
    ICornerDefinition CreateCornerDefinition(IEdgeCollection Edges, bool RippedCorner);
}