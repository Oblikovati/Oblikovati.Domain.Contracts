namespace Oblikovati.Domain.Contracts;

public interface IComponentDefinitionReference
{
    IComponentOccurrencesEnumerator ImmediateOccurrences { get; }
    IComponentDefinition ReferencedDefinition { get; }
    IReferencedFileDescriptor ReferencedFileDescriptor { get; }
}
