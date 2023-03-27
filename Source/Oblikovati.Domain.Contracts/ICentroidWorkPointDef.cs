namespace Oblikovati.Domain.Contracts;

public interface ICentroidWorkPointDef
{

    IWorkPoint Parent { get; }
    object Entities { get; }
}
