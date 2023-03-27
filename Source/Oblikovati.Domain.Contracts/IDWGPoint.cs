namespace Oblikovati.Domain.Contracts;

public interface IDWGPoint
{

    string HandleID { get; }
    IImportedDWGComponent Parent { get; }
    IDWGEntity ParentEntity { get; }
    IPoint Point { get; }
}
