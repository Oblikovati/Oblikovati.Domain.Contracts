namespace Oblikovati.Domain.Contracts;

public interface IDWGBlockReferenceProxy
{

    string HandleID { get; }
    IImportedDWGComponent Parent { get; }
    IDWGEntity ParentEntity { get; }
    IDWGBlockDefinition Definition { get; }
    IMatrix Transformation { get; }
    IDWGBlockReference NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
    object GetObject(object ObjectInDefinition);
}
