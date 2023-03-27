using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ISurfaceTextureSymbolDefinition
{

    ISheet Parent { get; }
    bool AllAroundSymbol { get; set; }
    bool IsForceTailShown { get; set; }
    bool IsMajority { get; set; }
    DraftingStandardEnum StandardReferenceType { get; }
    SurfaceTextureTypeEnum SurfaceTextureType { get; set; }
}
