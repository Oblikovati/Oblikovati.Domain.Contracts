using Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    LoftedFlangeFeature;
using Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    UnfoldFeature;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.Parameters;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition.SheetMetalFeatures.
    PunchToolFeature;

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