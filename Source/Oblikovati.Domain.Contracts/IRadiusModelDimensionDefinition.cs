using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IRadiusModelDimensionDefinition
{
    bool IsInspectionDimension { get; set; }
    bool IsModelValueOverridden { get; set; }
    bool IsValueHidden { get; set; }
    IAnnotationPlane AnnotationPlane { get; set; }
    IAnnotationPlaneDefinition AnnotationPlaneDefinition { get; set; }
    double OverrideModelValue { get; set; }
    IModelDimension Parent { get; }
    int Precision { get; set; }
    int TolerancePrecision { get; set; }
    IModelAnnotationText Text { get; }
    IPoint TextPosition { get; set; }
    ITolerance Tolerance { get; }
    IParameter PromoteParameter { get; set; }
    ArrowheadTypeEnum ArrowheadType { get; set; }
    IGeometryIntent Intent { get; set; }
    bool IsArrowheadInside { get; set; }
    bool IsLeaderFromCenter { get; set; }
    bool IsJogged { get; set; }
    IPoint LandingPosition { get; set; }
    void GetInspectionDimensionData(out InspectionDimensionShapeEnum Shape, out string Label, out string Rate);
    void SetInspectionDimensionData(InspectionDimensionShapeEnum Shape, string Label, string Rate);
    bool IsValidAnnotationPlane(object pPlane);
    IRadiusModelDimensionDefinition Copy();
}
