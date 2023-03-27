namespace Oblikovati.Domain.Contracts;

public interface IPointWorkPointDef
{

    IWorkPoint Parent { get; }
    object Point { get; }
}
