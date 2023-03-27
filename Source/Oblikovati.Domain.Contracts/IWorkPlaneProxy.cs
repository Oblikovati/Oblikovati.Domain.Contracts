using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IWorkPlaneProxy
{

    IComponentDefinition Parent { get; }
    IAttributeSets AttributeSets { get; }
    bool Adaptive { get; set; }
    bool Construction { get; }
    object Definition { get; }
    WorkPlaneDefinitionEnum DefinitionType { get; }
    IObjectCollection Dependents { get; }
    IObjectCollection DrivenBy { get; }
    bool Grounded { get; set; }
    string Name { get; set; }
    IPlane Plane { get; }
    bool Visible { get; set; }
    HealthStatusEnum HealthStatus { get; }
    IWorkPlane ReferencedEntity { get; }
    bool HasReferenceComponent { get; }
    IReferenceComponent ReferenceComponent { get; }
    bool IsPatternElement { get; }
    bool Shared { get; set; }
    bool Consumed { get; }
    bool ConsumeInputs { get; set; }
    bool IsParentSketch { get; }
    ISketch3D ParentSketch { get; }
    bool AutoResize { get; set; }
    bool IsOwnedByFeature { get; }
    IPartFeature OwnedBy { get; }
    bool IsCoordinateSystemElement { get; }
    bool Exported { get; set; }
    IWorkPlane NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
    void Delete(bool RetainDependents);
    void GetSize(out IPoint Point1, out IPoint Point2);
    void SetSize(IPoint Point1, IPoint Point2);
    void GetPosition(out IPoint Origin, out IUnitVector XAxis, out IUnitVector YAxis);
    void SetByThreePoints(object Point1, object Point2, object Point3);
    void SetByTwoLines(object Line1, object Line2);
    void SetByPlaneAndPoint(object Plane, object Point);
    void SetByLinePlaneAndAngle(object Line, object Plane, object Angle);
    void SetByPlaneAndOffset(object Plane, object Offset);
    void SetByNormalToCurve(object CurveEntity, object Point);
    void _SetByTwoPlanes(object Plane1, object Plane2);
    void SetByTwoPlanes(object Plane1, object Plane2, object QuadrantPoint);
    void SetByLineAndTangent(object Line, IFace Face, IPoint ProximityPoint);
    void SetByPlaneAndTangent(object Plane, IFace Face, IPoint ProximityPoint);
    void SetByPointAndTangent(object Point, IFace Face);
    void SetByTorusMidPlane(IFace Face);
    void SetFixed(IPoint OriginPoint, IUnitVector XAxis, IUnitVector YAxis);
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void SetEndOfPart(bool Before);
    void FlipNormal();
}
