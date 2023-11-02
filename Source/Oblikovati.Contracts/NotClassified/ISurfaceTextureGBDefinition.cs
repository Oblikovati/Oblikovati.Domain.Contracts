using Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.NotClassified;

public interface ISurfaceTextureGBDefinition
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
    LayDirectionTypeEnum LayDirection { get; set; }
    string ProcessNoteOne { get; set; }
    string ProcessNoteTwo { get; set; }
    string MachiningAllowance { get; set; }
}