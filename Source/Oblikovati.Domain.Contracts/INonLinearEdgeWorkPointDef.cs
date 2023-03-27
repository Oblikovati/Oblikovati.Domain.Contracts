namespace Oblikovati.Domain.Contracts;

public interface INonLinearEdgeWorkPointDef
{

    IWorkPoint Parent { get; }
    IEdge Edge { get; }
}
