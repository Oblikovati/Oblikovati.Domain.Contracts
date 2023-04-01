namespace Oblikovati.Contracts;

public interface IPointWorkPointDef
{
    IWorkPoint Parent { get; }
    object Point { get; }
}