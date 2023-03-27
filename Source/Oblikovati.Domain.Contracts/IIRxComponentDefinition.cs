namespace Oblikovati.Domain.Contracts;

public interface IIRxComponentDefinition
{
    IIRxEnumSurfaceBodies SurfaceBodies { get; }
    object _CurveBodies { get; }
    object _Curve2dBodies { get; }
    IIRxEnumComponentOccurrences Occurrences { get; }
    IIRxEnumComponentDefinitionReferences ImmediateReferencedDefinitions { get; }
    IIRxComponentDocument Document { get; }
    short _HasUnderlyingDefinition { get; }
    IIRxComponentDefinition _UnderlyingDefinition { get; }
}
