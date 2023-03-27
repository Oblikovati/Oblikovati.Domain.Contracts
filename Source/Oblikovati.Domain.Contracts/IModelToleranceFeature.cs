using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IModelToleranceFeature
{
    IAttributeSets AttributeSets { get; }
    IComponentDefinition Parent { get; }
    string ClientId { get; }
    IModelToleranceFeatureDefinition Definition { get; set; }
    HealthStatusEnum HealthStatus { get; }
    IModelToleranceFeature ParentToleranceFeature { get; }
    string Name { get; set; }
    bool Visible { get; set; }
    IFaceCollection AllFaces { get; }
    ModelToleranceFeatureConstrainedStatusEnum ConstrainedStatus { get; set; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void Delete();
    void PseudoDelete();
}
