using Oblikovati.Contracts.Application.TransientObjects.Utility;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    BendFeature;

public interface IBendFeatures : IList<IBendFeatures>
{
    IBendFeature Item { get; }


    IBendFeature Add(IBendDefinition BendDefinition);
    IBendDefinition CreateBendDefinition(IEdgeCollection Edges);
}