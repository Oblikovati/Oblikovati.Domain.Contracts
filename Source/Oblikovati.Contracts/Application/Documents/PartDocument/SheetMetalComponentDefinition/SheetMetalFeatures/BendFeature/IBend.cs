using Oblikovati.Contracts.NotClassified;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    BendFeature;

public interface IBend
{
    ISheetMetalComponentDefinition Parent { get; }
    IFaces BackFaces { get; }
    IFaces FrontFaces { get; }
    bool IsFlat { get; }
}