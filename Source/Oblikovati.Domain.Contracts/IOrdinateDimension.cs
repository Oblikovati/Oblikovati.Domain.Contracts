using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IOrdinateDimension
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
    DimensionTypeEnum DimensionType { get; }
    IGeometryIntent Intent { get; set; }
    IPoint2d JogPointOne { get; set; }
    IPoint2d JogPointTwo { get; set; }
    IDimensionStyle Style { get; set; }
    IOrdinateDimensionSet OrdinateDimensionSet { get; }
    bool IsOrdinateSetMember { get; }
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void GetInspectionDimensionData(out InspectionDimensionShapeEnum Shape, out string Label, out string Rate);
    void SetInspectionDimensionData(InspectionDimensionShapeEnum Shape, string Label, string Rate);
}
