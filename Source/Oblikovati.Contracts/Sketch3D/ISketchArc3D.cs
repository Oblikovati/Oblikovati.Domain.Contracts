using Oblikovati.Contracts.Application.TransientGeometry;
using Oblikovati.Contracts.Application.TransientObjects.Math;
using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.Enums;
using Oblikovati.Contracts.NotClassified;
using Oblikovati.Contracts.Sketch3D.GeometricConstraints3D;

namespace Oblikovati.Contracts.Sketch3D;

public interface ISketchArc3D
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
    object EndPoint { get; }
    object StartPoint { get; }
    ISketchPoint3D EndSketchPoint { get; }
    ISketchPoint3D StartSketchPoint { get; }
    IPoint CenterPoint { get; }
    IArc3d Geometry { get; set; }
    double Length { get; }
    bool CurvatureDisplay { get; set; }
    double Radius { get; }
    double StartAngle { get; }
    double SweepAngle { get; }
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
}