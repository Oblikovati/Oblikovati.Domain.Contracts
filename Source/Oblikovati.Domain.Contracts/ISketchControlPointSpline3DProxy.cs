using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ISketchControlPointSpline3DProxy
{

    ISketch3D Parent { get; }
    IAttributeSets AttributeSets { get; }
    ISketchConstraints3DEnumerator Constraints3D { get; }
    bool HasReferenceComponent { get; }
    IBox RangeBox { get; }
    bool Reference { get; set; }
    object ReferencedEntity { get; }
    IReferenceComponent ReferenceComponent { get; }
    bool Construction { get; set; }
    ISketchEntities3DEnumerator OwnedBy { get; }
    ConstraintStatusEnum ConstraintStatus { get; }
    int AssociativeID { get; }
    GeometryMoveableStatusEnum _GeometryMoveableStatus { get; }
    ISketchPoint3D ControlPoint { get; }
    int ControlPointCount { get; }
    ISketchLine3D ControlPolygonSide { get; }
    bool CurvatureDisplay { get; set; }
    ISketchPoint3D EndSketchPoint { get; }
    IBSplineCurve Geometry { get; }
    bool IsClosed { get; }
    double Length { get; }
    ISketchPoint3D StartSketchPoint { get; }
    ISketchControlPointSpline3D NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    ISketchSpline3D ConvertToSpline();
    double InsertKnot(double Position);
}
