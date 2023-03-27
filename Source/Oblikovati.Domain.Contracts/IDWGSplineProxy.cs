namespace Oblikovati.Domain.Contracts;

public interface IDWGSplineProxy
{

    string HandleID { get; }
    IImportedDWGComponent Parent { get; }
    IDWGEntity ParentEntity { get; }
    IPoint StartPoint { get; }
    IPoint EndPoint { get; }
    IDWGSpline NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
}
