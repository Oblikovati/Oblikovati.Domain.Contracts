namespace Oblikovati.Contracts;

public interface IMidPointWorkPointDef
{
    IWorkPoint Parent { get; }
    IEdge Edge { get; }
}