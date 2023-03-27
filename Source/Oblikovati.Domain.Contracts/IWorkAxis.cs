using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IWorkAxis
{
    bool Adaptive { get; set; }
    IComponentDefinition Parent { get; }

    bool Construction { get; }
    object Definition { get; }
    WorkAxisDefinitionEnum DefinitionType { get; }
    IObjectCollection Dependents { get; }
    IObjectCollection DrivenBy { get; }
    bool Grounded { get; set; }
    string Name { get; set; }
    ILine Line { get; }
    bool Visible { get; set; }
    HealthStatusEnum HealthStatus { get; }
    IAttributeSets AttributeSets { get; }
    IWorkAxis ReferencedEntity { get; }
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
    void Delete(bool RetainDependents);
    void SetByLine(object Line);
    void SetByTwoPlanes(object Plane1, object Plane2);
    void SetByTwoPoints(object Point1, object Point2);
    void SetByRevolvedFace(IFace Face);
    void SetByLineAndPlane(object Line, object Plane);
    void SetFixed(IPoint Point, IUnitVector Axis);
    void SetByAnalyticEdge(IEdge Edge);
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void SetEndOfPart(bool Before);
    void SetByLineAndPoint(object Line, object Point);
    void SetByNormalToSurface(object Surface, object Point);
    void GetSize(out IPoint Point1, out IPoint Point2);
    void SetSize(IPoint Point1, IPoint Point2);
}
