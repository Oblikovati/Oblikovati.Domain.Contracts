namespace Oblikovati.Domain.Contracts;

public interface IIRxComponentOccurrenceOld
{
    IIRxComponentDefinition ContextDefinition { get; }
    IIRxComponentDefinition Definition { get; }
    IIRxComponentOccurrence ParentOccurrence { get; }
    IIRxEnumComponentOccurrences SubOccurrences { get; }
    IIRxMatrix Transformation { get; }
    void CreateGeometryProxy(IIRxReferenceKey pGeometry, out IIRxGeometryProxy ppResult);
}
