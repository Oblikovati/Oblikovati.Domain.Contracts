using Oblikovati.Contracts.Parameters;

namespace Oblikovati.Contracts;

public interface IFilletIntermediateRadius
{
    IParameter PercentLength { get; }
    IEdge Edge { get; }
    IParameter Radius { get; }
}