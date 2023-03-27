namespace Oblikovati.Domain.Contracts;

public interface IFilletIntermediateRadius
{
    IParameter PercentLength { get; }
    IEdge Edge { get; }
    IParameter Radius { get; }
}
