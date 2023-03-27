using Oblikovati.Domain.Contracts.Enums;

namespace Oblikovati.Domain.Contracts;

public interface IiAssemblyMember
{

    IAssemblyComponentDefinition Parent { get; }
    IiAssemblyFactory ParentFactory { get; }
    IDocumentDescriptor ReferencedDocumentDescriptor { get; }
    HealthStatusEnum HealthStatus { get; }
    IiAssemblyTableRow Row { get; }
    void BreakLinkToFactory();
    void SetRowName(string RowName);
}
