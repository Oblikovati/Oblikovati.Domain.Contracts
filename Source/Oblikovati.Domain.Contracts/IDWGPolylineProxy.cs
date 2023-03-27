namespace Oblikovati.Domain.Contracts;

public interface IDWGPolylineProxy
{

    string HandleID { get; }
    IImportedDWGComponent Parent { get; }
    IDWGEntity ParentEntity { get; }
    IDWGEntitiesEnumerator Entities { get; }
    IDWGEntitySegmentsEnumerator Segments { get; }
    IDWGPolyline NativeObject { get; }
    IComponentOccurrence ContainingOccurrence { get; }
}
