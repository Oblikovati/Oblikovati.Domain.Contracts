using Oblikovati.Contracts.Application.TransientObjects.Utility;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    FlangeFeature;

public interface IFlangeFeatures : IList<IFlangeFeatures>
{
    IFlangeFeature Item { get; }


    IFlangeFeature Add(IFlangeDefinition FlangeDefinition);

    IFlangeDefinition CreateFlangeDefinition(IEdgeCollection Edges, object FlangeAngleOrFlangeAngleReferencePlane,
        object Distance);
}