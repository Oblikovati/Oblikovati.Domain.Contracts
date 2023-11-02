using Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition.PartFeatures.PartFeature;
using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.NotClassified;
using Oblikovati.Contracts.Sketch2D;
using Oblikovati.Contracts.Sketch2D.DimensionConstraints;
using Oblikovati.Contracts.Sketch2D.GeometricConstraints;
using Oblikovati.Contracts.Sketch2D.Profiles;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition;

public interface IPlanarSketch
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
    bool Adaptive { get; set; }
    bool Shared { get; set; }
    object PlanarEntity { get; set; }
    IPlane PlanarEntityGeometry { get; }
    object AxisEntity { get; set; }
    ILine AxisEntityGeometry { get; }
    bool NaturalAxisDirection { get; set; }
    bool AxisIsX { get; set; }
    object OriginPoint { get; set; }
    IPoint OriginPointGeometry { get; }
    IMatrix ModelToSketchTransform { get; }
    IMatrix SketchToModelTransform { get; }
    IObjectsEnumerator Dependents { get; }
    IProfiles Profiles { get; }
    IPlanarSketch ReferencedEntity { get; }
    bool HasReferenceComponent { get; }
    IReferenceComponent ReferenceComponent { get; }
    bool Consumed { get; }
    bool DimensionsVisible { get; set; }
    HealthStatusEnum HealthStatus { get; }
    bool VisibleBelowEndOfPart { get; set; }
    bool IsOwnedByFeature { get; }
    IPartFeature OwnedBy { get; }
    IProjectedCuts ProjectedCuts { get; }
    ISketchBlocks SketchBlocks { get; }
    bool Exported { get; set; }
    bool CopyToFlatPattern { get; set; }
    int CheckSumValue { get; }
    void Edit();
    void ExitEdit();
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);

    IObjectsEnumerator MoveSketchObjects(IObjectCollection SketchObjects, IVector2d Vector, bool Copy,
        bool RemoveConstraints);

    IObjectsEnumerator RotateSketchObjects(IObjectCollection SketchObjects, IPoint2d CenterPoint, double Angle,
        bool Copy, bool RemoveConstraints);

    void Solve();

    ISketchEntitiesEnumerator OffsetSketchEntitiesUsingDistance(IObjectCollection SketchEntities, double OffsetDistance,
        bool NaturalOffsetDirection, bool IncludeConnectedEntities, bool CreateOffsetConstraints);

    ISketchEntitiesEnumerator OffsetSketchEntitiesUsingPoint(IObjectCollection SketchEntities, IPoint2d OffsetPoint,
        bool IncludeConnectedEntities, bool CreateOffsetConstraints);

    ISketchEntity AddByProjectingEntity(object Entity);
    void GetCustomLineType(out string LineTypeName, out string LineTypeDescription);
    void SetCustomLineType(string FullFileName, string LineTypeName, bool ReplaceExisting);
    void CopyContentsTo(ISketch TargetSketch);
    ISketchEntitiesEnumerator AddStraightSlotByCenterToCenter(object StartPoint, object EndPoint, double Width);
    ISketchEntitiesEnumerator AddStraightSlotByOverall(object StartPoint, object EndPoint, double Width);
    ISketchEntitiesEnumerator AddStraightSlotBySlotCenter(object CenterPoint, object EndPoint, double Width);

    ISketchEntitiesEnumerator AddArcSlotByThreePointArc(object StartPoint, object MidPoint, object EndPoint,
        double Width);

    ISketchEntitiesEnumerator AddArcSlotByCenterPointArc(object CenterPoint, object StartPoint, double SweepAngle,
        double Width);

    ISketchEntity AddBySilhouette(IFace Face, IPoint ProximityPoint);
    IPoint2d ModelToSketchSpace(IPoint ModelCoordinate);
    IPoint SketchToModelSpace(IPoint2d SketchCoordinate);
    void SetEndOfPart(bool Before);
    void UpdateProfiles();
    void BreakLink();
}