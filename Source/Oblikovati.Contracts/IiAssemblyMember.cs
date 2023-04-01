using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition;
using Oblikovati.Contracts.Application.Documents.Document;
using Oblikovati.Contracts.Enums;

namespace Oblikovati.Contracts;

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