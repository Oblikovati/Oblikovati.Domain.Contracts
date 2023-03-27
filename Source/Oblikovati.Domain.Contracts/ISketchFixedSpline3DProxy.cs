using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ISketchFixedSpline3DProxy
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
    ISketchPoint3D EndSketchPoint { get; }
    ISketchPoint3D StartSketchPoint { get; }
    IBSplineCurve Geometry { get; set; }
    double Length { get; }
    bool Closed { get; }
    bool IsDefinedByEdge { get; }
    ISketchFixedSpline3D NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void Edit(IBSplineCurve SplineCurve, object StartPoint, object EndPoint);
    ISketchSpline3D ConvertToSpline();
    void EditByEdge(IEdge TransientEdge);
}
