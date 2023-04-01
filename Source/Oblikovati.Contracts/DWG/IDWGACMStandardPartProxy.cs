namespace Oblikovati.Contracts.DWG;

public interface IDWGACMStandardPartProxy
{
    string HandleID { get; }
    IImportedDWGComponent Parent { get; }
    IDWGEntity ParentEntity { get; }
}