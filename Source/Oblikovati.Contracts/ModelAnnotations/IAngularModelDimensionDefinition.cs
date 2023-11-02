using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition;
using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.NotClassified;
using Oblikovati.Contracts.Parameters;

namespace Oblikovati.Contracts.ModelAnnotations;

public interface IAngularModelDimensionDefinition
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
    ArrowheadTypeEnum FirstArrowheadType { get; set; }
    IGeometryIntent IntentOne { get; set; }
    IGeometryIntent IntentTwo { get; set; }
    IGeometryIntent IntentThree { get; set; }
    bool IsExtensionLineOneVisible { get; set; }
    bool IsExtensionLineTwoVisible { get; set; }
    bool IsFirstArrowheadInside { get; set; }
    bool IsSecondArrowheadInside { get; set; }
    ArrowheadTypeEnum SecondArrowheadType { get; set; }
    bool OppositeAngle { get; set; }
    bool UseQuadrant { get; set; }
    bool ArrowheadsInside { get; set; }
    void GetInspectionDimensionData(out InspectionDimensionShapeEnum Shape, out string Label, out string Rate);
    void SetInspectionDimensionData(InspectionDimensionShapeEnum Shape, string Label, string Rate);
    bool IsValidAnnotationPlane(object pPlane);
    IAngularModelDimensionDefinition Copy();
}