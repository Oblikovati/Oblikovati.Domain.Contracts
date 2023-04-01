using Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts;

public interface ISurfaceTextureGOSTDefinition
{
    ISheet Parent { get; }
    bool AllAroundSymbol { get; set; }
    bool IsForceTailShown { get; set; }
    bool IsMajority { get; set; }
    DraftingStandardEnum StandardReferenceType { get; }
    SurfaceTextureTypeEnum SurfaceTextureType { get; set; }
    string FirstRequirement { get; set; }
    string SecondRequirement { get; set; }
    string ThirdRequirement { get; set; }
    string FourthRequirement { get; set; }
    LayDirectionTypeEnum TextureDirection { get; set; }
    string ProductionMethod { get; set; }
}