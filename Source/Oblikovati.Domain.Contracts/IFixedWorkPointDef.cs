namespace Oblikovati.Domain.Contracts;

public interface IFixedWorkPointDef
{

    IWorkPoint Parent { get; }
    IPoint Point { get; set; }
}
