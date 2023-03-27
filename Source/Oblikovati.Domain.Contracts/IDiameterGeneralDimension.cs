using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IDiameterGeneralDimension
{

    ISheet Parent { get; }
    IAttributeSets AttributeSets { get; }
    bool HideValue { get; set; }
    double ModelValue { get; }
    double OverrideModelValue { get; set; }
    bool ModelValueOverridden { get; set; }
    int Precision { get; set; }
    IDimensionText Text { get; set; }
    ITolerance Tolerance { get; }
    ILayer Layer { get; set; }
    bool Attached { get; }
    int TolerancePrecision { get; set; }
    object DimensionLine { get; }
    bool IsInspectionDimension { get; set; }
    bool ArrowheadsInside { get; set; }
    bool FirstArrowheadInside { get; set; }
    bool Retrieved { get; }
    bool SecondArrowheadInside { get; set; }
    IDimensionStyle Style { get; set; }
    bool _ShowLeader { get; }
    object RetrievedFrom { get; }
    GeneralDimensionTypeEnum GeneralDimensionType { get; }
    ArrowheadTypeEnum FirstArrowheadType { get; set; }
    ArrowheadTypeEnum SecondArrowheadType { get; set; }
    IGeometryIntent Intent { get; set; }
    bool LeaderFromCenter { get; set; }
    bool SingleDimensionLine { get; set; }
    object ExtensionLineOne { get; }
    object ExtensionLineTwo { get; }
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void GetInspectionDimensionData(out InspectionDimensionShapeEnum Shape, out string Label, out string Rate);
    void SetInspectionDimensionData(InspectionDimensionShapeEnum Shape, string Label, string Rate);
    IDimensionConstraint PromoteToSketch();
    void ShowAllExtensionLines();
}
