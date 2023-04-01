using Oblikovati.Contracts.Application.TransientObjects.Utility;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    HemFeature;

public interface IHemFeatures : IList<IHemFeatures>
{
    IHemFeature Item { get; }


    IHemFeature Add(IHemDefinition HemDefinition);
    IHemDefinition CreateHemDefinition(IEdgeCollection Edges);
}