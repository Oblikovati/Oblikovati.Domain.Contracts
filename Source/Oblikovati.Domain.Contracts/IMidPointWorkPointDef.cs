namespace Oblikovati.Domain.Contracts;

public interface IMidPointWorkPointDef
{

    IWorkPoint Parent { get; }
    IEdge Edge { get; }
}
