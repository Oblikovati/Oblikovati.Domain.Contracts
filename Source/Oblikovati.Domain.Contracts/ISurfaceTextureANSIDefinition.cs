using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ISurfaceTextureANSIDefinition
{

    ISheet Parent { get; }
    bool AllAroundSymbol { get; set; }
    bool IsForceTailShown { get; set; }
    bool IsMajority { get; set; }
    DraftingStandardEnum StandardReferenceType { get; }
    SurfaceTextureTypeEnum SurfaceTextureType { get; set; }
    string AdditionalMaxRoughness { get; set; }
    string AdditionalMinRoughness { get; set; }
    string Cutoff { get; set; }
    LayDirectionTypeEnum LayDirection { get; set; }
    string ProcessNote { get; set; }
    string MachiningAllowance { get; set; }
    string MaximumRoughness { get; set; }
    string MinimumRoughness { get; set; }
    string SamplingLength { get; set; }
}
