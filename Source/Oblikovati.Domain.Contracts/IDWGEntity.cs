namespace Oblikovati.Domain.Contracts;

public interface IDWGEntity
{

    string HandleID { get; }
    IImportedDWGComponent Parent { get; }
    IDWGEntity ParentEntity { get; }
}
