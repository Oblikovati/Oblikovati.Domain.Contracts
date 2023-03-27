namespace Oblikovati.Domain.Contracts;

public interface IDWGLineProxy
{

    string HandleID { get; }
    IImportedDWGComponent Parent { get; }
    IDWGEntity ParentEntity { get; }
    IUnitVector Direction { get; }
    IPoint EndPoint { get; }
    IPoint StartPoint { get; }
    IDWGLine NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
}
