using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IModelDatumReferenceFrame
{
    IAttributeSets AttributeSets { get; }
    IComponentDefinition Parent { get; }
    string ClientId { get; }
    IModelDatumReferenceFrameDefinition Definition { get; set; }
    HealthStatusEnum HealthStatus { get; }
    string Name { get; set; }
    bool Visible { get; set; }
    string Identifier { get; }
    void GetReferenceKey(ref List<byte> ReferenceKey, int KeyContext);
    void Delete();
}
