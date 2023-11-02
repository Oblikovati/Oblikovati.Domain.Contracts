using Oblikovati.Contracts.Parameters;

namespace Oblikovati.Contracts.NotClassified;

public interface IFilletIntermediateRadius
{
    IParameter PercentLength { get; }
    IEdge Edge { get; }
    IParameter Radius { get; }
}