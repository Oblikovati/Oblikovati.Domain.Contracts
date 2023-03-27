namespace Oblikovati.Domain.Contracts;

public interface IDWGPointProxy
{

    string HandleID { get; }
    IImportedDWGComponent Parent { get; }
    IDWGEntity ParentEntity { get; }
    IPoint Point { get; }
    IDWGPoint NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
}
