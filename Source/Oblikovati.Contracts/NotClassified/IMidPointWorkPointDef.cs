namespace Oblikovati.Contracts.NotClassified;

public interface IMidPointWorkPointDef
{
    IWorkPoint Parent { get; }
    IEdge Edge { get; }
}