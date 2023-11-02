using Oblikovati.Contracts.Application.Documents.PartDocument.SheetMetalComponentDefinition;
using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.NotClassified;
using Oblikovati.Contracts.Parameters;

namespace Oblikovati.Contracts.Application.Documents.DrawingDocument.Sheets.DrawingDimensions;

public interface IDrawingDimension
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
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void GetInspectionDimensionData(out InspectionDimensionShapeEnum Shape, out string Label, out string Rate);
    void SetInspectionDimensionData(InspectionDimensionShapeEnum Shape, string Label, string Rate);
}