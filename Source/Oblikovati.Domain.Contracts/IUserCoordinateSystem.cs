using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IUserCoordinateSystem
{

    IAttributeSets AttributeSets { get; }
    HealthStatusEnum HealthStatus { get; }
    bool IsOwnedByFeature { get; }
    IPartFeature OwnedBy { get; }
    IComponentDefinition Parent { get; }
    string Name { get; set; }
    IWorkPoint Origin { get; }
    IMatrix Transformation { get; set; }
    bool Visible { get; set; }
    IParameter XAngle { get; }
    IWorkAxis XAxis { get; }
    IParameter XOffset { get; }
    IParameter YAngle { get; }
    IWorkAxis YAxis { get; }
    IParameter YOffset { get; }
    IParameter ZAngle { get; }
    IWorkAxis ZAxis { get; }
    IParameter ZOffset { get; }
    IWorkPlane XYPlane { get; }
    IWorkPlane XZPlane { get; }
    IWorkPlane YZPlane { get; }
    IUserCoordinateSystemDefinition Definition { get; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void Delete(bool RetainDependentFeaturesAndSketches, bool RetainDependentWorkFeatures);
    void SetEndOfPart(bool Before);
}
