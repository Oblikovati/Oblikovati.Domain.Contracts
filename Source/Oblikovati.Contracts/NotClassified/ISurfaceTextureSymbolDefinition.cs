using Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.NotClassified;

public interface ISurfaceTextureSymbolDefinition
{
    ISheet Parent { get; }
    bool AllAroundSymbol { get; set; }
    bool IsForceTailShown { get; set; }
    bool IsMajority { get; set; }
    DraftingStandardEnum StandardReferenceType { get; }
    SurfaceTextureTypeEnum SurfaceTextureType { get; set; }
}