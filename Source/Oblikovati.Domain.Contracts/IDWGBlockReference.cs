namespace Oblikovati.Domain.Contracts;

public interface IDWGBlockReference
{

    string HandleID { get; }
    IImportedDWGComponent Parent { get; }
    IDWGEntity ParentEntity { get; }
    IDWGBlockDefinition Definition { get; }
    IMatrix Transformation { get; }
    object GetObject(object ObjectInDefinition);
}
