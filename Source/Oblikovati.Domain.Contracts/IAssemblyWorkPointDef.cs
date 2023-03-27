namespace Oblikovati.Domain.Contracts;

public interface IAssemblyWorkPointDef
{

    IWorkPoint Parent { get; }
    IAssemblyConstraintsEnumerator Constraints { get; }
    IPoint Point { get; set; }
}
