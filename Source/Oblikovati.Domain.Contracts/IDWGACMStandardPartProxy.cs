namespace Oblikovati.Domain.Contracts;

public interface IDWGACMStandardPartProxy
{

    string HandleID { get; }
    IImportedDWGComponent Parent { get; }
    IDWGEntity ParentEntity { get; }
}
