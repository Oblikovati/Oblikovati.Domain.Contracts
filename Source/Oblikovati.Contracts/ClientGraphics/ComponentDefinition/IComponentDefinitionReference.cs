using Oblikovati.Contracts.Application.Documents.AssemblyDocument.AssemblyComponentDefinition.ComponentOccurence;
using Oblikovati.Contracts.Application.Documents.Document;

namespace Oblikovati.Contracts.ClientGraphics.ComponentDefinition;

public interface IComponentDefinitionReference
{
    IComponentOccurrencesEnumerator ImmediateOccurrences { get; }
    IComponentDefinition ReferencedDefinition { get; }
    IReferencedFileDescriptor ReferencedFileDescriptor { get; }
}