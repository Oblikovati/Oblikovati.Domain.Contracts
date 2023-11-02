using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.NotClassified;
using Oblikovati.Contracts.Sketch3D.GeometricConstraints3D;

namespace Oblikovati.Contracts.Sketch3D;

public interface ISketchControlPointSpline3D
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
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    ISketchSpline3D ConvertToSpline();
    double InsertKnot(double Position);
}