namespace Oblikovati.Domain.Contracts;

public interface IIRxComponentDefinitionReference
{
    IIRxEnumComponentOccurrences ImmediateOccurrences { get; }
    IIRxComponentDefinition ReferencedDefinition { get; }
}
