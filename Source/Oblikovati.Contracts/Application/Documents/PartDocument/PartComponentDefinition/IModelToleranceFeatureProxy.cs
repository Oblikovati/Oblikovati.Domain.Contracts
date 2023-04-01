using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.ComponentOccurence;
using Oblikovati.Contracts.Application.TransientObjects.Utility;
using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.ClientGraphics.ComponentDefinition;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.Application.Documents.PartDocument.PartComponentDefinition;

public interface IModelToleranceFeatureProxy
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
    IModelToleranceFeature NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void Delete();
    void PseudoDelete();
}