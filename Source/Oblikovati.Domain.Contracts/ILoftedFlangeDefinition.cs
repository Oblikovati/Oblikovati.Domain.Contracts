using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ILoftedFlangeDefinition
{

    object BendRadius { get; set; }
    bool Converge { get; set; }
    PartFeatureExtentDirectionEnum ExtentDirection { get; set; }
    IParameter FacetTolerance { get; }
    LoftedFlangeOutputTypeEnum OutputType { get; }
    ILoftedFlangeFeature Parent { get; }
    IPath ProfileOne { get; set; }
    IPath ProfileTwo { get; set; }
    IUnfoldMethod UnfoldMethod { get; set; }
    bool IsUnfoldMethodOverridden { get; set; }
    PartFeatureOperationEnum Operation { get; set; }
    IObjectCollection AffectedBodies { get; set; }
    bool UseDefaultSheetMetalRule { get; set; }
    ISheetMetalStyle SheetMetalRule { get; set; }
    ILoftedFlangeDefinition Copy();
    void SetOutputType(LoftedFlangeOutputTypeEnum OutputType, object FacetTolerance);
}
