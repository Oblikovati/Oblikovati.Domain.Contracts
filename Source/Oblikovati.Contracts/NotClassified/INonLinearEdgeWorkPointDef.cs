namespace Oblikovati.Contracts.NotClassified;

public interface INonLinearEdgeWorkPointDef
{
    IWorkPoint Parent { get; }
    IEdge Edge { get; }
}