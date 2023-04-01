using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.ComponentOccurence;
using Oblikovati.Contracts.Attributes;
using Oblikovati.Contracts.ClientGraphics.ComponentDefinition;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts.ModelAnnotations;

public interface IModelDatumReferenceFrameProxy
{
    IAttributeSets AttributeSets { get; }
    IComponentDefinition Parent { get; }
    string ClientId { get; }
    IModelDatumReferenceFrameDefinition Definition { get; set; }
    HealthStatusEnum HealthStatus { get; }
    string Name { get; set; }
    bool Visible { get; set; }
    string Identifier { get; }
    IModelDatumReferenceFrame NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void Delete();
}