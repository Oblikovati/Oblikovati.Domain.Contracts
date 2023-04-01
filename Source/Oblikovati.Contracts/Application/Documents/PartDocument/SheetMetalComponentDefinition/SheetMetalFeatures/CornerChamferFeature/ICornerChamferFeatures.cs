namespace Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    CornerChamferFeature;

public interface ICornerChamferFeatures : IList<ICornerChamferFeatures>
{
    ICornerChamferFeature Item { get; }


    ICornerChamferFeature Add(ICornerChamferDefinition CornerChamferDefinition);
    ICornerChamferDefinition CreateCornerChamferDefinition(object CornerEdges, object Distance);
}