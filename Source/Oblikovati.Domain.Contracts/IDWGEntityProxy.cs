namespace Oblikovati.Domain.Contracts;

public interface IDWGEntityProxy
{

    string HandleID { get; }
    IImportedDWGComponent Parent { get; }
    IDWGEntity ParentEntity { get; }
    IDWGEntity NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
}
