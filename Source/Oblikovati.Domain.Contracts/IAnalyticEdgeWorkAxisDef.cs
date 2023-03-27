namespace Oblikovati.Domain.Contracts;

public interface IAnalyticEdgeWorkAxisDef
{

    IWorkAxis Parent { get; }
    IEdge Edge { get; }
}
