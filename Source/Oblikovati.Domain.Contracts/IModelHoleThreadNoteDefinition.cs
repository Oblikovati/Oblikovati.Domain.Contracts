using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IModelHoleThreadNoteDefinition
{
    IModelAnnotation Parent { get; }
    IGeometryIntent Intent { get; set; }
    string FormattedHoleThreadNote { get; set; }
    bool IsHoleNote { get; set; }
    bool IsTapDrill { get; set; }
    bool UseCustomThreadDesignation { get; set; }
    bool UseDefaultFormat { get; set; }
    IAnnotationPlane AnnotationPlane { get; set; }
    IAnnotationPlaneDefinition AnnotationPlaneDefinition { get; set; }
    ArrowheadTypeEnum ArrowheadType { get; set; }
    IModelAnnotationText Text { get; }
    IPoint TextPosition { get; set; }
    IPoint LandingPosition { get; set; }
    bool UseParameterTolerance { get; set; }
    bool UseModelUnits { get; set; }
    IModelHoleThreadNoteDefinition Copy();
    ITolerance GetHolePropertyTolerance(HolePropertyEnum HolePropEnum);
    int GetHolePropertyTolerancePrecision(HolePropertyEnum HolePropEnum);
    void SetHolePropertyTolerancePrecision(HolePropertyEnum HolePropEnum, int Value);
    bool IsValidAnnotationPlane(object pPlane);
    bool GetHolePropertyToleranceStatus(HolePropertyEnum HolePropEnum);
    void SetHolePropertyToleranceStatus(HolePropertyEnum HolePropEnum, bool Value);
}
