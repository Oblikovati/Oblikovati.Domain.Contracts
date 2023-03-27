using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IDrawingSketch
{


    IDataIO DataIO { get; }
    string Name { get; set; }
    bool Visible { get; set; }
    IGeometricConstraints GeometricConstraints { get; }
    IDimensionConstraints DimensionConstraints { get; }
    ISketchEntitiesEnumerator SketchEntities { get; }
    ISketchArcs SketchArcs { get; }
    ISketchLines SketchLines { get; }
    ISketchPoints SketchPoints { get; }
    ISketchSplines SketchSplines { get; }
    ISketchOffsetSplines SketchOffsetSplines { get; }
    ISketchEllipses SketchEllipses { get; }
    ISketchEllipticalArcs SketchEllipticalArcs { get; }
    ISketchCircles SketchCircles { get; }
    ITextBoxes TextBoxes { get; }
    IAttributeSets AttributeSets { get; }
    ISketchFixedSplines SketchFixedSplines { get; }
    ActionTypeEnum DisabledActionTypes { get; set; }
    ConstraintStatusEnum ConstraintStatus { get; }
    bool DeferUpdates { get; set; }
    ISketchImages SketchImages { get; }
    IColor Color { get; set; }
    LineTypeEnum LineType { get; set; }
    double LineWeight { get; set; }
    ISketchControlPointSplines SketchControlPointSplines { get; }
    ISketchEquationCurves SketchEquationCurves { get; }
    ITextBoxes _TextBoxes { get; }
    IProfiles Profiles { get; }
    ISketchFillRegions SketchFillRegions { get; }
    ISketchHatchRegions SketchHatchRegions { get; }
    void Edit();
    void ExitEdit();
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    IObjectsEnumerator MoveSketchObjects(IObjectCollection SketchObjects, IVector2d Vector, bool Copy, bool RemoveConstraints);
    IObjectsEnumerator RotateSketchObjects(IObjectCollection SketchObjects, IPoint2d CenterPoint, double Angle, bool Copy, bool RemoveConstraints);
    void Solve();
    ISketchEntitiesEnumerator OffsetSketchEntitiesUsingDistance(IObjectCollection SketchEntities, double OffsetDistance, bool NaturalOffsetDirection, bool IncludeConnectedEntities, bool CreateOffsetConstraints);
    ISketchEntitiesEnumerator OffsetSketchEntitiesUsingPoint(IObjectCollection SketchEntities, IPoint2d OffsetPoint, bool IncludeConnectedEntities, bool CreateOffsetConstraints);
    ISketchEntity AddByProjectingEntity(object Entity);
    void GetCustomLineType(out string LineTypeName, out string LineTypeDescription);
    void SetCustomLineType(string FullFileName, string LineTypeName, bool ReplaceExisting);
    void CopyContentsTo(ISketch TargetSketch);
    ISketchEntitiesEnumerator AddStraightSlotByCenterToCenter(object StartPoint, object EndPoint, double Width);
    ISketchEntitiesEnumerator AddStraightSlotByOverall(object StartPoint, object EndPoint, double Width);
    ISketchEntitiesEnumerator AddStraightSlotBySlotCenter(object CenterPoint, object EndPoint, double Width);
    ISketchEntitiesEnumerator AddArcSlotByThreePointArc(object StartPoint, object MidPoint, object EndPoint, double Width);
    ISketchEntitiesEnumerator AddArcSlotByCenterPointArc(object CenterPoint, object StartPoint, double SweepAngle, double Width);
    IPoint2d SheetToSketchSpace(IPoint2d SheetCoordinate);
    IPoint2d SketchToSheetSpace(IPoint2d SketchCoordinate);
    void GetAutomatedCenterlineSettings(out IAutomatedCenterlineSettings AutomatedCenterlineSettings);
    IObjectsEnumerator SetAutomatedCenterlineSettings(object AutomatedCenterlineSettings);
}
