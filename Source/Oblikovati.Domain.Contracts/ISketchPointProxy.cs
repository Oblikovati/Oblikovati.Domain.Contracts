using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface ISketchPointProxy
{

    ISketch Parent { get; }
    IAttributeSets AttributeSets { get; }
    object ReferencedEntity { get; }
    IBox2d RangeBox { get; }
    ISketchConstraintsEnumerator Constraints { get; }
    bool Reference { get; set; }
    bool Construction { get; set; }
    bool HasReferenceComponent { get; }
    IReferenceComponent ReferenceComponent { get; }
    ActionTypeEnum DisabledActionTypes { get; set; }
    ConstraintStatusEnum ConstraintStatus { get; }
    ILayer Layer { get; set; }
    GeometryMoveableStatusEnum _GeometryMoveableStatus { get; }
    ISketchEntitiesEnumerator OwnedBy { get; }
    bool SketchOnly { get; set; }
    ISketchBlock ContainingSketchBlock { get; }
    ISketchBlocksEnumerator SketchBlockPath { get; }
    IPoint2d Geometry { get; }
    ISketchEntitiesEnumerator AttachedEntities { get; }
    bool HoleCenter { get; set; }
    bool InsertionPoint { get; set; }
    bool ConnectionPoint { get; set; }
    IPoint Geometry3d { get; }
    ISketchPoint NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
    void Delete();
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void MoveTo(IPoint2d Point);
    void MoveBy(IVector2d Vector);
    void Merge(ISketchPoint SketchPoint);
}
