namespace Oblikovati.Domain.Contracts;

public interface IDWGACMStandardPart
{

    string HandleID { get; }
    IImportedDWGComponent Parent { get; }
    IDWGEntity ParentEntity { get; }
}
