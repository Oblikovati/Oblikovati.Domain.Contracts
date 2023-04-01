namespace Oblikovati.Contracts.DWG;

public interface IDWGACMStandardPart
{
    string HandleID { get; }
    IImportedDWGComponent Parent { get; }
    IDWGEntity ParentEntity { get; }
}