namespace Oblikovati.Contracts.NotClassified;

public interface IPointWorkPointDef
{
    IWorkPoint Parent { get; }
    object Point { get; }
}