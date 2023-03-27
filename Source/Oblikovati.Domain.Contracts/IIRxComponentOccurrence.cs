namespace Oblikovati.Domain.Contracts;

public interface IIRxComponentOccurrence : IIRxComponentOccurrenceOld
{
    IIRxComponentDefinition ContextDefinition { get; }
    IIRxComponentDefinition Definition { get; }
    IIRxComponentOccurrence ParentOccurrence { get; }
    IIRxEnumComponentOccurrences SubOccurrences { get; }
    IIRxMatrix Transformation { get; }
    IIRxEnumSurfaceBodies SurfaceBodies { get; }
    object _CurveBodies { get; }
    object _Curve2dBodies { get; }
    void CreateGeometryProxy(IIRxReferenceKey pGeometry, out IIRxGeometryProxy ppResult);
}
